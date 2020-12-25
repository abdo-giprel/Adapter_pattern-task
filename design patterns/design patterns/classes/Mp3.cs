using System;

namespace design_patterns
{
    class Mp3 : IAudio
    {
        private MediaAdapter _mediaAdapter;
        public void playAll(string audioType, string path)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine("{0} is running inside mp3 app",path);
            }
            else if (audioType.ToLower() == "mp4" || audioType.ToLower()=="vlc")
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.playAll(path);
            }
            else
            {
                _mediaAdapter = null;
                Console.WriteLine($"{audioType} not supported");
            }
        }
    }
}