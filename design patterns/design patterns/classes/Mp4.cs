using System;

namespace design_patterns
{
    class Mp4 : IVideo
    {
        public void play(string path)
        {
            Console.WriteLine("{0} is playing inside MP4 app",path);
        }
    }
}