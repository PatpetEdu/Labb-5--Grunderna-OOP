namespace Labb_5__Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle Circle1 = new Circle(5);//sets the value of radius from the constructor
            Circle1.getArea();//calls the method getArea


            Circle Circle2 = new Circle(6);//sets the value of radius from the constructor
            Circle2.getArea();//calls the method getArea

        }
    }
}