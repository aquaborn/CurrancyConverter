using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TestWebApplication.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с конвертером валют
    /// </summary>
    /// <typeparam name="CurrancyDict"></typeparam>
    public interface CurrancyInterface<CurrancyDict> where CurrancyDict : IDictionary<string, decimal>
    {
        /// <summary>
        /// Получение текущего набора валют и курсов
        /// </summary>
        /// <returns></returns>
        void GetCurrentCurrancy(Dictionary<string, decimal> dataDict);

        /// <summary>
        /// Добавление валюты в словарь
        /// </summary>
        /// <returns></returns>
        void AddCurrancy(Dictionary<string, decimal> dataDict, string currancyName, decimal currancyValue);

        /// <summary>
        /// Удаление валюты из словаря
        /// </summary>
        /// <returns></returns>
        void DeleteCurrancy(Dictionary<string, decimal> dataDict, string curranyName);

        /// <summary>
        /// Редактирование валюты из словаря
        /// </summary>
        /// <returns></returns>
        void EditCurrancy(Dictionary<string, decimal> dataDict, string curranyName, decimal newValue);

        /// <summary>
        /// Конвертирование валюты
        /// </summary>
        /// <returns></returns>
        Task<decimal> ConvertMoney(Dictionary<string, decimal> dataDict, string currancyNameOld, string currancyNameNew, decimal currentValue);
    }
}