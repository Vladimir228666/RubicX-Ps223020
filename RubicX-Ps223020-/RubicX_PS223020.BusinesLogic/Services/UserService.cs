using AutoMapper;
using RubciX_Ps223020_DataAccess.Core.Interface.DbContext;
using RubciX_Ps223020_DataAccess.Core.Models;
using RubicX_PS223020.BusinesLogic.Core.Interfaces;
using RubicX_PS223020.BusinesLogic.Core.Models;
using Shared.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRubicContext _context;
        public UserService(IMapper mapper, IRubicContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<UserInformationBlo> AuthWithEmail(string email,string password)
        {
            UserRto user = _context.Users.FirstOrDefault(p => p.Email == email && p.Password == password);
            if (user == null)
                throw new NotFoundExceptions($"Пользователь с почтой {email} не найден");


            return ConverToUserInformation(user);
        }

        public Task<UserInformationBlo> AutWithEmail(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> AutWithLogin(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> AutWithPhone(string numberPrefix, string number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist()
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(string numberPrefix, string number, string password, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
        private async Task<UserInformationBlo> ConverToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            var userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
