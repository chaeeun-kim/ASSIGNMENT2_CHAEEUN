using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT2_CHAEEUN
{
    class TikTokManager
    {
        private static List<TikTok> TIKTOKS;

        private static string filename = "chaeeun_12\tLee.p\t50\tdance+judy_35\tLISA\t18\tparty+ZO_178\tYOUNG.K\t49\tdrama";
        static TikTokManager()

        {
            TIKTOKS = new List<TikTok>();
            string[] fileline = filename.Split('+');

            foreach (var line in fileline)
              {
                TikTok ob = TikTok.Parse(line);
              TIKTOKS.Add(ob);

            }
 
        }

        public static void Initialize()
        {
            TIKTOKS.Add(new TikTok("Lee", 50, "dance", Audience.special));
            TIKTOKS.Add(new TikTok("KaUU", 15, "game", Audience.world));
            TIKTOKS.Add(new TikTok("ZIKO", 45, "play", Audience.special));
           TIKTOKS.Add(new TikTok("KIKO", 35, "sports", Audience.world));
           TIKTOKS.Add(new TikTok("ELEE", 25, "couple", Audience.special));
        }



        public static void Show()
        {

            Console.WriteLine("SHOW ALL TIKTOKS");

            for (int i = 0; i < TIKTOKS.Count; i++)

            {
                Console.WriteLine(TIKTOKS[i]);
            }

            Console.WriteLine("");

      }

        public static void Show(string tag)

        {

            Console.WriteLine($"SHOW ALL TIKTOKS MATCHING WITH TAG {tag}");

            foreach (TikTok ob in TIKTOKS)
            {
                if (ob.Hashtag == tag)

                { Console.WriteLine(ob); }

            }
            Console.WriteLine("");
        }



        public static void Show(int length)

        {
           Console.WriteLine($"SHOW ALL TIKTOKS MATCHING WITH LENGTH {length}");
            foreach (TikTok ob in TIKTOKS)
           {
                if (ob.Length == length)

                { Console.WriteLine(ob); }
                
            }

            Console.WriteLine("");

        }



        public static void Show(Audience audience)
        {

            Console.WriteLine($"SHOW ALL TIKTOKS MATCHING WITH AUDIENCE {audience}");
            foreach (TikTok ob in TIKTOKS)
            {
                if (ob.Audience == audience)
                { Console.WriteLine(ob); }

            }

            Console.WriteLine("");

        }

    }
}
