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
            /// <para>The key of the filter to use for the query. Set the value to <c>CreationStartTime</c>. You can use <c>Filter.1.Key</c> and <c>Filter.1.Value</c> to query resources that were created after a specific point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter to use for the query. When you specify this parameter, you must also specify the <c>Filter.1.Key</c> parameter. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The additional attributes. Currently, the only valid value is <c>Placement</c>, which you can specify to query the data placement location of the disk.</para>
        /// <remarks>
        /// <para>Currently, only regional redundant disks have a data placement location.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IOPS</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy that is applied to the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-m5e2w2jutw8bv31****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The category of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>all: all disk categories, including all cloud disks, local disks, and elastic ephemeral disks.</para>
        /// </description></item>
        /// <item><description><para>cloud: basic disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_efficiency: ultra disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_ssd: SSD disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_essd: ESSD</para>
        /// </description></item>
        /// <item><description><para>cloud_auto: ESSD AutoPL disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_regional_disk_auto: regional redundant ESSD disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_essd_entry: ESSD Entry disk.</para>
        /// </description></item>
        /// <item><description><para>elastic_ephemeral_disk_standard: Standard elastic ephemeral disk.</para>
        /// </description></item>
        /// <item><description><para>elastic_ephemeral_disk_premium: Premium elastic ephemeral disk.</para>
        /// </description></item>
        /// <item><description><para>local_ssd_pro: I/O-intensive local disk.</para>
        /// </description></item>
        /// <item><description><para>local_hdd_pro: throughput-intensive local disk.</para>
        /// </description></item>
        /// <item><description><para>ephemeral: (Discontinued) local disk.</para>
        /// </description></item>
        /// <item><description><para>ephemeral_ssd: (Discontinued) local SSD disk.</para>
        /// </description></item>
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
        /// <para>Specifies whether to release the automatic snapshots of the disk when the disk is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The automatic snapshots are released.</para>
        /// </description></item>
        /// <item><description><para>false: The automatic snapshots are retained.</para>
        /// </description></item>
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
        /// <para>Specifies whether the disk is released when the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The disk is released with the instance.</para>
        /// </description></item>
        /// <item><description><para>false: The disk is retained as a pay-as-you-go data disk and is not released.</para>
        /// </description></item>
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
        /// <item><description><para>PrePaid: subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud disks, local disks, or elastic ephemeral disks. The value is a JSON array of up to 100 disk IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d-bp67acfmxazb4p****&quot;, &quot;d-bp67acfmxazb4g****&quot;, … &quot;d-bp67acfmxazb4d****&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The type of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>all: both system disks and data disks.</para>
        /// </description></item>
        /// <item><description><para>system: only system disks.</para>
        /// </description></item>
        /// <item><description><para>data: only data disks.</para>
        /// </description></item>
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
        /// <para>Specifies whether to perform a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Performs a dry run to check the request\&quot;s validity, including AccessKey authentication, permissions, and required parameters. If the request is valid, the <c>DryRunOperation</c> error code is returned. Otherwise, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para>false: Sends the request. If the request is valid, a 2xx HTTP status code is returned and the resources are queried.</para>
        /// </description></item>
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
        /// <para>Specifies whether the automatic snapshot policy feature is enabled for the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The feature is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: The feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is deprecated. The automatic snapshot policy feature is enabled by default for all disks. You only need to apply an automatic snapshot policy to a disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether an automatic snapshot policy is applied to the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: An automatic snapshot policy is applied.</para>
        /// </description></item>
        /// <item><description><para>false: No automatic snapshot policy is applied to the disk.</para>
        /// </description></item>
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
        /// <para>Specifies whether the disk is a shared block storage device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableShared")]
        [Validation(Required=false)]
        public bool? EnableShared { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only encrypted disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Only encrypted disks are queried.</para>
        /// </description></item>
        /// <item><description><para>false: The query includes both encrypted and unencrypted disks.</para>
        /// </description></item>
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
        /// <para>The ID of the instance to which the disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4q****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key that is used to encrypt the cloud disk.</para>
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
        /// <item><description><para>financial: The disk is locked due to overdue payments.</para>
        /// </description></item>
        /// <item><description><para>security: The disk is locked for security reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 10 to 500.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified or is set to a value less than 10, the default value is 10.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to a value greater than 500, the value 500 is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether the multi-attach feature is enabled for the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Disabled: The multi-attach feature is disabled.</para>
        /// </description></item>
        /// <item><description><para>Enabled: The multi-attach feature is enabled.</para>
        /// </description></item>
        /// <item><description><para>LegacyShared: Used to query shared block storage devices.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        /// <summary>
        /// <para>The token used to start the next query. To retrieve the next page of results, set this parameter to the <c>NextToken</c> value returned from the previous call.</para>
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
        /// <para>This parameter is deprecated. Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paged queries instead.</para>
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
        /// <para>This parameter is deprecated. Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paged queries instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is detachable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The disk is detachable. A detachable disk can exist independently and can be attached to or detached from an instance within the same availability zone.</para>
        /// </description></item>
        /// <item><description><para>false: The disk is not detachable. Its lifecycle is bound to the instance to which it is attached.</para>
        /// </description></item>
        /// </list>
        /// <para>The <c>Portable</c> attribute for the following disk types is always <c>false</c>, and their lifecycles are bound to the instances to which they are attached:</para>
        /// <list type="bullet">
        /// <item><description><para>Local disks</para>
        /// </description></item>
        /// <item><description><para>Local SSD disks</para>
        /// </description></item>
        /// <item><description><para>Subscription data disks</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Portable")]
        [Validation(Required=false)]
        public bool? Portable { get; set; }

        /// <summary>
        /// <para>The ID of the region where the disk resides. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the disk belongs. When you use this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>You cannot filter resources in the default resource group.</para>
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
        /// <para>The ID of the snapshot that was used to create the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The state of the disk. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk states</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>In_use: The disk is in use.</para>
        /// </description></item>
        /// <item><description><para>Available: The disk is ready for attachment.</para>
        /// </description></item>
        /// <item><description><para>Attaching: The disk is being attached.</para>
        /// </description></item>
        /// <item><description><para>Detaching: The disk is being detached.</para>
        /// </description></item>
        /// <item><description><para>Creating: The disk is being created.</para>
        /// </description></item>
        /// <item><description><para>ReIniting: The disk is being re-initialized.</para>
        /// </description></item>
        /// <item><description><para>All: all disk states.</para>
        /// </description></item>
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
            /// <para>The tag key of the disk.</para>
            /// <remarks>
            /// <para>For better compatibility, we recommend that you use the <c>Tag.N.Key</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
