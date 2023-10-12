using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5__Grunderna_OOP
{
    internal class Circle
    {
        //varibels to store the values
        private float _pi = 3.141f;
        private int _Radius;    
        public Circle(int radius)
        {         
            _Radius = radius;
        }
        //Method getArea calculates the area in a circle and prints the result
        public float getArea() 
        {        
            Console.WriteLine($"Arean för circeln med radie {_Radius} är: {_pi * _Radius * _Radius} ");
            return _pi * _Radius * _Radius; //returns value                   
        }
    }
    
    

}
