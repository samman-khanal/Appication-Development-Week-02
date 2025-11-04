class Circle
{
    const double PI = 3.14;
    //? Method to calculate area of the circle
    static double calculateArea(double radius)
    {
        return PI * radius * radius;
    }
    //? Method to calculate perimeter of the circle
    static double calculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }

    static void Main(string[] args)
    {
        //* Trying to change the value of the constant PI
        PI = 6.28;  //! This line will generate a compile-time error because PI is a constant and cannot be reassigned.
    }
}
