// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("BPSPercent")]
            [Validation(Required=false)]
            public long? BPSPercent { get; set; }

            [NameInMap("BurstIOCount")]
            [Validation(Required=false)]
            public long? BurstIOCount { get; set; }

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("IOPSPercent")]
            [Validation(Required=false)]
            public long? IOPSPercent { get; set; }

            [NameInMap("ReadBPS")]
            [Validation(Required=false)]
            public long? ReadBPS { get; set; }

            [NameInMap("ReadIOPS")]
            [Validation(Required=false)]
            public long? ReadIOPS { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("WriteBPS")]
            [Validation(Required=false)]
            public long? WriteBPS { get; set; }

            [NameInMap("WriteIOPS")]
            [Validation(Required=false)]
            public long? WriteIOPS { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
