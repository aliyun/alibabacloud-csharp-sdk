// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// The new description for the vSwitch.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable the IPv6 feature for the vSwitch. Valid values:
        /// 
        /// *   **true**: enables the IPv6 feature.
        /// *   **false**: disables the IPv6 feature. This is the default value.
        /// </summary>
        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

        /// <summary>
        /// The last eight bits of the IPv6 CIDR block of the vSwitch. Valid values: **0** to **255**.
        /// 
        /// You can set this parameter only when the IPv6 feature is enabled for the virtual private cloud (VPC) to which the vSwitch belongs.
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public int? Ipv6CidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the vSwitch is deployed. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The new name for the vSwitch.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// The IPv6 CIDR block of the VPC to which the vSwitch belongs.
        /// 
        /// You can set this parameter only when the IPv6 feature is enabled for the VPC.
        /// </summary>
        [NameInMap("VpcIpv6CidrBlock")]
        [Validation(Required=false)]
        public string VpcIpv6CidrBlock { get; set; }

    }

}
