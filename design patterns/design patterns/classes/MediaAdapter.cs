namespace design_patterns
{
    class MediaAdapter
    {
        private IVideo _video;
         
        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower() == "mp4") _video = new Mp4();
            else if (audioType.ToLower() == "vlc") _video = new Vlc();
            else
            {
                _video = null;
            }
            
        }

        public void playAll(string path)
        {
            _video.play(path);
        }
    }
}