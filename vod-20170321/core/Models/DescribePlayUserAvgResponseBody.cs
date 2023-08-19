// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserAvgResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics on average playback each day.
        /// </summary>
        [NameInMap("UserPlayStatisAvgs")]
        [Validation(Required=false)]
        public DescribePlayUserAvgResponseBodyUserPlayStatisAvgs UserPlayStatisAvgs { get; set; }
        public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgs : TeaModel {
            [NameInMap("UserPlayStatisAvg")]
            [Validation(Required=false)]
            public List<DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg> UserPlayStatisAvg { get; set; }
            public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg : TeaModel {
                /// <summary>
                /// The average number of video views.
                /// </summary>
                [NameInMap("AvgPlayCount")]
                [Validation(Required=false)]
                public string AvgPlayCount { get; set; }

                /// <summary>
                /// The average playback duration. Unit: milliseconds.
                /// </summary>
                [NameInMap("AvgPlayDuration")]
                [Validation(Required=false)]
                public string AvgPlayDuration { get; set; }

                /// <summary>
                /// The date when the statistics were generated. The date follows the *yyyy-MM-dd* format.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

            }

        }

    }

}
