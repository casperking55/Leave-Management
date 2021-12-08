using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Data
{
    public class LeaveAllocation:BaseEntity
    {
       
        public int NumberOfDays { get; set; }
        
        [ForeignKey("EmployeeId")]
        public Emplyee Emplyee { get; set; }
        public string EmployeeId  { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        
    }
}
