using Microsoft.EntityFrameworkCore;
using RubciX_Ps223020_DataAccess.Core.Interface.DbContext;
using RubciX_Ps223020_DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_Ps223020_DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get => throw new NotImplementedException(); }
        public DbSet<UserRoleRto> UserRoles { get => throw new NotImplementedException();}
    }
}
