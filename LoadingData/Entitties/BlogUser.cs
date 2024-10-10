using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoadingData.Entitties
{
    //[PrimaryKey(nameof(UserId),nameof(BlogId))]
    public class BlogUser
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Blog Blog { get; set; }

        public int BlogId { get; set; }

        public bool IsAdmin { get; set; }
    }
}
