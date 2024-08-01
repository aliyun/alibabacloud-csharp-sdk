// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestFilter> Filter { get; set; }
        public class DescribeSnapshotsRequestFilter : TeaModel {
            /// <summary>
            /// The key of filter 1 that is used to query resources. Set the value to `CreationStartTime`. You can specify a time by configuring both `Filter.1.Key` and `Filter.1.Value` to query resources that were created after the time.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of filter 1 that is used to query resources. Set the value to a time. If you configure this parameter, you must also configure `Filter.1.Key`. Specify the time in the `yyyy-MM-ddTHH:mmZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The category of the snapshot. Valid values:
        /// 
        /// *   Standard: normal snapshot
        /// *   Flash: local snapshot
        /// 
        /// The local snapshot feature is replaced by the instant access feature. When you specify this parameter, take note of the following items:
        /// 
        /// *   If you have used local snapshots before December 14, 2020, you can use this parameter.
        /// *   If you have not used local snapshots before December 14, 2020, you cannot use this parameter.
        /// 
        /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The disk ID.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks your AccessKey pair, the permissions of the RAM user, and the required parameters. If the request passes the dry run, the DryRunOperation error code is returned. Otherwise, an error message is returned.
        /// *   false (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether the snapshot is encrypted. Default value: false.
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that is used for the data disk.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
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
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the disk. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID. If you configure this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of whether you configure this parameter.
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
        /// The IDs of snapshots. You can specify a JSON array that consists of up to 100 snapshot IDs. Separate the snapshot IDs with commas (,).
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIds { get; set; }

        /// <summary>
        /// The snapshot chain ID. You can specify a JSON array that contains up to 100 snapshot chain IDs. Separate the snapshot chain IDs with commas (,).
        /// </summary>
        [NameInMap("SnapshotLinkId")]
        [Validation(Required=false)]
        public string SnapshotLinkId { get; set; }

        /// <summary>
        /// The name of the snapshot.
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// The type of the snapshot. Valid values:
        /// 
        /// *   auto: automatic snapshot
        /// *   user: manual snapshot
        /// *   all (default): all snapshot types
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// The source disk type of the snapshot. Valid values:
        /// 
        /// *   system: system disk.
        /// *   data: data disk.
        /// 
        /// >  The value of this parameter is case-insensitive.
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

        /// <summary>
        /// The status of the snapshot. Valid values:
        /// 
        /// *   progressing: The snapshot is being created.
        /// *   accomplished: The snapshot is created.
        /// *   failed: The snapshot fails to be created.
        /// *   all (default): This value indicates all snapshot states.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the snapshot.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestTag> Tag { get; set; }
        public class DescribeSnapshotsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the snapshot. Valid values of N: 1 to 20
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added are returned. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added are returned. To query more than 1,000 resources with the specified tags, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the snapshot. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether the snapshot has been used to create custom images or disks. Valid values:
        /// 
        /// *   image: The snapshot has been used to create custom images.
        /// *   disk: The snapshot has been used to create disks.
        /// *   image_disk: The snapshot has been used to create both custom images and data disks.
        /// *   none: The snapshot has not been used to create custom images or disks.
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
