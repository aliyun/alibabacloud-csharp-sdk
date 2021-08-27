// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DiskReplicaPairs")]
        [Validation(Required=false)]
        public DescribeDiskReplicaPairsResponseBodyDiskReplicaPairs DiskReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyDiskReplicaPairs : TeaModel {
            [NameInMap("DiskReplicaPair")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaPairsResponseBodyDiskReplicaPairsDiskReplicaPair> DiskReplicaPair { get; set; }
            public class DescribeDiskReplicaPairsResponseBodyDiskReplicaPairsDiskReplicaPair : TeaModel {
                public string Status { get; set; }
                public string SourceDiskId { get; set; }
                public string ReplicaPairId { get; set; }
                public string Description { get; set; }
                public string DestinationRegion { get; set; }
                public string PairName { get; set; }
                public string SourceRegion { get; set; }
                public string DestinationDiskId { get; set; }
            }
        };

    }

}
