// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStorageTrafficUsageDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficUsage")]
        [Validation(Required=false)]
        public DescribeVsStorageTrafficUsageDataResponseBodyTrafficUsage TrafficUsage { get; set; }
        public class DescribeVsStorageTrafficUsageDataResponseBodyTrafficUsage : TeaModel {
            [NameInMap("TrafficUsageDataModule")]
            [Validation(Required=false)]
            public List<DescribeVsStorageTrafficUsageDataResponseBodyTrafficUsageTrafficUsageDataModule> TrafficUsageDataModule { get; set; }
            public class DescribeVsStorageTrafficUsageDataResponseBodyTrafficUsageTrafficUsageDataModule : TeaModel {
                public string Bucket { get; set; }
                public float? LanBandwidthInDataValue { get; set; }
                public float? LanBandwidthOutDataValue { get; set; }
                public long? LanTrafficInDataValue { get; set; }
                public long? LanTrafficOutDataValue { get; set; }
                public string TimeStamp { get; set; }
                public float? WanBandwidthInDataValue { get; set; }
                public float? WanBandwidthOutDataValue { get; set; }
                public long? WanTrafficInDataValue { get; set; }
                public long? WanTrafficOutDataValue { get; set; }
            }
        };

    }

}
