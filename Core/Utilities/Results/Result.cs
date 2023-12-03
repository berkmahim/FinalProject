﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message = null) : this(success)
        {
            Message = message;
            
        }
        public Result(bool success)
        {
            Succeeded = success;
        }

        public bool Succeeded {  get; }

        public string Message { get; }
    }
}