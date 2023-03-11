using System;
namespace IDoctor.Models
{
	public class Doctor
	{

        public int Id { get; set; }
        public string ?DoctorName { get; set; }
        public int DoctorPhone { get; set; }
        public string ?DoctorSpecialization { get; set; }
        public string ?DoctorEmail { get; set; }
    }
}

