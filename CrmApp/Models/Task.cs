using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public int Created_Id { get; set; }
        public int? Update_Id { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
    }
}
