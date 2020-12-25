using System;

namespace design_patterns
{
    class Vlc : IVideo
    {
        public void play(string path)
        {
            Console.WriteLine("{0} runing inside vlc app",path);
        }
    }
}