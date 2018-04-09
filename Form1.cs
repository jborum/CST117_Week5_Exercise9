/*
 * This program was debugged by Jason Borum
 * Date: April 8, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace Exercise9
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            // added variable to set default value to false
            bool hasElement = false;

            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    // set variable to be true if element is found
                    hasElement = true;
                //else
                //return false;
                //}
                //return false;
                //This section of code would always return false therefore
                //by blocking out this section and return the variable
                //This would ensure true would be returned when the
                //element is found
            }
            return hasElement;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }

            return rhs;
        }
    }
}
