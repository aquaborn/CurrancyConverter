using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class Employees:Entity
    {
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        [Description("ФИО сотрудника")]
        public string FullName { get; set; }

        /// <summary>
        /// Почтовый адрес
        /// </summary>
        [Description("Почтовый адрес")]
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>        
        [Description("Номер телефона")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Сотрудники группы
        /// </summary>        
        public virtual HashSet<EmployeeOfGroup> Groups { get; set; }
    }
}