// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoSnapshotPolicyExRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of cross-region snapshot replicas. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: permanently retained.</description></item>
        /// <item><description>1 to 65535: the specified number of days for which snapshot replicas are retained.</description></item>
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
        /// <para>The encryption parameter for cross-region snapshot replication.</para>
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
            /// <item><description>true: enabled. </description></item>
            /// <item><description>false: disabled.</description></item>
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
            /// <para>The key ID of the KMS key used for encrypted cross-region snapshot replication.</para>
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
        /// <item><description>true: allowed.</description></item>
        /// <item><description>false: not allowed.</description></item>
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
        /// <para>The destination region for cross-region snapshot replication. You can set one destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;]</para>
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy. You can call <a href="https://help.aliyun.com/document_detail/25530.html">DescribeAutoSnapshotPolicyEx</a> to query available automatic snapshot policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp12m37ccmxvbmi5****</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. If this parameter is left empty, the name is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPTestName</para>
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
        /// <para>The days of the week on which automatic snapshots are created. Unit: days. The cycle is weekly. Valid values: 1 to 7. For example, 1 indicates Monday.</para>
        /// <para>To create multiple automatic snapshots within a week, specify multiple days:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 7 days.</description></item>
        /// <item><description>Specify multiple days in a JSON array in the format of <c>&quot;1&quot;, &quot;2&quot;, … &quot;7&quot;</c>. Separate the days with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;, &quot;7&quot;]</para>
        /// </summary>
        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of automatic snapshots. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: permanently retained.</description></item>
        /// <item><description>1 to 65536: the specified number of days for which snapshots are retained.</description></item>
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
        /// <para>The points in time at which automatic snapshots are created. The time is displayed in UTC+8. Unit: hours. Valid values: 0 to 23, which correspond to the 24 points in time from 00:00 to 23:00. For example, 1 indicates 01:00.</para>
        /// <para>To create multiple automatic snapshots within a day, specify multiple points in time:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 24 points in time.</description></item>
        /// <item><description>Specify multiple points in time in a JSON array in the format of <c>&quot;0&quot;, &quot;1&quot;, … &quot;23&quot;</c>. Separate the points in time with commas (,).</description></item>
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
