using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Domain.src.MediaAggregate;
using MediaPlayer.Service.src.MediaManagement;

namespace MediaPlayer.Infrastructure.src.Repository
{
    public class MediaRepository : IMediaRepository
    {
        private List<MediaFile> _mediaFiles;

        public MediaRepository(Database database)
        {
            _mediaFiles = database.MediaFiles;
        }

        public MediaFile AddMediaFile(MediaFile mediaFile)
        {
            _mediaFiles.Add(mediaFile);
            return mediaFile;
        }

        public bool DeleteMediaFile(string id)
        {
            var mediaFileToDelete = _mediaFiles.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (mediaFileToDelete == null)
            {
                throw new ArgumentException("Media File not found");
            }
            _mediaFiles.Remove(mediaFileToDelete);
            return true;
        }

        public List<MediaFile> GetAllMediaFiles()
        {
            return _mediaFiles;
        }

        public MediaFile GetMediaFileById(string id)
        {
            var mediaFileToGet = _mediaFiles.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (mediaFileToGet == null)
            {
                throw new ArgumentException("Media File not found");
            }
            return mediaFileToGet;
        }

        public MediaFile UpdateMediaFile(string id, MediaFile updatedMediaFile)
        {
            var mediaFileToUpdate = _mediaFiles.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (mediaFileToUpdate == null)
            {
                throw new ArgumentException("Media File not found");
            }
            mediaFileToUpdate.Name = updatedMediaFile.Name;
            mediaFileToUpdate.Volume = updatedMediaFile.Volume;
            return mediaFileToUpdate;
        }
    }
}
