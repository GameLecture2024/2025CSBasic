namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 선언 방법
            // 정수, 실수, 문자, 문자열

            // 정수를 표현하는 방법
            int number = 10;
            // 실수를 표현하는 방법
            float number2 = 0.5f;
            // 문자를 표현하는 방법
            char character = 'F';
            // 문자열을 표현하는 방법
            string myString = "안녕하세요";

            // 변수를 화면에 출력하기
            Console.Write(number);

            // 게임에 등장하는 플레이어를 상상해보세요.
            // 이름,
            string playerName = "홍길동";
            // 아이디,
            string ID = "ABC#123";
            // 레벨,
            int level = 1;
            // 공격력
            int attackPower = 10;
            // 점프하는 힘,
            float jumpForce = 50 * 9.5f;
            // 경험치
            int exp = 0;

            int uiPosX = 80;
            int uiPosY = 5;

            int playerX = 10;
            int playerY = 10;

            Console.SetCursorPosition(uiPosX, uiPosY - 1);
            Console.Write("+--------------------------+");
            Console.SetCursorPosition(uiPosX, uiPosY + 0);
            Console.WriteLine($"플레이어의 이름: {playerName}");
            Console.SetCursorPosition(uiPosX, uiPosY + 1);
            Console.WriteLine($"플레이어의 ID: {ID}");
            Console.SetCursorPosition(uiPosX, uiPosY +2);
            Console.WriteLine($"플레이어의 레벨: {level}");
            Console.SetCursorPosition(uiPosX, uiPosY +3);
            Console.WriteLine($"플레이어의 공격력: {attackPower}");
            Console.SetCursorPosition(uiPosX, uiPosY +4);
            Console.WriteLine($"플레이어의 점프력: {jumpForce}");
            Console.SetCursorPosition(uiPosX, uiPosY +5);
            Console.WriteLine($"플레이어의 경험치: {exp}");
            Console.SetCursorPosition(uiPosX, uiPosY + 6);
            Console.WriteLine($"플레이어의 좌표: {playerX},{playerY}");
            Console.SetCursorPosition(uiPosX, uiPosY + 7);
            Console.WriteLine("+--------------------------+");

            int time = 0;

            // 플레이어의 좌표로 커서를 이동해서 * 플레이어를 표현해보세요
            Console.SetCursorPosition(playerX, playerY);
            Console.WriteLine("*");

            while(true)
            {
                //time++;
                //Console.WriteLine($"현재 타임의 값 : {time}");
                // 플레이어의 이동을 구현해보자

                var key = Console.ReadKey(true);

                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(" ");

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow: playerX--;
                        // 만약에 X좌표가 0보다작으면 0으로 만들어라
                        break;
                    case ConsoleKey.RightArrow: playerX++;
                        break;
                    case ConsoleKey.UpArrow: playerY--;
                        // 만약에 X좌표가 0보다작으면 0으로 만들어라
                        break;
                    case ConsoleKey.DownArrow: playerY++;
                        break;
                    default:
                        break;
                }

                // 키보드 화살표 왼쪽, 오른쪽을 누르면 playerX의 값이 변경된다.

                // 키보드 화살표 위쪽, 아래쪽을 누르면 playerY의 값이 변경된다.

                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine("*");
                if (time == 10)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }

                Console.SetCursorPosition(uiPosX, uiPosY - 1);
                Console.Write("+--------------------------+");
                Console.SetCursorPosition(uiPosX, uiPosY + 0);
                Console.WriteLine($"플레이어의 이름: {playerName}");
                Console.SetCursorPosition(uiPosX, uiPosY + 1);
                Console.WriteLine($"플레이어의 ID: {ID}");
                Console.SetCursorPosition(uiPosX, uiPosY + 2);
                Console.WriteLine($"플레이어의 레벨: {level}");
                Console.SetCursorPosition(uiPosX, uiPosY + 3);
                Console.WriteLine($"플레이어의 공격력: {attackPower}");
                Console.SetCursorPosition(uiPosX, uiPosY + 4);
                Console.WriteLine($"플레이어의 점프력: {jumpForce}");
                Console.SetCursorPosition(uiPosX, uiPosY + 5);
                Console.WriteLine($"플레이어의 경험치: {exp}");
                Console.SetCursorPosition(uiPosX, uiPosY + 6);
                Console.WriteLine($"플레이어의 좌표: {playerX},{playerY}");
                Console.SetCursorPosition(uiPosX, uiPosY + 7);
                Console.WriteLine("+--------------------------+");
            }
        }
    }
}
