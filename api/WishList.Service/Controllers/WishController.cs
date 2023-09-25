using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

using WishList.Contracts.Dtos;

namespace WishList.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class WishController : ControllerBase
    {
        public ILogger<WishController> Logger { get; }
        public WishController(ILogger<WishController> logger)
        {
            Logger = logger;
        }

        [Route("add")]
        [HttpPost]
        public async Task<WishDto> AddWish([FromBody][Required]WishDto wish, CancellationToken ct = default)
        {
            return wish;
        }

        [Route("delete/{wishId}")]
        [HttpDelete]
        public async Task<bool> DeleteWish([FromRoute][Required]Guid wishId, CancellationToken ct = default)
        {
            return true;
        }

        [Route("delete/{wishId}")]
        [HttpPut]
        public async Task<WishDto> UpdateWish([FromBody][Required]WishDto wish, CancellationToken ct = default)
        {
            return wish;
        }

        [Route("get/{wishId}")]
        [HttpGet]
        public async Task<WishDto> GetWish([FromRoute][Required]Guid id, CancellationToken ct = default)
        {
            return new WishDto
            {
                Id = id,
            };
        }

        [Route("user/{userId}")]
        [HttpGet]
        public async Task<List<WishDto>> GetWishesForUser([FromRoute][Required]Guid userId, CancellationToken ct = default)
        {
            return new List<WishDto>
            {
                new WishDto
                {
                    CreatedBy = userId,
                }
            };
        }

        [Route("reserve/{wishId}/{userId?}")]
        [HttpPatch]
        public async Task<WishDto> ReserveWish([FromRoute][Required] Guid wishId, [FromQuery][Required]Guid userId, CancellationToken ct = default)
        {
            return new WishDto { Id = wishId, ReservedByUser = userId };
        }

        [Route("complete/{wishId}/{completedBy?}/{showWhoIsComplete?}")]
        [HttpPatch]
        public async Task<WishDto> CompleteWish([FromRoute][Required] Guid wishId, [FromQuery][Required] Guid completedBy, [FromQuery] bool showWhoIsComplete = false, CancellationToken ct = default)
        {
            return new WishDto
            {
                IsCompleted = true,
                ShowWhoIsCompleted = showWhoIsComplete,
                CompletedBy = completedBy
            };
        }

    }
}
