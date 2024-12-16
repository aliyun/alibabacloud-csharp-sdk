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
            /// <para>The key of filter 1 used to query resources. Set the value to <c>CreationStartTime</c>. You can specify a time by setting both <c>Filter.1.Key</c> and <c>Filter.1.Value</c> to query resources that were created after the specified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of filter 1 used to query resources. Set the value to a time. If you specify this parameter, you must also specify the <c>Filter.1.Key</c> parameter. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The additional attributes. Set the value to <c>Placement</c>, which indicates the data storage locations of the disk.</para>
        /// <remarks>
        /// <para> This attribute is valid only for Regional Enterprise SSDs (ESSDs).</para>
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
        /// <item><description>all: all disk categories</description></item>
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD)</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
        /// <item><description>local_ssd_pro: I/O-intensive local disk</description></item>
        /// <item><description>local_hdd_pro: throughput-intensive local disk</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: premium elastic ephemeral disk</description></item>
        /// <item><description>ephemeral: retired local disk</description></item>
        /// <item><description>ephemeral_ssd: retired local SSD</description></item>
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
        /// <para>Specifies whether to delete the automatic snapshots of the cloud disk after the disk is released.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is released when the associated instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released when the associated instance is released.</description></item>
        /// <item><description>false: The disk is retained as a pay-as-you-go data disk when the associated instance is released.</description></item>
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
        /// <item><description>PrePaid: subscription</description></item>
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of cloud disks, local disks, or elastic ephemeral disks. The value is a JSON array that consists of up to 100 disk IDs. Separate the disk IDs with commas (,).</para>
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
        /// <item><description>all: system disk and data disk</description></item>
        /// <item><description>system: system disk</description></item>
        /// <item><description>data: data disk</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// <remarks>
        /// <para> Elastic ephemeral disks cannot be used as system disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The systems checks whether your AccessKey pair is valid, whether RAM users are granted permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic snapshot policy feature for the cloud disk.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, the automatic snapshot policy feature is enabled for cloud disks that are already created. Additionally, only the automatic snapshot policy needs to be applied to a cloud disk before you can use the automatic snapshot policy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether an automatic snapshot policy is applied to the cloud disk.</para>
        /// <list type="bullet">
        /// <item><description>true: An automatic snapshot policy is applied to the cloud disk.</description></item>
        /// <item><description>false: No automatic snapshot policy is applied to the cloud disk.</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutomatedSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? EnableAutomatedSnapshotPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is a Shared Block Storage device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableShared")]
        [Validation(Required=false)]
        public bool? EnableShared { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only encrypted cloud disks.</para>
        /// <list type="bullet">
        /// <item><description>true: queries only encrypted cloud disks.</description></item>
        /// <item><description>false: does not query encrypted cloud disks.</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Compute Service (ECS) instance to which the disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4q****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used by the cloud disk.</para>
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
        /// <item><description>security: The disk is locked due to security reasons.</description></item>
        /// <item><description>recycling: The preemptible instance is locked and pending release.</description></item>
        /// <item><description>dedicatedhostfinancial: The instance is locked due to overdue payments for the dedicated host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>recycling</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 10 to 500.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter or you set this parameter to a value less than 10, the default value is 10.</description></item>
        /// <item><description>If you set this parameter to a value greater than 500, the default value is 500.</description></item>
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
        /// <item><description>Disabled: The multi-attach feature is not enabled for the disk.</description></item>
        /// <item><description>Enabled: The multi-attach feature is enabled for the disk.</description></item>
        /// <item><description>LegacyShared: Shared Block Storage devices are queried.</description></item>
        /// </list>
        /// <para>The multi-attach feature is available to select users. To use this feature, <a href="https://workorder-intl.console.aliyun.com/console.htm#/ticket/list">submit a ticket</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the <c>NextToken</c> value that was returned in the last call to this operation.</para>
        /// <para>For more information about how to check the responses returned by this operation, see the preceding &quot;Description&quot; section.</para>
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
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is removable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is removable. A removable disk can independently exist and can be attached to or detached from an instance within the same zone.</description></item>
        /// <item><description>false: The disk is not removable. A disk that is not removable cannot independently exist or be attached to or detached from an instance within the same zone.</description></item>
        /// </list>
        /// <para>The <c>Portable</c> attribute of the following types of disks is <c>false</c>, and these types of disks share the same lifecycle with their associated instances:</para>
        /// <list type="bullet">
        /// <item><description>Local disks</description></item>
        /// <item><description>Local SSDs</description></item>
        /// <item><description>Subscription data disks</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Portable")]
        [Validation(Required=false)]
        public bool? Portable { get; set; }

        /// <summary>
        /// <para>The region ID of the disk. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the disk belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.</para>
        /// <remarks>
        /// <para> Resources in the default resource group are displayed in the response regardless of the value specified for this parameter.</para>
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
        /// <para>The ID of the snapshot from which you create the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The status of the disk. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk states</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In_use</description></item>
        /// <item><description>Available</description></item>
        /// <item><description>Attaching</description></item>
        /// <item><description>Detaching</description></item>
        /// <item><description>Creating</description></item>
        /// <item><description>ReIniting</description></item>
        /// <item><description>All</description></item>
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
            /// <para>The key of tag N of the disk. Valid values of N: 1 to 20.</para>
            /// <para>If you specify a single tag to query resources, up to 1,000 resources to which the tag is added are returned. If you specify multiple tags to query resources, up to 1,000 resources to which all specified tags are added are returned. To query more than 1,000 resources that have specified tags added, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the disk. Valid values of N: 1 to 20.</para>
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
