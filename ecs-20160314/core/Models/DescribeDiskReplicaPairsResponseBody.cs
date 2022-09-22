// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        [NameInMap("DiskReplicaPairs")]
        [Validation(Required=false)]
        public DescribeDiskReplicaPairsResponseBodyDiskReplicaPairs DiskReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyDiskReplicaPairs : TeaModel {
            [NameInMap("DiskReplicaPair")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaPairsResponseBodyDiskReplicaPairsDiskReplicaPair> DiskReplicaPair { get; set; }
            public class DescribeDiskReplicaPairsResponseBodyDiskReplicaPairsDiskReplicaPair : TeaModel {
                [NameInMap("AsyncCycle")]
                [Validation(Required=false)]
                public int? AsyncCycle { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestinationDiskId")]
                [Validation(Required=false)]
                public string DestinationDiskId { get; set; }

                [NameInMap("DestinationRegion")]
                [Validation(Required=false)]
                public string DestinationRegion { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("PairName")]
                [Validation(Required=false)]
                public string PairName { get; set; }

                [NameInMap("ReplicaPairId")]
                [Validation(Required=false)]
                public string ReplicaPairId { get; set; }

                [NameInMap("RpoTime")]
                [Validation(Required=false)]
                public string RpoTime { get; set; }

                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                [NameInMap("SourceRegion")]
                [Validation(Required=false)]
                public string SourceRegion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCopiedSize")]
                [Validation(Required=false)]
                public long? TotalCopiedSize { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
