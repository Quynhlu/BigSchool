using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string Lecturerld { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte Categoryld { get; set; }
        public string LecturerId { get; internal set; }
        public byte CategoryId { get; internal set; }
    }
    //public class Category
    //{
    //    public byte Id { get; set; }
    //    [Required]
    //    [StringLength(255)]
    //    public string Name
    //    {
    //        get; set;
    //    }
    //}
}