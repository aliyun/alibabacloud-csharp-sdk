// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance to which the ENI is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1e2l6djkndyuli****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>An array that consists of the IPv6 address of the ENI. You can specify multiple IPv6 addresses. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4321:180:1701:94c7:bc38:3bfa:****</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: 10 to 500.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified or if this parameter is set to a value less than 10, the default value is 10.</description></item>
        /// <item><description>If this parameter is set to a value greater than 500, the default value is 500.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>An array that consists of the IDs of the ENIs. You specify multiple ENI IDs. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp125p95hhdhn3ot****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-eni-name</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the <c>NextToken</c> value returned in the last call to this operation.</para>
        /// <para>For more information about how to check the responses returned by this operation, see the preceding &quot;Description&quot; section.</para>
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
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
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
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 1000.</para>
        /// <para>Default value: 10.</para>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
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
        /// <para>The primary private IPv4 address of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// <para>An array that consists of the secondary private IPv4 addresses of the ENI. You can specify multiple secondary private IPv4 addresses. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the ENI. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ENI belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be returned.</para>
        /// <remarks>
        /// <para>Resources in the default resource group are displayed in the response regardless of how this parameter is set.</para>
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
        /// <para>The ID of the security group to which the secondary ENI belongs.</para>
        /// <list type="bullet">
        /// <item><description>To query the details of secondary ENIs based on the ID of a security group, specify this parameter.</description></item>
        /// <item><description>To query the details of primary ENIs based on the ID of a security group, call the <a href="https://help.aliyun.com/document_detail/25506.html">DescribeInstances</a> operation and specify the <c>SecurityGroupId</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp144yr32sx6ndw****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the user of the ENI is an Alibaba Cloud service or a distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The state of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: The ENI is available.</description></item>
        /// <item><description>Attaching: The ENI is being attached to an instance.</description></item>
        /// <item><description>InUse: The ENI is attached to an instance.</description></item>
        /// <item><description>Detaching: The ENI is being detached from an instance.</description></item>
        /// <item><description>Deleting: The ENI is being deleted.</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates that ENIs in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags to use for query.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfacesRequestTag> Tag { get; set; }
        public class DescribeNetworkInterfacesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the ENI. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the ENI. Valid values of N: 1 to 20.</para>
            /// <para>If a single tag is specified to query ENIs, up to 1,000 ENIs that have this tag can be returned. If multiple tags are specified to query ENIs, up to 1,000 ENIs that have all these tags can be returned. To query more than 1,000 resources that have specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Primary</description></item>
        /// <item><description>Secondary</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates that both primary and secondary ENIs are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch with which the ENI is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp16usj2p27htro3****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the elastic network interface (ENI) belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp16usj2p27htro3****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
