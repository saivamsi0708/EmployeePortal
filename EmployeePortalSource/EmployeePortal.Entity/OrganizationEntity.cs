using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Entity
{
    public class OrganizationEntity : BaseEntity
    {

        public string? OrgName { get; set; }
        public string? OrgEmail { get; set; }
        public string? OrgAddress { get; set; }
        [InverseProperty(nameof(EmployeeEntity.Organization))]
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
