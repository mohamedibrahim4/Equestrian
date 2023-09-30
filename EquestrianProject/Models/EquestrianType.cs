using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EquestrianProject.Models
{
    public class EquestrianType
    {
        public int EquestrianTypeID { get; set; }
        [Required(ErrorMessage = "Please enter Equestrian Type Name"), MaxLength(50)]


        public string EquestrianTypeName { get; set; }
    }
}