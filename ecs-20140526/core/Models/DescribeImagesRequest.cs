// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// The scenario in which to use the image. Default value: CreateEcs. Valid values:
        /// 
        /// *   CreateEcs: creates an instance.
        /// *   ChangeOS: replaces the system disk or operating system.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The architecture of the image. Valid values:
        /// 
        /// *   i386
        /// *   x86\_64
        /// *   arm64
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run.
        /// 
        /// *   true: performs a dry run. The system checks your AccessKey pair, the permissions of the RAM user, and the required parameters. If the request fails the dry run, the corresponding error message is returned. If the check passes the dry run, the DryRunOperation error code is returned.
        /// *   false: performs a dry run and sends the request. If the request passes the dry run, a 2XX HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The list of filter conditions used to query resources.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestFilter> Filter { get; set; }
        public class DescribeImagesRequestFilter : TeaModel {
            /// <summary>
            /// The key of the filter that is used to query resources. Valid values:
            /// 
            /// *   If you set this parameter to `CreationStartTime`, you can query the resources that were created after the point in time specified by the `Filter.N.Value` parameter.
            /// *   If you set this parameter to `CreationEndTime`, you can query the resources that were created before the point in time specified by the `Filter.N.Value` parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter that is used to query resources. When you specify this parameter, you must also specify the `Filter.N.Key` parameter. Specify the time in the `yyyy-MM-ddTHH:mmZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the image family. You can specify this parameter to query images of the specified image family.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// The IDs of the images.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the image.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The source of the image. Valid values:
        /// 
        /// *   system: public images provided by Alibaba Cloud. These are not available in Alibaba Cloud Marketplace.
        /// 
        /// *   self: custom images that you create.
        /// 
        /// *   others: shared images from other Alibaba Cloud accounts and community images that image providers released on the image platform of Alibaba Cloud Community. When you call this operation, take note of the following items:
        /// 
        ///     *   To query community images, you must set the IsPublic parameter to true.
        ///     *   To query shared images, you must set the IsPublic parameter to false or leave the IsPublic parameter empty.
        /// 
        /// *   marketplace: an image maintained by Alibaba Cloud or Independent Software Vendors (ISVs) in the Alibaba Cloud Marketplace. These images need to be purchased together with an Elastic Compute Service (ECS) instance. Before you use Alibaba Cloud Marketplace images, take note of the billing details of the images.
        /// 
        /// This parameter is empty by default.
        /// 
        /// > This parameter is empty by default, which indicates that public images provided by Alibaba Cloud, custom images in your repository, shared images from other Alibaba Cloud accounts, and community images published by other Alibaba Cloud accounts are queried.
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the image belongs. This parameter is valid only when you query shared images or community images.
        /// </summary>
        [NameInMap("ImageOwnerId")]
        [Validation(Required=false)]
        public long? ImageOwnerId { get; set; }

        /// <summary>
        /// The instance type for which the image can be used.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Indicates whether to query published community images. Valid values:
        /// 
        /// *   true: queries published community images. When you set this parameter to true, you must set the ImageOwnerAlias parameter to others.
        /// *   false: queries image types other than community images. The specific image types to be queried are determined by the ImageOwnerAlias parameter.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Specifies whether the image supports cloud-init.
        /// </summary>
        [NameInMap("IsSupportCloudinit")]
        [Validation(Required=false)]
        public bool? IsSupportCloudinit { get; set; }

        /// <summary>
        /// Specifies whether the image can be used on I/O optimized instances.
        /// </summary>
        [NameInMap("IsSupportIoOptimized")]
        [Validation(Required=false)]
        public bool? IsSupportIoOptimized { get; set; }

        /// <summary>
        /// The operating system type of the image. Valid values:
        /// 
        /// *   windows
        /// *   linux
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
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
        /// The region ID of the image. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the custom image belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group are returned.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of how this parameter is set.
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
        /// Specifies whether the subscription image has expired.
        /// 
        /// > This parameter will be removed in the future. To ensure future compatibility, we recommend that you use other parameters.
        /// </summary>
        [NameInMap("ShowExpired")]
        [Validation(Required=false)]
        public bool? ShowExpired { get; set; }

        /// <summary>
        /// The ID of the snapshot used to create the custom image.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The state of the image. If you do not specify this parameter, only images in the Available state are returned. Valid values:
        /// 
        /// *   Creating: The image is being created.
        /// *   Waiting: The image is waiting to be processed.
        /// *   Available: The image is available. This is the default value.
        /// *   UnAvailable: The image is unavailable.
        /// *   CreateFailed: The image cannot be created.
        /// *   Deprecated: The image is discontinued.
        /// 
        /// Default value: Available. You can specify multiple values for this parameter. Separate the values with commas (,).
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestTag> Tag { get; set; }
        public class DescribeImagesRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the image. Valid values of N: 1 to 20.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added are returned. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added are returned. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](~~110425~~) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the image. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether the image is running on an ECS instance. Valid values:
        /// 
        /// *   instance: The image is in use and running on an ECS instance.
        /// *   none: The image is not in use.
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
