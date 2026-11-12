// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAclsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the network ACLs.</para>
        /// </summary>
        [NameInMap("NetworkAcls")]
        [Validation(Required=false)]
        public List<DescribeNetworkAclsResponseBodyNetworkAcls> NetworkAcls { get; set; }
        public class DescribeNetworkAclsResponseBodyNetworkAcls : TeaModel {
            /// <summary>
            /// <para>The time when the network ACL was created. The time is displayed in UTC in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-11-01T06:08:46Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is my NetworkAcl.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The outbound rules.</para>
            /// </summary>
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries> EgressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries : TeaModel {
                /// <summary>
                /// <para>The destination CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The description of the outbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is EgressAclEntries.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the outbound rule entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nae-a2d447uw4tillfvgb****</para>
                /// </summary>
                [NameInMap("NetworkAclEntryId")]
                [Validation(Required=false)]
                public string NetworkAclEntryId { get; set; }

                /// <summary>
                /// <para>The name of the outbound rule entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-2</para>
                /// </summary>
                [NameInMap("NetworkAclEntryName")]
                [Validation(Required=false)]
                public string NetworkAclEntryName { get; set; }

                /// <summary>
                /// <para>The authorization policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b>: Allow.</description></item>
                /// <item><description><b>drop</b>: Deny.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The destination port range of the outbound rule.</para>
                /// <list type="bullet">
                /// <item><description>If the <b>Protocol</b> (Protocol Type) of the outbound rule is <b>all</b> or <b>icmp</b>, the port range is <b>-1/-1</b>, which indicates that all ports are allowed.</description></item>
                /// <item><description>If the <b>Protocol</b> (Protocol Type) of the outbound rule is <b>tcp</b> or <b>udp</b>, the port range is <b>1~65535</b>. The format is <b>1/200</b> or <b>80/80</b>, which indicates ports 1 to 200 or port 80.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the rule. Valid values: <b>1</b> to <b>100</b>. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>icmp</b>: Internet Control Message Protocol.</description></item>
                /// <item><description><b>tcp</b>: Transmission Control Protocol.</description></item>
                /// <item><description><b>udp</b>: User Datagram Protocol.</description></item>
                /// <item><description><b>all</b>: All protocols.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>system</b>: System-created.</description></item>
                /// <item><description><b>custom</b>: User-created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The inbound rules.</para>
            /// </summary>
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries> IngressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries : TeaModel {
                /// <summary>
                /// <para>The source CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The description of the inbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is IngressAclEntries.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The destination CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the inbound rule entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nae-5dk86arlydmezasw****</para>
                /// </summary>
                [NameInMap("NetworkAclEntryId")]
                [Validation(Required=false)]
                public string NetworkAclEntryId { get; set; }

                /// <summary>
                /// <para>The name of the inbound rule entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-3</para>
                /// </summary>
                [NameInMap("NetworkAclEntryName")]
                [Validation(Required=false)]
                public string NetworkAclEntryName { get; set; }

                /// <summary>
                /// <para>The authorization policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b>: Allow.</description></item>
                /// <item><description><b>drop</b>: Deny.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The destination port range of the inbound rule.</para>
                /// <list type="bullet">
                /// <item><description>If the <b>Protocol</b> (Protocol Type) of the inbound rule is <b>all</b> or <b>icmp</b>, the port range is <b>-1/-1</b>, which indicates that all ports are allowed.</description></item>
                /// <item><description>If the <b>Protocol</b> (Protocol Type) of the inbound rule is <b>tcp</b> or <b>udp</b>, the port range is <b>1~65535</b>. The format is <b>1/200</b> or <b>80/80</b>, which indicates ports 1 to 200 or port 80.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the rule. Valid values: <b>1</b> to <b>100</b>. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>icmp</b>: Internet Control Message Protocol.</description></item>
                /// <item><description><b>tcp</b>: Transmission Control Protocol.</description></item>
                /// <item><description><b>udp</b>: User Datagram Protocol.</description></item>
                /// <item><description><b>all</b>: All protocols.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>system</b>: System-created.</description></item>
                /// <item><description><b>custom</b>: User-created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacl-a2do9e413e0spxscd****</para>
            /// </summary>
            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }

            /// <summary>
            /// <para>The name of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-8</para>
            /// </summary>
            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }

            /// <summary>
            /// <para>The associated resources.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsResources> Resources { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsResources : TeaModel {
                /// <summary>
                /// <para>The ENS edge zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-fuzhou-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the associated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the associated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Network</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The status of the associated resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BINDED</b>: Bound.</description></item>
                /// <item><description><b>BINDING</b>: Binding.</description></item>
                /// <item><description><b>UNBINDING</b>: Unbinding.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BINDING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of the network ACL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: Active.</description></item>
            /// <item><description><b>Modifying</b>: Configuring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1707FC0-430C-423A-B624-284046B20399</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
