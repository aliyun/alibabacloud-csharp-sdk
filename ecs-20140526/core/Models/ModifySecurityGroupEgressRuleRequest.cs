// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySecurityGroupEgressRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>This is a new securitygroup rule.</para>
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
        /// <para>The ID of the destination security group. You must specify at least one of <c>DestGroupId</c> and <c>DestCidrIp</c>.</para>
        /// <list type="bullet">
        /// <item><description>At least one of DestGroupId, DestCidrIp, Ipv6DestCidrIp, and DestPrefixListId must be specified.</description></item>
        /// <item><description>If DestGroupId is specified but DestCidrIp is not specified, the NicType parameter can be set only to intranet.</description></item>
        /// <item><description>If both DestGroupId and DestCidrIp are specified, DestCidrIp takes precedence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("DestGroupId")]
        [Validation(Required=false)]
        public string DestGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that manages the destination security group when you set security group rule N across accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:EcsforCloud@Alibaba.com">EcsforCloud@Alibaba.com</a></para>
        /// </summary>
        [NameInMap("DestGroupOwnerAccount")]
        [Validation(Required=false)]
        public string DestGroupOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that manages the destination security group when you set security group rule N across accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("DestGroupOwnerId")]
        [Validation(Required=false)]
        public long? DestGroupOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the destination prefix list. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
        /// <para>If you specify <c>DestCidrIp</c>, <c>Ipv6DestCidrIp</c>, or <c>DestGroupId</c>, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("DestPrefixListId")]
        [Validation(Required=false)]
        public string DestPrefixListId { get; set; }

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
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The destination IPv6 CIDR block. IPv6 CIDR blocks and IPv6 addresses are supported.</para>
        /// <remarks>
        /// <para> Only the IP addresses of instances in virtual private clouds (VPCs) are supported. You cannot specify both Ipv6DestCidrIp and <c>DestCidrIp</c>.</para>
        /// </remarks>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block. IPv6 CIDR blocks and IPv6 addresses are supported.</para>
        /// <remarks>
        /// <para> Only the IP addresses of instances in VPCs are supported. You cannot specify both Ipv6SourceCidrIp and <c>SourceCidrIp</c>.</para>
        /// </remarks>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>You cannot modify this parameter when you modify a security group rule by specifying its ID.\
        /// You can add a new rule that meets your business requirements and delete the original rule.</para>
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
        /// <para>The ID of the security group rule.\
        /// This parameter is required when you modify a security group rule based on the security group rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgr-bp67acfmxazb4q****</para>
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

    }

}
