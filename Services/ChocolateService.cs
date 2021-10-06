using System.Collections.Generic;
using System.Globalization;
using Entities;

namespace Services
{
    public class ChocolateService
    {
        public List<Chocolate> GetChocolates()
        {
            try
            {
                var lista = new List<Chocolate>();
                lista.Add(null);
                return new List<Chocolate>();
            }
            catch
            {
                return new List<Chocolate>();

            }
        }

        public Chocolate GetChocolate(string id)
        {
            return new ();
        }
    }
}