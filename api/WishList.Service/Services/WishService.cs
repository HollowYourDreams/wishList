using WishList.Contracts.Dtos;
using WishList.Contracts.Interfaces;

namespace WishList.Service.Services
{
    public class WishService : IWishService
    {
        public Task<List<WishDto>> GetWishesByUser(Guid userId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
