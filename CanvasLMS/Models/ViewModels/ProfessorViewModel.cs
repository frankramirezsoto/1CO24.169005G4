﻿using CanvasLMS.Models.Entities;

namespace CanvasLMS.Models.ViewModels
{
    public class ProfessorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IdFullName => $"{Id.ToString().Substring(Math.Max(0, Id.ToString().Length - 3))} - {FirstName} {LastName}";

        public List<CourseCycle>? CourseCycles { get; } = [];
        public List<Class>? Classes { get; set; }
        public List<Career>? Careers { get; } = [];
    }
}
