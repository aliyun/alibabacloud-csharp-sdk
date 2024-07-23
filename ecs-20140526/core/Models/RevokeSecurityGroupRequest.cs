// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Description</c> to specify the rule description.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.IpProtocol</c> to specify the transport layer protocol.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.NicType</c> to specify the network interface type.</para>
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
        /// <para>The security group rules. Valid values of N: 1 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<RevokeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class RevokeSecurityGroupRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description of security group rule N. The description must be 1 to 512 characters in length.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.</para>
            /// <para>This parameter is supported by quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The transport layer protocol of security group rule N. The values of this parameter are not case-sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ICMP</description></item>
            /// <item><description>ICMPv6</description></item>
            /// <item><description>GRE</description></item>
            /// <item><description>ALL: All protocols are supported.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The destination IPv6 CIDR block. CIDR blocks and IPv6 addresses are supported.</para>
            /// <para>This parameter is supported by quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the destination is an ECS instance that resides in a VPC and supports IPv6 CIDR blocks. You cannot specify both this parameter and the <c>DestCidrIp</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the source is an Elastic Compute Service (ECS) instance that resides in a virtual private cloud (VPC) and supports IPv6 CIDR blocks. You cannot specify both this parameter and the <c>SourceCidrIp</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1234:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface card (NIC) type of the security group rule if the security group is of the classic network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>internet: public NIC</description></item>
            /// <item><description>intranet: internal NIC</description></item>
            /// </list>
            /// <para>If the security group is in a VPC, this parameter is set to intranet by default and cannot be changed.</para>
            /// <para>If you specify only <c>SourceGroupId</c> when you configure access between security groups, this parameter must be set to intranet.</para>
            /// <para>Default value: internet.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>The action of security group rule N that determines whether to allow inbound access. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accept: allows access.</description></item>
            /// <item><description>drop: denies access and returns no responses. In this case, the request times out or the connection cannot be established.</description></item>
            /// </list>
            /// <para>Default value: accept.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The range of destination ports that correspond to the transport layer protocol of security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: 1/200.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to ICMP, the port range is -1/-1, which indicates all ports.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to GRE, the port range is -1/-1, which indicates all ports.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to ALL, the port range is -1/-1, which indicates all ports.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/200</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of security group rule N. A smaller value specifies a higher priority. Valid values: 1 to 100.</para>
            /// <para>Default value: 1.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block for security group rule N. CIDR blocks and IPv4 addresses are supported.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the source security group that is referenced in security group rule N.</para>
            /// <list type="bullet">
            /// <item><description>Specify at least one of the following parameters: <c>SourceGroupId</c>, <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, and <c>SourcePrefixListId</c>.</description></item>
            /// <item><description>If you specify <c>SourceGroupId</c> but you do not specify <c>SourceCidrIp</c> or <c>Ipv6SourceCidrIp</c>, you must set NicType to intranet.</description></item>
            /// <item><description>If you specify <c>SourceGroupId</c> and <c>SourceCidrIp</c>, <c>SourceCidrIp</c> takes precedence.</description></item>
            /// </list>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>You cannot reference security groups as destinations or sources in the rules of advanced security groups.</description></item>
            /// <item><description>You can reference up to 20 security groups as destinations or sources in the rules of each basic security group.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxa123b****</para>
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that manages the source security group when you delete security group rule N across accounts.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>SourceGroupOwnerAccount</c> and <c>SourceGroupOwnerId</c> are not specified, the security group rule that controls access to other security groups managed by your account is deleted.</description></item>
            /// <item><description>If you specify <c>SourceCidrIp</c>, <c>SourceGroupOwnerAccount</c> is ignored.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that manages the source security group when you delete security group rule N across accounts.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>SourceGroupOwnerId</c> and <c>SourceGroupOwnerAccount</c> are not specified, the security group rule that controls access to other security groups managed by your account is deleted.</description></item>
            /// <item><description>If you specify <c>SourceCidrIp</c>, <c>SourceGroupOwnerId</c> is ignored.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The range of source ports that correspond to the transport layer protocol of security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: 1/200.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to ICMP, the port range is -1/-1, which indicates all ports.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to GRE, the port range is -1/-1, which indicates all ports.</description></item>
            /// <item><description>If the Permissions.N.IpProtocol parameter is set to ALL, the port range is -1/-1, which indicates all ports.</description></item>
            /// </list>
            /// <para>This parameter is supported by quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The ID of the source prefix list that is referenced in security group rule N. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>If the network type of a security group is classic network, you cannot reference prefix lists in the security group rules. For information about the limits on security groups and prefix lists, see the &quot;Security group limits&quot; section in <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
            /// <item><description>If you specify the <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, or <c>SourceGroupId</c> parameter, this parameter is ignored.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.Policy</c> to specify whether to allow inbound access.</para>
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
        /// <para>1/200</para>
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
        /// <para>The region ID of the security group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the security group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security group rules. Valid values of N: 1 to 100.</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupRuleId { get; set; }

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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourceGroupId</c> to specify the ID of the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourceGroupOwnerAccount</c> to specify the Alibaba Cloud account that manages the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourceGroupOwnerId</c> to specify the ID of the Alibaba Cloud account that manages the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? SourceGroupOwnerId { get; set; }

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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourcePrefixListId</c> to specify the ID of the source prefix list.</para>
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
