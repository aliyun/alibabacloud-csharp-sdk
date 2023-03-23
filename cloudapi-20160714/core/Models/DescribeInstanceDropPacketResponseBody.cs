// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceDropPacketResponseBody : TeaModel {
        /// <summary>
        /// The list of dropped packets in the instance.
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
                /// The metric. Valid values:
                /// 
                /// *   InstanceDropPacketRX: the number of inbound packets dropped in the instance per second.
                /// *   InstanceDropPacketTX: the number of outbound packets dropped in the instance per second.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The number of dropped packets in the instance.
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
