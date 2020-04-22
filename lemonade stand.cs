using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public List<string> names;
        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            names = new List<string>() { "Brad", "Cheeseman", "Roosevelt" };
            name = ChooseName();
        }





        // member methods (CAN DO)
        public string ChooseName()
        {
          Random randObj = new Random();
          int randomNumber = randObj.Next(names.Count - 1);
          return names[randomNumber];
          
        }
   
    }
        
        
      
}
