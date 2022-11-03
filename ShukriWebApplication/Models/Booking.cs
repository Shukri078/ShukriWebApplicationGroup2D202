using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ShukriWebApplication.Models
{
    public class Booking
    {
        public Booking()
        {
        }

        [Key]
        public int ExperienceId { get; set; }

        [ForeignKey("Applicant")]//very important
        public int ApplicantId { get; set; }
        public virtual Schedule Applicant { get; private set; } //very important 

        public string BkClassName { get; set; }
        public string BkClassDescription { get; set; }
        public string BkLectureName { get; set; }
        //Schedule Date

        public string BkStartDate { get; set; }
        public string BkEndDate { get; set; }
        public string BkStartTime { get; set; }
        public string BkEndTime { get; set; }

        public string BookingName { get; set; }
    }

}
