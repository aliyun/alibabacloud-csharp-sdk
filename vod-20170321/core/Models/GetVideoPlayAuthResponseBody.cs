// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthResponseBody : TeaModel {
        /// <summary>
        /// The credential for media playback.
        /// </summary>
        [NameInMap("PlayAuth")]
        [Validation(Required=false)]
        public string PlayAuth { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The metadata of the audio or video file.
        /// </summary>
        [NameInMap("VideoMeta")]
        [Validation(Required=false)]
        public GetVideoPlayAuthResponseBodyVideoMeta VideoMeta { get; set; }
        public class GetVideoPlayAuthResponseBodyVideoMeta : TeaModel {
            /// <summary>
            /// The thumbnail URL of the media file.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The duration of the media file. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// The status of the media file. For more information about the value range and description, see [Status: the status of a video](~~52839#title-vqg-8cz-7p8~~).
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The title of the media file.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The ID of the media file.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
