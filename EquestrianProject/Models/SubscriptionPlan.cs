using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EquestrianProject.Models
{
    public class SubscriptionPlan
    {
        public int SubscriptionPlanID { get; set; }
        public string SubscriptionPlanName { get; set; }
    }
}