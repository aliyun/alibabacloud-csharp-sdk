// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestFilter> Filter { get; set; }
        public class DescribeDisksRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key used to query resources. Set the value to <c>CreationStartTime</c>. If you specify both <c>Filter.1.Key</c> and <c>Filter.1.Value</c>, you can query resources created after the specified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used to query resources. If you specify this parameter, you must also specify the <c>Filter.1.Key</c> parameter. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of additional attributes. Currently, only <c>Placement</c> is supported, which indicates the data storage location of the disk.</para>
        /// <remarks>
        /// <para>Currently, only regional disks have a data storage location.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IOPS</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-m5e2w2jutw8bv31****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The disk category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: all cloud disks, local disks, and elastic ephemeral disks.</description></item>
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: enterprise SSD.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
        /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: premium elastic ephemeral disk.</description></item>
        /// <item><description>local_ssd_pro: I/O-intensive local disk.</description></item>
        /// <item><description>local_hdd_pro: throughput-intensive local disk.</description></item>
        /// <item><description>ephemeral: (retired) local disk.</description></item>
        /// <item><description>ephemeral_ssd: (retired) local SSD.</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic snapshots are released when the cloud disk is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatic snapshots are released.</description></item>
        /// <item><description>false: Automatic snapshots are not released.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is released together with the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released together with the instance.</description></item>
        /// <item><description>false: The disk is retained and not released. It is converted to a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The billing method of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud disks, local disks, or elastic ephemeral disks. The value is a JSON array that contains up to 100 IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d-bp67acfmxazb4p****&quot;, &quot;d-bp67acfmxazb4g****&quot;, … &quot;d-bp67acfmxazb4d****&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length and can contain Unicode letters, including English letters, Chinese characters, and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The type of the cloud disk, local disk, or elastic ephemeral disk to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: queries both system disks and data disks.</description></item>
        /// <item><description>system: queries only system disks.</description></item>
        /// <item><description>data: queries only data disks.</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// <remarks>
        /// <para>Elastic ephemeral disks cannot be used as system disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: send a check request and do not query resources. The check items include whether the AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: send a Normal request. If the request passes the check, a 2xx HTTP status code is returned and resources are queried.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the automatic snapshot policy feature is enabled for the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The feature is enabled.</description></item>
        /// <item><description>false: The feature is not enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is deprecated. The automatic snapshot policy feature is enabled by default for newly created cloud disks. You only need to apply an automatic snapshot policy to the cloud disk to use the feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether an automatic snapshot policy is applied to the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: An automatic snapshot policy is applied.</description></item>
        /// <item><description>false: No automatic snapshot policy is applied.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutomatedSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? EnableAutomatedSnapshotPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether the block storage device is Shared Block Storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableShared")]
        [Validation(Required=false)]
        public bool? EnableShared { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only encrypted cloud disks. Valid values:</para>
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
        /// <para>The instance ID to which the disk, local disk, or elastic ephemeral disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4q****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key used by the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The reason why the disk is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: The disk is locked due to overdue payments.</description></item>
        /// <item><description>security: The disk is locked for security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 10 to 500.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified or the specified value is less than 10, the default value is 10.</description></item>
        /// <item><description>If the specified value is greater than 500, the default value is 500.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether the multi-attach feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled: The feature is disabled.</description></item>
        /// <item><description>Enabled: The feature is enabled.</description></item>
        /// <item><description>LegacyShared: Used to query shared block storage devices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        /// <summary>
        /// <para>The query token. The value is the <c>NextToken</c> value returned from the previous API call.</para>
        /// <para>For more information about how to configure the returned data for this operation, see the operation description section above.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is about to go offline. We recommend that you use the <c>NextToken</c> and <c>MaxResults</c> parameters to perform paging and complete the paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is about to go offline. We recommend that you use the <c>NextToken</c> and <c>MaxResults</c> parameters to perform paging and complete the paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD disk. Valid values: PL0, PL1, PL2, and PL3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk can be detached. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk can be detached. It can exist independently and can be freely attached and detached within a zone.</description></item>
        /// <item><description>false: The disk cannot be detached. It cannot exist independently and cannot be freely attached or detached within a zone.</description></item>
        /// </list>
        /// <para>The <c>Portable</c> attribute is <c>false</c> for the following types of block storage devices, and their lifecycles are the same as those of the instances:</para>
        /// <list type="bullet">
        /// <item><description>Local disks.</description></item>
        /// <item><description>Local SSDs.</description></item>
        /// <item><description>Subscription data disks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Portable")]
        [Validation(Required=false)]
        public bool? Portable { get; set; }

        /// <summary>
        /// <para>The region ID of the block storage device. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the disk belongs. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>The ID of the snapshot used to create the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The disk status. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk status</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In_use: The disk is in use.</description></item>
        /// <item><description>Available: The disk is available for attachment.</description></item>
        /// <item><description>Attaching: The disk is being attached.</description></item>
        /// <item><description>Detaching: The disk is being detached.</description></item>
        /// <item><description>Creating: The disk is being created.</description></item>
        /// <item><description>ReIniting: The disk is being initialized.</description></item>
        /// <item><description>All: all statuses.</description></item>
        /// </list>
        /// <para>Default value: All.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestTag> Tag { get; set; }
        public class DescribeDisksRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the disk. Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the resource count returned cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that attach multiple tags cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
