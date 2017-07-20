using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 13, 2017
 * Description: This is the Super Villain class
 * Version: 0.3 - refactored - removed the ITrainable interface 
 */

namespace comp123___week09_lesson_10a
{
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES 
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }

        /// <summary>
        /// This is the main constructor for the superVillain class
        /// It takes two argument - name (string) - int (karma)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        // CONSTRUCTORS
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        // PUBLIC METHODS 

        public override void Trains()
        {
            Console.WriteLine("not implemented");
        }
    }
}