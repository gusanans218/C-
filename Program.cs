using System;

namespace ConsoleApp3
{
    //필드 : 인스턴스마다 다르게 동작하는 것.
    //static:정적인 변수 혹은 함수, 인스턴스 모두가 공유하는 속성
    // 1. 은닉성 2. 상속성, 3. 다양성
    // 1. 상속성 : 부모 class 자식 class 
    class Player
    {
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("플레이어 생성자 호출");
        }


        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine($"hp{this.hp}");
     
        }
        public void move()
        {
            Console.WriteLine("플레어 움직임");
        }
    }

        class Archer : Player
        {
            //생성자
        }
        class mage : Player
        {

        }
        
        class Knight: Player
    {
            public int hp;
            public int attack;

            //생성자 : knight가 생성될때 호출되는 것

            static public int count = 1;

            public Knight() : base(500)
            {
                hp = 100;
                attack = 10;
                Console.WriteLine("나이트가 생성되었습니다");
            }
            static public Knight CreateKnight()
            {
                Knight knight = new Knight();
                knight.hp = 100;
                knight.attack = 50;
                count++;
                return knight;
            }
            public Knight(int hp)
            {
                hp = 100;
                Console.WriteLine("생성되었습니다");
            }
            public Knight(int hp, int attack) : this(hp)
            {
                this.hp = hp;
                this.attack = attack;
                Console.WriteLine("int, int 호출");
            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
            Knight knight = new Knight();

                Knight.CreateKnight();
                //필드
                Random rand = new Random();
                rand.Next();
                Console.WriteLine();
                knight.move();

                Console.WriteLine($"hp : {knight.hp} attack : {knight.attack}");
            }
        }
    }

