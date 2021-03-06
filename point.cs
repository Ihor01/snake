﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleSnake
{
    class point
    {
        int x;
        int y;
        char s;

        public point(int x, int y, int s)
        {
            this.x = x;
            this.y = y;
            SetChar(s);
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            s = p.s;
        }

        public point(point p, int s)
        {
            x = p.x;
            y = p.y;
            SetChar(s);
        }

        public void Draw()
        {
            try
            {
                Console.SetCursorPosition(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(e.ToString());
            }
            if (s == '*')
                Console.ForegroundColor = ConsoleColor.Yellow;
            if (s == '$')
                Console.ForegroundColor = ConsoleColor.Green;
            if (s == '#')
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(s);
            if (s == '*' || s == '$' || s == '#')
                Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Move(int i, direction dir)
        {
            if (dir == direction.RIGHT)
                x = x + i;
            else if (dir == direction.LEFT)
                x = x - i;
            else if (dir == direction.DOWN)
                y = y + i;
            else if (dir == direction.UP)
                y = y - 1;
        }

        public void Clear()
        {
            s = ' ';
            Draw();
        }

        public bool IsHit(point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void ChangeChar(int NewChar)
        {
            SetChar(NewChar);
            Draw();
        }

        void SetChar(int Char)
        {
            if (Char == 1)
                this.s = '+';
            if (Char == 2)
                this.s = '$';
            if (Char == 3)
                this.s = '*';
            if (Char == 4)
                this.s = '=';
            if (Char == 5)
                this.s = '#';
        }
    }
}
