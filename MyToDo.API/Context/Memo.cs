﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDo.API.Context
{
    public class Memo : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
    }
}
