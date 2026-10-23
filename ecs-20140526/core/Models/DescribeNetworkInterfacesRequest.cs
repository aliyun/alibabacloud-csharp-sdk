// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID to which the Elastic Network Interface (ENI) is currently attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1e2l6djkndyuli****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IPv6 address of the Elastic Network Interface (ENI). N indicates that multiple IPv6 addresses can be configured. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4321:180:1701:94c7:bc38:3bfa:****</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paging query. Valid values: 10 to 500.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified or the specified value is less than 10, the default value is 10.</description></item>
        /// <item><description>If the specified value is greater than 500, the default value is 500.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The Elastic Network Interface (ENI) ID. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp125p95hhdhn3ot****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the Elastic Network Interface (ENI). The name must be 2 to 128 characters in length, and can contain characters in the letter categorization of Unicode (including English, Chinese, and digits). It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-eni-name</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the <c>NextToken</c> value returned from the previous API call.</para>
        /// <para>For more information about how to configure the pagination parameters, see the &quot;Operation description&quot; section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para><b>[Deprecated]</b> We recommend that you use the <c>MaxResults</c> and <c>NextToken</c> parameters for pagination.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageNumber { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para><b>[Deprecated]</b> We recommend that you use the <c>MaxResults</c> and <c>NextToken</c> parameters for pagination.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The primary private network IPv4 address of the Elastic Network Interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// <para>The secondary private IP IPv4 address of the Elastic Network Interface (ENI). Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. When you use this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group ID of the secondary ENI.</para>
        /// <list type="bullet">
        /// <item><description>To query the information about secondary ENIs by security group ID, specify this parameter.</description></item>
        /// <item><description>To query the information about primary ENIs by security group ID, call the <a href="https://help.aliyun.com/document_detail/25506.html">DescribeInstances</a> operation and specify the <c>SecurityGroupId</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp144yr32sx6ndw****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the Elastic Network Interface (ENI) is used by an Alibaba Cloud service or a Virtual Network Operator (VNO).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The status of the Elastic Network Interface (ENI). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: active.</description></item>
        /// <item><description>Attaching: being attached.</description></item>
        /// <item><description>InUse: attached.</description></item>
        /// <item><description>Detaching: being detached.</description></item>
        /// <item><description>Deleting: being deleted.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that Elastic Network Interfaces (ENIs) in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfacesRequestTag> Tag { get; set; }
        public class DescribeNetworkInterfacesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the Elastic Network Interface (ENI). Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the Elastic Network Interface (ENI). Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the number of resources that match the tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources that are attached with multiple tags cannot exceed 1,000. If the number of resources exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Elastic Network Interface (ENI) type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Primary: primary network interface controller (NIC).</description></item>
        /// <item><description>Secondary: secondary ENI.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that Elastic Network Interfaces (ENIs) of all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the Elastic Network Interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp16usj2p27htro3****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID of the Elastic Network Interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1j7w3gc1cexjqd****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
