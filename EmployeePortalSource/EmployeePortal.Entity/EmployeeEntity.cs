using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Entity
{
    public class EmployeeEntity : BaseEntity
    {
        public string? EmpName { get; set; }
        public string? EmpCode { get; set; }
        public string? Designation { get; set; }
        public DateTime DateOfJoined { get; set; }
        public DateTime? DateOfExit { get; set; }

        // Foreign key
        public Guid OrganizationId { get; set; }

        [ForeignKey(nameof(OrganizationId))]
        public OrganizationEntity? Organization { get; set; }
    }
}
