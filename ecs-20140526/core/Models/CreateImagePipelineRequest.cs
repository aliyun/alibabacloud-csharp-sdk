// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// The IDs of Alibaba Cloud accounts with which you want to share the image that is created based on the image template. You can specify up to 20 account IDs.
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        /// <summary>
        /// The source image.
        /// 
        /// *   If you set the `BaseImageType` parameter to IMAGE, set the BaseImage parameter to the ID of a custom image.
        /// *   If you set the `BaseImageType` parameter to IMAGE_FAMILY, set the BaseImage parameter to the name of an image family.
        /// </summary>
        [NameInMap("BaseImage")]
        [Validation(Required=false)]
        public string BaseImage { get; set; }

        /// <summary>
        /// The type of the source image. Valid values:
        /// 
        /// *   IMAGE: image
        /// *   IMAGE_FAMILY: image family
        /// </summary>
        [NameInMap("BaseImageType")]
        [Validation(Required=false)]
        public string BaseImageType { get; set; }

        /// <summary>
        /// The content of the image template. The content cannot exceed 16 KB in size and can contain up to 127 commands. For information about the commands that are supported by the image template, see the "Usage notes" section in this topic.
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. **The token can contain only ASCII characters and cannot exceed 64 characters in length.** For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to release the intermediate instance if the image cannot be created. Valid values:
        /// 
        /// *   true: releases the intermediate instance if the image cannot be created.
        /// *   false: does not release the intermediate instance if the image cannot be created.
        /// 
        /// Default value: true.
        /// 
        /// > If the intermediate instance cannot be started, the instance is automatically released.
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// The description of the image template. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The prefix of the image name. The prefix must be 2 to 64 characters in length. The prefix must start with a letter but cannot start with `http://` or `https://`. The prefix can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// 
        /// The system generates the final image name that consists of the specified prefix and the ID of the build task (`ExecutionId`) in the `{ImageName}_{ExecutionId}` format.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The instance type. You can call the [DescribeInstanceTypes](~~25620~~) to query supported instance types.
        /// 
        /// If you do not specify this parameter, an instance type that provides the fewest vCPUs and memory resources is selected. This configuration is subject to the resource availability of instance types. For example, the ecs.g6.large instance type is selected. If the available ecs.g6.large resources are insufficient, the ecs.g6.xlarge instance type is selected.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The size of the outbound public bandwidth of the intermediate instance. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// The name of the image template. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// 
        /// > If you do not specify the `Name` parameter, the value of the `ImagePipelineId` return parameter is used.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the image template that you want to create. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The size of the system disk of the intermediate instance. Unit: GiB. Valid values: 20 to 500.
        /// 
        /// Default value: 40.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The tags that you want to add to the image template.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// The keys of tags. You can specify up to 20 tag keys. The tag key cannot be an empty string. The tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The values of tags. You can specify up to 20 tag values. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The IDs of regions to which you want to distribute the image that is created based on the image template. You can specify up to 20 region IDs.
        /// 
        /// If you do not specify this parameter, the image is created only in the current region.
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// If you do not specify this parameter, a new virtual private cloud (VPC) and vSwitch are created by default. Make sure that the VPC quota of your account is sufficient. For more information, see [Limits](~~27750~~).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
