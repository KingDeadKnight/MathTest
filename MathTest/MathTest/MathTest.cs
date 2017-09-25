using System;

namespace MathTest
{
    //Point
    public class Point
    {
        private Object x;
        private Object y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x)
        {
            this.x = x;
            this.y = 0;
        }

        public Point(float x)
        {
            this.x = x;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override String ToString()
        {
            return "(" + this.x + ", " + this.y + ")";
        }
    }

    //RIGHT
    public class Right
    {
        private Object a;
        private Object b;
        private Object c;

        public Right(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Right(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    //VECTOR
    public class Vector
    {

        public Vector()
        {

        }
    }
}