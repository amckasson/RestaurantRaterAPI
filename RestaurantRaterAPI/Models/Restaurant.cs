using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    public class Restaurant
    {
        //This acts similarly to our POCO (I think this is our Entity)

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Rating { get; set; }
        //Below is the same as opening "get" and returning somthing, this is the streamlined version
        public bool IsRecommended => Rating > 3.5;
    }
}