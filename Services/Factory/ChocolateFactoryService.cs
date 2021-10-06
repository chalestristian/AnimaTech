using Entities;
using Entities.Factory;

namespace Services.Factory
{
    public class ChocolateFactoryService
    {
        public Chocolate FabricarChocolate()
        {
            return new Chocolate();
        }
        
        public Embalagem FabricarEmbalagem()
        {
            return new Embalagem();
        }

        public Produto MontarProduto()
        {
            return new Produto();
        }


    }
}