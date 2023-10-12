using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5__Grunderna_OOP
{
    internal class Circle
    {
        private float _pi = 3.141f;
        private int _Radius;

        public Circle(int radius)
        {         
            _Radius = radius;
        }

        public float getArea()
        {
            
            Console.WriteLine($"Arean för circeln med radie {_Radius} är: {_pi * _Radius * _Radius} ");
            return _pi * _Radius * _Radius;
            
           
        }
    }
    
    

}
