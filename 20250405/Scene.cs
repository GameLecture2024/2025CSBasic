using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250405
{
    class Scene
    {

        // x,y의 좌표에 그림을 그려주세요
        public void DrawImage(string[] art, int x, int y)
        {
            for(int i=0; i< art.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(art[i]);
            }
        }
    }
}
