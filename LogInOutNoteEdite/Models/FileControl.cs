using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Linq;
using LogInOutNoteEdite.Models;

namespace LogInOutNoteEdite.Models
{
    public class FileControl
    {

        static String FilePath = HttpContext.Current.Server.MapPath("/App_Data/ListProjects.xml");

        public static void LoadFile(ref List<Project> listProjects)
        {
            //string path = "App_Data/ListProjects.xml";
            XDocument document = XDocument.Load(FilePath);
            XElement rootElement = document.Root;

            var listPr = from e in rootElement.Elements() select e;

            foreach(var e in listPr)
            {
                var tmpE = e.Elements();
                
                Project tmp = new Project(Convert.ToInt32(tmpE.ElementAt(0).Value),tmpE.ElementAt(1).Value,tmpE.ElementAt(2).Value,Convert.ToInt32(tmpE.ElementAt(3).Value));
                listProjects.Add(tmp);
            }   
        }
    }
}