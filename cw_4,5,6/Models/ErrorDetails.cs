﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ErrorDetails
{
    public string Message { get; set; }
    public int StatusCode { get; set; }


    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}