// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancePacketsResponseBody : TeaModel {
        /// <summary>
        /// The list of inbound and outbound data packets in the instance.
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
                /// The metric. Valid values:
                /// 
                /// *   InstancePacketRX: inbound data packets
                /// *   InstancePacketTX: outbound data packets
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
                /// The number of inbound and outbound data packets in the instance.
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
