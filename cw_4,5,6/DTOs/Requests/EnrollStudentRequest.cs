﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public class EnrollStudentRequest
{
    [Required]
    [RegularExpression("^s[0-9]+$")]
    [MaxLength(100)]
    public string IndexNumber { get; set; }



    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }


    [Required]
    public string Studies { get; set; }

    [Required]

    public string BirthDate { get; set; }

} 
