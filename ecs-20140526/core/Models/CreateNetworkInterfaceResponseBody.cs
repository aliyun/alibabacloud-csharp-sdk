// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfaceResponseBody : TeaModel {
        /// <summary>
        /// The description of the ENI.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The IPv4 prefixes assigned to the ENI.
        /// </summary>
        [NameInMap("Ipv4PrefixSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv4PrefixSets Ipv4PrefixSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv4PrefixSets : TeaModel {
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                /// <summary>
                /// The IPv4 prefix assigned to the ENI.
                /// </summary>
                [NameInMap("Ipv4Prefix")]
                [Validation(Required=false)]
                public string Ipv4Prefix { get; set; }

            }

        }

        /// <summary>
        /// The IPv6 prefixes assigned to the ENI.
        /// </summary>
        [NameInMap("Ipv6PrefixSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6PrefixSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                /// <summary>
                /// The IPv6 prefix assigned to the ENI.
                /// </summary>
                [NameInMap("Ipv6Prefix")]
                [Validation(Required=false)]
                public string Ipv6Prefix { get; set; }

            }

        }

        /// <summary>
        /// The IPv6 addresses assigned to the ENI.
        /// </summary>
        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set : TeaModel {
                /// <summary>
                /// The IPv6 address assigned to the ENI.
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

        }

        /// <summary>
        /// The media access control (MAC) address of the ENI.
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// The name of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The ID of the account to which the ENI belongs.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The private IP address of the ENI.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The private IP addresses.
        /// </summary>
        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                /// <summary>
                /// Indicates whether the private IP address is the primary private IP address.
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// The private IP address of the instance.
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the ENI belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The IDs of the security groups to which the ENI belongs.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class CreateNetworkInterfaceResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// The ID of the distributor to which the ENI belongs.
        /// </summary>
        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        /// <summary>
        /// Indicates whether the user of the ENI is an Alibaba Cloud service or a distributor.
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The state of the ENI.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the ENI.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyTags Tags { get; set; }
        public class CreateNetworkInterfaceResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyTagsTag> Tag { get; set; }
            public class CreateNetworkInterfaceResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The type of the ENI.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the ENI is connected.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the ENI belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the ENI.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
