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

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
        
        
        public double Rating
        {
            get
            {
                double totalAverageRating = 0;

                foreach (Rating rating in Ratings)
                {
                    totalAverageRating += rating.AverageRating;
                }
                return totalAverageRating / Ratings.Count;
            }
        }

        //AverageFoodScore //Challenge
        public double AverageFoodScore
        {
            get
            {
                double totalAverageFoodScore = 0;

                foreach (Rating foodScore in Ratings)
                {
                    totalAverageFoodScore += foodScore.FoodScore;
                }
                return totalAverageFoodScore / Ratings.Count;
            }
        }
        //AverageEnviromentScore // Challenge
        public double AverageEnviromentScore
        {
            get
            {
                double totalAverageEnviromentScore = 0;

                foreach (Rating enviromentScore in Ratings)
                {
                    totalAverageEnviromentScore += enviromentScore.EnviromentScore;
                }
                return totalAverageEnviromentScore / Ratings.Count;
            }
        }
        //AverageCleanlinessScore // Challenge
        public double AverageCleanlinessScore
        {
            get
            {
                double totalAverageCleanlinessScore = 0;

                foreach (Rating cleanlinessScore in Ratings)
                {
                    totalAverageCleanlinessScore += cleanlinessScore.CleanlinessScore;
                }
                return totalAverageCleanlinessScore / Ratings.Count;
            }
        }

        //Below is the same as opening "get" and returning somthing, this is the streamlined version
        public bool IsRecommended => Rating > 8.5;
    }
}