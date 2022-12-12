// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskMonitorDataListResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataListResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataListResponseBodyMonitorData : TeaModel {
            [NameInMap("BurstIOCount")]
            [Validation(Required=false)]
            public long? BurstIOCount { get; set; }

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
