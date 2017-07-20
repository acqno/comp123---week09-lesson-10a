using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 20, 2017
 * Description: This is the AntiHero Class
 * It extends the superHuman class and implements both the IHasKarma and IHasMalice interfaces
 * Version: 0.2 - Implemented ITrainable interface
 */

namespace comp123___week09_lesson_10a
{
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice, ITrainable
    {
        // PRIVATE INSTANCE VARIABLES 
        private int _karma;
        private int _malice;

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
        /// This is the main constructor for the AntiHero class
        /// It takes three arguments - name (string) - karma (int) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        // CONSTRUCTORS 
        public AntiHero(string name, int karma, int malice)
            : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }



        //PRIVATE METHODS 

        //PUBLIC METHODS 
        public void Train()
        {

        }

    }
}