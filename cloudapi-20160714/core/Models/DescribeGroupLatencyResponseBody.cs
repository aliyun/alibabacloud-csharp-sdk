// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupLatencyResponseBody : TeaModel {
        /// <summary>
        /// The latency information.
        /// </summary>
        [NameInMap("LatencyPacket")]
        [Validation(Required=false)]
        public DescribeGroupLatencyResponseBodyLatencyPacket LatencyPacket { get; set; }
        public class DescribeGroupLatencyResponseBodyLatencyPacket : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupLatencyResponseBodyLatencyPacketMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupLatencyResponseBodyLatencyPacketMonitorItem : TeaModel {
                /// <summary>
                /// The metric. Valid values:
                /// 
                /// *   latency: the backend processing latency
                /// *   gatewayLatency: the API Gateway processing latency
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The point in time when the latency data was collected. The format is YYYY-MM-DDThh:mm:ssZ.
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The latency. Unit: ms.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
