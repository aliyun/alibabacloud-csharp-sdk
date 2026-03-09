// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCNetworkInterfacesResponseBody : TeaModel {
        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=false)]
        public List<DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSets> NetworkInterfaceSets { get; set; }
        public class DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSets : TeaModel {
            [NameInMap("AssociatedPublicIp")]
            [Validation(Required=false)]
            public DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsAssociatedPublicIp AssociatedPublicIp { get; set; }
            public class DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsAssociatedPublicIp : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><c>116.62.**.**</c></para>
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-25T12:31:31Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DescriptionTest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rc-m5sc1271fv344a1r****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ipv6Sets")]
            [Validation(Required=false)]
            public List<DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsIpv6Sets> Ipv6Sets { get; set; }
            public class DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsIpv6Sets : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2408:4321:180:1701:94c7:bc38:3bfa:****</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00:16:3e:12:<b>:</b></para>
            /// </summary>
            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eni-bp125p95hhdhn3ot****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("PrivateIpSets")]
            [Validation(Required=false)]
            public List<DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsPrivateIpSets> PrivateIpSets { get; set; }
            public class DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsPrivateIpSets : TeaModel {
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><c>172.17.**.**</c></para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-2ze88m67qx5z****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsTags> Tags { get; set; }
            public class DescribeRCNetworkInterfacesResponseBodyNetworkInterfaceSetsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Secondary</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp16usj2p27htro3****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp1j7w3gc1cexjqd****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
