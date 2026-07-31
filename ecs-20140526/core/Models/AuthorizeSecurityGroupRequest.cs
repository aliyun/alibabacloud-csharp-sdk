// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.Description</c> to specify the description of the security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        [Obsolete]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.DestCidrIp</c> to specify the destination IPv4 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.IpProtocol</c> to specify the protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public string IpProtocol { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.Ipv6DestCidrIp</c> to specify the destination IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6DestCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.Ipv6SourceCidrIp</c> to specify the source IPv6 Classless Inter-Domain Routing block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:250:6000::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6SourceCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.NicType</c> to specify the NIC type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        [Obsolete]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The security group rules. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description of the security group rule. The description must be 1 to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 CIDR block. CIDR blocks and IPv4 address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The network-layer or transport-layer protocol. Two types of values are supported:</para>
            /// <ol>
            /// <item><description>Case-insensitive protocol names. Valid values:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>ICMP</description></item>
            /// <item><description>GRE</description></item>
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ALL: All protocols are supported.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Protocol numbers that comply with IANA specifications, which are integers from 0 to 255. The following regions currently support this feature:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Philippines</description></item>
            /// <item><description>UK</description></item>
            /// <item><description>Malaysia</description></item>
            /// <item><description>Hohhot</description></item>
            /// <item><description>Qingdao</description></item>
            /// <item><description>US West</description></item>
            /// <item><description>Singapore</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The destination IPv6 CIDR block. Settings support CIDR format and IPv6 format address ranges.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for VPC-connected ECS instances that support IPv6. This parameter and <c>DestCidrIp</c> cannot be specified at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:250:6000::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block for which you want to set access permissions. Settings support CIDR format and IPv6 format address ranges.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for VPC-connected ECS instances that support IPv6. This parameter and <c>SourceCidrIp</c> cannot be specified at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:250:6000::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) type for a classic network security group rule. Settings include the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>internet: public network interface controller (NIC).</para>
            /// </description></item>
            /// <item><description><para>intranet: internal network interface controller (NIC).</para>
            /// </description></item>
            /// </list>
            /// <para>For VPC security group rules, you do not need to set the network interface controller (NIC) type. The default value is intranet, and only intranet is supported.</para>
            /// <para>When you set security groups to access each other, meaning only the DestGroupId parameter is specified, only intranet is supported.</para>
            /// <para>Default value: internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>Settings for access permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>accept: Accepts access.</para>
            /// </description></item>
            /// <item><description><para>drop: Denies access without returning a deny response. The request appears to timeout or the connection cannot be established.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: accept.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The range of destination ports that correspond to the protocol for the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP: Valid values are 1 to 65535. Separate the start port and the stop port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to ALL: -1/-1.</description></item>
            /// </list>
            /// <para>For more information about common scenarios of ports, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The port address book ID.
            /// You can invoke <c>DescribePortRangeLists</c> to query available port address book IDs.</para>
            /// <list type="bullet">
            /// <item><description>If you specify <c>Permissions.N.PortRange</c>, this parameter is ignored.</description></item>
            /// <item><description>Port address books are not supported when the security group network type is classic network. For more information about security group and port address book limits, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>. Settings for port address books are subject to these limits.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prl-2ze9743****</para>
            /// </summary>
            [NameInMap("PortRangeListId")]
            [Validation(Required=false)]
            public string PortRangeListId { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block for which you want to set access permissions. Settings support CIDR format and IPv4 format address ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the source security group for which you want to set access permissions.</para>
            /// <list type="bullet">
            /// <item><description><para>Specify at least one of the following parameters: <c>SourceGroupId</c>, <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, or <c>SourcePrefixListId</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>SourceGroupId</c> is specified but <c>SourceCidrIp</c> or <c>Ipv6SourceCidrIp</c> is not specified, the <c>NicType</c> parameter can only be set to <c>intranet</c>.</para>
            /// </description></item>
            /// <item><description><para>If both <c>SourceGroupId</c> and <c>SourceCidrIp</c> are specified, <c>SourceCidrIp</c> takes precedence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that owns the source security group when you set a cross-account security group rule. Settings apply as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>If neither <c>SourceGroupOwnerAccount</c> nor <c>SourceGroupOwnerId</c> is set, the rule is created to set access permissions for another security group within your account.</para>
            /// </description></item>
            /// <item><description><para>If the <c>SourceCidrIp</c> parameter is specified, the <c>SourceGroupOwnerAccount</c> parameter is ignored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the source security group when you set a cross-account security group rule. Settings apply as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>If neither <c>SourceGroupOwnerAccount</c> nor <c>SourceGroupOwnerId</c> is set, the rule is created to set access permissions for another security group within your account.</para>
            /// </description></item>
            /// <item><description><para>If the <c>SourceCidrIp</c> parameter is specified, the <c>SourceGroupOwnerAccount</c> parameter is ignored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The range of source ports that correspond to the protocol for the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP: Valid values are 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000/8000</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The ID of the source prefix list for which you want to set access permissions. You can call <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> to query available prefix list IDs.</para>
            /// <para>Usage notes:</para>
            /// <para>If you specify one of the <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, or <c>SourceGroupId</c> parameters, this parameter is ignored.</para>
            /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("SourcePrefixListId")]
            [Validation(Required=false)]
            public string SourcePrefixListId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.Policy</c> to set access permissions. Settings configured through this parameter are no longer supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        [Obsolete]
        public string Policy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.PortRange</c> to specify the port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.Priority</c> to specify the priority of the security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the security group. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourceCidrIp</c> to specify the source IPv4 Classless Inter-Domain Routing block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourceGroupId</c> to specify the source security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourceGroupOwnerAccount</c> to specify the Alibaba Cloud account that owns the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourceGroupOwnerId</c> to specify the ID of the Alibaba Cloud account that owns the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? SourceGroupOwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourcePortRange</c> to specify the source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated. Use <c>Permissions.N.SourcePrefixListId</c> to specify the source prefix list ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePrefixListId { get; set; }

    }

}
