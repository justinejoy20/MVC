﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public DateTime Date { get; set; }

        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}