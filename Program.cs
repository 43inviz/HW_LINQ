using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace HW_Device
{
    /*Створіть користувацький тип «Пристрій», який зберігатиме таку
інформацію:
 назва пристрою;
 виробник пристрою;
 вартість.
Для двох масивів пристроїв реалізуйте операції:
 різниця масивів;
 перетин масивів;
 об'єднання масивів.
Критерій для проведення операцій — виробник пристрою.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices2 = new List<Device>() 
            { 
                new Device ("S21", "Samsung", 799.99),
                new Device("3310", "Nokia", 499.99),
                new Device("13", "Apple", 999.99),

            
            };


            List<Device> devices1 = new List<Device>()
            {
                new Device("Galaxy Note", "Samsung", 949.99),
                new Device("Nova ", "Huawei", 499.99),
                new Device("SE", "Apple", 399.99),

            };

            //Разница по производителю
            List<Device> list = GetDifference(devices1, devices2);

            ShowUnion(devices1, devices2);

            //list = GetIntersection(devices1, devices2);

            //foreach(var el in list)
            //{
            //    Console.WriteLine(el.Maker);
            //}

            Console.ReadKey();
        }

        public static List<Device> GetDifference(List<Device> list1,List<Device>list2)
        {
            var difference1 = list1.Where(el1 => !list2.Any(el2 => el2.Maker == el1.Maker));
            var difference2 = list2.Where(el1 => !list1.Any(el2 => el2.Maker == el1.Maker));

            if(difference1!=null && difference2!=null)
            {

                List<Device> list = new List<Device>();


                foreach (var device in difference1)
                {
                
                    list.Add(device);
                }
                foreach (var device in difference2)
                {
                
                    list.Add(device);
                }

                return list;
            }
            else
            {
                throw new Exception("Различия не найдены");
            }
        }

        public static List<Device> GetIntersection(List<Device> list1, List<Device> list2)
        {

            var intersection1 = list1.Where(d1 => list2.Any(d2 => d2.Maker == d1.Maker));
            var intersection2 = list1.Where(d1 => list2.Any(d2 => d2.Maker == d1.Maker));

            if(intersection1 != null && intersection2 != null)
            {
                List<Device> list = new List<Device>();

                foreach(var device in intersection1)
                {
                    list.Add(device);
                }
                foreach(var device  in intersection2)
                {
                    list2.Add(device);
                }
                return list;
            }
            else
            {
                throw new Exception("Пересечения не найдены");
            }

        }

        public static void ShowUnion(List<Device> list1, List<Device> list2)
        {
            var union = list1.Concat(list2).OrderBy(el => el.Maker).Select(el => el);

            foreach(var device in union)
            {
                Console.WriteLine(device.ToString());
                Console.WriteLine();
            }
        }
    }
}
