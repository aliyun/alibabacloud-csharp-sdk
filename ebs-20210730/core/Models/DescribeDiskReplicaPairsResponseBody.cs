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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ReplicaPairs")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsResponseBodyReplicaPairs> ReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyReplicaPairs : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationDiskId")]
            [Validation(Required=false)]
            public string DestinationDiskId { get; set; }

            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            [NameInMap("PairName")]
            [Validation(Required=false)]
            public string PairName { get; set; }

            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("RPO")]
            [Validation(Required=false)]
            public long? RPO { get; set; }

            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            [NameInMap("ReplicaGroupName")]
            [Validation(Required=false)]
            public string ReplicaGroupName { get; set; }

            [NameInMap("ReplicaPairId")]
            [Validation(Required=false)]
            public string ReplicaPairId { get; set; }

            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            [NameInMap("StandbyZone")]
            [Validation(Required=false)]
            public string StandbyZone { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
