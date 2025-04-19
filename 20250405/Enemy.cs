using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250405
{
    class Enemy
    {
        public string[] IMAGE2 =
        {
               "  ◐◐    ",
              "      ■■■■■  ",
            "    ■■      ■■  ",
            "  ■■    ■■■■    ■■  ",
            "  ■■  ■    ■  ■■  ",
            "    ■■ ■■■■ ■■  ",
            "      ■    ■  ",
            "    ■■■■■■■■  ",
            "    ■  ■■  ■  ",
            "    ■      ■  "
        };
        public string[] IMAGE3 =
        {
               "  ◑◑    ",
              "      ■■■■■  ",
            "    ■■      ■■  ",
            "  ■■    ■■■■    ■■  ",
            "  ■■  ■    ■  ■■  ",
            "    ■■ ■■■■ ■■  ",
            "      ■    ■  ",
            "    ■■■■■■■■  ",
            "    ■  ■■  ■  ",
            "    ■      ■  "
        };

        public void RemoveImage(string[] art)
        {
            for(int i=0; i<art.Length; i++)
            {
                string[] remove = art;
                remove[i] = "                         ";
                Console.WriteLine(remove[i]);
            }
        }
    }
}
