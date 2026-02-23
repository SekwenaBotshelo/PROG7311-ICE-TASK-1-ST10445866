using Microsoft.AspNetCore.Mvc;
using PROG7311_ICE1_ST10445866.Models;
using System.Collections.Generic;
using System.IO;

namespace PROG7311_ICE1_ST10445866.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var myCvData = new CvViewModel
            {
                Name = "Botshelo Koketso Sekwena",
                Title = "BSc in Computer and Information Sciences in Application Development",
                ProfileSummary = "Detail-oriented Bachelor of Computer and Information Sciences in Application Development student entering final year, with a strong technical foundation in C#, Java, and ASP.NET Core MVC. Proven track record in developing cloud-integrated web applications using Azure Services and SQL/NoSQL databases. Passionate about Solutions Architecture and Network Security, with a research-driven approach to solving complex architectural challenges.",

                Languages = new List<string> { "English", "Brazil (Português)", "Tswana", "Afrikaans", "C#", "Java", "ASP.NET Core MVC", "Microsoft Azure" },

                Certifications = new List<Certification>
                {
                    new Certification { Name = "5.0 Professional Gen A.I. + Power BI + Excel", Issuer = "Exodus Experts", Year = "2026" }
                },

                Skills = new List<Skill>
                {
                    new Skill { Name = "Microsoft Word", Level = "Proficient" },
                    new Skill { Name = "Microsoft PowerPoint", Level = "Proficient" },
                    new Skill { Name = "Sporting Analysis", Level = "Proficient" },
                    new Skill { Name = "Photography", Level = "Proficient" },
                    new Skill { Name = "Microsoft Excel", Level = "Competent" },
                    new Skill { Name = "Microsoft Azure", Level = "Competent" },
                    new Skill { Name = "Visual Arts", Level = "Competent" },
                    new Skill { Name = "Project Management", Level = "Amateur" }
                },

                Projects = new List<Project>
                {
                    new Project {
                        Title = "Learning Progression Companion - LPC #1",
                        Description = "A smart learning tracker that visualizes knowledge growth and uses ML to identify gaps.",
                        TechStack = "Machine Learning, C#",
                        GithubUrl = "https://github.com/SekwenaBotshelo"
                    },
                    new Project {
                        Title = "EventEase Venue Booking System",
                        Description = "Web-based application used to manage bookings and confirmations.",
                        TechStack = "ASP.NET Core MVC, SQL",
                        GithubUrl = "https://github.com/SekwenaBotshelo/PROG6212-POE-Final-Submission-ST10445866.git"
                    }
                }
            };

            return View(myCvData);
        }

        public IActionResult DownloadCV()
        {
            string fileName = "Botshelo-Koketso-Sekwena-Resume-20260223.pdf";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName);
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.ReadAllBytes(filePath), "application/pdf", "Botshelo_Sekwena_Resume.pdf");
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult RequestDocument(string documentName, string requesterEmail)
        {
            TempData["SuccessMessage"] = $"Request for '{documentName}' sent! I will contact you at {requesterEmail}.";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}