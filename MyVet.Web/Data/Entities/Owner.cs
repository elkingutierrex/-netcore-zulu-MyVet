using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public  int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public int Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display (Name = "Fist Name")]
        public int FristName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public int LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public int FixedPhone { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public int CellPhone { get; set; }
            
        [MaxLength(100)]
        public int Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FristName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FristName} {LastName} - {Document}";
    }
}
