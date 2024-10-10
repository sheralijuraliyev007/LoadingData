using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData.Entitties
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<BlogUser> BlogUsers { get; set; } //WHEN IT IS LAZY LOADING THEY WOULD BE VIRTUAL


        public virtual List<Post> Posts { get; set; }
    }
}
