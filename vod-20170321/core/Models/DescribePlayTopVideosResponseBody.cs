// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayTopVideosResponseBody : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The daily playback statistics on each top video.
        /// </summary>
        [NameInMap("TopPlayVideos")]
        [Validation(Required=false)]
        public DescribePlayTopVideosResponseBodyTopPlayVideos TopPlayVideos { get; set; }
        public class DescribePlayTopVideosResponseBodyTopPlayVideos : TeaModel {
            [NameInMap("TopPlayVideoStatis")]
            [Validation(Required=false)]
            public List<DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis> TopPlayVideoStatis { get; set; }
            public class DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis : TeaModel {
                /// <summary>
                /// The total playback duration. Unit: milliseconds.
                /// </summary>
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                /// <summary>
                /// The title of the video.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The number of unique visitors.
                /// </summary>
                [NameInMap("UV")]
                [Validation(Required=false)]
                public string UV { get; set; }

                /// <summary>
                /// The number of video views.
                /// </summary>
                [NameInMap("VV")]
                [Validation(Required=false)]
                public string VV { get; set; }

                /// <summary>
                /// The ID of the video.
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries that were collected in playback statistics on top videos.
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
