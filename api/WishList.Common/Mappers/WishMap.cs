using System;
using System.Collections.Generic;
using System.Text;

using WishList.Contracts.DAL;
using WishList.Contracts.Dtos;

namespace WishList.Common.Mappers
{
    public static class WishMap
    {
        public static WishDal ToDal(this WishDto instance)
        {
            return new WishDal
            {
                CompletedBy = instance.CompletedBy,
                CreatedBy = instance.CreatedBy,
                Created = instance.Created,
                Currency = instance.Currency,
                Description = instance.Description,
                Id = instance.Id,
                Image = (byte[])instance.Image.Clone(),
                IsArchived = instance.IsArchived,
                LinkTo = instance.LinkTo,
                IsCompleted = instance.IsCompleted,
                IsReserved = instance.IsReserved,
                Name = instance.Name,
                NeedTo = instance.NeedTo,
                Price = instance.Price,
                ReservedByUser = instance.ReservedByUser,
                ShowWhoIsCompleted = instance.ShowWhoIsCompleted
            };
        }
        public static WishDto ToDto(this WishDal instance)
        {
            return new WishDto
            {
                CompletedBy = instance.CompletedBy,
                CreatedBy = instance.CreatedBy,
                Created = instance.Created,
                Currency = instance.Currency,
                Description = instance.Description,
                Id = instance.Id,
                Image = (byte[])instance.Image.Clone(),
                IsArchived = instance.IsArchived,
                LinkTo = instance.LinkTo,
                IsCompleted = instance.IsCompleted,
                IsReserved = instance.IsReserved,
                Name = instance.Name,
                NeedTo = instance.NeedTo,
                Price = instance.Price,
                ReservedByUser = instance.ReservedByUser,
                ShowWhoIsCompleted = instance.ShowWhoIsCompleted
            };
        }
    }
}
