using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Employee
    {
        public int Id { get; set; }
        public string LeadSource { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string OtherPhone { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Assistan { get; set; }
        public string DateOfBirth { get; set; }
        public string AsstPhone { get; set; }
        public string SkypeId { get; set; }
        public string SecondaryEmail { get; set; }
        public string Twitter { get; set; }
        public int? Owner_Id { get; set; }
        public int Account_Id { get; set; }
        public List<int> Tasks_Id { get; set; }
    }
}
