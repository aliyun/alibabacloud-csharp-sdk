// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The **ClientToken** value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the security group rule. The description must be 1 to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// The transport layer protocol of the security group rule. The values of this parameter are case-insensitive. Valid values:
        /// 
        /// *   ICMP
        /// *   GRE
        /// *   TCP
        /// *   UDP
        /// *   ALL
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The destination IPv6 CIDR block. CIDR blocks and IPv6 addresses are supported.
        /// 
        /// > Only the IP addresses of the VPC type are supported. You cannot specify both the Ipv6DestCidrIp parameter and the `DestCidrIp` parameter.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// The source IPv6 CIDR block to which you want to control access. CIDR blocks and IPv6 addresses are supported.
        /// 
        /// > Only the IP addresses of the Virtual Private Cloud (VPC) type are supported. You cannot specify both the Ipv6SourceCidrIp parameter and the `SourceCidrIp` parameter.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// You cannot modify this parameter when you modify a security group rule by specifying its ID.\
        /// You can add a new rule that meets your requirements and delete the original rule.
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
        /// The action of the security group rule that determines whether to allow access. Valid values:
        /// 
        /// *   accept: allows access.
        /// *   drop: denies access and returns no responses.
        /// 
        /// Default value: accept.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The range of source ports that correspond to the transport layer protocol. Valid values:
        /// 
        /// *   When the IpProtocol parameter is set to tcp or udp, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
        /// *   If the IpProtocol parameter is set to icmp, the port number range is -1/-1, which indicates all ports.
        /// *   If the IpProtocol parameter is set to gre, the port number range is -1/-1, which indicates all ports.
        /// *   If the IpProtocol parameter is set to all, the port number range is -1/-1, which indicates all ports.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// The priority of the security group rule. Valid values: 1 to 100.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// The region ID of the security group. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The ID of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The ID of the security group rule.\
        /// This parameter is required when you modify a security group rule based on the ID of the security group rule.
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// The source IPv4 CIDR block to which you want to control access. CIDR blocks and IPv4 addresses are supported.
        /// 
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// The ID of the source security group. At least one of `SourceGroupId` and `SourceCidrIp` must be specified.
        /// 
        /// *   If `SourceGroupId` is specified but `SourceCidrIp` is not specified, the `NicType` parameter must be set to intranet.
        /// *   If both `SourceGroupId` and `SourceCidrIp` are specified, `SourceCidrIp` takes precedence.
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account that manages the source security group when you set a security group rule across accounts.
        /// 
        /// *   If both `SourceGroupOwnerId` and `SourceGroupOwnerAccount` are empty, access permissions are configured for another security group managed by your account.
        /// *   If `SourceCidrIp` is specified, the `SourceGroupOwnerAccount` parameter is ignored.
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// The Alibaba Cloud account that manages the source security group when you set a security group rule across accounts.
        /// 
        /// *   If both `SourceGroupOwnerId` and `SourceGroupOwnerAccount` are empty, access permissions are configured for another security group managed by your account.
        /// *   If `SourceCidrIp` is specified, the `SourceGroupOwnerId` parameter is ignored.
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// The range of source ports that correspond to the transport layer protocol. Valid values:
        /// 
        /// *   When the IpProtocol parameter is set to tcp or udp, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
        /// *   If the IpProtocol parameter is set to icmp, the port number range is -1/-1, which indicates all ports.
        /// *   If the IpProtocol parameter is set to gre, the port number range is -1/-1, which indicates all ports.
        /// *   If the IpProtocol parameter is set to all, the port number range is -1/-1, which indicates all ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// The ID of the source prefix list to which you want to control access. You can call the [DescribePrefixLists](~~205046~~) operation to query the IDs of available prefix lists.
        /// 
        /// If you specify the `SourceCidrIp`, `Ipv6SourceCidrIp`, or `SourceGroupId` parameter, this parameter is ignored.
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        public string SourcePrefixListId { get; set; }

    }

}
