using System;
using System.Linq;
using System.Threading.Tasks;

namespace webme12.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public string Clinet { get; set; }

        public Project(long id, string name,string description,string clinet,string img)
        {
              Id = id;
              Img = img;
              Name = name;
              Description = description;
              Clinet = clinet;
        }
    }

 
}
