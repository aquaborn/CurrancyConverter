using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using TestWebApplication.Models;

namespace TestWebApplication.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с сущностями из БД
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IBaseRepository<TModel> where TModel:Entity
    {
        /// <summary>
        /// Получение сущности по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TModel> GetItems(Guid id);

        /// <summary>
        /// Получить список объектов таблицы
        /// </summary>
        /// <returns>Список объектов таблицы</returns>
        Task<IEnumerable<TModel>> ListAsync(Expression<Func<TModel, bool>> condition = null);

        /// <summary>
        /// Загрузка связанных сущностей
        /// </summary>
        /// <param name="navigationProperty"></param>
        /// <returns></returns>
        Task LoadAsync(TModel entity, Expression<Func<TModel, object>> navigationProperty);
    }
}