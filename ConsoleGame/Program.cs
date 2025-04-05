/* C# 언어를 사용해서 게임을 만든다.
 * 1. AI를 사용해서 질문을 한다.
 * 2. 이미 만들어진 게임에 기능을 추가하고 싶다. -> 구현된 코드의 의미를 알아야한다.
 * 
 * 목표1_ 숫자의 값이 1~100이다. 이 값을 1 ~ 1000 증가시켜보세요.
 * 목표2_ 숫자를 맞추는 것을 방해하는 요소를 만든다. 정답을 입력할 횟수를 구현하기.
 */


using System;
class Program
{
    static void Main()
    {
        int maxNumber = 1000; // 목표의 최대 값을 변수로 선언한다.

        Random random = new Random();
        int secretNumber = random.Next(1, maxNumber + 1); // 1에서 100 사이의 랜덤 숫자
        int guess = 0;
        int attempts = 0;
        int maxTryNumber = 5;

        Console.WriteLine("숫자 맞히기 게임을 시작합니다! 1부터 100 사이의 숫자를 맞혀보세요.");

        while (guess != secretNumber)
        {
            Console.Write("숫자를 입력하세요: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                attempts++;
                // attempts = attempts + 1; // 변수 = 데이터, '=' 오른쪽 값을 왼쪽으로 대입한다.  
                // attempts = 1; 
                if (guess < secretNumber)
                {
                    Console.WriteLine("너무 낮아요! 더 큰 숫자를 입력하세요.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("너무 높아요! 더 작은 숫자를 입력하세요.");
                }
                else
                {
                    Console.WriteLine($"정답입니다! {attempts}번 만에 맞히셨습니다.");
                }

                if(attempts == maxTryNumber)
                {
                    Console.WriteLine("시도 횟수를 전부 하였습니다. 게임이 종료됩니다.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("올바른 숫자를 입력하세요.");
            }
        }
    }
}
