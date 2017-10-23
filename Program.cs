using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrap
{
    class Program
    {
        static void Main(string[] args)
        {
            string CactusHabitat = "desert";
            Plant CactusPlant = new Plant(CactusHabitat);
            //Instantiate a type Plant, called CactusPlant

            FlyTrap FreddieTheFlyTrap = new FlyTrap();
            FreddieTheFlyTrap.WaterPlant(12);
            //Instantiate a type FlyTrap, a subclass off Plant, called FreddieTheFlyTrap
            //Call Plant method WaterPlant (inherits method)

            string DoDoBirdName = "DoDo";
            int DoDoBirdAge = 120;
            Animal DoDoBird = new Animal(DoDoBirdAge, DoDoBirdName);
            DoDoBird.GrowOlder();
            //Instantiate a type Animal, called DoDoBird
            //Call Animal method GrowOlder

            IBugEater ArnieTheAardvark = new Aardvark();
            ArnieTheAardvark.ConsumeBugs(3);
            //Instatiate a type Aadvark, with Interface of BugEater
            //Call method ConsumeBug (inherits from BugEater interface)
            //Call method FeedAardvark
            //Call method GrowOlder (inherits from LivingBeing)

            //DoDoBird.IBugEater();
            //Will not work, as DoDoBird is type Animal, and does not ref BugEater Interface
        }
    }
}
