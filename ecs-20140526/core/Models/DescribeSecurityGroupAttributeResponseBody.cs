// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The access control policy of the security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Accept: All instances in the security group can communicate with each other.</description></item>
        /// <item><description>Drop: All instances in the security group are isolated from each other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Accept</para>
        /// </summary>
        [NameInMap("InnerAccessPolicy")]
        [Validation(Required=false)]
        public string InnerAccessPolicy { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If the return value of this parameter is empty when you specify <c>MaxResults</c> and <c>NextToken</c> for a paged query, no more results are to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                [NameInMap("DestGroupId")]
                [Validation(Required=false)]
                public string DestGroupId { get; set; }

                [NameInMap("DestGroupName")]
                [Validation(Required=false)]
                public string DestGroupName { get; set; }

                [NameInMap("DestGroupOwnerAccount")]
                [Validation(Required=false)]
                public string DestGroupOwnerAccount { get; set; }

                [NameInMap("DestPrefixListId")]
                [Validation(Required=false)]
                public string DestPrefixListId { get; set; }

                [NameInMap("DestPrefixListName")]
                [Validation(Required=false)]
                public string DestPrefixListName { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Ipv6DestCidrIp")]
                [Validation(Required=false)]
                public string Ipv6DestCidrIp { get; set; }

                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                [NameInMap("NicType")]
                [Validation(Required=false)]
                public string NicType { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("PortRangeListId")]
                [Validation(Required=false)]
                public string PortRangeListId { get; set; }

                [NameInMap("PortRangeListName")]
                [Validation(Required=false)]
                public string PortRangeListName { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                [NameInMap("SecurityGroupRuleId")]
                [Validation(Required=false)]
                public string SecurityGroupRuleId { get; set; }

                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                [NameInMap("SourceGroupId")]
                [Validation(Required=false)]
                public string SourceGroupId { get; set; }

                [NameInMap("SourceGroupName")]
                [Validation(Required=false)]
                public string SourceGroupName { get; set; }

                [NameInMap("SourceGroupOwnerAccount")]
                [Validation(Required=false)]
                public string SourceGroupOwnerAccount { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("SourcePrefixListId")]
                [Validation(Required=false)]
                public string SourcePrefixListId { get; set; }

                [NameInMap("SourcePrefixListName")]
                [Validation(Required=false)]
                public string SourcePrefixListName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1gxw6bznjjvhu3****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecurityGroupName Sample</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        [NameInMap("SnapshotPolicyIds")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodySnapshotPolicyIds SnapshotPolicyIds { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodySnapshotPolicyIds : TeaModel {
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public List<string> SnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC. If a VPC ID is returned, the network type of the security group is VPC. If no VPC ID is returned, the network type of the security group is classic network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
