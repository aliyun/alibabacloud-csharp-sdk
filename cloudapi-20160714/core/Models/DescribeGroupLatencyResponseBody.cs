// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupLatencyResponseBody : TeaModel {
        /// <summary>
        /// <para>The latency information.</para>
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
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>latency: the backend processing latency</description></item>
                /// <item><description>gatewayLatency: the API Gateway processing latency</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>latency</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The point in time when the latency data was collected. The format is YYYY-MM-DDThh:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T16:10:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The latency. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DC3AB0-421C-5371-8170-86AEABF77AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
