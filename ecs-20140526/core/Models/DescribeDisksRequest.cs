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
            /// The key of filter 1 used to query resources. Set the value to `CreationStartTime`. You can specify a time by setting both `Filter.1.Key` and `Filter.1.Value` to query resources that were created after the specified time.
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
        /// The attribute value. Set the value to IOPS, which indicates the maximum IOPS of the disk.
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
        /// *   all: all disk categories
        /// *   cloud: basic disk
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: standard SSD
        /// *   cloud_essd: enhanced SSD (ESSD)
        /// *   cloud_auto: ESSD AutoPL disk
        /// *   local_ssd_pro: I/O-intensive local disk
        /// *   local_hdd_pro: throughput-intensive local disk
        /// *   cloud_essd_entry: ESSD Entry disk
        /// *   ephemeral: retired local disk
        /// *   ephemeral_ssd: retired local SSD
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// Specifies whether to delete the automatic snapshots of the cloud disk after the disk is released.
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// Specifies whether to release the cloud disk when its associated instance is released. Valid values:
        /// 
        /// *   true: The cloud disk is released when its associated instance is released.
        /// *   false: The cloud disk is not released but is retained as a pay-as-you-go data disk after its associated instance is released.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The disk billing method. Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// The of disk IDs. The value is a JSON array that consists of up to 100 disk IDs. Separate the disk IDs with commas (,).
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// The cloud disk or local disk name.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// The disk type. Valid values:
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
        /// Specifies whether to perform only a dry run without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The systems checks whether your AccessKey pair is valid, whether RAM users are granted permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable the automatic snapshot policy feature for the cloud disk.
        /// 
        /// *   true
        /// *   false
        /// 
        /// > By default, the automatic snapshot policy feature is enabled for cloud disks that are already created. Additionally, only the automatic snapshot policy needs to be applied to a cloud disk before you can use the automatic snapshot policy.
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
        /// Default value: false
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
        /// Default value: false
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the instance to which the cloud disk or local disk is attached.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that is used by the cloud disk.
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
        /// *   dedicatedhostfinancial: The ECS instance is locked due to overdue payments of the dedicated host.
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 10 to 500.
        /// 
        /// Default value:
        /// 
        /// *   If you do not specify this parameter or you set this parameter to a value less than 10, the default value is 10.
        /// *   If you set this parameter to a value greater than 500, the default value is 500.
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
        /// The multi-attach feature is available to select users. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/console.htm#/ticket/list).
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value that was returned in the last call to this operation.
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
        /// The page number to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return per page.
        /// 
        /// Maximum value: 100.
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
        /// *   false: The disk is not removable. A disk that is not removable cannot independently exist nor can it be attached to or detached from an instance within the same zone.
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
        /// The ID of the resource group to which the disk belongs. If you specify this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be returned.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of whether you specify this parameter.
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
        /// The ID of the snapshot from which you create the cloud disk.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The state of the cloud disk. For more information, see [Disk states](~~25689~~). Valid values:
        /// 
        /// *   In_use
        /// *   Available
        /// *   Attaching
        /// *   Detaching
        /// *   Creating
        /// *   ReIniting
        /// *   All
        /// 
        /// Default value: All.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the disk.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestTag> Tag { get; set; }
        public class DescribeDisksRequestTag : TeaModel {
            /// <summary>
            /// The disk tag key. Valid values of N: 1 to 20.
            /// 
            /// Up to 1,000 resources that match the specified tags can be returned in the response. To query more than 1,000 resources that match the specified tags, call the [ListTagResources](~~110425~~) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The disk tag value. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
