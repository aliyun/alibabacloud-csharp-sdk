// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyExResponseBody : TeaModel {
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies : TeaModel {
            [NameInMap("AutoSnapshotPolicy")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy> AutoSnapshotPolicy { get; set; }
            public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy : TeaModel {
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                [NameInMap("AutoSnapshotPolicyName")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyName { get; set; }

                [NameInMap("CopiedSnapshotsRetentionDays")]
                [Validation(Required=false)]
                public int? CopiedSnapshotsRetentionDays { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DiskNums")]
                [Validation(Required=false)]
                public int? DiskNums { get; set; }

                [NameInMap("EnableCrossRegionCopy")]
                [Validation(Required=false)]
                public bool? EnableCrossRegionCopy { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RepeatWeekdays")]
                [Validation(Required=false)]
                public string RepeatWeekdays { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags Tags { get; set; }
                public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag> Tag { get; set; }
                    public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("TargetCopyRegions")]
                [Validation(Required=false)]
                public string TargetCopyRegions { get; set; }

                [NameInMap("TimePoints")]
                [Validation(Required=false)]
                public string TimePoints { get; set; }

                [NameInMap("VolumeNums")]
                [Validation(Required=false)]
                public int? VolumeNums { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
