using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessExample.Models
{
    public class CompanyType
    {
        [Key]
        [Display(Name = "Company Type Id")]
        public decimal company_type_id { get; set; }

        [Display(Name = "Company Type Desc")]
        public string company_type_desc { get; set; }

        [Display(Name = "Entered By")]
        public decimal entered_by { get; set; }

        [Display(Name = "Entered Guid")]
        public string entered_guid { get; set; }

        [Display(Name = "Last Modified By")]
        public decimal last_modified_by { get; set; }

        [Display(Name = "Last Modified Date")]
        public DateTime last_modified_date { get; set; }

        [Display(Name = "Sysdate")]
        public DateTime sysdate { get; set; }

        [Display(Name = "Active Flag")]
        public byte active_flag { get; set; }

    }
}
