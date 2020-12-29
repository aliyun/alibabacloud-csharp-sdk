// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotMonitorDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeSnapshotMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeSnapshotMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("DataPoint")]
            [Validation(Required=false)]
            public List<DescribeSnapshotMonitorDataResponseBodyMonitorDataDataPoint> DataPoint { get; set; }
            public class DescribeSnapshotMonitorDataResponseBodyMonitorDataDataPoint : TeaModel {
                public long? Size { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
