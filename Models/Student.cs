using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace efcore1.Models
{
    public class Student
    {   
        [Key]
        public int StudentId{get; set;}
        
        [Column("FirstName", TypeName ="ntext")]
        [MaxLength(200)]

        public string FirstName{get; set;}

        [Column("LastName", TypeName ="ntext")]
        [MaxLength(200)]
        public string LastName{get; set;}
        [Column("CityName", TypeName ="ntext")]
        [MaxLength(200)]
        public string City{get; set;}
        [Column("State", TypeName ="ntext")]
        [MaxLength(200)]
        public string State{get; set;}
    }
}