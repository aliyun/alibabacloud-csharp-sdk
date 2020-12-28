// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyExResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies> AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public string TimePoints { get; set; }

            [NameInMap("AutoSnapshotPolicyName")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyName { get; set; }

            [NameInMap("TargetCopyRegions")]
            [Validation(Required=false)]
            public string TargetCopyRegions { get; set; }

            [NameInMap("CopiedSnapshotsRetentionDays")]
            [Validation(Required=false)]
            public int? CopiedSnapshotsRetentionDays { get; set; }

            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesTags> Tags { get; set; }
            public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public int? RetentionDays { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("DiskNums")]
            [Validation(Required=false)]
            public int? DiskNums { get; set; }

            [NameInMap("EnableCrossRegionCopy")]
            [Validation(Required=false)]
            public bool? EnableCrossRegionCopy { get; set; }

            [NameInMap("RepeatWeekdays")]
            [Validation(Required=false)]
            public string RepeatWeekdays { get; set; }

            [NameInMap("VolumeNums")]
            [Validation(Required=false)]
            public int? VolumeNums { get; set; }

        }

    }

}
