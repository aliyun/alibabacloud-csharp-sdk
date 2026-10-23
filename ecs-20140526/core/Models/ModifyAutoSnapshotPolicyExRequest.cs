// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoSnapshotPolicyExRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of cross-region replicated snapshots. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: The snapshots are permanently retained.</description></item>
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
        /// <para>The encryption parameters for cross-region snapshot replication.</para>
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// <para>This parameter is not available.</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// <para>This parameter is not available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// <para>This parameter is not available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <para>This parameter is not available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable encrypted cross-region snapshot replication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes. </description></item>
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
            /// <para>The KMS key ID used for encrypted cross-region snapshot replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic cross-region replication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
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
        /// <para>The destination region for cross-region snapshot replication. You can specify only one destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;]</para>
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// <para>The list of target resource tags. The automatic snapshot policy matches target resources based on tags.</para>
        /// </summary>
        [NameInMap("TargetTags")]
        [Validation(Required=false)]
        public List<ModifyAutoSnapshotPolicyExRequestTargetTags> TargetTags { get; set; }
        public class ModifyAutoSnapshotPolicyExRequestTargetTags : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 5. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with aliyun or acs: or contain http:// or https://.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 5. It can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>If this parameter is left empty or set to an empty string, it indicates any value.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy. You can call the <a href="https://help.aliyun.com/document_detail/25530.html">DescribeAutoSnapshotPolicyEx</a> operation to query the available automatic snapshot policies.</para>
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
        /// <para>The days of the week on which automatic snapshots are created. Valid values: 1 to 7, which represent Monday to Sunday. For example, 1 indicates Monday.</para>
        /// <para>If you want to create automatic snapshots on multiple days within a week, you can specify multiple days:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 7 days.</description></item>
        /// <item><description>Specify multiple days in a JSON array, such as <c>[&quot;1&quot;, &quot;2&quot;, ... &quot;7&quot;]</c>. Separate the days with commas (,).</description></item>
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
        /// <item><description>-1: The snapshots are permanently retained.</description></item>
        /// <item><description>1 to 65536: The snapshots are retained for the specified number of days.</description></item>
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
        /// <para>The points in time at which automatic snapshots are created. The time is in UTC+8 and measured in hours. Valid values: 0 to 23, which represent 24 points in time from 00:00 to 23:00. For example, 1 indicates 01:00.</para>
        /// <para>If you want to create multiple automatic snapshots within a day, you can specify multiple points in time:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 24 points in time.</description></item>
        /// <item><description>Specify multiple points in time in a JSON array, such as <c>[&quot;0&quot;, &quot;1&quot;, ... &quot;23&quot;]</c>. Separate the points in time with commas (,).</description></item>
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
