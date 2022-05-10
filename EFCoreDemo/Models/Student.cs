using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Email { get; set; }


        
        // un étudient peut avoir plusieurs cours
        public ICollection<Course> Courses { get; set; }


        //Un étudient peut avoir plusieur adresseEmail
        public  ICollection<EmailAdress> Emails{ get; set; }

    }
}
