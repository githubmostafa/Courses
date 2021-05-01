using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class enrollment
    {
        public int AdmissionCodeId { get; set; }
        [ForeignKey("AdmissionCodeId")]
        public virtual AdmissionTermCode AdmissionTermCode { get; set; }


        public byte Id { get; set; }
        [ForeignKey("Id")]
        public virtual Student Student { get; set; }

        public int MajorId { get; set; }
        [ForeignKey("MajorId")]
        public virtual Major Major { get; set; }

        [Required]
        [Range(0, 100)]
        public int Grade { get; set; }

        [Required]
        public Boolean EnrolledIndicator { get; set; }


        [Required]
        public Boolean PaymentIndicator { get; set; }


    }
}