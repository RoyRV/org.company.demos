﻿using System.ComponentModel.DataAnnotations;

namespace org.company.order.entities
{
    public class Status
    {

        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}