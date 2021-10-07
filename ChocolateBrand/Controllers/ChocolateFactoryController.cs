using Microsoft.AspNetCore.Mvc;
using Services.Factory;

namespace ChocolateBrand.Controllers
{
    public class ChocolateFactoryController
    {

        [ApiController]
        [Route("[controller]")]
        public class ChocolateFactory : ControllerBase
        {
            private ChocolateFactoryService _chocolateFactoryService;

            public ChocolateFactory()
            {
                _chocolateFactoryService = new ChocolateFactoryService();
            }


            [HttpPost]
            public void FabricarChocolate()
            {
                _chocolateFactoryService.FabricarChocolate();
            }
        }
    
}
}
