using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StoryGame
{
    // 주의 사항 중괄호 안에 작성해야한다.
    internal class Actor
    {
        public string[] Title =
        {
            @"
   /\_/\    ────┐  
  (='o'=)   CATS ADVENTURE  
  ("")__("")  ────┘  
"
        };

        public string[] End =
        {
            @"
■■■■■■■■■ ■■    ■■ ■■■■■■■  
■■      ■■ ■■    ■■ ■■        
■■  ■■  ■■ ■■■■■■■ ■■■■■■    
■■  ■■  ■■ ■■  ■■ ■■        
■■■■■■■■■ ■■  ■■ ■■■■■■■ 
"
        };

        public string[] camel =
           {
                @" 
Art by Morfina
 _______\\__
(_. _ ._  _/ 
 '-' \__. /
      /  / 
     /  /    .--.  .--.
    (  (    / '' \/ '' \   ""
     \  \_.'            \   )
     ||               _  './
      |\   \     ___.'\  /
        '-./   .'    \ |/ 
           \| /       )|\
            |/       // \\ 
            |\    __//   \\__
           //\\  /__/  mrf\__|
       .--_/  \_--.
      /__/      \__\
"
            };

        public string[] sleepCat =
        {
            @"
      |\      _,,,---,,_
ZZZzz /,`.-'`'    -.  ;-;;,_
     |,4-  ) )-,_. ,\ (  `'-'
    '---''(_/--'  `-'\_)  Felix Lee 
"
        };

        public string[] man =
        {
            @"
    ,
            ,:' `..;
            `. ,;;'%
            +;;'%%%%%
             /- %,)%%
             `   \ %%
              =  )/ \
              `-'/ / \
                /\/.-.\
               |  (    |
               |  |   ||
               |  |   ||
           _.-----'   ||
          / \________,'|
         (((/  |       |
         //    |       |
        //     |\      |
       //      | \     |
      //       |  \    |
     //        |   \   |
    //         |    \  |
   //          |    |\ |
  //           |    | \|
 //            \    \
c'             |\    \
               | \    \
               |  \    \
               |.' \    \
              _\    \.-' \ MJP
             (___.-(__.'\/
"
        };

        public string[] bird =
        {
            @"
             __
             /'{>
         ____) (____
       //'--;   ;--'\\
      ///////\_/\\\\\\\
jgs          m m
"
        };

        public string[] dolphin =
        {
            @"
                ;'-. 
    `;-._        )  '---.._
      >  `-.__.-'          `'.__
     /_.-'-._         _,   ^ ---)
jgs  `       `'------/_.'----```
                     `
"
        };

        public string[] RoomA =
        {
            @"
+----------------------------------------+
|                                        |
| +------+  +-------+  +------+ +------+ |
| |      |  |       |  |      | |      | |
| +------+  +-------+  +------+ +------+ |
|                                        |
+----------------------------------------+
"
        };

        public string[] EndA =
        {
            @"
  \
     - \
     |   \
     |---- \
     |  KKB  \
     |---------\
      \          \
        \--------O-\
          \----^-|-^-\
            \___/_\____\
            __/_____\____\___/
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
"
        };

        public void ShowActor(string[] actor)
        {
            for(int i=0; i<actor.Length; i++)
            {
                Console.WriteLine(actor[i]);
            }
        }

        public void Tell(string name, string content)
        {
            Console.WriteLine();
            Console.WriteLine($"{name} : {content}");
        }

        public void Selection(string name, string True, string False)
        {
            Tell("[나레이션]", "1_ 긍정한다, 2_ 부정한다.");
            var KeyInfo = Console.ReadKey(); // 키보드의 입력값을 받아오겠다.

            if(KeyInfo.Key == ConsoleKey.D1)
            {
                Tell(name, True);
            }
            else if(KeyInfo.Key == ConsoleKey.D2)
            {
                Tell(name, False); ;
            }
            else
            {
                Console.WriteLine("잘못된 키를 입력하였습니다. 다시 입력해주세요.");
                Selection(name, True, False);
                return;
            }
        }

        public bool Selection(string name, string True, string False, string[] TrueActor, string[] FalseActor)
        {
            Tell("[나레이션]", $"1_{True}, 2_{False}");
            var KeyInfo = Console.ReadKey(); // 키보드의 입력값을 받아오겠다.

            if (KeyInfo.Key == ConsoleKey.D1)
            {
                ShowActor(TrueActor);
                Tell(name, True);
                return true;
            }
            else if (KeyInfo.Key == ConsoleKey.D2)
            {
                ShowActor(FalseActor);
                Tell(name, False);
                return false;
            }
            else
            {
                Console.WriteLine("잘못된 키를 입력하였습니다. 다시 입력해주세요.");
                return Selection(name, True, False, TrueActor, FalseActor);
            }
        }

    }
}
