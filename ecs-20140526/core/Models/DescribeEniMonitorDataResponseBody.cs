// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEniMonitorDataResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeEniMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeEniMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("PacketRx")]
            [Validation(Required=false)]
            public string PacketRx { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("DropPacketRx")]
            [Validation(Required=false)]
            public string DropPacketRx { get; set; }

            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            [NameInMap("DropPacketTx")]
            [Validation(Required=false)]
            public string DropPacketTx { get; set; }

            [NameInMap("PacketTx")]
            [Validation(Required=false)]
            public string PacketTx { get; set; }

            [NameInMap("IntranetTx")]
            [Validation(Required=false)]
            public string IntranetTx { get; set; }

            [NameInMap("IntranetRx")]
            [Validation(Required=false)]
            public string IntranetRx { get; set; }

        }

    }

}
