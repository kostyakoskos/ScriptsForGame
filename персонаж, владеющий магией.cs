using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    public class personaj : PlayerScript
    {
        // List<int> inventory = new List<int>();// сдесь буде хранить инвентарь
        // //когда подходим на какую-то позицию
        // if(personaj.position = eleksir.position)
        //     {
        //     inventory.Add(eleksir);
        //     }
        //if(elersir.use)
        // {
        // inventory.eleksir.count--;
        // if(inventory.eleksir.count == 0)
        //     {
        //      eleksir.Visuable=false;
        //     }
        // }


        private int nowmana;
        private int maxmana;
        public int _nowmana// свойство mana, не отрицательная величина.
        {
            get
            {
                return nowmana;
            }
            set
            {
                if (nowmana < 0)
                    throw new ArgumentException();
                if (nowmana > value)
                    nowmana -= -value;
                else
                    _nowmana = nowmana;

            }
        }
        public personaj(int silazaklinaniya, int nowmana)//конструктор, если заклининание обладает
                                                         //силой
        {
            Console.WriteLine("Please enter sila:");
            if (silazaklinaniya > 0)
                nowmana -= silazaklinaniya;
        }
        public void AddHealth(int PlayerScript)//функция добавления здоровья.
        {
            while (nowmana > 0 && health < maxhealth)
            {
                health++;
                nowmana = nowmana - 2;
            }
        }
        HP temp = new HP();
        public void zaklinaniya()
        {
            if(HP)
        }
    }
   
}
