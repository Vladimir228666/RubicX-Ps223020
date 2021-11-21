using Microsoft.EntityFrameworkCore;
using RubciX_Ps223020_DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubciX_Ps223020_DataAccess.Core.Interface.DbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
