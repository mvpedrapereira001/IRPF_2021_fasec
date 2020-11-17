using IRPF_2021_fasec.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IRPF_2021_fasec.DAL
{
    public class EFContext:DbContext
    {

        public EFContext() : base("DefaultConnection") { }

        public DbSet<Titular> Titular { get; set; }


    }
}