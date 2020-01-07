using Microsoft.AspNet.Identity.EntityFramework;
using Projeto01.Areas.Seguranca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto01.DAL
{
    public class IndentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IndentityDbContextAplicacao() : base("IdentityDb") { }

        static IndentityDbContextAplicacao()
        {
            Database.SetInitializer<IndentityDbContextAplicacao>(new IdentityDbInit());
        }

        public static IndentityDbContextAplicacao Create()
        {
            return new IndentityDbContextAplicacao();
        }
    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IndentityDbContextAplicacao>
    {
    }
}