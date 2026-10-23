// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The association type between the automatic snapshot policy and the target resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AssociatedWithDisk: Associated with cloud disks.</description></item>
        /// <item><description>AssociatedWithInstanceTag: Associated with instance tags.</description></item>
        /// </list>
        /// <para>Default value: AssociatedWithDisk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AssociatedWithDisk</para>
        /// </summary>
        [NameInMap("AssociationType")]
        [Validation(Required=false)]
        public string AssociationType { get; set; }

        /// <summary>
        /// <para>The retention period of cross-region replicated snapshots. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: The snapshots are retained permanently.</description></item>
        /// <item><description>1 to 65535: The snapshots are retained for the specified number of days.</description></item>
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
        /// <para>The backup encryption parameter object for snapshot geo-redundancy.</para>
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public CreateAutoSnapshotPolicyRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class CreateAutoSnapshotPolicyRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoSnapshotPolicyRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class CreateAutoSnapshotPolicyRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is not available.</para>
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
                /// <para>This parameter is not available.</para>
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
                /// <para>This parameter is not available.</para>
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
            /// <para>Specifies whether to enable encryption for cross-region snapshot backups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
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
            /// <para>The KMS key ID used for snapshot geo-redundancy backup encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to allow automatic cross-region replication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Allowed.</description></item>
        /// <item><description>false: Not allowed.</description></item>
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
        /// <para>The ID of the resource group.</para>
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
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The list of tags for the automatic snapshot policy.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateAutoSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the automatic snapshot policy. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with aliyun or acs: or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the automatic snapshot policy. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length, and cannot start with acs: or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The destination region for cross-region snapshot replication. You can specify only one destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;]</para>
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// <para>The list of target resource tags. The automatic snapshot policy matches target resources based on tags. This parameter is required when AssociationType is set to AssociatedWithInstanceTag.</para>
        /// </summary>
        [NameInMap("TargetTags")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTargetTags> TargetTags { get; set; }
        public class CreateAutoSnapshotPolicyRequestTargetTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Valid values of N: 1 to 5.</para>
            /// <para>If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with aliyun or acs: or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>Valid values of N: 1 to 5.</para>
            /// <para>The tag value can be up to 128 characters in length, and cannot contain http:// or https://.</para>
            /// <remarks>
            /// <para>If you leave this parameter empty or specify an empty string, it indicates any value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// <para>The region to which the automatic snapshot policy belongs. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The days of the week when automatic snapshots are created. Valid values: 1 to 7, which represent Monday to Sunday. For example, 1 indicates Monday. Format description:</para>
        /// <list type="bullet">
        /// <item><description>The parameter must be a JSON array. For example, [&quot;1&quot;] indicates that automatic snapshots are created every Monday.</description></item>
        /// <item><description>If you want to create automatic snapshots multiple times a week, you can specify multiple days separated by commas (,). You can specify up to 7 days. For example, [&quot;1&quot;,&quot;3&quot;,&quot;5&quot;] indicates that automatic snapshots are created every Monday, Wednesday, and Friday.</description></item>
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
        /// <item><description>-1: The snapshots are retained permanently.</description></item>
        /// <item><description>1 to 65535: The snapshots are retained for the specified number of days.</description></item>
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
        /// <para>The points in time when automatic snapshots are created. The time is in UTC+8 and measured in hours. Valid values: 0 to 23, which represent the 24 points in time from 00:00 to 23:00. For example, 1 indicates 01:00. Format description:</para>
        /// <list type="bullet">
        /// <item><description>The parameter must be a JSON array. For example, [&quot;1&quot;] indicates that automatic snapshots are created at 01:00.</description></item>
        /// <item><description>If you want to create multiple automatic snapshots in a day, you can specify multiple points in time separated by commas (,). You can specify up to 24 points in time. For example, [&quot;1&quot;,&quot;3&quot;,&quot;5&quot;] indicates that automatic snapshots are created at 01:00, 03:00, and 05:00.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the cloud disk contains a large amount of data and the duration of creating a single automatic snapshot exceeds the interval between two points in time, the system skips the next point in time. For example, if you set the points in time to 09:00, 10:00, 11:00, and 12:00, and the snapshot creation starts at 09:00 and finishes at 10:20, taking 80 minutes, the system skips the 10:00 point in time and creates the next automatic snapshot at 11:00.</para>
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
