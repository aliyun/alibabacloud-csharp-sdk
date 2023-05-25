// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **ClientToken** value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Description` to specify the description of security group rule N.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestCidrIp` to specify the destination IPv4 CIDR block.
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.IpProtocol` to specify the transport layer protocol.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Ipv6DestCidrIp` to specify the destination IPv6 CIDR block.
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Ipv6SourceCidrIp` to specify the source IPv6 CIDR block.
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.NicType` to specify the NIC type.
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
        /// The security group rules. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<RevokeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class RevokeSecurityGroupRequestPermissions : TeaModel {
            /// <summary>
            /// The description of security group rule N. The description must be 1 to 512 characters in length.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.
            /// 
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// The transport layer protocol of security group rule N. The values of this parameter are not case-sensitive. Valid values:
            /// 
            /// *   TCP
            /// *   UDP
            /// *   ICMP
            /// *   ICMPv6
            /// *   GRE
            /// *   ALL: All protocols are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The destination IPv6 CIDR block. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter is valid only when the destination is an ECS instance that resides in a VPC and supports IPv6 CIDR blocks. You cannot specify both this parameter and the `DestCidrIp` parameter.
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// The source IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter is valid only when the source is an Elastic Compute Service (ECS) instance that resides in a virtual private cloud (VPC) and supports IPv6 CIDR blocks. You cannot specify both this parameter and the `SourceCidrIp` parameter.
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// The network interface card (NIC) type of the security group rule if the security group is of the classic network type. Valid values:
            /// 
            /// *   internet: public NIC
            /// *   intranet: internal NIC
            /// 
            /// If the security group is in a VPC, this parameter is set to intranet by default and cannot be changed.
            /// 
            /// If you specify only `SourceGroupId` when you configure access between security groups, this parameter must be set to intranet.
            /// 
            /// Default value: internet.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// The action of security group rule N that determines whether to allow inbound access. Valid values:
            /// 
            /// *   accept: allows access.
            /// *   drop: denies access and returns no responses. In this case, the request times out or the connection cannot be established.
            /// 
            /// Default value: accept.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The range of destination ports that correspond to the transport layer protocol of security group rule N. Valid values:
            /// 
            /// *   If the Permissions.N.IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: 1/200.
            /// *   If the Permissions.N.IpProtocol parameter is set to ICMP, the port range is -1/-1, which indicates all ports.
            /// *   If the Permissions.N.IpProtocol parameter is set to GRE, the port range is -1/-1, which indicates all ports.
            /// *   If the Permissions.N.IpProtocol parameter is set to ALL, the port range is -1/-1, which indicates all ports.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// The priority of security group rule N. A smaller value specifies a higher priority. Valid values: 1 to 100.
            /// 
            /// Default value: 1.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The source IPv4 CIDR block for security group rule N. CIDR blocks and IPv4 addresses are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// The ID of the source security group that is referenced in security group rule N.
            /// 
            /// *   Specify at least one of the following parameters: `SourceGroupId`, `SourceCidrIp`, `Ipv6SourceCidrIp`, and `SourcePrefixListId`.
            /// *   If you specify `SourceGroupId` but you do not specify `SourceCidrIp` or `Ipv6SourceCidrIp`, you must set NicType to intranet.
            /// *   If you specify `SourceGroupId` and `SourceCidrIp`, `SourceCidrIp` takes precedence.
            /// 
            /// When you specify this parameter, take note of the following items:
            /// 
            /// *   You cannot reference security groups as destinations or sources in the rules of advanced security groups.
            /// *   You can reference up to 20 security groups as destinations or sources in the rules of each basic security group.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account that manages the source security group when you delete security group rule N across accounts.
            /// 
            /// *   If both `SourceGroupOwnerAccount` and `SourceGroupOwnerId` are not specified, the security group rule that controls access to other security groups managed by your account is deleted.
            /// *   If you specify `SourceCidrIp`, `SourceGroupOwnerAccount` is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that manages the source security group when you delete security group rule N across accounts.
            /// 
            /// *   If both `SourceGroupOwnerId` and `SourceGroupOwnerAccount` are not specified, the security group rule that controls access to other security groups managed by your account is deleted.
            /// *   If you specify `SourceCidrIp`, `SourceGroupOwnerId` is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// The range of source ports that correspond to the transport layer protocol of security group rule N. Valid values:
            /// 
            /// *   If the Permissions.N.IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: 1/200.
            /// *   If the Permissions.N.IpProtocol parameter is set to ICMP, the port range is -1/-1, which indicates all ports.
            /// *   If the Permissions.N.IpProtocol parameter is set to GRE, the port range is -1/-1, which indicates all ports.
            /// *   If the Permissions.N.IpProtocol parameter is set to ALL, the port range is -1/-1, which indicates all ports.
            /// 
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// The ID of the source prefix list that is referenced in security group rule N. You can call the [DescribePrefixLists](~~205046~~) operation to query the IDs of available prefix lists.
            /// 
            /// When you specify this parameter, take note of the following items:
            /// 
            /// *   If the network type of a security group is classic network, you cannot reference prefix lists in the security group rules. For information about the limits on security groups and prefix lists, see the "Security group limits" section in [Limits](~~25412#SecurityGroupQuota1~~).
            /// *   If you specify the `SourceCidrIp`, `Ipv6SourceCidrIp`, or `SourceGroupId` parameter, this parameter is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourcePrefixListId")]
            [Validation(Required=false)]
            public string SourcePrefixListId { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Policy` to specify whether to allow inbound access.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.PortRange` to specify the range of destination ports.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Priority` to specify the priority of the rule.
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
        /// The IDs of the security group rules. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupRuleId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceCidrIp` to specify the source IPv4 CIDR block.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupId` to specify the ID of the source security group.
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupOwnerAccount` to specify the Alibaba Cloud account that manages the source security group.
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupOwnerId` to specify the ID of the Alibaba Cloud account that manages the source security group.
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourcePortRange` to specify the range of source ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourcePrefixListId` to specify the ID of the source prefix list.
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        public string SourcePrefixListId { get; set; }

    }

}
