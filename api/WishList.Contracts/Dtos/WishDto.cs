using System;

using WishList.Contracts.Enums;

namespace WishList.Contracts.Dtos
{
    public class WishDto
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string LinkTo { get; set; }

        public double Price { get; set; }
        public Currencies Currency { get; set; }


        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? NeedTo { get; set; }

        public bool IsReserved { get; set; }
        public Guid ReservedByUser { get; set; }

        public bool IsArchived { get; set; }
        public bool IsCompleted { get; set; }
        public Guid CompletedBy { get; set; }
        public bool ShowWhoIsCompleted { get; set; }

        public Guid CreatedBy { get; set; }

        public byte[] Image { get; set; }
    }
}
