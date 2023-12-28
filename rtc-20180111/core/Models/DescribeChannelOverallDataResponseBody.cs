// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelOverallDataResponseBody : TeaModel {
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeChannelOverallDataResponseBodyCallInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelOverallDataResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelOverallDataResponseBodyMetricDatas : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelOverallDataResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelOverallDataResponseBodyMetricDatasNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelOverallDataResponseBodyOverallData : TeaModel {
            [NameInMap("ConnAvgTime")]
            [Validation(Required=false)]
            public float? ConnAvgTime { get; set; }

            [NameInMap("FiveSecJoinRate")]
            [Validation(Required=false)]
            public float? FiveSecJoinRate { get; set; }

            [NameInMap("TotalAudioStuckRate")]
            [Validation(Required=false)]
            public float? TotalAudioStuckRate { get; set; }

            [NameInMap("TotalVideoStuckRate")]
            [Validation(Required=false)]
            public float? TotalVideoStuckRate { get; set; }

            [NameInMap("TotalVideoVagueRate")]
            [Validation(Required=false)]
            public float? TotalVideoVagueRate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
