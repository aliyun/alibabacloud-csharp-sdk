// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeHostInstanceMonitorInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHostInstanceMonitorInfoResponseBodyItems> Items { get; set; }
        public class DescribeHostInstanceMonitorInfoResponseBodyItems : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("MemSize")]
            [Validation(Required=false)]
            public int? MemSize { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("AuroraSwitchInstanceLog")]
            [Validation(Required=false)]
            public DescribeHostInstanceMonitorInfoResponseBodyItemsAuroraSwitchInstanceLog AuroraSwitchInstanceLog { get; set; }
            public class DescribeHostInstanceMonitorInfoResponseBodyItemsAuroraSwitchInstanceLog : TeaModel {
                [NameInMap("SwitchFrom")]
                [Validation(Required=false)]
                public float? SwitchFrom { get; set; }
                [NameInMap("SwitchType")]
                [Validation(Required=false)]
                public float? SwitchType { get; set; }
                [NameInMap("SwitchTime")]
                [Validation(Required=false)]
                public long? SwitchTime { get; set; }
            };

        }

    }

}
