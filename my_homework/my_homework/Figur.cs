using System;

namespace my_homework

{
    public struct Figur
    {
        private int _x;
        private int _y;
        private readonly int _hw;

        public Figur(int x, int y,int hw)
        {
            _x = x;
            _y = y;
            _hw = hw;
        }

        public void SetNewPosX(int x)
        {
            var tempx = _x;
            _x = _x + x;
            if (_x < 0 || _x > Console.WindowWidth-6)
            {
                _x = tempx;
            }
        }
        public void SetNewPosY(int y)
        {
            var tempy = _y;
            _y = _y + y;
            if (_y < 0 || _y > Console.WindowHeight-6)
            {
                _y = tempy;
            }
        }
        public void Show()
        {
            var x=_x;
            var y=_y;
            for (var i = 1; i <= _hw; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(i == _hw ? "+" : "|");
                if (i == _hw)
                {
                    y = _y;
                    for (var j = 1; j < _hw + 1; j++)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(j == _hw ? "+" : "-");
                    }
                    x = _x;
                    y = _y;
                }
            }
            for (var i = _hw - 1; i >= 0; i--)
            {
                Console.SetCursorPosition(x+_hw, y + i);
                Console.Write(i == 0 ? "+" : "|");
                if (i == 0)
                {
                    x = _x;
                    y = _y;
                    for (var j = _hw - 1; j >= 0; j--)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(j == 0 ? "+" : "-");
                    }
                }
            }
        }
    }
}