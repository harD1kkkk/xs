using Microsoft.AspNetCore.Mvc;
using Project_Coffe.Models.ModelInterface;

namespace Project_Coffe.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            await _orderService.CreateOrderAsync(request.UserId, request.ProductIds);
            return Ok(new { message = "Order created successfully" });
        }
    }
    public class CreateOrderRequest
    {
        public int UserId { get; set; }
        public List<int>? ProductIds { get; set; }
    }
}
