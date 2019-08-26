﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using StudentiProject.Models.Attributes;

namespace StudentiProject.Responses
{
    public class CollegeResponse
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }


    }
}
