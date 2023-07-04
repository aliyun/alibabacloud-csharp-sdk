// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the VPC to which the vSwitch belongs.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The details about the vSwitch.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the vSwitch. Valid values:
        /// 
        /// *   **Pending**: The vSwitch is being configured.
        /// *   **Available**: The vSwitch is available.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The time when the vSwitch was created.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public long? AvailableIpAddressCount { get; set; }

                /// <summary>
                /// The ID of the zone to which the vSwitch belongs.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The ID of the network access control list (ACL).
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The IPv6 CIDR block of the vSwitch.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The key of the tag that is added to the vSwitch.
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs.
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The IPv4 CIDR block of the vSwitch.
                /// </summary>
                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                /// <summary>
                /// The description of the vSwitches.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The name of the vSwitch.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RouteTable")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable RouteTable { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                    [NameInMap("RouteTableType")]
                    [Validation(Required=false)]
                    public string RouteTableType { get; set; }

                }

                [NameInMap("ShareType")]
                [Validation(Required=false)]
                public string ShareType { get; set; }

                /// <summary>
                /// The number of available IP addresses in the vSwitch.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The information about the route table.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchTags Tags { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag> Tag { get; set; }
                    public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag : TeaModel {
                        /// <summary>
                        /// The ID of the route table that is associated with the vSwitch.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The type of the route table that is associated with the vSwitch. Valid values:
                        /// 
                        /// - **System**: system route table
                        /// - **Custom**: custom route table
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the resource group to which the vSwitch belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The value of the tag that is added to the vSwitch.
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                /// <summary>
                /// Indicates whether the vSwitch is the default vSwitch. Valid values:
                /// 
                /// *   **true**: The vSwitch is the default vSwitch.
                /// *   **false**: The vSwitch is not the default vSwitch.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The tag information about the vSwitch.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
