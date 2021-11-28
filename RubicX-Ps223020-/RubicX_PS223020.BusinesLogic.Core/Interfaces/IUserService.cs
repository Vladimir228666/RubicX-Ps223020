using RubicX_PS223020.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.BusinesLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);
        Task<UserInformationBlo> AutWithPhone(string numberPrefix, string number, string password);
        Task<UserInformationBlo> AutWithEmail(string email, string password);
        Task<UserInformationBlo> AutWithLogin(string login, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(string numberPrefix, string number, string password, UserUpdateBlo userUpdateBlo);
        Task<bool> DoesExist();
    }
}
