using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData.Entitties
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<BlogUser> UserBlogs {  get; set; } 
    }
}
