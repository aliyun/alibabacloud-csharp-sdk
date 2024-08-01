// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Description` to specify the rule description.
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
        /// This parameter is deprecated. Use `Permissions.N.NicType` to specify the network interface type.
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
        /// Security group rule N. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupRequestPermissions : TeaModel {
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
            /// This parameter is specified to meet quintuple rules. For more information, see [Security group quintuple rules](https://help.aliyun.com/document_detail/97439.html).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// The transport layer protocol of security group rule N. The value of this parameter is case-insensitive. Valid values:
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
            /// The destination IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// This parameter is specified to meet quintuple rules. For more information, see [Security group quintuple rules](https://help.aliyun.com/document_detail/97439.html).
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter is valid only when the source is ECS instances that reside in VPCs and support IPv6 CIDR blocks. You cannot specify both this parameter and the `DestCidrIp` parameter.
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// The source IPv6 CIDR block for security group rule N. CIDR blocks and IPv6 addresses are supported.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// > This parameter takes effect only if the sources are ECS instances that reside in VPCs and support IPv6 CIDR blocks. You cannot specify this parameter and `SourceCidrIp` at the same time.
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// The network interface controller (NIC) type of security group rule N when the security group is in the classic network. Valid values:
            /// 
            /// *   internet: public NIC.
            /// *   intranet: internal NIC.
            /// 
            /// If the security group is in a VPC, this parameter is set to intranet by default and cannot be changed.
            /// 
            /// If you specify only DestGroupId when you configure access between security groups, this parameter must be set to intranet.
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
            /// The range of destination ports that correspond to the transport layer protocol for security group rule N. Valid values:
            /// 
            /// *   If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Specify a port range in the format of \\<Start port number>/\\<End port number>. Example: 1/200.
            /// *   If you set IpProtocol to ICMP, the port number range is -1/-1.
            /// *   If you set IpProtocol to GRE, the port number range is -1/-1.
            /// *   If you set IpProtocol to ALL, the port number range is -1/-1.
            /// 
            /// For more information, see [Typical applications of commonly used ports](https://help.aliyun.com/document_detail/40724.html).
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
            /// The ID of the source security group to be referenced in security group rule N.
            /// 
            /// *   At least one of `SourceGroupId`, `SourceCidrIp`, `Ipv6SourceCidrIp`, and `SourcePrefixListId` must be specified.
            /// *   If `SourceGroupId` is specified but `SourceCidrIp` or `Ipv6SourceCidrIp` is not specified, `NicType` must be set to `intranet`.
            /// *   If both `SourceGroupId` and `SourceCidrIp` are specified, `SourceCidrIp` takes precedence.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// Take note of the following items:
            /// 
            /// *   For advanced security groups, security groups cannot be used as authorization objects.
            /// *   For each basic security group, up to 20 security groups can be used as authorization objects.
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account that manages the source security group when you set a security group rule across accounts.
            /// 
            /// *   If you do not specify `SourceGroupOwnerAccount` and `SourceGroupOwnerId`, access permissions are configured for another security group managed by your account.
            /// *   If you specify `SourceCidrIp`, `SourceGroupOwnerAccount` becomes invalid.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that manages the source security group when you set security group rule N across accounts.
            /// 
            /// *   If you do not specify `SourceGroupOwnerAccount` and `SourceGroupOwnerId`, access permissions are configured for another security group managed by your account.
            /// *   If you specify `SourceCidrIp`, `SourceGroupOwnerAccount` is ignored.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// The range of source ports that correspond to the transport layer protocol for security group rule N. Valid values:
            /// 
            /// *   If you set IpProtocol to TCP or UDP, the port number range is 1 to 65535. Specify a port range in the format of \\<Start port number>/\\<End port number>. Example: 1/200.
            /// *   If you set IpProtocol to ICMP, the port number range is -1/-1.
            /// *   If you set IpProtocol to GRE, the port number range is -1/-1.
            /// *   If you set IpProtocol to ALL, the port number range is -1/-1.
            /// 
            /// This parameter is specified to meet quintuple rules. For more information, see [Security group quintuple rules](https://help.aliyun.com/document_detail/97439.html).
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// The ID of the source prefix list to which you want to control access. You can call the [DescribePrefixLists](https://help.aliyun.com/document_detail/205046.html) operation to query the IDs of available prefix lists.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// Take note of the following items:
            /// 
            /// *   If a security group is in the classic network, you cannot reference prefix lists in the security group rules. For information about the limits on security groups and prefix lists, see the "Security group limits" section in [Limits](~~25412#SecurityGroupQuota1~~).
            /// *   If you specify `SourceCidrIp`, `Ipv6SourceCidrIp`, or `SourceGroupId`, this parameter is ignored.
            /// </summary>
            [NameInMap("SourcePrefixListId")]
            [Validation(Required=false)]
            public string SourcePrefixListId { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.Policy` to specify whether to allow access.
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
        /// The region ID of the security group. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
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
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupId` to specify the ID of the source security group.
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupOwnerAccount` to specify the Alibaba Cloud account that manages the source security group.
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourceGroupOwnerId` to specify the ID of the Alibaba Cloud account that manages the source security group.
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourcePortRange` to specify the range of source ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// This parameter is deprecated. Use `Permissions.N.SourcePrefixListId` to specify the ID of the source prefix list.
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePrefixListId { get; set; }

    }

}
