// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEniMonitorDataResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeEniMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEniMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("EniMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData> EniMonitorData { get; set; }
            public class DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData : TeaModel {
                [NameInMap("DropPacketRx")]
                [Validation(Required=false)]
                public string DropPacketRx { get; set; }

                [NameInMap("DropPacketTx")]
                [Validation(Required=false)]
                public string DropPacketTx { get; set; }

                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                [NameInMap("IntranetRx")]
                [Validation(Required=false)]
                public string IntranetRx { get; set; }

                [NameInMap("IntranetTx")]
                [Validation(Required=false)]
                public string IntranetTx { get; set; }

                [NameInMap("PacketRx")]
                [Validation(Required=false)]
                public string PacketRx { get; set; }

                [NameInMap("PacketTx")]
                [Validation(Required=false)]
                public string PacketTx { get; set; }

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
