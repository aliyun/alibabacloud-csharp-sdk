// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserTotalResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics on total playback each day.
        /// </summary>
        [NameInMap("UserPlayStatisTotals")]
        [Validation(Required=false)]
        public DescribePlayUserTotalResponseBodyUserPlayStatisTotals UserPlayStatisTotals { get; set; }
        public class DescribePlayUserTotalResponseBodyUserPlayStatisTotals : TeaModel {
            [NameInMap("UserPlayStatisTotal")]
            [Validation(Required=false)]
            public List<DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotal> UserPlayStatisTotal { get; set; }
            public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotal : TeaModel {
                /// <summary>
                /// The date when the statistics were generated. The date follows the *yyyy-MM-dd* format.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// The total playback duration. Unit: milliseconds.
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
                /// The total number of unique visitors.
                /// </summary>
                [NameInMap("UV")]
                [Validation(Required=false)]
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV UV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV : TeaModel {
                    /// <summary>
                    /// The total number of unique visitors who use ApsaraVideo Player SDK for Android.
                    /// </summary>
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    /// <summary>
                    /// The total number of unique visitors who use ApsaraVideo Player SDK for Flash.
                    /// </summary>
                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    /// <summary>
                    /// The total number of unique visitors who use ApsaraVideo Player SDK for HTML5.
                    /// </summary>
                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    /// <summary>
                    /// The total number of unique visitors who use ApsaraVideo Player SDK for iOS.
                    /// </summary>
                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }

                /// <summary>
                /// The total number of video views.
                /// </summary>
                [NameInMap("VV")]
                [Validation(Required=false)]
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV VV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV : TeaModel {
                    /// <summary>
                    /// The total number of video views that is collected for videos that are played by using ApsaraVideo Player SDK for Android.
                    /// </summary>
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    /// <summary>
                    /// The total number of video views that is collected for videos that are played by using ApsaraVideo Player SDK for Flash.
                    /// </summary>
                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    /// <summary>
                    /// The total number of video views that is collected for videos that are played by using ApsaraVideo Player SDK for HTML5.
                    /// </summary>
                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    /// <summary>
                    /// The total number of video views that is collected for videos that are played by using ApsaraVideo Player SDK for iOS.
                    /// </summary>
                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }

            }

        }

    }

}
