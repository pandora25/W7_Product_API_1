using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cars_DealerShip_FinalCapstone.Models;

namespace Cars_DealerShip_FinalCapstone.Controllers
{
    public class CarsController : ApiController
    {
        [HttpGet]
        public List<Cars_Table> AllCarAPI()
        {
            Cars_Final_ProjectEntities ORM = new Cars_Final_ProjectEntities();
            return ORM.Cars_Table.ToList();
        }


        [HttpGet]
        public List<Cars_Table> AllCarMakesAPI(string make)
        {
            Cars_Final_ProjectEntities ORM = new Cars_Final_ProjectEntities();
            return ORM.Cars_Table.Where(t => t.Make.Contains(make)).ToList();
        }

        [HttpGet]
        public List<Cars_Table> AllCarModelAPI(string model)
        {
            Cars_Final_ProjectEntities ORM = new Cars_Final_ProjectEntities();
            return ORM.Cars_Table.Where(t => t.Model.Contains(model)).ToList();

        }

        [HttpGet]
        public List<Cars_Table> AllCarColorAPI(string color)
        {
            Cars_Final_ProjectEntities ORM = new Cars_Final_ProjectEntities();
            return ORM.Cars_Table.Where(t => t.Color.Contains(color)).ToList();
        }

        [HttpGet]
        public List<Cars_Table> AllCarYearAPI(string year)
        {
            Cars_Final_ProjectEntities ORM = new Cars_Final_ProjectEntities();
            return ORM.Cars_Table.Where(t => t.Year.Contains(year)).ToList();
        }

    }
}
