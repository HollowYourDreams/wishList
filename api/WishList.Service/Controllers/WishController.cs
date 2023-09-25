using Microsoft.AspNetCore.Mvc;

using WishList.Contracts.Dtos;

namespace WishList.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishController : ControllerBase
    {
        public ILogger<WishController> Logger { get; }
        public WishController(ILogger<WishController> logger)
        {
            Logger = logger;
        }

        public async Task<WishDto> AddWish(WishDto wish, CancellationToken ct = default)
        {
            return wish;
        }

        public async Task<bool> DeleteWish(Guid wishId, CancellationToken ct = default)
        {
            return true;
        }

        public async Task<WishDto> UpdateWish(WishDto wish, CancellationToken ct = default)
        {
            return wish;
        }

        [HttpGet(Name = "get")]
        public async Task<WishDto> GetWish([FromQuery]Guid id, CancellationToken ct = default)
        {
            return new WishDto
            {
                Id = id,
            };
        }

        public async Task<List<WishDto>> GetWishesForUser(Guid userId, CancellationToken ct = default)
        {
            return new List<WishDto>
            {
                new WishDto
                {
                    CreatedBy = userId,
                }
            };
        }

        public async Task<WishDto> ReserveWish(Guid wishId, Guid userId, CancellationToken ct = default)
        {
            return new WishDto { Id = wishId, ReservedByUser = userId };
        }

        public async Task<WishDto> CompleteWish(Guid wishId, Guid completedBy, bool showWhoIsCompleted = false, CancellationToken ct = default)
        {
            return new WishDto
            {
                IsCompleted = true,
                ShowWhoIsCompleted = showWhoIsCompleted,
                CompletedBy = completedBy
            };
        }

    }
}
