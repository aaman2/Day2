using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  
OOP -

  Object ( Any Person Place or thing) - Anything which is exist in the world and which has description
  ^
  |
  Oriented (Dedication in One Direction)
  ^
  |
  Programming (An approach to write a program)


  Program - Solution ( Product )

  OOP is a theoratical concept to understand the real life in computer world with technical description.

  OOP - How to create new objects and how to use existing one (object base)

  Paradigms

  Class   - Class is collection of descriptions. It is just an imagination. It does not physically exist in the world.

  Object  - Physically exist in the word which can be describe.

  Relation Between Class and Object

  Class gives theoratical description about an object and object is real life
  representative of class. Class tells what what of an object is.

  Encapsulation - It is a process to wrap the information about an object which
  you want to create into a single unit after Encapsulation the encapsulated unit
  is know as class. Class has

	Properties  - Decide how an object look like
	Function - decide how an object work
	Events  - what kind of actions an object can take.
	Event Handlers - when a function associated with an event that function is known as event handler

  in its description. During encapsulation we will also decide which one member of class
  should be public or private to make a member private is known as data hiding.

  class classname
  {
     private dt varname; // datatype
     .....
     public DataType PropertyUnitName
        {
            get{ return varname;} // absense of this mean this property write only
            set{ varname=value; } // absense of this mean this property is ready only
        }
     public RT funname()
        {
        ....
        }
     .........
  }

  Abstration - Represent the complexity in very simple manner. PINK
  Polymorphism
  Inheritance
*/
namespace ConsoleAppIntro
{
    public class Rect
    {
        int l, b; // instance variable
        public Rect()
        {
            l = 0; b=0;
        }
        public Rect(int len, int b) // local variable of Rect() constructor
        {
            l = len;
            this.b = b;
        }
        public int Length
        {
            get { return l; }
            set { l = value; }
        }
        public int Breadth
        {
            get { return b; }
            set { b = value; }
        }
        public int area()
        {
            return l * b;
        }
    }
}
