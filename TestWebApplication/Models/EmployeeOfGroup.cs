using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    /// <summary>
    /// Сотрудники группы
    /// </summary>
    [Description("Сотрудники группы")]
    public class EmployeeOfGroup:Entity
    {
        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>        
        [Description("Идентификатор пользователя")]
        [Column("Employee_ID")]
        [Index("IX_EMPLOYEEOFGROUP", 1, IsUnique = true)]
        public Guid EmployeeID { get; set; }

        /// <summary>
        /// Идентификатор группы
        /// </summary>
        [Description("Идентификатор группы")]
        [Column("Group_ID")]
        [Index("IX_EMPLOYEEOFGROUP", 2, IsUnique = true)]
        public Guid GroupID { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        [ForeignKey(nameof(EmployeeID))]        
        public virtual Employees Employee { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        [ForeignKey(nameof(GroupID))]
        public virtual Groups Group { get; set; }
    }
}