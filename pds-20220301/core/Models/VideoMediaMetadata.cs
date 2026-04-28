// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoMediaMetadata : TeaModel {
        /// <summary>
        /// <para>The height of the video image. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// <para>The information about the audio stream.</para>
        /// </summary>
        [NameInMap("video_media_audio_stream")]
        [Validation(Required=false)]
        public List<VideoMediaAudioStream> VideoMediaAudioStream { get; set; }

        /// <summary>
        /// <para>The information about the video stream.</para>
        /// </summary>
        [NameInMap("video_media_video_stream")]
        [Validation(Required=false)]
        public List<VideoMediaVideoStream> VideoMediaVideoStream { get; set; }

        /// <summary>
        /// <para>The width of the video image. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
