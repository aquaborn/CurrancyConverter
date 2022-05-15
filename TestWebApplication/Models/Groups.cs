using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using TestWebApplication.Enums;

namespace TestWebApplication.Models
{
    /// <summary>
    /// Группы сотрудников
    /// </summary>
    public class Groups:Entity
    {
        /// <summary>
        /// Имя группы
        /// </summary>
        [Description("ФИО сотрудника")]
        public string Name { get; set; }

        /// <summary>
        /// Тип группы
        /// </summary>
        [Description("Тип группы")]
        public GroupEnum GroupType { get; set; }

        /// <summary>
        /// Сотрудники группы
        /// </summary>        
        public virtual HashSet<EmployeeOfGroup> Employees { get; set; }
    }
}