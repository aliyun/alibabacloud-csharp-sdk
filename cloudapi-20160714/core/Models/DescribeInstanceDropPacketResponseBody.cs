// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceDropPacketResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dropped packets in the instance.</para>
        /// </summary>
        [NameInMap("InstanceDropPacket")]
        [Validation(Required=false)]
        public DescribeInstanceDropPacketResponseBodyInstanceDropPacket InstanceDropPacket { get; set; }
        public class DescribeInstanceDropPacketResponseBodyInstanceDropPacket : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceDropPacketResponseBodyInstanceDropPacketMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceDropPacketResponseBodyInstanceDropPacketMonitorItem : TeaModel {
                /// <summary>
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>InstanceDropPacketRX: the number of inbound packets dropped in the instance per second.</description></item>
                /// <item><description>InstanceDropPacketTX: the number of outbound packets dropped in the instance per second.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceDropPacketRX</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-06T04:00:36Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of dropped packets in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
