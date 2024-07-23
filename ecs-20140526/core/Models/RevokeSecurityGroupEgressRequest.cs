// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RevokeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.DestGroupId</c> to specify the ID of the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.IpProtocol</c> to specify the transport layer protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
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
        /// <para>Security group rule N. Valid values of N: 1 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<RevokeSecurityGroupEgressRequestPermissions> Permissions { get; set; }
        public class RevokeSecurityGroupEgressRequestPermissions : TeaModel {
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
            /// <para>The destination IPv4 CIDR block for security group rule N. CIDR blocks and IPv4 addresses are supported.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the source security group that is referenced in security group rule N.</para>
            /// <list type="bullet">
            /// <item><description>At least one of <c>DestGroupId</c>, <c>DestCidrIp</c>, <c>Ipv6DestCidrIp</c>, and <c>DestPrefixListId</c> must be specified.</description></item>
            /// <item><description>If <c>DestGroupId</c> is specified but <c>DestCidrIp</c> is not specified, the <c>NicType</c> parameter must be set to intranet.</description></item>
            /// <item><description>If both <c>DestGroupId</c> and <c>DestCidrIp</c> are specified, <c>DestCidrIp</c> takes precedence.</description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>For advanced security groups, security groups cannot be used as authorization objects.</description></item>
            /// <item><description>For each basic security group, a maximum of 20 security groups can be used as authorization objects.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxa123b****</para>
            /// </summary>
            [NameInMap("DestGroupId")]
            [Validation(Required=false)]
            public string DestGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that manages the destination security group when you delete security group rules N across accounts.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>DestGroupOwnerAccount</c> and <c>DestGroupOwnerId</c> are not specified, the access control is revoked from another security group managed by your account.</description></item>
            /// <item><description>If <c>DestCidrIp</c> is specified, <c>DestGroupOwnerAccount</c> is ignored.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("DestGroupOwnerAccount")]
            [Validation(Required=false)]
            public string DestGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that manages the destination security group when you delete security group rule N across accounts.</para>
            /// <list type="bullet">
            /// <item><description>If both <c>DestGroupOwnerId</c> and <c>DestGroupOwnerAccount</c> are not specified, the access control is revoked from another security group managed by your account.</description></item>
            /// <item><description>If <c>DestCidrIp</c> is specified, <c>DestGroupOwnerId</c> is invalid.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("DestGroupOwnerId")]
            [Validation(Required=false)]
            public string DestGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the destination prefix list that is referenced in security group rule N. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>If a security group is in the classic network, you cannot reference prefix lists in the security group rules. For information about the limits on security groups and prefix lists, see the &quot;Security group limits&quot; section in <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
            /// <item><description>If you specify <c>DestCidrIp</c>, <c>Ipv6DestCidrIp</c>, or <c>DestGroupId</c>, this parameter is ignored.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("DestPrefixListId")]
            [Validation(Required=false)]
            public string DestPrefixListId { get; set; }

            /// <summary>
            /// <para>The transport layer protocol of security group rule N. The value of this parameter is case-insensitive. Valid values:</para>
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
            /// <para>The destination IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the destination is Elastic Compute Service (ECS) instances that reside in virtual private clouds (VPCs) and support IPv6 CIDR blocks. You cannot specify both this parameter and the <c>DestCidrIp</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block. CIDR blocks and IPv6 addresses are supported.</para>
            /// <para>This parameter is specified to meet quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the source is ECS instances that reside in VPCs and support IPv6 CIDR blocks. You cannot specify both this parameter and the <c>SourceCidrIp</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1234:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) type of security group rule N when the security group is in the classic network. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>internet: public NIC.</description></item>
            /// <item><description>intranet: internal NIC.</description></item>
            /// </list>
            /// <para>If the security group is in a VPC, this parameter is set to intranet by default and cannot be modified.</para>
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
            /// <para>The action of security group rule N that determines whether to allow outbound access. Valid values:</para>
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
            /// <para>The range of destination ports that correspond to the transport layer protocol for security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Specify a port range in the format of \<Start port number>/\<End port number>. Example: 1/200.</description></item>
            /// <item><description>If you set IpProtocol to ICMP, the port number range is -1/-1.</description></item>
            /// <item><description>If you set IpProtocol to GRE, the port number range is -1/-1.</description></item>
            /// <item><description>If you set IpProtocol to ALL, the port number range is -1/-1.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of security group rule N. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
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
            /// <para>This parameter is specified to meet quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The range of source ports that correspond to the transport layer protocol for security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Specify a port range in the format of \<Start port number>/\<End port number>. Example: 1/200.</description></item>
            /// <item><description>If you set IpProtocol to ICMP, the port number range is -1/-1.</description></item>
            /// <item><description>If you set IpProtocol to GRE, the port number range is -1/-1.</description></item>
            /// <item><description>If you set IpProtocol to ALL, the port number range is -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is specified to meet quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Security group quintuple rules</a>.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
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
        /// <para>22/22</para>
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
        /// <para>The ID of security group rule N. Valid values of N: 1 to 100.</para>
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
        /// <para>This parameter is deprecated. Use <c>Permissions.N.SourcePortRange</c> to specify the range of source ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

    }

}
