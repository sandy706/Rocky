﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class BookingStatus
    {
        
        public int Id { get; set; }
        

        public string Name { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }


    }
}
