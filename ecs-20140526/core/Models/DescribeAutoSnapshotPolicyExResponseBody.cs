// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyExResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies : TeaModel {
            [NameInMap("AutoSnapshotPolicy")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy> AutoSnapshotPolicy { get; set; }
            public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy : TeaModel {
                public string TimePoints { get; set; }
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string AutoSnapshotPolicyName { get; set; }
                public string TargetCopyRegions { get; set; }
                public int? CopiedSnapshotsRetentionDays { get; set; }
                public string AutoSnapshotPolicyId { get; set; }
                public int? RetentionDays { get; set; }
                public string RegionId { get; set; }
                public int? DiskNums { get; set; }
                public bool? EnableCrossRegionCopy { get; set; }
                public string RepeatWeekdays { get; set; }
                public int? VolumeNums { get; set; }
                public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags Tags { get; set; }
                public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag> Tag { get; set; }
                    public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
            }
        };

    }

}
