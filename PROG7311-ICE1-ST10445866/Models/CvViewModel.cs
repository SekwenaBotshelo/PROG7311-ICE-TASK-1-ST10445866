namespace PROG7311_ICE1_ST10445866.Models
{
    public class CvViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string ProfileSummary { get; set; } // Added this
        public List<string> Languages { get; set; }
        public List<Project> Projects { get; set; }
        public List<Certification> Certifications { get; set; }
        public List<Skill> Skills { get; set; } // Added this
    }

    public class Skill // Added this class
    {
        public string Name { get; set; }
        public string Level { get; set; }
    }

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TechStack { get; set; }
        public string GithubUrl { get; set; }
    }

    public class Certification
    {
        public string Name { get; set; }
        public string Issuer { get; set; }
        public string Year { get; set; }
    }
}