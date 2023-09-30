using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EquestrianProject.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Please enter Client Name"), MaxLength(100)]

        public string ClientName { get; set; }
        public GenderType? Gender { get; set; }
        //[Required(ErrorMessage = "Please enter Date Of Participation")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yy}")]
        //[Required(ErrorMessage = "Enter Date Of Participation")]
        [DataType(DataType.Date)]
        public DateTime DateOfParticipation { get; set; }
        //public string ImagePath { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yy}")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yy}")]

        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        public string ReferedBy { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Price Cost")]

        public float PriceCost { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Discount")]

        public double Discount { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Paid Cost")]

        public double PaidCost { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Remaining Cost")]

        public double RemainingCost { get; set; }

        public string Notes { get; set; }

        [ForeignKey("SubscriptionPlan")]
        public int SubscriptionPlanID { get; set; }
        public SubscriptionPlan SubscriptionPlan { get; set; }

        [ForeignKey("EquestrianType")]
        public int EquestrianTypeID { get; set; }
        public EquestrianType EquestrianType { get; set; }
    }
}