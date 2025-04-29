// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the security group rule. The description must be 1 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new security group rule.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination IPv4 CIDR block. IPv4 CIDR blocks and IPv4 addresses are supported.</para>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// <para>The transport layer protocol of the security group rule. The value of this parameter is case-insensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ICMP</description></item>
        /// <item><description>GRE</description></item>
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// <item><description>ALL: All protocols are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The destination IPv6 CIDR block. IPv6 CIDR blocks and IPv6 addresses are supported.</para>
        /// <remarks>
        /// <para> Only the IP addresses of instances in VPCs are supported. You cannot specify both Ipv6DestCidrIp and <c>DestCidrIp</c>.</para>
        /// </remarks>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block. IPv6 CIDR blocks and IPv6 addresses are supported.</para>
        /// <remarks>
        /// <para> Only the IP addresses of instances in virtual private clouds (VPCs) are supported. You cannot specify both Ipv6SourceCidrIp and <c>SourceCidrIp</c>.</para>
        /// </remarks>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The type of the network interface controller (NIC).</para>
        /// <remarks>
        /// <para> You cannot modify this parameter when you modify a security group rule by specifying the ID of the rule. If you want to change the NIC type of a security group rule, you can create a security group rule of a desired NIC type and delete the existing rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The action of the security group rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accept: allows access.</description></item>
        /// <item><description>drop: denies access and returns no responses.</description></item>
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
        /// <para>The range of destination ports that correspond to the transport layer protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.</description></item>
        /// <item><description>If you set IpProtocol to ICMP, the port number range is -1/-1.</description></item>
        /// <item><description>If you set IpProtocol to GRE, the port number range is -1/-1.</description></item>
        /// <item><description>If you set IpProtocol to ALL, the port number range is -1/-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// <para>The ID of the port list. You can call the <c>DescribePortRangeLists</c> operation to query the IDs of available port lists.</para>
        /// <list type="bullet">
        /// <item><description>If you specify PortRange, this parameter is ignored.</description></item>
        /// <item><description>If a security group is in the classic network, you cannot configure port lists in the rules of the security group. For information about the limits on security groups and port lists, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prl-2ze9743****</para>
        /// </summary>
        [NameInMap("PortRangeListId")]
        [Validation(Required=false)]
        public string PortRangeListId { get; set; }

        /// <summary>
        /// <para>The priority of the security group rule. Valid values: 1 to 100.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
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
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group rule. You can call the <a href="https://help.aliyun.com/document_detail/2679845.html">DescribeSecurityGroupAttribute</a> operation to query the IDs of security group rules in a security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgr-bp67acfmxa123b***</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// <para>The source IPv4 CIDR block. IPv4 CIDR blocks and IPv4 addresses are supported.</para>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The source security group ID. You must specify either <c>SourceGroupId</c> or <c>SourceCidrIp</c> or specify both of them.</para>
        /// <list type="bullet">
        /// <item><description>If <c>SourceGroupId</c> is specified but <c>SourceCidrIp</c> is not specified, the value of <c>NicType</c> must be set to intranet.</description></item>
        /// <item><description>If both <c>SourceGroupId</c> and <c>SourceCidrIp</c> are specified, the value of <c>SourceCidrIp</c> prevails by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that manages the source security group when you configure a security group rule across accounts.</para>
        /// <list type="bullet">
        /// <item><description>If both <c>SourceGroupOwnerId</c> and <c>SourceGroupOwnerAccount</c> are empty, access permissions are configured for another security group managed by your account.</description></item>
        /// <item><description>If <c>SourceCidrIp</c> is specified, <c>SourceGroupOwnerAccount</c> is ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:EcsforCloud@Alibaba.com">EcsforCloud@Alibaba.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that manages the source security group when you configure a security group rule across accounts.</para>
        /// <list type="bullet">
        /// <item><description>If both <c>SourceGroupOwnerId</c> and <c>SourceGroupOwnerAccount</c> are empty, access permissions are configured for another security group managed by your account.</description></item>
        /// <item><description>If <c>SourceCidrIp</c> is specified, <c>SourceGroupOwnerId</c> is ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// <para>The range of source ports that correspond to the transport layer protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.</description></item>
        /// <item><description>If you set IpProtocol to ICMP, the port number range is -1/-1.</description></item>
        /// <item><description>If you set IpProtocol to GRE, the port number range is -1/-1.</description></item>
        /// <item><description>If you set IpProtocol to ALL, the port number range is -1/-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The ID of the source prefix list to which you want to control access. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
        /// <para>If you specify <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, or <c>SourceGroupId</c>, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        public string SourcePrefixListId { get; set; }

    }

}
