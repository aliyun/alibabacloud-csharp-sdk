// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// Details about the ENIs.
        /// </summary>
        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets NetworkInterfaceSets { get; set; }
        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets : TeaModel {
            [NameInMap("NetworkInterfaceSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet> NetworkInterfaceSet { get; set; }
            public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet : TeaModel {
                /// <summary>
                /// The time when the ENI was created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of ENI.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The ID of the instance to which the ENI is bound.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Ipv6Sets")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets Ipv6Sets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets : TeaModel {
                    [NameInMap("Ipv6Set")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set> Ipv6Set { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set : TeaModel {
                        [NameInMap("Ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                    }

                }

                /// <summary>
                /// The MAC address of the ENI.
                /// </summary>
                [NameInMap("MacAddress")]
                [Validation(Required=false)]
                public string MacAddress { get; set; }

                /// <summary>
                /// The ID of the network.
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// The ID of the ENI.
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// The ENI name.
                /// </summary>
                [NameInMap("NetworkInterfaceName")]
                [Validation(Required=false)]
                public string NetworkInterfaceName { get; set; }

                /// <summary>
                /// The private IP address of the server.
                /// </summary>
                [NameInMap("PrimaryIp")]
                [Validation(Required=false)]
                public string PrimaryIp { get; set; }

                /// <summary>
                /// The primary private IP address. Valid values:
                /// 
                /// *   **Public**: public IP address.
                /// *   **Private**: internal IP address.
                /// </summary>
                [NameInMap("PrimaryIpType")]
                [Validation(Required=false)]
                public string PrimaryIpType { get; set; }

                /// <summary>
                /// Details about the private IP address.
                /// </summary>
                [NameInMap("PrivateIpSets")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets PrivateIpSets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets : TeaModel {
                    [NameInMap("PrivateIpSet")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet : TeaModel {
                        /// <summary>
                        /// Specifies whether the private IP address is the primary private IP address. Valid values:
                        /// 
                        /// *   true
                        /// *   false
                        /// </summary>
                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                        /// <summary>
                        /// The private IP address.
                        /// </summary>
                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the security group.
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroup")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroup { get; set; }

                }

                /// <summary>
                /// The status of the ENI. Valid values:
                /// 
                /// *   Available: The ENI is available.
                /// *   Attaching: The ENI is being attached to an instance.
                /// *   InUse: The ENI is attached to an instance.
                /// *   Detaching: The ENI is being detached from an instance.
                /// *   Deleting: The ENI is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the ENI. Valid values:
                /// 
                /// *   Primary
                /// *   Secondary
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries in the list.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
