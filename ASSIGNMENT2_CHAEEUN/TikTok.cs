using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT2_CHAEEUN
{
    enum Audience { world, group, special };
    class TikTok
    {
        private static int _ID;
        public string Originator { get; }
       public int Length { get; }
        public string Hashtag { get; }
        public Audience Audience { get; }
        public string Id { get; }
        public TikTok(string originator, int length, string hashtag, Audience audience)
        {
            this.Originator = originator;
            this.Length = length;
            this.Hashtag = hashtag;
            this.Audience = audience;
            _ID = Convert.ToInt32(Id);
            _ID++;
        }



        private TikTok(string id, string originator, string length, string hashtag, Audience audience)
       {
            this.Id = id;
            this.Originator = originator;
            Length = Convert.ToInt32(length);
            this.Hashtag = hashtag;
            this.Audience = audience;
        }

        public override string ToString() => $"ID:{Id}{_ID}  ORIGINATOR:{Originator}  LENGTH:{Length}  HASHTAG:{Hashtag}  AUDIENCE:{Audience}";



        public static TikTok Parse(string line)
        {            string[] array = new string[4];

           int count = 0;
            string[] words = line.Split('\t');

            foreach (var word in words)
            { array[count] = word;
                count++;
            }

            TikTok object1 = new TikTok(array[0], array[1], array[2], array[3], Audience.group);

            return object1;

        }
    }
}
