using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class1
    {
        public string Name;
        public string Description;
        public DateTime DueDate;

        public enum TaskStatus
        {
            [Display(Name="Новая")]  New,
            [Display(Name = "Выполняется")]Inprogress,
            [Display(Name = "Отложена")]Postponded,
            [Display(Name = "Завершена")]Completed,
            [Display(Name="Отменена")]Canceled
        }

        public string Group;
    }
}
