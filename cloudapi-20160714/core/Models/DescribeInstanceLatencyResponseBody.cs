// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceLatencyResponseBody : TeaModel {
        /// <summary>
        /// The list of average latencies in the instance.
        /// </summary>
        [NameInMap("InstanceLatency")]
        [Validation(Required=false)]
        public DescribeInstanceLatencyResponseBodyInstanceLatency InstanceLatency { get; set; }
        public class DescribeInstanceLatencyResponseBodyInstanceLatency : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceLatencyResponseBodyInstanceLatencyMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceLatencyResponseBodyInstanceLatencyMonitorItem : TeaModel {
                /// <summary>
                /// The metric. Valid values:
                /// 
                /// *   gatewayLatency API: the processing latency of API Gateway
                /// *   latency: the processing latency of the backend service.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The value of the average latency.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
