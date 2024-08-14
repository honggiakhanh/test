using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Domain.src.MediaAggregate;

namespace MediaPlayer.Service.src.MediaManagement
{
    public class MediaManagementImplementation : IMediaManagement
    {
        private IMediaRepository _mediaRepository;

        public MediaManagementImplementation(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public MediaFile AddMediaFile(MediaFile mediaFile)
        {
            _mediaRepository.AddMediaFile(mediaFile);
            return mediaFile;
        }

        public bool DeleteMediaFile(string id)
        {
            var mediaFileToDelete = _mediaRepository.GetMediaFileById(id);
            if (mediaFileToDelete == null)
            {
                throw new ArgumentException("Media File not found");
            }

            _mediaRepository.DeleteMediaFile(id);
            return true;
        }

        public List<MediaFile> GetAllMediaFiles()
        {
            return _mediaRepository.GetAllMediaFiles();
        }

        public MediaFile GetMediaFileById(string id)
        {
            return _mediaRepository.GetMediaFileById(id);
        }

        public MediaFile UpdateMediaFile(string id, MediaFile newMediaFile)
        {
            var mediaFileToUpdate = _mediaRepository.GetMediaFileById(id);
            if (mediaFileToUpdate == null)
            {
                throw new ArgumentException("Media File not found");
            }
            mediaFileToUpdate.Name = newMediaFile.Name;
            mediaFileToUpdate.Volume = newMediaFile.Volume;

            _mediaRepository.UpdateMediaFile(id, newMediaFile);
            return mediaFileToUpdate;
        }
    }
}
