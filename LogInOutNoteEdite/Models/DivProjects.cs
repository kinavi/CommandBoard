using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogInOutNoteEdite.Models;


namespace LogInOutNoteEdite.Models
{
    public class DivProjects
    {
        public List<Project> listProjects = new List<Project>();

        public DivProjects()
        {
            FileControl.LoadFile(ref listProjects);
        }
    }
}