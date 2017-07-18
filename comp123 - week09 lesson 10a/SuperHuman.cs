using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 18, 2017
 * Description: This is the superHuman sub class
 * Version: 0.9 - Added the GetPowerRank method
 */

namespace comp123___week09_lesson_10a
{
    /// <summary>
    /// This is the SuperHuman sub class
    /// It inherits from the Human SuperClass
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS 
        private List<Power> _powers;

        // PUBLIC PROPERTIES 
        public List<Power> Powers
        {
            get
            {
                return this._powers; // returns a reference to the Powers list
            }
        }

        /// <param name="name"></param>
        // CONSTRUCTORS 
        public SuperHuman(string name)
            : base(name)
        {
            this._Initialize();
        }


        /// <summary>
        /// This method initializes and assigns default values to class fields
        /// </summary>
        // PRIVATE METHODS 
        private void _Initialize()
        {
            _powers = new List<Power>();
        }


        /// <summary>
        /// This private method returns the index of the power name if found.
        /// If not found it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns an integer related to the index of the power</returns>
        private int _findPower(string name)
        {
            int index = 0;

            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;

                if(this.Powers.Count == index)
                {
                    index = -1;
                }
            }

            return index;
        }

        // PUBLIC METHODS 
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// the ToString method overrides the built in object.ToString method 
        /// It outputs a string that disaplays the superhuman's name and their power list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "=================================================================\n";
            outputString += "Name: " + this.Name + "\n";
            outputString += "=================================================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }

            outputString += "=================================================================\n";
            return outputString;
        }


        /// <summary>
        /// This method returns the power rank number of the power in the power list
        /// </summary>
        /// <param name="name"></param>
        /// <returns>This returns the power rank number or 0 if the power is not found</returns>
        public int GetPowerRank(string name)
        {
            if (this._findPower(name) != -1)
            {
                return this.Powers[this._findPower(name)].Rank;
            }

            return 0;
        }

        /// <summary>
        /// This method overrides the human abstract superclass DisplaySkills method
        /// this method will display a list of skills to the console.
        /// </summary>
        /// <returns></returns>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}