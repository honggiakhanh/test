namespace MediaPlayer.Domain.src.MediaAggregate
{
    public abstract class MediaFile
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Volume { get; set; }

        public void ChangeVolume(int newVolume)
        {
            Volume = newVolume;
        }

        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }
}
