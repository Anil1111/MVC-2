﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Degree 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DegreeID { get; set; }
        public string DegreeAbbrev { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
        public ICollection<DegreeRequirement> DegreeRequirements { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "DegreeId = " + DegreeID +
              ", DegreeAbbrev = " + DegreeAbbrev +
              ", DegreeName = " + DegreeName +
              "";
        }
    }
}
