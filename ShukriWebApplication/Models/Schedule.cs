using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShukriWebApplication.Models
{
    public class Schedule
    {
        public Schedule()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;

        }
        [Key]
        public int Id { get; set; }



        //-------------Class-------------//

        [Display(Name = "Class Name: ")]
        public string ClassName { get; set; }


        //Description of the class
        [Display(Name = "Description: ")]
        public string ClassDescription { get; set; }

        //Lecture name of the class
        [Display(Name = "Lecture Name: ")]
        public string LectureName { get; set; }




        //-------------Schedule-------------//
        //Schedule Date
        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        //Start Time
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = false)]
        public DateTime StartTime { get; set; }

        //End Time
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = false)]
        public DateTime EndTime { get; set; }


        public virtual List<Booking> Experiences { get; set; } = new List<Booking>();//detail very important




    }
}
