using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    /// <summary>
    /// Корневая сущность базы данных
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Уникальный идентификатор записи
        /// </summary>
        [Description("Уникальный идентификатор записи")]
        public Guid ID { get; set; }

        /// <summary>
        /// Метка времени создания объекта
        /// </summary>
        [Display(AutoGenerateField = false)]
        [Description("Метка времени создания объекта")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Метка времени обновления объекта
        /// </summary>
        [Display(AutoGenerateField = false)]
        [Description("Метка времени обновления объекта")]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Entity()
        {
            // Генерация нового уникального идентификатора
            ID = Guid.NewGuid();
            // Фиксация метки времени создания объекта
            Created = DateTime.Now;
        }
    }
}