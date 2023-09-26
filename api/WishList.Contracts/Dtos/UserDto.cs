using System;
using System.Collections.Generic;

namespace WishList.Contracts.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string RealName { get; set; }
        public string PhoneNumber { get; set; }

        List<Guid> FriendsIds { get; set;  }

        public List<WishDto> Wishes { get; set; }
    }
}
