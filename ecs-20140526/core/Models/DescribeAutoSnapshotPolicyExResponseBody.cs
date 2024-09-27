// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyExResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the automatic snapshot policies.</para>
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
                /// <para>The ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The name of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testAutoSnapshotPolicyName</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyName")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyName { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CopiedSnapshotsRetentionDays")]
                [Validation(Required=false)]
                public int? CopiedSnapshotsRetentionDays { get; set; }

                /// <summary>
                /// <para>Encryption configurations for cross-region snapshot replication.</para>
                /// </summary>
                [NameInMap("CopyEncryptionConfiguration")]
                [Validation(Required=false)]
                public DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyCopyEncryptionConfiguration CopyEncryptionConfiguration { get; set; }
                public class DescribeAutoSnapshotPolicyExResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicyCopyEncryptionConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Whether to enable encryption for cross-region snapshot replication. Valid values:</para>
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
                    /// <para>The ID of the Key Management Service (KMS) key used to encrypt snapshots in cross-region snapshot replication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                    /// </summary>
                    [NameInMap("KMSKeyId")]
                    [Validation(Required=false)]
                    public string KMSKeyId { get; set; }

                }

                /// <summary>
                /// <para>The time when the automatic snapshot policy was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-10T16:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The number of disks to which the automatic snapshot policy is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiskNums")]
                [Validation(Required=false)]
                public int? DiskNums { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableCrossRegionCopy")]
                [Validation(Required=false)]
                public bool? EnableCrossRegionCopy { get; set; }

                /// <summary>
                /// <para>The region ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The days of the week on which to create automatic snapshots. Valid values: 1 to 7, which correspond to the days of the week. For example, 1 indicates Monday. One or more days can be specified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;6&quot;]</para>
                /// </summary>
                [NameInMap("RepeatWeekdays")]
                [Validation(Required=false)]
                public string RepeatWeekdays { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2kkmhmhs****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The retention period of the automatic snapshots. Unit: days. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-1: Automatic snapshots are retained until they are deleted.</description></item>
                /// <item><description>1 to 65536: Auto snapshots are retained for the specified number of days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                /// <summary>
                /// <para>The status of the automatic snapshot policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: The automatic snapshot policy is normal.</description></item>
                /// <item><description>Expire: The automatic snapshot policy cannot be used because your account has overdue payments.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the automatic snapshot policy.</para>
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
                        /// <para>The tag key of the automatic snapshot policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the automatic snapshot policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TargetCopyRegions")]
                [Validation(Required=false)]
                public string TargetCopyRegions { get; set; }

                /// <summary>
                /// <para>The points in time of the day at which to create automatic snapshots.</para>
                /// <para>The time is displayed in UTC+8. Unit: hours. Valid values: 0 to 23, which correspond to the 24 points in time on the hour from 00:00:00 to 23:00:00. For example, 1 indicates 01:00:00. Multiple points in time can be specified.</para>
                /// <para>The parameter value is a JSON array that contains up to 24 points in time separated by commas (,). Example: <c>[&quot;0&quot;, &quot;1&quot;, ... &quot;23&quot;]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;1&quot;]</para>
                /// </summary>
                [NameInMap("TimePoints")]
                [Validation(Required=false)]
                public string TimePoints { get; set; }

                /// <summary>
                /// <para>The type of the automatic snapshot policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom: user-defined snapshot policy.</description></item>
                /// <item><description>System: system-defined snapshot policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The number of extended volumes to which the automatic snapshot policy is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("VolumeNums")]
                [Validation(Required=false)]
                public int? VolumeNums { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of automatic snapshot policies</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
