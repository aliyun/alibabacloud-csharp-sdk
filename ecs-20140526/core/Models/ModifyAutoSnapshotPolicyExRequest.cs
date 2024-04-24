// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoSnapshotPolicyExRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("CopiedSnapshotsRetentionDays")]
        [Validation(Required=false)]
        public int? CopiedSnapshotsRetentionDays { get; set; }

        /// <summary>
        /// The encryption configurations for cross-region snapshot replication.
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// This parameter is not publicly available.
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// This parameter is not publicly available.
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// This parameter is not publicly available.
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable encryption for cross-region snapshot replication. Valid values:
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
            /// The ID of the KMS key used for encryption in cross-region snapshot replication.
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// The destination region to which to copy the snapshot. You can specify only a single destination region.
        /// </summary>
        [NameInMap("EnableCrossRegionCopy")]
        [Validation(Required=false)]
        public bool? EnableCrossRegionCopy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The retention period of the snapshot copy in the destination region. Unit: days. Valid values:
        /// 
        /// *   \-1: The snapshot is permanently retained.
        /// *   1 to 65535: The automatic snapshot is retained for the specified number of days.
        /// 
        /// Default value: -1.
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// The name of the automatic snapshot policy. If this parameter is not specified, the original name of the automatic snapshot policy is retained.
        /// </summary>
        [NameInMap("autoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// The points in time of the day at which to create automatic snapshots. The time must be in UTC+8. Unit: hours. Valid values are 0 to 23, which correspond to the 24 points in time on the hour from 00:00:00 to 23:00:00. For example, a value of 1 indicates 01:00:00.
        /// 
        /// To schedule multiple automatic snapshots to be created in a day, you can specify multiple hours.
        /// 
        /// *   You can specify up to 24 points in time.
        /// *   You must set this parameter to a JSON array such as `["0", "1", ... "23"]`. Separate the points in time with commas (,).
        /// </summary>
        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// The ID of the automatic snapshot policy. You can call the [DescribeAutoSnapshotPolicyEx](~~25530~~) operation to query available automatic snapshot policies.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The retention period of the automatic snapshot. Unit: days. Valid values:
        /// 
        /// *   \-1: The automatic snapshot is permanently retained.
        /// *   1 to 65536: The auto snapshot is retained for the specified number of days.
        /// 
        /// Default value: -1.
        /// </summary>
        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// Specifies whether to enable cross-region replication for the automatic snapshot.
        /// 
        /// *   true: enables cross-region replication for the automatic snapshot.
        /// *   false: disables cross-region replication for the automatic snapshot.
        /// </summary>
        [NameInMap("retentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The days of the week on which to create automatic snapshots. Valid values are 1 to 7, which correspond to the days of the week. For example, a value of 1 indicates Monday.
        /// 
        /// To schedule multiple automatic snapshots to be created in a week, you can specify multiple days.
        /// 
        /// *   You can specify up to seven days over a one-week period.
        /// *   You must set this parameter to a JSON array such as `["1", "2" ... "7"]`. Separate the values in the array with commas (,).
        /// </summary>
        [NameInMap("timePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
