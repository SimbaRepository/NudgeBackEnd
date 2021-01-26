using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NudgeBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NudgeBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
 
    public class APIController : ControllerBase
    {

        
        [HttpGet("GetLaptops")]
        public string GetLaptops()
        {

            List<Laptops> list = new List<Laptops>
{
   new Laptops() { Laptopname = "Sony", Cost = 100},
   new Laptops() { Laptopname = "Toshiba", Cost = 200},
   new Laptops() { Laptopname = "HP", Cost = 300},
};

            string json = JsonConvert.SerializeObject(list);

            return json;

        }


        [HttpGet("GetColors")]
        public string GetColors()
        {

            List<Colors> list = new List<Colors>
{
   new Colors() { LaptopColor = "Ram 8GB", Cost = 500},
   new Colors() { LaptopColor = "Ram 16GB", Cost = 1000},
  
};

            string json = JsonConvert.SerializeObject(list);

            return json;

        }



        [HttpGet("GetHDD")]
        public string GetHDD()
        {

            List<HDD> list = new List<HDD>
{
   new HDD() { HDDSize = "HDD 500 GB", Cost = 5000},
   new HDD() { HDDSize = "HDD 1 TB", Cost = 10000},

};

            string json = JsonConvert.SerializeObject(list);

            return json;

        }


        [HttpGet("GetRam")]
        public string GetRam()
        {

            List<Ram> list = new List<Ram>
{
   new Ram() { LaptopRAM  = "Ram 8GB", Cost = 1000},
   new Ram() { LaptopRAM  = "Ram 16GB", Cost = 5000},

};

            string json = JsonConvert.SerializeObject(list);

            return json;

        }








    }
}
