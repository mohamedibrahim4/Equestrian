using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EquestrianProject.Models
{
    public class Session
    {
        public int SessionID { get; set; }

        public int SessionNo { get; set; }


        public DateTime? SessionDate { get; set; }


        [ForeignKey("Client")]
        public int ClientID { get; set; }

        public Client Client { get; set; }
    }
}