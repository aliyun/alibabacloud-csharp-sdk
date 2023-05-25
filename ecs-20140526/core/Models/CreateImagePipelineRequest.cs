// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template. You can specify up to 20 account IDs.
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        /// <summary>
        /// The source image.
        /// 
        /// *   If you set `BaseImageType` to IMAGE, set the BaseImage parameter to the ID of a custom image.
        /// *   If you set `BaseImageType` to IMAGE_FAMILY, set the BaseImage parameter to the name of an image family.
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
        /// The content of the image template. The content cannot exceed 16 KB in size and can contain up to 127 commands. For more information about the commands that are supported, see the "Usage notes" section of this topic.
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to release the intermediate instance when the image cannot be created. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: true.
        /// 
        /// > If the intermediate instance cannot be started, the instance is released by default.
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// The description of the image template. The description must be 2 to 256 characters in length. It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The prefix of the image name. The prefix must be 2 to 64 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// 
        /// The system generates the final complete image name that consists of the specified prefix and the ID of the build task (`ExecutionId`) in the format of `{ImageName}_{ExecutionId}`.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The instance type. You can call the [DescribeInstanceTypes](~~25620~~) to query instance types.
        /// 
        /// If you do not configure this parameter, an instance type that provides the fewest vCPUs and memory resources is automatically selected. This configuration is subject to resource availability of instance types. For example, the ecs.g6.large instance type is automatically selected. If available ecs.g6.large resources are insufficient, the ecs.g6.xlarge instance type is selected.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// The name of the image template. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// 
        /// > If you do not specify the `Name` parameter, the return value of `ImagePipelineId` is used.
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
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The system disk size of the intermediate instance. Unit: GiB. Valid values: 20 to 500.
        /// 
        /// Default value: 40.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The tags to add to the template.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value must be 0 to 128 characters in length. It cannot start with `acs:` or contain `http://` or `https://`.
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
        /// If you do not specify this parameter, a new VPC and vSwitch are created. Make sure that the VPC quota in your account is sufficient. For more information, see [Limits and quotas](~~27750~~).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
