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

        /// <summary>
        /// <para>Details about the security group rules.</para>
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
                /// <para>The time when the security group rule was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-12T07:28:38Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description Sample 01</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The destination CIDR block for outbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                /// <summary>
                /// <para>The ID of the destination security group for outbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1czdx84jd88i7v****</para>
                /// </summary>
                [NameInMap("DestGroupId")]
                [Validation(Required=false)]
                public string DestGroupId { get; set; }

                /// <summary>
                /// <para>The name of the destination security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDestGroupName</para>
                /// </summary>
                [NameInMap("DestGroupName")]
                [Validation(Required=false)]
                public string DestGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the destination security group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("DestGroupOwnerAccount")]
                [Validation(Required=false)]
                public string DestGroupOwnerAccount { get; set; }

                /// <summary>
                /// <para>The ID of the destination prefix list for outbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-x1j1k5ykzqlixabc****</para>
                /// </summary>
                [NameInMap("DestPrefixListId")]
                [Validation(Required=false)]
                public string DestPrefixListId { get; set; }

                /// <summary>
                /// <para>The name of the destination prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DestPrefixListName Sample</para>
                /// </summary>
                [NameInMap("DestPrefixListName")]
                [Validation(Required=false)]
                public string DestPrefixListName { get; set; }

                /// <summary>
                /// <para>The direction in which the security group rule is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ingress</para>
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// <para>The transport layer protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The destination IPv6 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:db8:1233:1a00::***</para>
                /// </summary>
                [NameInMap("Ipv6DestCidrIp")]
                [Validation(Required=false)]
                public string Ipv6DestCidrIp { get; set; }

                /// <summary>
                /// <para>The source IPv6 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:db8:1234:1a00::***</para>
                /// </summary>
                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>intranet</para>
                /// </summary>
                [NameInMap("NicType")]
                [Validation(Required=false)]
                public string NicType { get; set; }

                /// <summary>
                /// <para>The access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80/80</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The ID of the port list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prl-2ze9743****</para>
                /// </summary>
                [NameInMap("PortRangeListId")]
                [Validation(Required=false)]
                public string PortRangeListId { get; set; }

                /// <summary>
                /// <para>The name of the port list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PortRangeListNameSample</para>
                /// </summary>
                [NameInMap("PortRangeListName")]
                [Validation(Required=false)]
                public string PortRangeListName { get; set; }

                /// <summary>
                /// <para>The priority of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The ID of the security group rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgr-bp12kewq32dfwrdi****</para>
                /// </summary>
                [NameInMap("SecurityGroupRuleId")]
                [Validation(Required=false)]
                public string SecurityGroupRuleId { get; set; }

                /// <summary>
                /// <para>The source CIDR block for inbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// <para>The source security group for inbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp12kc4rqohaf2js****</para>
                /// </summary>
                [NameInMap("SourceGroupId")]
                [Validation(Required=false)]
                public string SourceGroupId { get; set; }

                /// <summary>
                /// <para>The name of the source security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testSourceGroupName1</para>
                /// </summary>
                [NameInMap("SourceGroupName")]
                [Validation(Required=false)]
                public string SourceGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the source security group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("SourceGroupOwnerAccount")]
                [Validation(Required=false)]
                public string SourceGroupOwnerAccount { get; set; }

                /// <summary>
                /// <para>The source port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80/80</para>
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// <para>The ID of the source prefix list for inbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-x1j1k5ykzqlixdcy****</para>
                /// </summary>
                [NameInMap("SourcePrefixListId")]
                [Validation(Required=false)]
                public string SourcePrefixListId { get; set; }

                /// <summary>
                /// <para>The name of the source prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourcePrefixListName Sample</para>
                /// </summary>
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
