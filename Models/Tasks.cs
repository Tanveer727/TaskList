using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskList.Models
{
    public class Tasks
    {

        public int Id { get; set; }

        
        public string Email { get; set; }

        [DisplayName("Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; }

        [DisplayName("Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool Done { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Done Date")]
        public DateTime DoneDate { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        


    }
}
