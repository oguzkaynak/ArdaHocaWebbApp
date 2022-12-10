using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ArdaHocaWebbApp.Models
{
    public partial class ArdaHocaModel : DbContext
    {
        public ArdaHocaModel()
            : base("name=ArdaHocaModel")
        {
        }
        public virtual DbSet<Manager>Managers { get; set; }
        public virtual DbSet<ManagerTypes>ManagerTypes  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
