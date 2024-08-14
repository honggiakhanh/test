namespace MediaPlayer.Domain.src.MediaAggregate
{
    public class AudioFile : MediaFile
    {
        public string SoundEffect { get; set; }

        public override void Play()
        {
            Console.WriteLine($"Playing Audio: ${Name} : ${Id}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Pausing Audio: ${Name} : ${Id}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stoping Audio: ${Name} : ${Id}");
        }

        public void ChangeSoundEffect(string newSoundEffect)
        {
            SoundEffect = newSoundEffect;
        }
    }
}
