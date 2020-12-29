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
        public DescribeEniMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEniMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("EniMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData> EniMonitorData { get; set; }
            public class DescribeEniMonitorDataResponseBodyMonitorDataEniMonitorData : TeaModel {
                public string PacketRx { get; set; }
                public string TimeStamp { get; set; }
                public string DropPacketRx { get; set; }
                public string EniId { get; set; }
                public string DropPacketTx { get; set; }
                public string PacketTx { get; set; }
                public string IntranetTx { get; set; }
                public string IntranetRx { get; set; }
            }
        };

    }

}
