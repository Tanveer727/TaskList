using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskList.Models
{
    public class TaskStatusModel
    {
       public List<Tasks> Completed { get; set; }
        public List<Tasks> Pending { get; set; }
    }
}
