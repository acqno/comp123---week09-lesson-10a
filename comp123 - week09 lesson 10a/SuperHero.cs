using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 13, 2017
 * Description: This is the SuperHeroes class
 * Version: 0.4 - Implemented ITrainable interface
 */

namespace comp123___week09_lesson_10a
{
    /// <summary>
    /// This is the SuperHero Class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma, ITrainable
    {
        // PRIVATE INSTANCE VARIABLES 
        private int _karma;

        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }


        /// <summary>
        /// This is the main constructor for the superHero class
        /// It takes two argument - name (string) - int (karma)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        // CONSTRUCTORS
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

        public void Trains()
        {
            Console.WriteLine("not implemented");
        }
        //PRIVATE METHODS 

        // PUBLIC METHODS  
    }
}