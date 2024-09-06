// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// The scenario in which the image is used. Valid values:
        /// 
        /// *   CreateEcs: instance creation
        /// *   ChangeOS: replacement of the system disk or OS
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The architecture of the image. Valid values:
        /// 
        /// *   i386
        /// *   x86_64
        /// *   arm64
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run without performing the actual request.
        /// 
        /// *   true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
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
            /// The key of the filter condition used to query resources. Valid values:
            /// 
            /// *   If you set this parameter to `CreationStartTime`, you can query the resources that were created after the point in time specified by the `Filter.N.Value` value.
            /// *   If you set this parameter to `CreationEndTime`, you can query the resources that were created before the point in time as specified by the `Filter.N.Value` value.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of filter N used to query resources. When you specify this parameter, you must also specify `Filter.N.Key`. Make sure the time is in the `yyyy-MM-ddTHH:mmZ` format and in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the image family. You can set this parameter to query images of the specified image family.
        /// 
        /// This parameter is empty by default.
        /// 
        /// >  For information about image families that are associated with Alibaba Cloud official images, see [Overview of public images](https://help.aliyun.com/document_detail/108393.html).
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// The image IDs.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The image name.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The image source. Valid values:
        /// 
        /// *   system: images that are provided by Alibaba Cloud and are not released in Alibaba Cloud Marketplace, which are different from public images in the Elastic Compute Service (ECS) console.
        /// 
        /// *   self: your custom images
        /// 
        /// *   others: shared images (images shared by other Alibaba Cloud accounts) and community images (publicly available custom images that are published by other Alibaba Cloud accounts). Take note of the following items:
        /// 
        ///     *   To query community images, you must set IsPublic to true.
        ///     *   To query shared images, you must set IsPublic to false or leave IsPublic empty.
        /// 
        /// *   marketplace: images released by Alibaba Cloud or independent software vendors (ISVs) in the Alibaba Cloud Marketplace, which must be purchased together with ECS instances. Take note of the billing details of the images.
        /// 
        /// This parameter is empty by default.
        /// 
        /// > By default, this parameter is empty, which indicates that the following images are queried: public images provided by Alibaba Cloud, custom images in your repository, shared images from other Alibaba Cloud accounts, and community images that are published by other Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the image belongs. This parameter takes effect only if you query shared images or community images.
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
        /// Specifies whether to query published community images. Valid values:
        /// 
        /// *   true: queries published community images. When you set this parameter to true, you must set ImageOwnerAlias to others.
        /// *   false: queries image types other than the community images type. The specific image types to be queried are determined by the ImageOwnerAlias value.
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
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the image. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the custom image belongs. If you specify this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be returned.
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
        /// Specifies whether the subscription image has expired.
        /// 
        /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
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
        /// The status of the image. By default, if you do not specify this parameter, only images in the Available state are returned. Valid values:
        /// 
        /// *   Creating: The image is being created.
        /// *   Waiting: The image is waiting to be processed.
        /// *   Available: The image is available.
        /// *   UnAvailable: The image is unavailable.
        /// *   CreateFailed: The image failed to be created.
        /// *   Deprecated: The image is deprecated.
        /// 
        /// Default value: Available. You can specify multiple values for this parameter. Separate the values with commas (,).
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestTag> Tag { get; set; }
        public class DescribeImagesRequestTag : TeaModel {
            /// <summary>
            /// The tag N key of the image. Valid values of N: 1 to 20.
            /// 
            /// Up to 1,000 resources that match the specified tags can be returned in the response. To query more than 1,000 resources that match the specified tags, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
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
        /// Specifies whether the image is running on an Elastic Compute Service (ECS) instance. Valid values:
        /// 
        /// *   instance: The image is already in use and running on an ECS instance.
        /// *   none: The image is idle.
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
