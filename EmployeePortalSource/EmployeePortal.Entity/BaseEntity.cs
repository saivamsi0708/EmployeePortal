using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Entity
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string? CreatedOn { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get;  set; }
        public DateTime? DeletedDate { get;}

        [NotMapped]
        public bool IsDeleted => DeletedDate.HasValue;


    }
}
