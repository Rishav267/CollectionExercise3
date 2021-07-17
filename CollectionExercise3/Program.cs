using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entity[] entity = new Entity[4];

            IList<Entity> entity = new List<Entity>() { new Entity() { Productid = 200, BrandName = "Dell", Description = "15 inch Monitor", Price = 3400.44 },
            new Entity() { Productid = 120, BrandName = "Dell", Description = "Laptop", Price = 45000.00 },
            new Entity() { Productid = 150, BrandName = "Microsoft", Description = "Windows 7", Price = 7000.50 },
            new Entity() { Productid = 100, BrandName = "Logitech", Description = "Optical Mouse", Price = 540.0 }  };

            Console.WriteLine("enter choice for soting the table 1) Brand Name 2) Price 3) Default");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        var res = entity.OrderBy(a => a.BrandName).ThenBy(a=> a.Description);
                        
                        foreach (var a in res)
                        {                            
                                Console.WriteLine("row is: {0} {1} {2} {3} ", a.Productid, a.BrandName, a.Description, a.Price);
                        
                        }
                        break;
                    }
                case 2:
                    {
                        var res = entity.OrderBy(a => a.Price).ThenBy(a => a.Productid);

                        foreach (var a in res)
                        {
                            Console.WriteLine("row is: {0} {1} {2} {3} ", a.Productid, a.BrandName, a.Description, a.Price);

                        }
                        break;
                    }
                case 3:
                    {
                        var res = entity.OrderBy(a => a.Productid);//.ThenBy(a => a.Description);

                        foreach (var a in res)
                        {
                            Console.WriteLine("row is: {0} {1} {2} {3} ", a.Productid, a.BrandName, a.Description, a.Price);

                        }
                        break;
                    }
                    
            }
            //var res = from e in entity orderby e.Productid select e;
            //var res = entity.OrderBy(a => a.BrandName);
            //entity.OrderBy(ent => ent.Productid);
            //foreach (var a in res)
            //{
            //    Console.WriteLine("row is: {0} {1} {2} {3} ",a.Productid, a.BrandName, a.Description, a.Price);
            //}
        }
    }

    public class Entity
    {
        public int Productid { get; set; }

        public string BrandName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
