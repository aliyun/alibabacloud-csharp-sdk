// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoMediaMetadata : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("video_media_audio_stream")]
        [Validation(Required=false)]
        public List<VideoMediaAudioStream> VideoMediaAudioStream { get; set; }

        [NameInMap("video_media_video_stream")]
        [Validation(Required=false)]
        public List<VideoMediaVideoStream> VideoMediaVideoStream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
