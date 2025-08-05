namespace Triangle_Type_Identifier
{
    internal class TriangleType
    {
        static void Main()
        {
            // Prompt the user to enter the lengths of the three sides
            Console.WriteLine("Enter the length of the first side:");

            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");

            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side:");

            double side3 = Convert.ToDouble(Console.ReadLine());

            // Determine the type of triangle
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("The lengths of the sides must be positive numbers.");
            }
            else if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
