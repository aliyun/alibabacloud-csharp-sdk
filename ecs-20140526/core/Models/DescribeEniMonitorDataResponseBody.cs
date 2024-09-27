// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEniMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of the secondary ENI.</para>
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
                /// <para>The number of received packets that were dropped by the secondary ENI over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DropPacketRx")]
                [Validation(Required=false)]
                public string DropPacketRx { get; set; }

                /// <summary>
                /// <para>The number of sent packets that were dropped by the secondary ENI over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DropPacketTx")]
                [Validation(Required=false)]
                public string DropPacketTx { get; set; }

                /// <summary>
                /// <para>The ID of the secondary ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp19da36d6xdwey****</para>
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>The average rate at which the secondary ENI received data over the internal network. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IntranetRx")]
                [Validation(Required=false)]
                public string IntranetRx { get; set; }

                /// <summary>
                /// <para>The average rate at which the secondary ENI sent data over the internal network. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IntranetTx")]
                [Validation(Required=false)]
                public string IntranetTx { get; set; }

                /// <summary>
                /// <para>The number of packets received by the secondary ENI over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PacketRx")]
                [Validation(Required=false)]
                public string PacketRx { get; set; }

                /// <summary>
                /// <para>The number of packets sent by the secondary ENI over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PacketTx")]
                [Validation(Required=false)]
                public string PacketTx { get; set; }

                /// <summary>
                /// <para>The timestamp of the monitoring data. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-05-21T03:22:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
