using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogInOutNoteEdite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Rank { get; set; }

        public Project(int id, string name, string disc, int rank)
        {
            Id = id;
            Name = name;
            Discription = disc;
            Rank = rank;
        }
    }
}