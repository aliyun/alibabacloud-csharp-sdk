// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ReplicaPairs")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsResponseBodyReplicaPairs> ReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyReplicaPairs : TeaModel {
            [NameInMap("AsyncCycle")]
            [Validation(Required=false)]
            public long? AsyncCycle { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationDiskId")]
            [Validation(Required=false)]
            public string DestinationDiskId { get; set; }

            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            [NameInMap("LastRPO")]
            [Validation(Required=false)]
            public long? LastRPO { get; set; }

            [NameInMap("PairName")]
            [Validation(Required=false)]
            public string PairName { get; set; }

            [NameInMap("ReplicaPairId")]
            [Validation(Required=false)]
            public string ReplicaPairId { get; set; }

            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
