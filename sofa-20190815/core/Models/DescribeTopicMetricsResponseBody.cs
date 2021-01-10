// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeTopicMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeTopicMetricsResponseBodyMetrics> Metrics { get; set; }
        public class DescribeTopicMetricsResponseBodyMetrics : TeaModel {
            [NameInMap("SendTraffic")]
            [Validation(Required=false)]
            public long? SendTraffic { get; set; }

            [NameInMap("RecvCnt")]
            [Validation(Required=false)]
            public long? RecvCnt { get; set; }

            [NameInMap("SendCnt")]
            [Validation(Required=false)]
            public long? SendCnt { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("RecvTraffic")]
            [Validation(Required=false)]
            public long? RecvTraffic { get; set; }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

    }

}
