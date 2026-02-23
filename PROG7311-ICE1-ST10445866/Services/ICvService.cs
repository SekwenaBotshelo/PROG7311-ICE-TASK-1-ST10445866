using PROG7311_ICE1_ST10445866.Models;

namespace PROG7311_ICE1_ST10445866.Services
{
    public interface ICvService
    {
        CvViewModel GetCvData();
    }

    public class CvService : ICvService
    {
        public CvViewModel GetCvData()
        {
            return new CvViewModel
            {
                Languages = new List<string> { "C#", "ASP.NET Core", "SQL", "Java", "JavaScript", "HTML/CSS" },
                Projects = new List<Project>
                {
                    new Project {
                        Title = "EventEase Venue Booking System",
                        Description = "Developed full CRUD system, prevented double bookings using custom MVC logic.",
                        TechStack = "ASP.NET MVC, SQL Server",
                        GithubUrl = "#"
                    },
                    new Project {
                        Title = "Customer Data Analysis App",
                        Description = "Analyzed CSV data to identify defaulters using C# data processing techniques.",
                        TechStack = "C#, File I/O",
                        GithubUrl = "#"
                    }
                },
                Certifications = new List<Certification>
                {
                    new Certification { Name = "Career Boost with Power BI and AI", Issuer = "Exodus Experts", Year = "2024" }
                }
            };
        }
    }
}