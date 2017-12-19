using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FiskeriServiceNiklasTest4
{
    public class Catch
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public string Place { get; set; }
        public int Week { get; set; }

        public Catch()
        {
            
        }

        public Catch(int id, string name, string type, double weight, string place, int week)
        {
            Id = id;
            Name = name;
            Type = type;
            Weight = weight;
            Place = place;
            Week = week;
        }
    }
}