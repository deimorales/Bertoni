﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class CommentsModel
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}