﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            new LineHorisontal(3, 35, 8, '*').draw();
            new LineVertical(6, 20, 3, '#').draw();

            Console.ReadKey();
        }

    }

    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol = '*')
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }

    class Line
    {
        protected List<Point> pointList = new List<Point>();

        public void draw()
        {
            foreach (Point i in pointList)
            {
                i.draw();
            }
        }
    }
    class LineHorisontal : Line
    {
        public LineHorisontal(int xFrom, int xTo, int y, char symbol)
        {
            for (int x = xFrom; x <= xTo; x++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }

    class LineVertical : Line
    {
        public LineVertical(int yFrom, int yTo, int x, char symbol)
        {
            for (int y = yFrom; y <= yTo; y++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }
}
