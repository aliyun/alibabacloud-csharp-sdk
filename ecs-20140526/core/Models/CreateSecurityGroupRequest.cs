// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. **The token can contain only ASCII characters and cannot exceed 64 characters in length.** For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the security group. The description must be 2 to 256 characters in length. It cannot start with `http://` or `https://`.
        /// 
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the security group. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the security group belongs.
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
        /// The name of the security group. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain Unicode characters under the Decimal Number category and the categories whose names contain Letter. The name can also contain colons (:), underscores (_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// The type of the security group. Valid values:
        /// 
        /// *   normal: basic security group.
        /// *   enterprise: advanced security group. For more information, see [Advanced security groups](https://help.aliyun.com/document_detail/120621.html).
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The tags to add to the security group.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSecurityGroupRequestTag> Tag { get; set; }
        public class CreateSecurityGroupRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the security group.
            /// 
            /// Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the security group.
            /// 
            /// Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the VPC in which you want to create the security group.
        /// 
        /// > The VpcId parameter is required only if you want to create security groups of the VPC type. In regions that support the classic network, you can create security groups of the classic network type without the need to specify the VpcId parameter.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
