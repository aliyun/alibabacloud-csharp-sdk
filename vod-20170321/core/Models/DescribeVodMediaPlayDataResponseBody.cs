// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMediaPlayDataResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("QoeInfoList")]
        [Validation(Required=false)]
        public List<DescribeVodMediaPlayDataResponseBodyQoeInfoList> QoeInfoList { get; set; }
        public class DescribeVodMediaPlayDataResponseBodyQoeInfoList : TeaModel {
            /// <summary>
            /// The number of visits to the audio or video per day.
            /// </summary>
            [NameInMap("DAU")]
            [Validation(Required=false)]
            public float? DAU { get; set; }

            /// <summary>
            /// The ID of the media file (VideoId).
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The total playback duration of the audio or video. Unit: seconds.
            /// </summary>
            [NameInMap("PlayDuration")]
            [Validation(Required=false)]
            public float? PlayDuration { get; set; }

            /// <summary>
            /// The average playback duration of the audio or video per viewer. Unit: seconds.
            /// </summary>
            [NameInMap("PlayDurationPerUv")]
            [Validation(Required=false)]
            public float? PlayDurationPerUv { get; set; }

            /// <summary>
            /// The average number of times that the audio or video was played per viewer.
            /// </summary>
            [NameInMap("PlayPerVv")]
            [Validation(Required=false)]
            public float? PlayPerVv { get; set; }

            /// <summary>
            /// The total number of times the audio or video has been played.
            /// </summary>
            [NameInMap("PlaySuccessVv")]
            [Validation(Required=false)]
            public float? PlaySuccessVv { get; set; }

            /// <summary>
            /// The duration of the audio or video file. Unit: seconds.
            /// </summary>
            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public float? VideoDuration { get; set; }

            /// <summary>
            /// The name of the audio or video file.
            /// </summary>
            [NameInMap("VideoTitle")]
            [Validation(Required=false)]
            public string VideoTitle { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
