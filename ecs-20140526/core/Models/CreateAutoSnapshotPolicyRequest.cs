// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The association type between the automatic snapshot policy and target resources. Valid values:
        /// ● AssociatedWithDisk: associated with disks.
        /// ● AssociatedWithInstanceTag: associated with instance tags.
        /// Default value: AssociatedWithDisk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AssociatedWithDisk</para>
        /// </summary>
        [NameInMap("AssociationType")]
        [Validation(Required=false)]
        public string AssociationType { get; set; }

        /// <summary>
        /// <para>The retention period of cross-region snapshot replicas. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: Snapshot replicas are permanently retained.</description></item>
        /// <item><description>1 to 65535: Snapshot replicas are retained for the specified number of days.</description></item>
        /// </list>
        /// <para>Default value: -1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CopiedSnapshotsRetentionDays")]
        [Validation(Required=false)]
        public int? CopiedSnapshotsRetentionDays { get; set; }

        /// <summary>
        /// <para>The backup encryption parameters for snapshot geo-redundancy.</para>
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public CreateAutoSnapshotPolicyRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class CreateAutoSnapshotPolicyRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoSnapshotPolicyRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class CreateAutoSnapshotPolicyRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable encryption for cross-region snapshot backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables encryption.</description></item>
            /// <item><description>false: does not enable encryption.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The key ID of the KMS key used for cross-region encrypted snapshot backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to allow automatic cross-region replication.</para>
        /// <list type="bullet">
        /// <item><description>true: allows automatic cross-region replication.</description></item>
        /// <item><description>false: does not allow automatic cross-region replication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCrossRegionCopy")]
        [Validation(Required=false)]
        public bool? EnableCrossRegionCopy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kkmhmhs****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The tags of the automatic snapshot policy.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateAutoSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the automatic snapshot policy. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the automatic snapshot policy. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with acs:. The tag value cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The destination region to which snapshots are replicated. You can specify one destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;]</para>
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// <para>The list of target resource tags. The automatic snapshot policy matches target resources based on tags.
        /// When AssociationType is set to AssociatedWithInstanceTag, this parameter is required.</para>
        /// </summary>
        [NameInMap("TargetTags")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTargetTags> TargetTags { get; set; }
        public class CreateAutoSnapshotPolicyRequestTargetTags : TeaModel {
            /// <summary>
            /// <para>The tag key.
            /// Valid values of N: 1 to 10.
            /// The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.
            /// Valid values of N: 1 to 10. The tag value can be up to 128 characters in length and cannot contain http:// or https://.
            /// Note: If you pass in an empty or empty string value, it indicates any value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with http:// or https://. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// <para>The region ID of the automatic snapshot policy. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The days of the week on which automatic snapshots are created. Unit: days. The cycle is weekly. Valid values: 1 to 7. For example, 1 indicates Monday. Format description:</para>
        /// <list type="bullet">
        /// <item><description>The parameter value must be a JSON array. For example, [&quot;1&quot;\] indicates that automatic snapshots are created every Monday.</description></item>
        /// <item><description>To create multiple automatic snapshots within a week, specify multiple time points separated by commas (,). You can specify up to 7 time points. For example, [&quot;1&quot;,&quot;3&quot;,&quot;5&quot;\] indicates that automatic snapshots are created every Monday, Wednesday, and Friday.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;2&quot;]</para>
        /// </summary>
        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of automatic snapshots. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: Automatic snapshots are permanently retained.</description></item>
        /// <item><description>1 to 65535: Automatic snapshots are retained for the specified number of days.</description></item>
        /// </list>
        /// <para>Default value: -1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("retentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The points in time at which automatic snapshots are created. The time is displayed in UTC+8. Unit: hours. Valid values: 0 to 23, which represent 00:00 to 23:00 (a total of 24 time points). For example, 1 indicates 01:00. Format description:</para>
        /// <list type="bullet">
        /// <item><description>The parameter value must be a JSON array. For example, [&quot;1&quot;\] indicates that automatic snapshots are created at 01:00.</description></item>
        /// <item><description>To create multiple automatic snapshots within a day, specify multiple time points separated by commas (,). You can specify up to 24 time points. For example, [&quot;1&quot;,&quot;3&quot;,&quot;5&quot;\] indicates that automatic snapshots are created at 01:00, 03:00, and 05:00.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If a disk contains a large amount of data and the time required to create a single automatic snapshot exceeds the interval between two time points, the next time point is skipped. For example, you set 09:00, 10:00, 11:00, and 12:00 as the automatic snapshot time points. Because the disk contains a large amount of data, the snapshot creation starts at 09:00 and is completed at 10:20, which takes 80 minutes. The system skips the 10:00 time point and creates the next automatic snapshot at 11:00.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;0&quot;, &quot;1&quot;, … &quot;23&quot;]</para>
        /// </summary>
        [NameInMap("timePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
