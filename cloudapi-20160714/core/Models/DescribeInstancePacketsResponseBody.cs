// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancePacketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of inbound and outbound data packets in the instance.</para>
        /// </summary>
        [NameInMap("InstancePackets")]
        [Validation(Required=false)]
        public DescribeInstancePacketsResponseBodyInstancePackets InstancePackets { get; set; }
        public class DescribeInstancePacketsResponseBodyInstancePackets : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstancePacketsResponseBodyInstancePacketsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstancePacketsResponseBodyInstancePacketsMonitorItem : TeaModel {
                /// <summary>
                /// <para>The metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>InstancePacketRX: inbound data packets</description></item>
                /// <item><description>InstancePacketTX: outbound data packets</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstancePacketRX</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-24T10:14:53Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of inbound and outbound data packets in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
