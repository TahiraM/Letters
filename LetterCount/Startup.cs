using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LetterCount
{
    public class Startup
    {
        public int price;
        public string model;
        public string colour;
        public int IdNum;
    }
#region
    public class cars
    {
        public List<Startup> newcars = new List <Startup>();

        public int AddRecord(int Idnum, int pri, string modl, string color)
        {

            Startup carsz = new Startup();

            carsz.price = pri;
            carsz.model = modl;
            carsz.colour = color;
            carsz.IdNum = Idnum;

            newcars.Add(carsz);

        
            return 1;




        }
    }
}
#endregion