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
        /// <item><description>-1: The snapshot is retained permanently.</description></item>
        /// <item><description>1 to 65535: The snapshot is retained for the specified number of days.</description></item>
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
        /// <para>The encryption configuration for cross-region snapshot replication.</para>
        /// </summary>
        [NameInMap("CopyEncryptionConfiguration")]
        [Validation(Required=false)]
        public ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
        public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfiguration : TeaModel {
            /// <summary>
            /// <para>This parameter is not available for use.</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn> Arn { get; set; }
            public class ModifyAutoSnapshotPolicyExRequestCopyEncryptionConfigurationArn : TeaModel {
                /// <summary>
                /// <para>This parameter is not available for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// <para>This parameter is not available for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <para>This parameter is not available for use.</para>
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
            /// <para>The key ID of the KMS key used for cross-region encrypted snapshot replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to allow automatic cross-region snapshot replication. Valid values:</para>
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
            /// <para>The tag key.</para>
            /// <para>Valid values of N: 1 to 5.</para>
            /// <para>The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>Valid values of N: 1 to 5.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>If you pass an empty value or an empty string, the tag value matches any value.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        /// <para>The days of the week on which to create automatic snapshots. Valid values: 1 to 7, where 1 represents Monday.</para>
        /// <para>To create multiple automatic snapshots within a week, specify multiple days:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 7 days.</description></item>
        /// <item><description>Specify multiple days as a JSON array in the format of <c>&quot;1&quot;, &quot;2&quot;, … &quot;7&quot;</c>. Separate multiple days with commas (,).</description></item>
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
        /// <item><description>-1: The snapshot is retained permanently.</description></item>
        /// <item><description>1 to 65536: The snapshot is retained for the specified number of days.</description></item>
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
        /// <para>The time of day at which to create automatic snapshots. The time is in UTC+8 and in the format of hours. Valid values: 0 to 23, representing 24 points in time from 00:00 to 23:00. For example, 1 represents 01:00.</para>
        /// <para>To create multiple automatic snapshots within a day, specify multiple time points:</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 24 time points.</description></item>
        /// <item><description>Specify multiple time points as a JSON array in the format of <c>&quot;0&quot;, &quot;1&quot;, … &quot;23&quot;</c>. Separate multiple time points with commas (,).</description></item>
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
