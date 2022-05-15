using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.ResultModels
{
    /// <summary>
    /// Модель данных о сотрудниках
    /// </summary>
    public class EmployeesModel
    {
        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string FullName { get; set; }
    }
}