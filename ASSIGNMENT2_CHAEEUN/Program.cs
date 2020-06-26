using System;

namespace ASSIGNMENT2_CHAEEUN
{
    class Program
    {
        static void Main(string[] args)
        {
            TikTokManager.Initialize();
           TikTokManager.Show();
            TikTokManager.Show("dance");
            TikTokManager.Show(50);
            TikTokManager.Show(Audience.group);
        }
    }
}
