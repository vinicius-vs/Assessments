﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ContextDb
{
    public class AssessmentsDb : DbContext
    {

        public AssessmentsDb() : base("Data Source=192.168.0.170;Initial Catalog=Assessments;Persist Security Info=True;User ID=Assessments;Password=projetox")
        {
                
        }
    }
}
