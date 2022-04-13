// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeDiskMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("DiskMonitorData")]
            [Validation(Required=false)]
            public List<DescribeDiskMonitorDataResponseBodyMonitorDataDiskMonitorData> DiskMonitorData { get; set; }
            public class DescribeDiskMonitorDataResponseBodyMonitorDataDiskMonitorData : TeaModel {
                public int? BPSRead { get; set; }
                public int? BPSTotal { get; set; }
                public int? BPSWrite { get; set; }
                public string DiskId { get; set; }
                public int? IOPSRead { get; set; }
                public int? IOPSTotal { get; set; }
                public int? IOPSWrite { get; set; }
                public int? LatencyRead { get; set; }
                public int? LatencyWrite { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
