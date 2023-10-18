// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayVideoStatisResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The daily playback statistics on the video.
        /// </summary>
        [NameInMap("VideoPlayStatisDetails")]
        [Validation(Required=false)]
        public DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails VideoPlayStatisDetails { get; set; }
        public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails : TeaModel {
            [NameInMap("VideoPlayStatisDetail")]
            [Validation(Required=false)]
            public List<DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail> VideoPlayStatisDetail { get; set; }
            public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail : TeaModel {
                /// <summary>
                /// The date. The date is displayed in the *yyyy-MM-dd* format.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// The playback duration. Unit: millisecond.
                /// </summary>
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                /// <summary>
                /// The distribution of the playback duration.
                /// </summary>
                [NameInMap("PlayRange")]
                [Validation(Required=false)]
                public string PlayRange { get; set; }

                /// <summary>
                /// The video title.
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

            }

        }

    }

}
