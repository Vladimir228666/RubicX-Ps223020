using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.BusinesLogic.Core.Models
{
    public class UserInformationBlo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsBoy { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birtday { get; set; }
        public string AvatarUrl { get; set; }
    }
}
