namespace Rectangle
{
    public class rectangle
    {
        double width;
        double height;

        public rectangle()
        {

        }

        public rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getArea()
        {
            return this.width * this.height;
        }

        public double getPerimeter()
        {
            return (this.width + this.height) * 2;
        }
    }
}
