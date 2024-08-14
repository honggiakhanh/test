namespace MediaPlayer.Domain.src.MediaAggregate
{
    public class VideoFile : MediaFile
    {
        public int Brightness { get; set; }

        public override void Play()
        {
            Console.WriteLine($"Playing Video: ${Name} : ${Id}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Pausing Video ${Name} : ${Id}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping Video ${Name} : ${Id}");
        }

        public void ChangeBrightness(int newBrightness)
        {
            Brightness = newBrightness;
        }
    }
}
