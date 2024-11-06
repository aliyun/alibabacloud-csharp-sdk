// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelMetricResponseBody : TeaModel {
        [NameInMap("ChannelMetricInfo")]
        [Validation(Required=false)]
        public DescribeRtcChannelMetricResponseBodyChannelMetricInfo ChannelMetricInfo { get; set; }
        public class DescribeRtcChannelMetricResponseBodyChannelMetricInfo : TeaModel {
            [NameInMap("ChannelMetric")]
            [Validation(Required=false)]
            public DescribeRtcChannelMetricResponseBodyChannelMetricInfoChannelMetric ChannelMetric { get; set; }
            public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoChannelMetric : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>example_channel</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-06-06T18:57:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PubUserCount")]
                [Validation(Required=false)]
                public int? PubUserCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-06-06T17:57:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("SubUserCount")]
                [Validation(Required=false)]
                public int? SubUserCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public int? UserCount { get; set; }

            }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDuration Duration { get; set; }
            public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDuration : TeaModel {
                [NameInMap("PubDuration")]
                [Validation(Required=false)]
                public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationPubDuration PubDuration { get; set; }
                public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationPubDuration : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video720")]
                    [Validation(Required=false)]
                    public int? Video720 { get; set; }

                }

                [NameInMap("SubDuration")]
                [Validation(Required=false)]
                public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration SubDuration { get; set; }
                public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video720")]
                    [Validation(Required=false)]
                    public int? Video720 { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
