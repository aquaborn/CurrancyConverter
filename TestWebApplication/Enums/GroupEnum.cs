using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Enums
{
    /// <summary>
    /// Тип групп сотрудников
    /// </summary>
    public enum GroupEnum
    {
        /// <summary>
        /// Руководство
        /// </summary>
        Head,
        /// <summary>
        /// Администраторы
        /// </summary>
        Admins,
        /// <summary>
        /// Инженеры
        /// </summary>
        Engineers,
        /// <summary>
        /// Разработчики
        /// </summary>
        Developers,
    }
}