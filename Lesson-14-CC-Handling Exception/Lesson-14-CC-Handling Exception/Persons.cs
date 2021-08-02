using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_CC_Handling_Exception
{
    class Client
    {
        Waiter waiter = new Waiter();

        public void OrderDish()
        {
            string dish = "HumusWithTwoPitot";
            waiter.WriteDish(dish);
        }
    }

    class Waiter
    {
        ShiftManager manager = new ShiftManager();
        public void WriteDish(string dish)
        {
            manager.PassDishToChef(dish);
        }
    }

    class ShiftManager
    {
        Chef chef = new Chef();

        public void PassDishToChef(string dish)
        {
            chef.MakeDish(dish);
        }
    }

    class Chef
    {
        public void MakeDish(string dish)
        {
            if (dish == "Shawarma")
            {
                if (Stock.Lafot >= 1 && Stock.Meat >= 0.4)
                {
                    Stock.Lafot--;
                    Stock.Meat -= 0.4;
                }
                else
                {
                    //throw new
                }
            }
            else if (dish == "HumusWithTwoPitot")
            {
                if (Stock.Humus >= 3 && Stock.Pitot >= 2)
                {
                    Stock.Humus -= 3;
                    Stock.Pitot -= 1;
                }
                else
                {
                    throw new PitaOutOfRangeException("");
                }
            }
        }
    }

    static class Stock
    {
        public static int Humus { get; set; }
        public static int Pitot { get; set; }
        public static int Lafot { get; set; }
        public static double Meat { get; set; }

        static Stock()
        {
            Humus = 30;
            Pitot = 2;
            Lafot = 2;
            Meat = 1;
        }
    }
}
