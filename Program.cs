using System;

namespace ConsoleApp4
{
    //클래스 형변환

    class Player
    {
        protected int def;
    }
    class Myclass
    {
        void test()
        {
            def = 10;
        }
    }
    class Knight:Player
    {
        void test()
        {
            def = 10;
        }
        private int hp;
        private int attakc;

        public void setHP(int hp)
        {
            this.hp = hp;
            Console.WriteLine($"hp값 : {this.hp}");
        }
        
    }
    class Program
    {
         
        static void Main(string[] args)
        {
            Knight knight = new Knight();

        }
    }
}
