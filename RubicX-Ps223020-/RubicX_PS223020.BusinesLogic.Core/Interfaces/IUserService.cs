using RubicX_PS223020.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.BusinesLogic.Core.Interfaces
{
    interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);
    }
}
