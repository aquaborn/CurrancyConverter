using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using TestWebApplication.Interfaces;
using TestWebApplication.Models;

namespace TestWebApplication.Repositories
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : Entity
    {
        /// <summary>
        /// Контекст БД
        /// </summary
        private DB Context { get; set; }

        /// <summary>
        /// Инициализация контекста БД
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public BaseRepository(DB context)
        {
            Context = context;
        }

        /// <summary>
        /// Получение сущности по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TModel> GetItems(Guid id)
        {
            return await Context.Set<TModel>().FindAsync(id);

        }

        /// <summary>
        /// Получить список объектов таблицы
        /// </summary>
        /// <returns>Список объектов таблицы</returns>
        public async Task<IEnumerable<TModel>> ListAsync(Expression<Func<TModel, bool>> condition = null)
        {
            return condition == null
                    ? await Context.Set<TModel>().ToListAsync()
                    : await Context.Set<TModel>().Where(condition).ToListAsync();

        }

        /// <summary>
        /// Загрузка связанных сущностей
        /// </summary>
        public async Task LoadAsync(TModel entity, Expression<Func<TModel, object>> navigationProperty)
        {

            await Context.Entry(entity).Reference(navigationProperty).LoadAsync();

        }
    }
        
}