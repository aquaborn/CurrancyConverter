using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestWebApplication.Models;

namespace TestWebApplication
{
    /// <summary>
    /// БД
    /// </summary>
    public class DB:DbContext
    {
        /// <summary>
        /// Название строки соединений в файлах конфигурации
        /// </summary>
        public const string ConnectionStringName = "TEST";

        /// <summary>
        /// База данных Entity Framework Code First
        /// </summary>
        public DB() : base(ConnectionStringName)
        {
            Database.CreateIfNotExists();
        }

        /// <summary>
        /// Список групп сотрудников (N-N)
        /// </summary>
        public virtual DbSet<EmployeeOfGroup> EmployeesOfGroups { get; set; }

        /// <summary>
        /// Список сотрудников 
        /// </summary>
        public virtual DbSet<Employees> Employees { get; set; }

        /// <summary>
        /// Список групп 
        /// </summary>
        public virtual DbSet<Groups> Groups { get; set; }       
            
    }
}