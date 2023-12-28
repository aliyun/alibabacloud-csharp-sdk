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
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("PubUserCount")]
                [Validation(Required=false)]
                public int? PubUserCount { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("SubUserCount")]
                [Validation(Required=false)]
                public int? SubUserCount { get; set; }

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
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    [NameInMap("Video720")]
                    [Validation(Required=false)]
                    public int? Video720 { get; set; }

                }

                [NameInMap("SubDuration")]
                [Validation(Required=false)]
                public DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration SubDuration { get; set; }
                public class DescribeRtcChannelMetricResponseBodyChannelMetricInfoDurationSubDuration : TeaModel {
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public int? Audio { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public int? Content { get; set; }

                    [NameInMap("Video1080")]
                    [Validation(Required=false)]
                    public int? Video1080 { get; set; }

                    [NameInMap("Video360")]
                    [Validation(Required=false)]
                    public int? Video360 { get; set; }

                    [NameInMap("Video720")]
                    [Validation(Required=false)]
                    public int? Video720 { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
