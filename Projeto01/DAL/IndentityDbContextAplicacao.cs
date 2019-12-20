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
        public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
        {
            public IdentityDbContextAplicacao() : base("IdentityDb") { }

            static IdentityDbContextAplicacao()
            {
                Database.SetInitializer<IdentityDbContextAplicacao>(new IdentityDbInit());
            }

            public static IdentityDbContextAplicacao Create()
            {
                return new IdentityDbContextAplicacao();
            }
        }

        public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IdentityDbContextAplicacao>
        {
        }
    }
}