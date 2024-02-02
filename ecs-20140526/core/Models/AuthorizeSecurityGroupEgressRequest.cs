// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Description` to specify the description of security group rule N.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        [Obsolete]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestCidrIp` to specify the destination IPv4 CIDR block.
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestGroupId` to specify the ID of the destination security group.
        /// </summary>
        [NameInMap("DestGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestGroupOwnerAccount` to specify the Alibaba Cloud account that manages the destination security group.
        /// </summary>
        [NameInMap("DestGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupOwnerAccount { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestGroupOwnerId` to specify the ID of the Alibaba Cloud account that manages the destination security group.
        /// </summary>
        [NameInMap("DestGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DestGroupOwnerId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.DestPrefixListId` to specify the ID of the destination prefix list.
        /// </summary>
        [NameInMap("DestPrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestPrefixListId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.IpProtocol` to specify the transport layer protocol.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public string IpProtocol { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Ipv6DestCidrIp` to specify the destination IPv6 CIDR block.
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Ipv6SourceCidrIp` to specify the source IPv6 CIDR block.
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.NicType` to specify the NIC type.
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
        /// The security group rules. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupEgressRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupEgressRequestPermissions : TeaModel {
            /// <summary>
            /// The description of security group rule N. The description must be 1 to 512 characters in length.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination IPv4 CIDR block for security group rule N. CIDR blocks and IPv4 addresses are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// The ID of the destination security group to be referenced in security group rule N.
            /// 
            /// *   At least one of `DestGroupId`, `DestCidrIp`, `Ipv6DestCidrIp`, and `DestPrefixListId` must be configured.
            /// *   If `DestGroupId` is configured but `DestCidrIp` is not configured, the value of `NicType` must be set to intranet.
            /// *   If both `DestGroupId` and `DestCidrIp` are configured, the value of `DestCidrIp` prevails by default.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// Take note of the following items:
            /// 
            /// *   For advanced security groups, security groups cannot be used as authorization objects.
            /// *   For each basic security group, a maximum of 20 security groups can be used as authorization objects.
            /// </summary>
            [NameInMap("DestGroupId")]
            [Validation(Required=false)]
            public string DestGroupId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account that manages the destination security group when you configure security group rule N across accounts.
            /// 
            /// *   If both `DestGroupOwnerAccount` and `DestGroupOwnerId` are not configured, the rule is created to control access to another security group within your Alibaba Cloud account.
            /// *   If `DestCidrIp` is configured, `DestGroupOwnerAccount` is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestGroupOwnerAccount")]
            [Validation(Required=false)]
            public string DestGroupOwnerAccount { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that manages the destination security group when you configure security group rule N across accounts.
            /// 
            /// *   If both `DestGroupOwnerId` and `DestGroupOwnerAccount` are not configured, the rule is created to control access to another security group within your Alibaba Cloud account.
            /// *   If `DestCidrIp` is configured, `DestGroupOwnerId` is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestGroupOwnerId")]
            [Validation(Required=false)]
            public long? DestGroupOwnerId { get; set; }

            /// <summary>
            /// The ID of the destination prefix list to be referenced in security group rule N. You can call the [DescribePrefixLists](~~205046~~) operation to query the IDs of available prefix lists.
            /// 
            /// Take note of the following items:
            /// 
            /// *   If a security group is in the classic network, you cannot reference prefix lists in the security group rules. For information about the limits on security groups and prefix lists, see the "Security group limits" section in [Limits](~~25412#SecurityGroupQuota1~~).
            /// *   If you configured `DestCidrIp`, `Ipv6DestCidrIp`, or `DestGroupId`, DestPrefixListId is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestPrefixListId")]
            [Validation(Required=false)]
            public string DestPrefixListId { get; set; }

            /// <summary>
            /// The transport layer protocol of security group rule N. The value of this parameter is case-insensitive. Valid values:
            /// 
            /// *   TCP.
            /// *   UDP.
            /// *   ICMP.
            /// *   ICMPv6.
            /// *   GRE.
            /// *   ALL: All protocols are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The destination IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter takes effect only when the destination is ECS instances that reside in VPCs and support IPv6 CIDR blocks. You cannot configure both this parameter and `DestCidrIp`.
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// The source IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter takes effect only when the source is ECS instances that reside in VPCs and support IPv6 CIDR blocks. You cannot configure both this parameter and `SourceCidrIp`.
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// The network interface controller (NIC) type of security group rule N when the security group is in the classic network. Valid values:
            /// 
            /// *   internet: public NIC
            /// 
            /// *   intranet: internal NIC
            /// 
            ///     *   If the security group is in a VPC, this parameter is set to intranet by default and cannot be changed.
            ///     *   If you configure only DestGroupId when you configure access between security groups, this parameter must be set to intranet.
            /// 
            /// Default value: internet.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// The action of security group rule N that determines whether to allow outbound access. Valid values:
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
            /// The range of destination ports that correspond to the transport layer protocol for security group rule N. Valid values:
            /// 
            /// *   If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
            /// *   If you set IpProtocol to ICMP, the port number range is -1/-1.
            /// *   If you set IpProtocol to GRE, the port number range is -1/-1.
            /// *   If you set IpProtocol to ALL, the port number range is -1/-1.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// The priority of security group rule N. A smaller value indicates a higher priority. Valid values: 1 to 100.
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
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// The range of source ports that correspond to the transport layer protocol for security group rule N. Valid values:
            /// 
            /// *   If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
            /// *   If you set IpProtocol to ICMP, the port number range is -1/-1.
            /// *   If you set IpProtocol to GRE, the port number range is -1/-1.
            /// *   If you set IpProtocol to ALL, the port number range is -1/-1.
            /// 
            /// This parameter is supported by quintuple rules. For more information, see [Security group quintuple rules](~~97439~~).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Policy` to specify whether to allow outbound access.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        [Obsolete]
        public string Policy { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.PortRange` to specify the range of destination ports.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Priority` to specify the rule priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public string Priority { get; set; }

        /// <summary>
        /// The region ID of the source security group. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The security group ID.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceCidrIp` to specify the source IPv4 CIDR block.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourcePortRange` to specify the range of source ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

    }

}
