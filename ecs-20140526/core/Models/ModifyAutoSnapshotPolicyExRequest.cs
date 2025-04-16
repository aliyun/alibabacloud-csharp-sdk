// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoSnapshotPolicyExRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of the snapshot copy in the destination region. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: The snapshot copy is retained until it is deleted.</description></item>
        /// <item><description>1 to 65535: The snapshot copy is retained for a specified number of days.</description></item>
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
        /// <para>The encryption configurations for cross-region snapshot replication.</para>
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// <para>This parameter is not publicly available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// <para>This parameter is not publicly available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <para>This parameter is not publicly available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable encryption for cross-region snapshot replication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>The ID of the KMS key used for encryption in cross-region snapshot replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable cross-region replication for the automatic snapshot.</para>
        /// <list type="bullet">
        /// <item><description>true: enables cross-region replication for the automatic snapshot.</description></item>
        /// <item><description>false: disables cross-region replication for the automatic snapshot.</description></item>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The destination region to which to copy the snapshot. You can specify only a single destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;]</para>
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy. You can call the <a href="https://help.aliyun.com/document_detail/25530.html">DescribeAutoSnapshotPolicyEx</a> operation to query available automatic snapshot policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp12m37ccmxvbmi5****</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. If this parameter is not specified, the original name of the automatic snapshot policy is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPTestName</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// <para>The region ID of the automatic snapshot policy. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The days of the week on which to create automatic snapshots. Valid values are 1 to 7, which correspond to the days of the week. For example, a value of 1 indicates Monday.</para>
        /// <para>To schedule multiple automatic snapshots to be created in a week, you can specify multiple days.</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to seven days over a one-week period.</description></item>
        /// <item><description>You must set this parameter to a JSON array such as <c>[&quot;1&quot;, &quot;2&quot; ... &quot;7&quot;]</c>. Separate the values in the array with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;, &quot;7&quot;]</para>
        /// </summary>
        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of the automatic snapshot. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\-1: The automatic snapshot is permanently retained.</description></item>
        /// <item><description>1 to 65536: The auto snapshot is retained for the specified number of days.</description></item>
        /// </list>
        /// <para>Default value: -1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("retentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The points in time of the day at which to create automatic snapshots. The time must be in UTC+8. Unit: hours. Valid values are 0 to 23, which correspond to the 24 points in time on the hour from 00:00:00 to 23:00:00. For example, a value of 1 indicates 01:00:00.</para>
        /// <para>To schedule multiple automatic snapshots to be created in a day, you can specify multiple hours.</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 24 points in time.</description></item>
        /// <item><description>You must set this parameter to a JSON array such as <c>[&quot;0&quot;, &quot;1&quot;, ... &quot;23&quot;]</c>. Separate the points in time with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;0&quot;, &quot;1&quot;]</para>
        /// </summary>
        [NameInMap("timePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
