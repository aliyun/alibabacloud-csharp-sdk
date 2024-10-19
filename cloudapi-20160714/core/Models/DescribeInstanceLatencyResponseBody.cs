// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceLatencyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of average latencies in the instance.</para>
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
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>gatewayLatency API: the processing latency of API Gateway</description></item>
                /// <item><description>latency: the processing latency of the backend service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>latency</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-06T02:05:13Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The value of the average latency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
