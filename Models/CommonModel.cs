using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProfile.Models
{
    public class CommonModel
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int Updatedby { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public DateTime LastTimeUpdated { get; set; }
    }
}
