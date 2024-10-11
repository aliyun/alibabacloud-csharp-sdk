// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FAFB884-D5A7-47D1-****-8928AA9C8720</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The daily playback statistics.</para>
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
                /// <para>The date. The date is displayed in the yyyy-MM-dd format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20170120</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The total playback duration. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9340070</para>
                /// </summary>
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                /// <summary>
                /// <para>The distribution of the playback duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&lt;=1m:74.3%;&gt;1&lt;=5m:22.8%;&gt;5&lt;=10m:1.0%;&gt;10&lt;=15m:1.0%;&gt;15&lt;=30m:1.0%&quot;</para>
                /// </summary>
                [NameInMap("PlayRange")]
                [Validation(Required=false)]
                public string PlayRange { get; set; }

                /// <summary>
                /// <para>The total number of unique visitors.</para>
                /// </summary>
                [NameInMap("UV")]
                [Validation(Required=false)]
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV UV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalUV : TeaModel {
                    /// <summary>
                    /// <para>The total number of unique visitors who use ApsaraVideo Player SDK for Android.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    /// <summary>
                    /// <para>The total number of unique visitors who use the Flash player.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    /// <summary>
                    /// <para>The total number of unique visitors who use the HTML5 player.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    /// <summary>
                    /// <para>The total number of unique visitors who use ApsaraVideo Player SDK for iOS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }

                /// <summary>
                /// <para>The total number of video views.</para>
                /// </summary>
                [NameInMap("VV")]
                [Validation(Required=false)]
                public DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV VV { get; set; }
                public class DescribePlayUserTotalResponseBodyUserPlayStatisTotalsUserPlayStatisTotalVV : TeaModel {
                    /// <summary>
                    /// <para>The total number of video views played by using ApsaraVideo Player SDK for Android.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>161</para>
                    /// </summary>
                    [NameInMap("Android")]
                    [Validation(Required=false)]
                    public string Android { get; set; }

                    /// <summary>
                    /// <para>The total number of video views played by using the Flash player.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Flash")]
                    [Validation(Required=false)]
                    public string Flash { get; set; }

                    /// <summary>
                    /// <para>The total number of video views played by using the HTML5 player.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("HTML5")]
                    [Validation(Required=false)]
                    public string HTML5 { get; set; }

                    /// <summary>
                    /// <para>The total number of video views played by using ApsaraVideo Player SDK for iOS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("iOS")]
                    [Validation(Required=false)]
                    public string IOS { get; set; }

                }

            }

        }

    }

}
