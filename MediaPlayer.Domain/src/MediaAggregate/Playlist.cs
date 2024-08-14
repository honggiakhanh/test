using MediaPlayer.Domain.src.MediaAggregate;

public class Playlist
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public List<MediaFile> MediaFiles { get; set; }
}
