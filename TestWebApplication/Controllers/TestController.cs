using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Http;
using TestWebApplication.Interfaces;
using TestWebApplication.Models;
using TestWebApplication.ResultModels;

namespace TestWebApplication.Controllers
{
    /// <summary>
    /// Методы для выполнения тестового задания
    /// </summary>
    public class TestController : ApiController
    {        
        /// <summary>
        /// Репозиторий для таблицы сотрудников
        /// </summary>
        private readonly IBaseRepository<Employees> _employeesRepository;

        public TestController( IBaseRepository<Employees> employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        /// <summary>
        /// Получить список сотрудников, входящих в группу по ее идентификатору
        /// </summary>
        /// <param name="Id">Идентификатор группы</param>
        /// <returns>Список сотрудников</returns>
        [HttpGet]
        public async Task<List<EmployeesModel>> GetEmployeesByGroupId(Guid Id)
        {                        
            //Сотрудники, принадлежащие группе через кросс-таблицу
            var employees = await _employeesRepository.ListAsync(x => x.Groups.Any(s => s.GroupID == Id));            
            return employees.Select(x=> new  EmployeesModel {Id =  x.ID,FullName = x.FullName}).ToList();
        }

        /// <summary>
        /// Отправка письма всем сотрудникам кроме "Руководства"
        /// </summary>
        [HttpPost]
        public async Task<IHttpActionResult> SendEmails(string textMessage)
        {
            //Получаем список пользователей, не сходящих в группу "Руководство"
            var notifiedUsers = await _employeesRepository.ListAsync(x => x.Groups.Any(s => s.Group.GroupType != Enums.GroupEnum.Head));
            if (notifiedUsers != null)
            {
                MailAddress from = new MailAddress("maxim@gmail.com", "Maxim");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("maxim@gmail.com", "mypassword");
                smtp.EnableSsl = true;
                foreach (var user in notifiedUsers)
                {
                    MailAddress to = new MailAddress(user.Email);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Тест";
                    m.Body = textMessage;
                    try
                    {
                        await smtp.SendMailAsync(m);
                    }
                    catch
                    {
                        return BadRequest($"Невозможно отправить письмо сотруднику{user.FullName}. Ошибка Smtp-сервера");
                    }
                }
                return Ok("Письма отправлены");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
