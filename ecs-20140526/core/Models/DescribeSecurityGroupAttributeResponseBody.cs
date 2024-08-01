// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// The description of the security group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The access control policy of the security group. Valid values:
        /// 
        /// *   Accept: All instances in the security group can communicate with each other.
        /// *   Drop: All instances in the security group are isolated from each other.
        /// </summary>
        [NameInMap("InnerAccessPolicy")]
        [Validation(Required=false)]
        public string InnerAccessPolicy { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If the return value of this parameter is empty when you specify `MaxResults` and `NextToken` for a paged query, no more results are to be returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Details about the security group rules.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                /// <summary>
                /// The time when the security group rule was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the security group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The destination CIDR block for outbound access control.
                /// </summary>
                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                /// <summary>
                /// The ID of the destination security group for outbound access control.
                /// </summary>
                [NameInMap("DestGroupId")]
                [Validation(Required=false)]
                public string DestGroupId { get; set; }

                /// <summary>
                /// The name of the destination security group.
                /// </summary>
                [NameInMap("DestGroupName")]
                [Validation(Required=false)]
                public string DestGroupName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the destination security group belongs.
                /// </summary>
                [NameInMap("DestGroupOwnerAccount")]
                [Validation(Required=false)]
                public string DestGroupOwnerAccount { get; set; }

                /// <summary>
                /// The ID of the destination prefix list for outbound access control.
                /// </summary>
                [NameInMap("DestPrefixListId")]
                [Validation(Required=false)]
                public string DestPrefixListId { get; set; }

                /// <summary>
                /// The name of the destination prefix list.
                /// </summary>
                [NameInMap("DestPrefixListName")]
                [Validation(Required=false)]
                public string DestPrefixListName { get; set; }

                /// <summary>
                /// The direction in which the security group rule is applied.
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// The transport layer protocol.
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// The destination IPv6 CIDR block.
                /// </summary>
                [NameInMap("Ipv6DestCidrIp")]
                [Validation(Required=false)]
                public string Ipv6DestCidrIp { get; set; }

                /// <summary>
                /// The source IPv6 CIDR block.
                /// </summary>
                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("NicType")]
                [Validation(Required=false)]
                public string NicType { get; set; }

                /// <summary>
                /// The access control policy.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The port range.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// The priority of the rule.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// The ID of the security group rule.
                /// </summary>
                [NameInMap("SecurityGroupRuleId")]
                [Validation(Required=false)]
                public string SecurityGroupRuleId { get; set; }

                /// <summary>
                /// The source CIDR block for inbound access control.
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// The source security group for inbound access control.
                /// </summary>
                [NameInMap("SourceGroupId")]
                [Validation(Required=false)]
                public string SourceGroupId { get; set; }

                /// <summary>
                /// The name of the source security group.
                /// </summary>
                [NameInMap("SourceGroupName")]
                [Validation(Required=false)]
                public string SourceGroupName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the source security group belongs.
                /// </summary>
                [NameInMap("SourceGroupOwnerAccount")]
                [Validation(Required=false)]
                public string SourceGroupOwnerAccount { get; set; }

                /// <summary>
                /// The source port range.
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// The ID of the source prefix list for inbound access control.
                /// </summary>
                [NameInMap("SourcePrefixListId")]
                [Validation(Required=false)]
                public string SourcePrefixListId { get; set; }

                /// <summary>
                /// The name of the source prefix list.
                /// </summary>
                [NameInMap("SourcePrefixListName")]
                [Validation(Required=false)]
                public string SourcePrefixListName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the destination security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The name of the destination security group.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// The ID of the VPC. If a VPC ID is returned, the network type of the security group is VPC. If no VPC ID is returned, the network type of the security group is classic network.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
