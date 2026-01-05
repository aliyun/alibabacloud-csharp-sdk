// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Description</c> to specify the description of security group rule N.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestCidrIp</c> to specify the destination IPv4 CIDR block.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestGroupId</c> to specify the ID of the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DestGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestGroupOwnerAccount</c> to specify the Alibaba Cloud account that manages the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("DestGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestGroupOwnerId</c> to specify the ID of the Alibaba Cloud account that manages the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("DestGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DestGroupOwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestPrefixListId</c> to specify the ID of the destination prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("DestPrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestPrefixListId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.IpProtocol</c> to specify the protocol.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Ipv6DestCidrIp</c> to specify the destination IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6DestCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Ipv6SourceCidrIp</c> to specify the source IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6SourceCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.NicType</c> to specify the NIC type.</para>
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
        /// <para>An array of security group rules. You can specify 1 to 100 security group rules.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupEgressRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupEgressRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description of the security group rule. The description can be up to 1 to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 CIDR block of the security group rule. IPv4 CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the destination security group that is specified in the security group rule.</para>
            /// <list type="bullet">
            /// <item><description>You must specify at least one of the following parameters: <c>DestGroupId</c>, <c>DestCidrIp</c>, <c>Ipv6DestCidrIp</c>, and <c>DestPrefixListId</c>.</description></item>
            /// <item><description>If you specify <c>DestGroupId</c> but do not specify <c>DestCidrIp</c>, you must set <c>NicType</c> to intranet.</description></item>
            /// <item><description>If you specify both <c>DestGroupId</c> and <c>DestCidrIp</c>, <c>DestCidrIp</c> takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DestGroupId")]
            [Validation(Required=false)]
            public string DestGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that manages the destination security group.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>DestGroupOwnerAccount</c> and <c>DestGroupOwnerId</c> are empty, the rule is created to control access to another security group in your Alibaba Cloud account.</description></item>
            /// <item><description>If <c>DestCidrIp</c> is configured, <c>DestGroupOwnerAccount</c> is ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("DestGroupOwnerAccount")]
            [Validation(Required=false)]
            public string DestGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that manages the destination security group.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>DestGroupOwnerId</c> and <c>DestGroupOwnerAccount</c> are empty, the rule is created to control access to another security group in your Alibaba Cloud account.</description></item>
            /// <item><description>If you specify <c>DestCidrIp</c>, <c>DestGroupOwnerId</c> is ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("DestGroupOwnerId")]
            [Validation(Required=false)]
            public long? DestGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the destination prefix list. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>Notes:</para>
            /// <list type="bullet">
            /// <item><description>If a security group resides in the classic network, you cannot specify prefix lists in the rules of the security group. For information about the limits on security groups and prefix lists, see the <a href="~~25412#SecurityGroupQuota1~~">Security groups</a> section of the &quot;Limits and quotas on ECS&quot; topic.</description></item>
            /// <item><description>If you specify <c>DestCidrIp</c>, <c>Ipv6DestCidrIp</c>, or <c>DestGroupId</c>, this parameter is ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("DestPrefixListId")]
            [Validation(Required=false)]
            public string DestPrefixListId { get; set; }

            /// <summary>
            /// <para>Network Layer /transport layer protocol. Two types of assignments are supported:</para>
            /// <ol>
            /// <item><description>The case-insensitive protocol name. Valid value:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>ICMP</description></item>
            /// <item><description>GRE</description></item>
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ALL: supports all protocols.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>The value of the IANA-compliant protocol number, which is an integer from 0 to 255. List of regions currently available:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Philippines (Manila)</description></item>
            /// <item><description>UK (London)</description></item>
            /// <item><description>Malaysia (Kuala Lumpur)</description></item>
            /// <item><description>China (Hohhot)</description></item>
            /// <item><description>China (Qingdao)</description></item>
            /// <item><description>US (Silicon Valley)</description></item>
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
            /// <para>The destination IPv6 CIDR block of the security group rule. IPv6 CIDR blocks and IPv6 addresses are supported.</para>
            /// <remarks>
            /// <para> This parameter is valid only for VPC-type ECS instances that support IPv6. This parameter and the <c>DestCidrIp</c> parameter cannot be set at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block of the security group rule. or IPv6 address.</para>
            /// <para>This property is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <remarks>
            /// <para> This parameter is valid only for ECS instances that reside in virtual private clouds (VPCs) and support IPv6 CIDR blocks. You cannot specify this parameter and <c>DestCidrIp</c> in the same request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1234:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) type of the security group rule if the security group resides in the classic network. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>internet: public NIC.</para>
            /// </description></item>
            /// <item><description><para>intranet: internal NIC.</para>
            /// <list type="bullet">
            /// <item><description>If the security group resides in a VPC, this parameter is set to intranet by default and cannot be changed.</description></item>
            /// <item><description>If you specify only DestGroupId to create a rule that controls access to the specified security group, you must set this parameter to intranet.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>Default value: internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>The action of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accept: allows outbound access.</description></item>
            /// <item><description>drop: denies outbound access and returns no responses. In this case, the request times out or the connection cannot be established.</description></item>
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
            /// <para>The destination port range of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP: Valid values: 1 to 65535. Use a forward slash (/) to separate the start and end ports. Example: 1/200.</description></item>
            /// <item><description>ICMP:-1/-1.</description></item>
            /// <item><description>GRE:-1/-1.</description></item>
            /// <item><description>ALL:-1/-1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the port list. You can call the <c>DescribePortRangeLists</c> operation to query the IDs of available prefix lists.</para>
            /// <list type="bullet">
            /// <item><description>If you specify <c>Permissions.N.PortRange</c>, this parameter is ignored.</description></item>
            /// <item><description>If a security group resides in the classic network, you cannot reference port lists in the rules of the security group. For more information about limits on security groups and ports, see <a href="~~25412#SecurityGroupQuota1~~">Limits on security groups</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prl-2ze9743****</para>
            /// </summary>
            [NameInMap("PortRangeListId")]
            [Validation(Required=false)]
            public string PortRangeListId { get; set; }

            /// <summary>
            /// <para>The priority of security group rule N. A smaller value specifies a higher priority. Valid values: 1 to 100.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block of the security group rule. IPv4 CIDR blocks and IPv4 addresses are supported.</para>
            /// <para>This property is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The source port range of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP protocol: 1 to 65535. Use a forward slash (/) to separate the start and end ports. Example: 1/200.</description></item>
            /// <item><description>ICMP protocol:-1/-1.</description></item>
            /// <item><description>GRE protocol:-1/-1.</description></item>
            /// <item><description>ALL:-1/-1.</description></item>
            /// </list>
            /// <para>This property is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Policy</c> to specify whether to allow outbound access.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.PortRange</c> to specify the range of destination ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Priority</c> to specify the rule priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the source security group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourceCidrIp</c> to specify the source IPv4 CIDR block.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourcePortRange</c> to specify the range of source ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

    }

}
