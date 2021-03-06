﻿using System.Collections.Generic;
using YoutubeExplode.Internal;
using YoutubeExplode.Models.MediaStreams;

namespace YoutubeExplode.Models
{
    /// <summary>
    /// Model extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Gets sequence of all available <see cref="MediaStreamInfo" />s in a <see cref="Video" />
        /// </summary>
        public static IEnumerable<MediaStreamInfo> GetAllMediaStreamInfos(this Video video)
        {
            video.GuardNotNull(nameof(video));

            foreach (var streamInfo in video.MuxedStreamInfos)
                yield return streamInfo;
            foreach (var streamInfo in video.AudioStreamInfos)
                yield return streamInfo;
            foreach (var streamInfo in video.VideoStreamInfos)
                yield return streamInfo;
        }
    }
}