using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestWebApplication.Interfaces;

namespace TestWebApplication.Repositories
{
    /// <summary>
    /// Репозиторий для работы с конвертером валют
    /// </summary>
    /// <typeparam name="CurrancyDict"></typeparam>
    public class CurrancyRepository<CurrancyDict> : CurrancyInterface<CurrancyDict> where CurrancyDict : IDictionary<string, decimal>
    {

        /// <summary>
        /// Получение текущего набора валют и курсов
        /// </summary>
        /// <returns></returns>
        public void GetCurrentCurrancy(Dictionary<string, decimal> dataDict)
        {
            foreach (var item in dataDict)
            {
                Console.WriteLine(item.Key, item.Value);
            }
        }

        /// <summary>
        /// Добавление валюты в словарь
        /// </summary>
        /// <returns></returns>
        public void AddCurrancy(Dictionary<string, decimal> dataDict, string currancyName, decimal currancyValue)
        {
            dataDict.Add(currancyName, currancyValue);
        }

        /// <summary>
        /// Удаление валюты из словаря
        /// </summary>
        /// <returns></returns>
        public void DeleteCurrancy(Dictionary<string, decimal> dataDict, string curranyName)
        {
            dataDict.Remove(curranyName);
        }

        /// <summary>
        /// Редактирование валюты из словаря
        /// </summary>
        /// <returns></returns>
        public void EditCurrancy(Dictionary<string, decimal> dataDict, string curranyName, decimal newValue)
        {
            if (dataDict.ContainsKey(curranyName))
                dataDict[curranyName] = newValue;
        }

        /// <summary>
        /// Конвертирование валюты
        /// </summary>
        /// <returns></returns>
        public async Task<decimal> ConvertMoney(Dictionary<string, decimal> dataDict, string currancyNameOld, string currancyNameNew, decimal currentValue)
        {
            //Приводим к базовому курсу и переводим в нужный
            return currentValue / dataDict[currancyNameOld] * dataDict[currancyNameNew];
        }
    }
}