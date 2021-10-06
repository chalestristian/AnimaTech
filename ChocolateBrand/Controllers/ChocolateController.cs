using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ChocolateBrand.Controllers
{
    public class ChocolateController : ControllerBase
    {
        private ChocolateService _chocolateService;

        public ChocolateController()
        {
            _chocolateService = new ChocolateService();
        }
        
        [HttpGet("{all}")]
        public List <Chocolate> Get()
        {
            try
            {
                var listaDeChocolates = _chocolateService.GetChocolates();
                if (listaDeChocolates?[0]?.OrigemCacau == "Hawaii")
                { return listaDeChocolates.Take(1).ToList();}
                return listaDeChocolates;
            }
            catch (Exception e)
            {
                return new List<Chocolate>();
            }
            
        }
        
        [HttpGet("{id}")]
        public Chocolate Get(string id)
        {
            var chocolate = _chocolateService.GetChocolate(id);
            var origem = chocolate?.OrigemCacau;
            return chocolate;

        }
    }
}