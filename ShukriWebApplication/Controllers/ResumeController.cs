using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShukriWebApplication.Models;
using ShukriWebApplication.Data;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;

namespace ShukriWebApplication.Controllers
{
    [Authorize]
    public class ResumeController : Controller
    {

        private readonly ApplicationDbContext _context;

        //private readonly IWebHostEnvironment _webHost;




        public ResumeController(ApplicationDbContext context/*, IWebHostEnvironment webHost*/)
        {
            _context = context;
            //_webHost = webHost;

        }

        public IActionResult Index()
        {
            List<Schedule> applicants;
            applicants = _context.Applicants.ToList();
            return View(applicants);
        }

        public IActionResult Create()
        {
            Schedule applicant =  new Schedule();
            applicant.Experiences.Add(new Booking() { ExperienceId = 1 });
            return View(applicant);
        }

        [HttpPost]
        public IActionResult Create(Schedule applicant)
        {

            //foreach (Booking experience in applicant.Experiences)
            //{
            //    if (experience.CompanyName == null || experience.CompanyName.Length == 0)
            //        applicant.Experiences.Remove(experience);
            //}



            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("index");

        }


        //public IActionResult Details(int Id)
        //{
        //    Schedule applicant = _context.Applicants
        //        .Include(e => e.Experiences)
        //        .Where(a => a.Id == Id).FirstOrDefault();
        //    return View(applicant);
        //}

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Schedule applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Delete(Schedule applicant)
        {

            _context.Attach( applicant);
            _context.Entry(applicant).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");

        }





        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Schedule applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }


        [HttpPost]
        public IActionResult Edit(Schedule applicant)
        {
            List<Booking> expDetails = _context.Experiences.Where(d => d.ApplicantId == applicant.Id).ToList();
            _context.Experiences.RemoveRange(expDetails);
            _context.SaveChanges();

            //applicant.Experiences.RemoveAll(n => n.YearsWorked == 0);


            _context.Attach(applicant);
            _context.Entry(applicant).State = EntityState.Modified;


            _context.Experiences.AddRange(applicant.Experiences);
            _context.SaveChanges();
            return RedirectToAction("index");
        }







        [HttpGet]
        public IActionResult Editing(int Id)
        {
            Schedule applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }


        [HttpPost]
        public IActionResult Editing(Schedule applicant)
        {
            List<Booking> expDetails = _context.Experiences.Where(d => d.ApplicantId == applicant.Id).ToList();
            _context.Experiences.RemoveRange(expDetails);
            _context.SaveChanges();

            //applicant.Experiences.RemoveAll(n => n.YearsWorked == 0);


            _context.Attach(applicant);
            _context.Entry(applicant).State = EntityState.Modified;


            _context.Experiences.AddRange(applicant.Experiences);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        //[HttpPost]
        //{

        //    //foreach (Experience experience in applicant.Experiences)
        //    //{
        //    //    if (experience.CompanyName == null || experience.CompanyName.Length == 0)
        //    //        applicant.Experiences.Remove(experience);
        //    //}



        //    _context.Attach(applicant);
        //    _context.SaveChanges();
        //    return RedirectToAction("index");

        //}

    }
}
