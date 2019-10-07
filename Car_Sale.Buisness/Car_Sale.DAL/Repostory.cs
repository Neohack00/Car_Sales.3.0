using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Car_Sale.Business;
namespace Car_Sale.DAL
{
    public class Repostory
    {
        List<Car> MyCars = new List<Car>();

        public void Save(Car AddCar)
        {
            MyCars.Add(AddCar);
        }

        public List<Car> GetList()
        {
            return MyCars;
        }

    }
    
}
