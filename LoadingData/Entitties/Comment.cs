﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData.Entitties
{
    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public  virtual Post Post { get; set; }

        public string Text { get; set; }
    }
}
