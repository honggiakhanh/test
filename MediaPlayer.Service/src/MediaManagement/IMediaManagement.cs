using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Domain.src.MediaAggregate;

namespace MediaPlayer.Service.src.MediaManagement
{
    public interface IMediaManagement
    {
        public List<MediaFile> GetAllMediaFiles();
        public MediaFile GetMediaFileById(string id);
        public MediaFile AddMediaFile(MediaFile mediaFile);
        public bool DeleteMediaFile(string id);
        public MediaFile UpdateMediaFile(string id, MediaFile mediaFile);
    }
}
