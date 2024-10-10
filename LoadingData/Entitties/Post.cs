using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LoadingData.Entitties;

    public class Post {
        private ILazyLoader LazyLoader;

        //public Post(ILazyLoader lazyLoader)
        //{
        //    LazyLoader = lazyLoader;
        //}

        public int Id { get; set; }

        public int BlogId { get; set; }

        

        public string Content { get; set; }

        public string PhtotoUrl { get; set; }
        public virtual Blog Blog { get; set; }

        public virtual  List<Comment> Comments { get; set; }



        //public void LoadBlog()
        //{
        //    LazyLoader.Load(this, "Blog");
        //}

    }

    public class PostChild : Post
    {
        private ILazyLoader LazyLoader;

        public PostChild(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public override Blog Blog
        {
            get
            {
                LazyLoader.Load(this, nameof(Blog));
                return Blog;
            }
            set
            {

            }
        }
    }

