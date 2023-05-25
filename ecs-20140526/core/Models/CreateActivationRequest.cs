// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationRequest : TeaModel {
        /// <summary>
        /// The maximum number of times that you can use the activation code to register managed instances. Valid values: 1 to 1000.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The validity period of the activation code. The activation code cannot be used to register new instances after the validity period ends. Unit: hours. Valid values: 1 to 24.
        /// 
        /// Default value: 4.
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// The description of the activation code. The description must be 1 to 100 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The tags to add to the activation code.
        /// </summary>
        [NameInMap("IpAddressRange")]
        [Validation(Required=false)]
        public string IpAddressRange { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The default instance name prefix. The instance name prefix must be 1 to 50 characters in length. It must start with a letter and cannot start with `http://` or `https://`. The instance name prefix can contain letters, digits, periods (.), underscores (\_), hyphens (-), and colons (:).
        /// 
        /// If you use the activation code created by calling the CreateActivation operation to register managed instances, the instances are assigned sequential names that are prefixed by the value of this parameter. You can also specify a new instance name to override the assigned sequential name when you register a managed instance.
        /// 
        /// If you use an activation code for which you specify InstanceName to register a managed instance, an instance name in the format of `<InstanceName>-<Number>` is generated. The number of digits in the \<Number> value is determined by that in the `InstanceCount` value. Example: `001`. If you do not specify InstanceName, the hostname (Hostname) is used as the instance name.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tag to add to the activation code.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateActivationRequestTag> Tag { get; set; }
        public class CreateActivationRequestTag : TeaModel {
            /// <summary>
            /// The value of tag N to add to the activation code. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The IP addresses of hosts that are allowed to use the activation code. The value can be IPv4 addresses, IPv6 addresses, or CIDR blocks.
        /// </summary>
        [NameInMap("TimeToLiveInHours")]
        [Validation(Required=false)]
        public long? TimeToLiveInHours { get; set; }

    }

}
