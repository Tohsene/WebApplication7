using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApplication7.Models
{
    [Table("tb1_Student")]
    public class Student
    {
        [Key]
        public int Std_Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Std_Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Std_Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Std_Address { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Password is required")]
        //[RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)", ErrorMessage ="Invalid password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password",ErrorMessage ="Password does not match" )]
        public string cPassword { get; set; }
    }

    public class Db:DbContext
    {
        public Db():base("cs")
        {

        }

        public DbSet<Student> Students { get; set; }

    }

}