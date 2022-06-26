using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TestWebApplication.Interfaces;

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
        private readonly CurrancyInterface<Dictionary<string, decimal>> _currancyRepository;

        public TestController(CurrancyInterface<Dictionary<string, decimal>> currancyRepository)
        {
            _currancyRepository = currancyRepository;
        }

        /// <summary>
        /// ПОлучить текущее значение валют
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <returns>Список сотрудников</returns>
        [HttpGet]
        public async Task PostBaseCurrancy(Dictionary<string, decimal> exchangeRates) => _currancyRepository.GetCurrentCurrancy(exchangeRates);

        /// <summary>
        /// Задать базовую валюту
        /// </summary>
        /// <param name="baseCurrancyName">Наименование базовой валюты</param>
        /// <returns>Список сотрудников</returns>
        [HttpPost]
        public Dictionary<string, decimal> PostBaseCurrancy(string baseCurrancyName)
        {
            Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>();
            exchangeRates.Add(baseCurrancyName, 1);
            return exchangeRates;
        }

        /// <summary>
        /// Добавить валюту
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyName">Наименование нового курса</param>
        /// <param name="currancyValue">Курс валюты к базовой (значение)</param>
        /// <returns></returns>
        [HttpPost]
        public async Task PostNewCurrancyRates(Dictionary<string, decimal> exchangeRates, string currancyName, decimal currancyValue)
            => _currancyRepository.AddCurrancy(exchangeRates, currancyName, currancyValue);

        /// <summary>
        /// Удалить валюту
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyName">Наименование нового курса</param> 
        [HttpDelete]
        public async Task DeleteNewCurrancyRates(Dictionary<string, decimal> exchangeRates, string currancyName)
         => _currancyRepository.DeleteCurrancy(exchangeRates, currancyName);

        /// <summary>
        /// Редактировать валюту
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyName">Наименование курса, который нужно отредактировать</param>
        /// <param name="currancyValue">Курс валюты к базовой (значение)</param>
        [HttpPut]
        public async Task UpdateNewCurrancyRates(Dictionary<string, decimal> exchangeRates, string currancyName, decimal newValue)
         => _currancyRepository.EditCurrancy(exchangeRates, currancyName, newValue);

        /// <summary>
        /// Конвертировать валюту
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyNameOld">Наименование текущего курса</param>
        /// <param name="currancyNameNew">Наименование курса по которому нужно конвертировать</param>
        /// <param name="currancyValue">Значение по текущему курсу</param>
        [HttpGet]
        public async Task<decimal> ConvertMoneyForCurrancyRate(Dictionary<string, decimal> exchangeRates, string currancyNameOld, string currancyNameNew, decimal currentValue)
            => await _currancyRepository.ConvertMoney(exchangeRates, currancyNameOld, currancyNameNew, currentValue);

        /// <summary>
        /// Сложение валют
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyNamesandValues">Словарь валют которые необходимо сложить и  значений</param>

        [HttpGet]
        public async Task<decimal> AdditionMoneyForCurrancyRate(Dictionary<string, decimal> exchangeRates, Dictionary<string, decimal> currancyNamesandValues)
        {
            decimal result = 0;
            foreach (var item in currancyNamesandValues)
            {
                result += item.Value / exchangeRates[item.Key];
            }
            return result;
        }

        /// <summary>
        /// Сложение валют
        /// </summary>
        /// <param name="exchangeRates">Курсы валют</param>
        /// <param name="currancyNamesandValues">Словарь валют которые необходимо сложить и  значений</param>

        [HttpGet]
        public async Task<decimal> SubTractionMoneyForCurrancyRate(Dictionary<string, decimal> exchangeRates, Dictionary<string, decimal> currancyNamesandValues)
        {
            decimal result = 0;
            foreach (var item in currancyNamesandValues)
            {
                result -= item.Value / exchangeRates[item.Key];
            }
            return result;
        }

    }
}
