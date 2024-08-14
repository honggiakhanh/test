using MediaPlayer.Domain.src.MediaAggregate;

namespace MediaPlayer.Service.src.MediaManagement
{
    public interface IMediaRepository
    {
        public List<MediaFile> GetAllMediaFiles();
        public MediaFile GetMediaFileById(string id);
        public MediaFile AddMediaFile(MediaFile mediaFile);
        public MediaFile UpdateMediaFile(string id, MediaFile updatedMediaFile);
        public bool DeleteMediaFile(string id);
    }
}
