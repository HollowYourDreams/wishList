using System;
using System.Collections.Generic;
using System.Text;

namespace WishList.Contracts.Dtos
{
    public class WishListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? ActualTo { get; set; }
        public string Description { get; set; }
        public Guid Owner { get; set; }

        public List<WishDto> Wishes { get; set; }
    }
}
