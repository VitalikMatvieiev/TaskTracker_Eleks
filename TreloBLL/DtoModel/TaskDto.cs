﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreloDAL.Models;

namespace Trelo1.Models.ViewModel
{
    public class TaskDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public int AssignedUserId { get; set; }
    }
}
