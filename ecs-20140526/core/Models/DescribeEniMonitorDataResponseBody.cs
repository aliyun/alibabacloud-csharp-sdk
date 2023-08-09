// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEniMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The details about the monitoring data of the secondary ENI.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeEniMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEniMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("EniMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData> EniMonitorData { get; set; }
            public class DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData : TeaModel {
                /// <summary>
                /// The number of dropped packets received by the secondary ENI over the internal network.
                /// </summary>
                [NameInMap("DropPacketRx")]
                [Validation(Required=false)]
                public string DropPacketRx { get; set; }

                /// <summary>
                /// The number of dropped packets sent by the secondary ENI over the internal network.
                /// </summary>
                [NameInMap("DropPacketTx")]
                [Validation(Required=false)]
                public string DropPacketTx { get; set; }

                /// <summary>
                /// The secondary ENI ID.
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// The average rate of data received by the secondary ENI over the internal network. Unit: Kbit/s.
                /// </summary>
                [NameInMap("IntranetRx")]
                [Validation(Required=false)]
                public string IntranetRx { get; set; }

                /// <summary>
                /// The average rate of data sent by the secondary ENI over the internal network. Unit: Kbit/s.
                /// </summary>
                [NameInMap("IntranetTx")]
                [Validation(Required=false)]
                public string IntranetTx { get; set; }

                /// <summary>
                /// The number of packets received by the secondary ENI over the internal network.
                /// </summary>
                [NameInMap("PacketRx")]
                [Validation(Required=false)]
                public string PacketRx { get; set; }

                /// <summary>
                /// The number of packets sent by the secondary ENI over the internal network.
                /// </summary>
                [NameInMap("PacketTx")]
                [Validation(Required=false)]
                public string PacketTx { get; set; }

                /// <summary>
                /// The timestamp to query the monitoring data. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
