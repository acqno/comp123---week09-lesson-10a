using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 11, 2017
 * Description: This is the power class
 * Version: 0.2 - Added the greater than and less than overloaded methods to return the greater or lesser power. 
 */

namespace comp123___week09_lesson_10a
{

    /// <summary>
    /// The power class contains the data and structure of each super power
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        /// <summary>
        /// This is the power constructor
        /// Takes two parameters - name (string) - rank (int)
        /// </summary>
        // CONSTRUCTORS ---------------------------------------------------
        public Power(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }

        // OVERLOADED METHODS 

        /// <summary>
        /// This method overloads the > operator for the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns the power that is greater</returns>
        public static Power operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank) ? lhs : rhs;
        }

        /// <summary>
        /// This method overlads the < operator for the power class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns the power that is lesser in rank</returns>
        public static Power operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank) ? lhs : rhs;
        }

    }
}