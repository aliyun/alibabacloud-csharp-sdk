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
            /// The key of filter 1 used to query resources. Set the value to `CreationStartTime`. You can specify a time by setting both `Filter.1.Key` and `Filter.1.Value` to query resources that were created after the time.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of filter 1 used to query resources. Set the value to a time. If you specify this parameter, you must also specify the `Filter.1.Key` parameter. Specify the time in the `yyyy-MM-ddTHH:mmZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The values of attributes.
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// The ID of the automatic snapshot policy that is applied to the cloud disk.
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// The category of the disk. Valid values:
        /// 
        /// * all: all disk categories
        /// * cloud: basic disk
        /// * cloud_efficiency: ultra disk
        /// * cloud_ssd: standard SSD
        /// * cloud_essd: enhanced SSD (ESSD)
        /// * local\_ssd_pro: I/O-intensive local disk
        /// * local\_hdd_pro: throughput-intensive local disk
        /// * ephemeral: retired local disk
        /// * ephemeral_ssd: retired local SSD
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// Specifies whether to delete the automatic snapshots of the cloud disk when the disk is released.
        /// 
        /// *   true: The automatic snapshots of the cloud disk are deleted when the disk is released.
        /// *   false: The automatic snapshots of the cloud disk are not deleted when the disk is released.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// Specifies whether to release the cloud disk when its associated instance is released. Valid values:
        /// 
        /// *   true: The cloud disk is released when its associated instance is released.
        /// *   false: The cloud disk is not released but is retained as a pay-as-you-go data disk when its associated instance is released.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The billing method of the disk. Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// The IDs of disks. The value is a JSON array that consists of up to 100 disk IDs. Separate the disk IDs with commas (,).
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// The name of the disk.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// The type of the disk. Valid values:
        /// 
        /// *   all: system disk and data disk
        /// *   system: system disk
        /// *   data: data disk
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// Specifies whether to check the validity of the request without actually making the request. Valid values:
        /// 
        /// *   true: The validity of the request is checked but the request is not made. Check items include whether your AccessKey pair is valid, whether Resource Access Management (RAM) users are granted required permissions, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the `DryRunOperation` error code is returned.
        /// *   false: The validity of the request is checked. If the check succeeds, a 2XX HTTP status code is returned, and the request is made.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether the automatic snapshot policy feature is enabled for the cloud disk.
        /// 
        /// *   true: The automatic snapshot policy feature is enabled for the cloud disk.
        /// *   false: The automatic snapshot policy feature is not enabled for the cloud disk.
        /// 
        /// >  By default, the automatic snapshot policy feature is enabled for created cloud disks. You only need to apply an automatic snapshot policy to a cloud disk before you can use the automatic snapshot policy.
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        /// <summary>
        /// Specifies whether an automatic snapshot policy is applied to the cloud disk.
        /// 
        /// *   true: An automatic snapshot policy is applied to the cloud disk.
        /// *   false: No automatic snapshot policy is applied to the cloud disk.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("EnableAutomatedSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? EnableAutomatedSnapshotPolicy { get; set; }

        /// <summary>
        /// Specifies whether the disk is a Shared Block Storage device.
        /// </summary>
        [NameInMap("EnableShared")]
        [Validation(Required=false)]
        public bool? EnableShared { get; set; }

        /// <summary>
        /// Specifies whether to query only encrypted cloud disks.
        /// 
        /// *   true: queries only encrypted cloud disks.
        /// *   false: does not query encrypted cloud disks.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the instance to which the disk is attached.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key used by the cloud disk.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// The reason why the disk is locked. Valid values:
        /// 
        /// *   financial: The disk is locked due to overdue payments.
        /// *   security: The disk is locked due to security reasons.
        /// *   recycling: The preemptible instance is locked and pending release.
        /// *   dedicatedhostfinancial: The instance is locked due to overdue payments for the dedicated host.
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 1 to 500.
        /// 
        /// Default value:
        /// 
        /// *   If this parameter is not specified or is set to a value smaller than 10, the default value is 10.
        /// *   If this parameter is set to a value greater than 500, the default value is 500.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Specifies whether the multi-attach feature is enabled for the disk. Valid values:
        /// 
        /// *   Disabled: The multi-attach feature is not enabled for the disk.
        /// *   Enabled: The multi-attach feature is enabled for the disk.
        /// *   LegacyShared: Shared Block Storage devices are queried.
        /// 
        /// The multi-attach feature is in invitational preview. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/console.htm#/ticket/list).
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value returned in the last call to the Describedisks operation.
        /// 
        /// For more information about how to check the responses returned by this operation, see the preceding "Description" section.
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
        /// The number of the page to return.
        /// 
        /// Page start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the disk is removable. Valid values:
        /// 
        /// *   true: The disk is removable. A removable disk can independently exist and can be attached to or detached from an instance within the same zone.
        /// *   false: The disk is not removable. A disk that is not removable cannot independently exist or be attached to or detached from an instance within the same zone.
        /// 
        /// The `Portable` attribute of the following disks is `false`, and these disks share the same lifecycle with their associated instances:
        /// 
        /// *   Local disks
        /// *   Local SSDs
        /// *   Subscription data disks
        /// </summary>
        [NameInMap("Portable")]
        [Validation(Required=false)]
        public bool? Portable { get; set; }

        /// <summary>
        /// The region ID of the disk. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the disk belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.
        /// 
        /// >  Resources in the default resource group are displayed in the response regardless of how this parameter is set.
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
        /// The ID of the snapshot that was used to create the cloud disk.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The state of the cloud disk. For more information, see [Disk states](~~25689~~). Valid values:
        /// 
        /// * In_use
        /// * Available
        /// * Attaching
        /// * Detaching
        /// * Creating
        /// * ReIniting
        /// * All
        /// 
        /// Default value: All.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestTag> Tag { get; set; }
        public class DescribeDisksRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the disk. Valid values of N: 1 to 20.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](~~110425~~) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the disk. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID of the disk.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
