namespace RunGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 트랙을 그린다.
            // 2. 트랙안에 5명의 러너가 존재한다.

            // 누가 우승할 것인가? <= 기능 구현이 필요

            // 달리는 사람들이 각자의 속도로 움직인다. 도착했음을 알려주는 내용이 필요하다.

            Console.WriteLine("1 ~ 5 러너 중에 누가 일등을 할 지 고르세요.");
            int userInput = int.Parse(Console.ReadLine());
            int selectNum = 0;
            if(userInput == 1) // 1번이 일등할 거라고 입력했어
            {
                selectNum = 1;
            }
            else if(userInput == 2)
            {
                selectNum = 2;
            }
            else if(userInput == 3)
            {
                selectNum = 3;
            }
            else if(userInput == 4)
            {
                selectNum = 4;
            }
            else if(userInput == 5)
            {
                selectNum = 5;
            }

           
            Console.WriteLine($"1등으로 예상한 말 : {selectNum}말");
            ////////////////////////////////////////////////////////////////////////////////////////////////
            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;
            int runE = 0;

            int SpeedA = 0;
            int SpeedB = 0;
            int SpeedC = 0;
            int SpeedD = 0;
            int SpeedE = 0;

            bool endA = false;
            bool endB = false;
            bool endC = false;
            bool endD = false;
            bool endE = false;     // 

            int money = 0;
            int minSpeed = 1;
            int maxSpeed = 5;


            Random random = new Random();

            // 경기 시작전에 유저의 스탯을 업그레이드 할 수 있는 기능을 구현

            Console.WriteLine("1번을 입력하면 최소 속도가 증가하고, 2번을 입력하면 최대 속도가 증가합니다.");

            userInput = int.Parse(Console.ReadLine());

            if(userInput == 1)
            {
                if(minSpeed + 3 > maxSpeed)
                {
                    Console.WriteLine("업그레이드를 할 수 없습니다.");
                }
                else
                {
                    minSpeed = minSpeed + 3;
                }             
            }
            else if(userInput == 2)
            {
                maxSpeed = maxSpeed + 3;
            }


            while (true)               // 계속 반복하세요
            {
                Thread.Sleep(1000);    // 잠시 코드를 쉬세요
                Console.Clear();       // 화면을 지우세요

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("==정보 표시==");
                Console.WriteLine("1등으로 예상한 말 : " + selectNum + "말");
                Console.WriteLine("소지 금액 : " + money);
                Console.WriteLine("최소 속도 : " + minSpeed + " 최대 속도 : " + maxSpeed);

                Console.SetCursorPosition(0, 0);
                SpeedA = random.Next(minSpeed, maxSpeed); // 1 ~ 5 랜덤값으로 출력된다.
                runA = runA + SpeedA;
                SpeedB = random.Next(1, 5);
                runB = runB + SpeedB;
                SpeedC = random.Next(1, 15);
                runC = runC + SpeedC;
                SpeedD = random.Next(1, 5);
                runD = runD + SpeedD;
                SpeedE = random.Next(1, 5);
                runE = runE + SpeedE;

                Console.WriteLine("==================================================");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("1"); // 1번 러너를 그려라

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("4");

                for (int i = 0; i < runE; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("5");

                Console.WriteLine("=================================================="); 

                // 골라인에 도착했는지 파악하는 코드

                if(runA >= 50)
                {
                    endA = true;
                }

                if(runB >= 50)
                {
                    endB = true;
                }

                if(runC >= 50)
                {
                    endC = true;
                }

                if(runD >= 50)
                {
                    endD = true;
                }

                if(runE >= 50)
                {
                    endE = true;
                }

                // A,B,C,D,E중에 누구라도 결승선에 도착했으면 경기가 종료된다.
                if(endA == true || endB == true || endC == true || endD == true || endE == true)
                {
                    Console.WriteLine("경기가 종료되었습니다.");
                    break;
                }
            }

            // 경기 종료후에 누가 1등인지 알려줘야한다.
            if(endA == true && selectNum == 1) // 1번말이 우승했고, 선택한 말이 1번이다.
            {
                Console.WriteLine("1등은 : 1번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if(endB == true && selectNum == 2)
            {
                Console.WriteLine("1등은 : 2번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endC == true && selectNum == 3)
            {
                Console.WriteLine("1등은 : 3번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endD == true && selectNum == 4)
            {
                Console.WriteLine("1등은 : 4번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endE == true && selectNum == 5)
            {
                Console.WriteLine("1등은 : 5번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }



            /////////////////////////////////////////////////////////////////////////
            
            // 게임 기본 세팅을 해준다.

            // 1. 모든 주자를 0으로 세팅
            // 2. 도착했던 결과를 false로 되돌리기
            // 3. 1등할 주자 다시 선택하기
            // 코드를 복사해서 붙여넣은 수 만큼 게임에 반복해서 진행된다.
            runA = 0;
            runB = 0;
            runC = 0;
            runD = 0;
            runE = 0;

            endA = false;
            endB = false;
            endC = false;
            endD = false;
            endE = false;

            Console.WriteLine("1 ~ 5 러너 중에 누가 일등을 할 지 고르세요.");
            userInput = int.Parse(Console.ReadLine());
            selectNum = 0;
            if (userInput == 1) // 1번이 일등할 거라고 입력했어
            {
                selectNum = 1;
            }
            else if (userInput == 2)
            {
                selectNum = 2;
            }
            else if (userInput == 3)
            {
                selectNum = 3;
            }
            else if (userInput == 4)
            {
                selectNum = 4;
            }
            else if (userInput == 5)
            {
                selectNum = 5;
            }

            Console.WriteLine("1번을 입력하면 최소 속도가 증가하고, 2번을 입력하면 최대 속도가 증가합니다.");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                if (minSpeed + 3 > maxSpeed)
                {
                    Console.WriteLine("업그레이드를 할 수 없습니다.");
                }
                else
                {
                    minSpeed = minSpeed + 3;
                }
            }
            else if (userInput == 2)
            {
                maxSpeed = maxSpeed + 3;
            }


            while (true)               // 계속 반복하세요
            {
                Thread.Sleep(1000);    // 잠시 코드를 쉬세요
                Console.Clear();       // 화면을 지우세요

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("==정보 표시==");
                Console.WriteLine("1등으로 예상한 말 : " + selectNum + "말");
                Console.WriteLine("소지 금액 : " + money);
                Console.WriteLine("최소 속도 : " + minSpeed + " 최대 속도 : " + maxSpeed);

                Console.SetCursorPosition(0, 0);
                SpeedA = random.Next(minSpeed, maxSpeed); // 1 ~ 5 랜덤값으로 출력된다.
                runA = runA + SpeedA;
                SpeedB = random.Next(1, 5);
                runB = runB + SpeedB;
                SpeedC = random.Next(1, 15);
                runC = runC + SpeedC;
                SpeedD = random.Next(1, 5);
                runD = runD + SpeedD;
                SpeedE = random.Next(1, 5);
                runE = runE + SpeedE;

                Console.WriteLine("==================================================");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("1"); // 1번 러너를 그려라

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("4");

                for (int i = 0; i < runE; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("5");

                Console.WriteLine("==================================================");

                // 골라인에 도착했는지 파악하는 코드

                if (runA >= 50)
                {
                    endA = true;
                }

                if (runB >= 50)
                {
                    endB = true;
                }

                if (runC >= 50)
                {
                    endC = true;
                }

                if (runD >= 50)
                {
                    endD = true;
                }

                if (runE >= 50)
                {
                    endE = true;
                }

                // A,B,C,D,E중에 누구라도 결승선에 도착했으면 경기가 종료된다.
                if (endA == true || endB == true || endC == true || endD == true || endE == true)
                {
                    Console.WriteLine("경기가 종료되었습니다.");
                    break;
                }
            }

            // 경기 종료후에 누가 1등인지 알려줘야한다.
            if (endA == true && selectNum == 1) // 1번말이 우승했고, 선택한 말이 1번이다.
            {
                Console.WriteLine("1등은 : 1번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endB == true && selectNum == 2)
            {
                Console.WriteLine("1등은 : 2번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endC == true && selectNum == 3)
            {
                Console.WriteLine("1등은 : 3번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endD == true && selectNum == 4)
            {
                Console.WriteLine("1등은 : 4번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endE == true && selectNum == 5)
            {
                Console.WriteLine("1등은 : 5번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            //////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////

            // 게임 기본 세팅을 해준다.

            // 1. 모든 주자를 0으로 세팅
            // 2. 도착했던 결과를 false로 되돌리기
            // 3. 1등할 주자 다시 선택하기
            // 코드를 복사해서 붙여넣은 수 만큼 게임에 반복해서 진행된다.
            runA = 0;
            runB = 0;
            runC = 0;
            runD = 0;
            runE = 0;

            endA = false;
            endB = false;
            endC = false;
            endD = false;
            endE = false;

            Console.WriteLine("1 ~ 5 러너 중에 누가 일등을 할 지 고르세요.");
            userInput = int.Parse(Console.ReadLine());
            selectNum = 0;
            if (userInput == 1) // 1번이 일등할 거라고 입력했어
            {
                selectNum = 1;
            }
            else if (userInput == 2)
            {
                selectNum = 2;
            }
            else if (userInput == 3)
            {
                selectNum = 3;
            }
            else if (userInput == 4)
            {
                selectNum = 4;
            }
            else if (userInput == 5)
            {
                selectNum = 5;
            }

            Console.WriteLine("1번을 입력하면 최소 속도가 증가하고, 2번을 입력하면 최대 속도가 증가합니다.");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                if (minSpeed + 3 > maxSpeed)
                {
                    Console.WriteLine("업그레이드를 할 수 없습니다.");
                }
                else
                {
                    minSpeed = minSpeed + 3;
                }
            }
            else if (userInput == 2)
            {
                maxSpeed = maxSpeed + 3;
            }


            while (true)               // 계속 반복하세요
            {
                Thread.Sleep(1000);    // 잠시 코드를 쉬세요
                Console.Clear();       // 화면을 지우세요

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("==정보 표시==");
                Console.WriteLine("1등으로 예상한 말 : " + selectNum + "말");
                Console.WriteLine("소지 금액 : " + money);
                Console.WriteLine("최소 속도 : " + minSpeed + " 최대 속도 : " + maxSpeed);

                Console.SetCursorPosition(0, 0);
                SpeedA = random.Next(minSpeed, maxSpeed); // 1 ~ 5 랜덤값으로 출력된다.
                runA = runA + SpeedA;
                SpeedB = random.Next(1, 5);
                runB = runB + SpeedB;
                SpeedC = random.Next(1, 15);
                runC = runC + SpeedC;
                SpeedD = random.Next(1, 5);
                runD = runD + SpeedD;
                SpeedE = random.Next(1, 5);
                runE = runE + SpeedE;

                Console.WriteLine("==================================================");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("1"); // 1번 러너를 그려라

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("4");

                for (int i = 0; i < runE; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("5");

                Console.WriteLine("==================================================");

                // 골라인에 도착했는지 파악하는 코드

                if (runA >= 50)
                {
                    endA = true;
                }

                if (runB >= 50)
                {
                    endB = true;
                }

                if (runC >= 50)
                {
                    endC = true;
                }

                if (runD >= 50)
                {
                    endD = true;
                }

                if (runE >= 50)
                {
                    endE = true;
                }

                // A,B,C,D,E중에 누구라도 결승선에 도착했으면 경기가 종료된다.
                if (endA == true || endB == true || endC == true || endD == true || endE == true)
                {
                    Console.WriteLine("경기가 종료되었습니다.");
                    break;
                }
            }

            // 경기 종료후에 누가 1등인지 알려줘야한다.
            if (endA == true && selectNum == 1) // 1번말이 우승했고, 선택한 말이 1번이다.
            {
                Console.WriteLine("1등은 : 1번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endB == true && selectNum == 2)
            {
                Console.WriteLine("1등은 : 2번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endC == true && selectNum == 3)
            {
                Console.WriteLine("1등은 : 3번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endD == true && selectNum == 4)
            {
                Console.WriteLine("1등은 : 4번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endE == true && selectNum == 5)
            {
                Console.WriteLine("1등은 : 5번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            //////////////////////////////////////////////////////////////////////
            ///

            /////////////////////////////////////////////////////////////////////////

            // 게임 기본 세팅을 해준다.

            // 1. 모든 주자를 0으로 세팅
            // 2. 도착했던 결과를 false로 되돌리기
            // 3. 1등할 주자 다시 선택하기
            // 코드를 복사해서 붙여넣은 수 만큼 게임에 반복해서 진행된다.
            runA = 0;
            runB = 0;
            runC = 0;
            runD = 0;
            runE = 0;

            endA = false;
            endB = false;
            endC = false;
            endD = false;
            endE = false;

            Console.WriteLine("1 ~ 5 러너 중에 누가 일등을 할 지 고르세요.");
            userInput = int.Parse(Console.ReadLine());
            selectNum = 0;
            if (userInput == 1) // 1번이 일등할 거라고 입력했어
            {
                selectNum = 1;
            }
            else if (userInput == 2)
            {
                selectNum = 2;
            }
            else if (userInput == 3)
            {
                selectNum = 3;
            }
            else if (userInput == 4)
            {
                selectNum = 4;
            }
            else if (userInput == 5)
            {
                selectNum = 5;
            }

            Console.WriteLine("1번을 입력하면 최소 속도가 증가하고, 2번을 입력하면 최대 속도가 증가합니다.");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                if (minSpeed + 3 > maxSpeed)
                {
                    Console.WriteLine("업그레이드를 할 수 없습니다.");
                }
                else
                {
                    minSpeed = minSpeed + 3;
                }
            }
            else if (userInput == 2)
            {
                maxSpeed = maxSpeed + 3;
            }


            while (true)               // 계속 반복하세요
            {
                Thread.Sleep(1000);    // 잠시 코드를 쉬세요
                Console.Clear();       // 화면을 지우세요

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("==정보 표시==");
                Console.WriteLine("1등으로 예상한 말 : " + selectNum + "말");
                Console.WriteLine("소지 금액 : " + money);
                Console.WriteLine("최소 속도 : " + minSpeed + " 최대 속도 : " + maxSpeed);

                Console.SetCursorPosition(0, 0);
                SpeedA = random.Next(minSpeed, maxSpeed); // 1 ~ 5 랜덤값으로 출력된다.
                runA = runA + SpeedA;
                SpeedB = random.Next(1, 5);
                runB = runB + SpeedB;
                SpeedC = random.Next(1, 15);
                runC = runC + SpeedC;
                SpeedD = random.Next(1, 5);
                runD = runD + SpeedD;
                SpeedE = random.Next(1, 5);
                runE = runE + SpeedE;

                Console.WriteLine("==================================================");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("1"); // 1번 러너를 그려라

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("4");

                for (int i = 0; i < runE; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("5");

                Console.WriteLine("==================================================");

                // 골라인에 도착했는지 파악하는 코드

                if (runA >= 50)
                {
                    endA = true;
                }

                if (runB >= 50)
                {
                    endB = true;
                }

                if (runC >= 50)
                {
                    endC = true;
                }

                if (runD >= 50)
                {
                    endD = true;
                }

                if (runE >= 50)
                {
                    endE = true;
                }

                // A,B,C,D,E중에 누구라도 결승선에 도착했으면 경기가 종료된다.
                if (endA == true || endB == true || endC == true || endD == true || endE == true)
                {
                    Console.WriteLine("경기가 종료되었습니다.");
                    break;
                }
            }

            // 경기 종료후에 누가 1등인지 알려줘야한다.
            if (endA == true && selectNum == 1) // 1번말이 우승했고, 선택한 말이 1번이다.
            {
                Console.WriteLine("1등은 : 1번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endB == true && selectNum == 2)
            {
                Console.WriteLine("1등은 : 2번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endC == true && selectNum == 3)
            {
                Console.WriteLine("1등은 : 3번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endD == true && selectNum == 4)
            {
                Console.WriteLine("1등은 : 4번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endE == true && selectNum == 5)
            {
                Console.WriteLine("1등은 : 5번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            //////////////////////////////////////////////////////////////////////
            ///

            /////////////////////////////////////////////////////////////////////////

            // 게임 기본 세팅을 해준다.

            // 1. 모든 주자를 0으로 세팅
            // 2. 도착했던 결과를 false로 되돌리기
            // 3. 1등할 주자 다시 선택하기
            // 코드를 복사해서 붙여넣은 수 만큼 게임에 반복해서 진행된다.
            runA = 0;
            runB = 0;
            runC = 0;
            runD = 0;
            runE = 0;

            endA = false;
            endB = false;
            endC = false;
            endD = false;
            endE = false;

            Console.WriteLine("1 ~ 5 러너 중에 누가 일등을 할 지 고르세요.");
            userInput = int.Parse(Console.ReadLine());
            selectNum = 0;
            if (userInput == 1) // 1번이 일등할 거라고 입력했어
            {
                selectNum = 1;
            }
            else if (userInput == 2)
            {
                selectNum = 2;
            }
            else if (userInput == 3)
            {
                selectNum = 3;
            }
            else if (userInput == 4)
            {
                selectNum = 4;
            }
            else if (userInput == 5)
            {
                selectNum = 5;
            }

            Console.WriteLine("1번을 입력하면 최소 속도가 증가하고, 2번을 입력하면 최대 속도가 증가합니다.");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                if (minSpeed + 3 > maxSpeed)
                {
                    Console.WriteLine("업그레이드를 할 수 없습니다.");
                }
                else
                {
                    minSpeed = minSpeed + 3;
                }
            }
            else if (userInput == 2)
            {
                maxSpeed = maxSpeed + 3;
            }


            while (true)               // 계속 반복하세요
            {
                Thread.Sleep(1000);    // 잠시 코드를 쉬세요
                Console.Clear();       // 화면을 지우세요

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("==정보 표시==");
                Console.WriteLine("1등으로 예상한 말 : " + selectNum + "말");
                Console.WriteLine("소지 금액 : " + money);
                Console.WriteLine("최소 속도 : " + minSpeed + " 최대 속도 : " + maxSpeed);

                Console.SetCursorPosition(0, 0);
                SpeedA = random.Next(minSpeed, maxSpeed); // 1 ~ 5 랜덤값으로 출력된다.
                runA = runA + SpeedA;
                SpeedB = random.Next(1, 5);
                runB = runB + SpeedB;
                SpeedC = random.Next(1, 15);
                runC = runC + SpeedC;
                SpeedD = random.Next(1, 5);
                runD = runD + SpeedD;
                SpeedE = random.Next(1, 5);
                runE = runE + SpeedE;

                Console.WriteLine("==================================================");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("1"); // 1번 러너를 그려라

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("4");

                for (int i = 0; i < runE; i++)
                {
                    Console.Write(" ");   // 3칸 오른쪽으로 이동했다." " runA의 숫자만큼 반복된다.
                }
                Console.WriteLine("5");

                Console.WriteLine("==================================================");

                // 골라인에 도착했는지 파악하는 코드

                if (runA >= 50)
                {
                    endA = true;
                }

                if (runB >= 50)
                {
                    endB = true;
                }

                if (runC >= 50)
                {
                    endC = true;
                }

                if (runD >= 50)
                {
                    endD = true;
                }

                if (runE >= 50)
                {
                    endE = true;
                }

                // A,B,C,D,E중에 누구라도 결승선에 도착했으면 경기가 종료된다.
                if (endA == true || endB == true || endC == true || endD == true || endE == true)
                {
                    Console.WriteLine("경기가 종료되었습니다.");
                    break;
                }
            }

            // 경기 종료후에 누가 1등인지 알려줘야한다.
            if (endA == true && selectNum == 1) // 1번말이 우승했고, 선택한 말이 1번이다.
            {
                Console.WriteLine("1등은 : 1번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endB == true && selectNum == 2)
            {
                Console.WriteLine("1등은 : 2번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endC == true && selectNum == 3)
            {
                Console.WriteLine("1등은 : 3번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endD == true && selectNum == 4)
            {
                Console.WriteLine("1등은 : 4번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            if (endE == true && selectNum == 5)
            {
                Console.WriteLine("1등은 : 5번말입니다.");
                Console.WriteLine("상금을 획득합니다.");
                money = money + 1000;
            }

            //////////////////////////////////////////////////////////////////////
            ///


        }
    }
}
