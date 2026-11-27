// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("ChannelMetricInfo")]
        [Validation(Required=false)]
        public DescribeRtcChannelMetricResponseBodyChannelMetricInfo ChannelMetricInfo { get; set; }
        public class DescribeRtcChannelMetricResponseBodyChannelMetricInfo : TeaModel {
            /// <summary>
            /// <para>The user information of the channel.</para>
            /// </summary>
            [NameInMap("ChannelMetric")]
            [Validation(Required=false)]
            public DescribeRtcChannelMetricResponseBodyChannelMetricInfoChannelMetric ChannelMetric { get; set; }
            public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoChannelMetric : TeaModel {
                /// <summary>
                /// <para>The channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_channel</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The time when the user left the channel, in UTC. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-06T18:57:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The number of users that entered the channel and successfully published streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PubUserCount")]
                [Validation(Required=false)]
                public int? PubUserCount { get; set; }

                /// <summary>
                /// <para>The time when the user joined the channel, in UTC. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-06T17:57:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The number of users that entered the channel and successfully subscribed to streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("SubUserCount")]
                [Validation(Required=false)]
                public int? SubUserCount { get; set; }

                /// <summary>
                /// <para>The number of users that entered the channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public int? UserCount { get; set; }

            }

            /// <summary>
            /// <para>The duration information.</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDuration Duration { get; set; }
            public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDuration : TeaModel {
                /// <summary>
                /// <para>The duration information about publishing streams.</para>
                /// </summary>
                [NameInMap("PubDuration")]
                [Validation(Required=false)]
                public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationPubDuration PubDuration { get; set; }
                public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationPubDuration : TeaModel {
                    /// <summary>
                    /// <para>The duration of audio. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    /// <summary>
                    /// <para>The duration of screen sharing. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    /// <summary>
                    /// <para>The duration of full high-definition (FHD) videos. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    /// <summary>
                    /// <para>The duration of standard-definition (SD) videos. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    /// <summary>
                    /// <para>The duration of high-definition (HD) videos. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video720")]
                    [Validation(Required=false)]
                    public int? Video720 { get; set; }

                }

                /// <summary>
                /// <para>The duration information about subscribing to streams.</para>
                /// </summary>
                [NameInMap("SubDuration")]
                [Validation(Required=false)]
                public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration SubDuration { get; set; }
                public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration : TeaModel {
                    /// <summary>
                    /// <para>The duration of audio. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    /// <summary>
                    /// <para>The duration of screen sharing. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    /// <summary>
                    /// <para>The duration of full high-definition (FHD) videos. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    /// <summary>
                    /// <para>The duration of standard-definition (SD) videos. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    /// <summary>
                    /// <para>The duration of high-definition (HD) videos. Unit: minutes.</para>
                    /// 
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
