using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessExample.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Company Id")]
        public decimal company_id { get; set; }

        [Display(Name = "Company Name")]
        public string company_name { get; set; }

        [Display(Name = "Bio Short")]
        public string bio_short { get; set; }

        [Display(Name = "Bio Long")]
        public string bio_long { get; set; }

        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Zipcode")]
        public string zipcode { get; set; }

        [Display(Name = "Company Type Id")]
        public decimal company_type_id { get; set; }

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
