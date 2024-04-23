
using BlazorApp1Tut.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorApp1Tut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public OperationController(OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Construct an anonymous object with the data you want to return
            var data = new
            {
                Transient = _transientOperation,
                Scoped = _scopedOperation,
                Singleton = _singletonOperation,
                SingletonInstance = _singletonInstanceOperation,
                Service = _operationService
            };

            // Serialize the data to JSON
            var jsonData = JsonConvert.SerializeObject(data);

            // Return the JSON data
            return  Content(jsonData, "application/json");
        }
    }
}
