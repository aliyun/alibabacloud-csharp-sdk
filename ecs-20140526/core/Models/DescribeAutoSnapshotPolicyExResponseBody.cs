// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyExResponseBody : TeaModel {
        /// <summary>
        /// Details about the automatic snapshot policies.
        /// </summary>
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPolicies : TeaModel {
            [NameInMap("AutoSnapshotPolicy")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy> AutoSnapshotPolicy { get; set; }
            public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy : TeaModel {
                /// <summary>
                /// The ID of the automatic snapshot policy.
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// The name of the automatic snapshot policy.
                /// </summary>
                [NameInMap("AutoSnapshotPolicyName")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyName { get; set; }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("CopiedSnapshotsRetentionDays")]
                [Validation(Required=false)]
                public int? CopiedSnapshotsRetentionDays { get; set; }

                /// <summary>
                /// Encryption configurations for cross-region snapshot replication.
                /// </summary>
                [NameInMap("CopyEncryptionConfiguration")]
                [Validation(Required=false)]
                public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
                public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyCopyEncryptionConfiguration : TeaModel {
                    /// <summary>
                    /// Whether to enable encryption for cross-region snapshot replication. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// 
                    /// Default value: false.
                    /// </summary>
                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// The ID of the Key Management Service (KMS) key used to encrypt snapshots in cross-region snapshot replication.
                    /// </summary>
                    [NameInMap("KMSKeyId")]
                    [Validation(Required=false)]
                    public string KMSKeyId { get; set; }

                }

                /// <summary>
                /// The time when the automatic snapshot policy was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The number of disks to which the automatic snapshot policy is applied.
                /// </summary>
                [NameInMap("DiskNums")]
                [Validation(Required=false)]
                public int? DiskNums { get; set; }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("EnableCrossRegionCopy")]
                [Validation(Required=false)]
                public bool? EnableCrossRegionCopy { get; set; }

                /// <summary>
                /// The region ID of the automatic snapshot policy.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The days of the week on which to create automatic snapshots. Valid values: 1 to 7, which correspond to the days of the week. For example, 1 indicates Monday. One or more days can be specified.
                /// </summary>
                [NameInMap("RepeatWeekdays")]
                [Validation(Required=false)]
                public string RepeatWeekdays { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The retention period of the automatic snapshots. Unit: days. Valid values:
                /// 
                /// *   \\-1: Automatic snapshots are retained until they are deleted.
                /// *   1 to 65536: Auto snapshots are retained for the specified number of days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                /// <summary>
                /// The status of the automatic snapshot policy. Valid values:
                /// 
                /// *   Normal: The automatic snapshot policy is normal.
                /// *   Expire: The automatic snapshot policy cannot be used because your account has overdue payments.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the automatic snapshot policy.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags Tags { get; set; }
                public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag> Tag { get; set; }
                    public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the automatic snapshot policy.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the automatic snapshot policy.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("TargetCopyRegions")]
                [Validation(Required=false)]
                public string TargetCopyRegions { get; set; }

                /// <summary>
                /// The points in time of the day at which to create automatic snapshots.
                /// 
                /// The time is displayed in UTC+8. Unit: hours. Valid values: 0 to 23, which correspond to the 24 points in time on the hour from 00:00:00 to 23:00:00. For example, 1 indicates 01:00:00. Multiple points in time can be specified.
                /// 
                /// The parameter value is a JSON array that contains up to 24 points in time separated by commas (,). Example: `["0", "1", ... "23"]`.
                /// </summary>
                [NameInMap("TimePoints")]
                [Validation(Required=false)]
                public string TimePoints { get; set; }

                /// <summary>
                /// The type of the automatic snapshot policy. Valid values:
                /// 
                /// *   Custom: user-defined snapshot policy.
                /// *   System: system-defined snapshot policy.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The number of extended volumes to which the automatic snapshot policy is applied.
                /// </summary>
                [NameInMap("VolumeNums")]
                [Validation(Required=false)]
                public int? VolumeNums { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of automatic snapshot policies
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
