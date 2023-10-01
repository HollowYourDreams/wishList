using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using WishList.Contracts.Dtos;

namespace WishList.Contracts.Interfaces
{
    public interface IWishService
    {

        Task<List<WishDto>> GetWishesByUser(Guid userId, CancellationToken ct = default);

    }
}
