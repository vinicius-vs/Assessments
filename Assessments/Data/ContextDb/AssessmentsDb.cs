using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ContextDb
{
    public class AssessmentsDb : DbContext
    {
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Phase> Phase { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Criteria> Criterias { get; set; }
        public DbSet<Avaliation> Avaliation { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public AssessmentsDb() : base("Data Source=192.168.0.170;Initial Catalog=Assessments;Persist Security Info=True;User ID=Assessments;Password=projetox")
        {
                
        }
    }
}
