// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv4 CIDR block of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The list of resources in the network.</para>
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeNetworkAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                /// <summary>
                /// <para>The number of resources in the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// <para>The resource type. VSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitch</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the network was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rt-539***tbs</para>
        /// </summary>
        [NameInMap("GatewayRouteTableId")]
        [Validation(Required=false)]
        public string GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>List of HaVipIds.</para>
        /// </summary>
        [NameInMap("HaVipIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyHaVipIds HaVipIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyHaVipIds : TeaModel {
            [NameInMap("HaVipId")]
            [Validation(Required=false)]
            public List<string> HaVipId { get; set; }

        }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyInstanceIds InstanceIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// <para>List of ELB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyLoadBalancerIds LoadBalancerIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyLoadBalancerIds : TeaModel {
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public List<string> LoadBalancerId { get; set; }

        }

        /// <summary>
        /// <para>List of NAT Gateways.</para>
        /// </summary>
        [NameInMap("NatGatewayIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyNatGatewayIds NatGatewayIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyNatGatewayIds : TeaModel {
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public List<string> NatGatewayId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the network access control list (ACL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-a2do9e413e0sp****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5***</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>A list of multicast source IDs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyNetworkInterfaceIds NetworkInterfaceIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyNetworkInterfaceIds : TeaModel {
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public List<string> NetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// <para>The name of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rt-539***fpu</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>List of routing table IDs.</para>
        /// </summary>
        [NameInMap("RouteTableIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyRouteTableIds RouteTableIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyRouteTableIds : TeaModel {
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public List<string> RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtb-5***</para>
        /// </summary>
        [NameInMap("RouterTableId")]
        [Validation(Required=false)]
        public string RouterTableId { get; set; }

        /// <summary>
        /// <para>The status of the network. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending</description></item>
        /// <item><description>Available</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of vSwitches in the network.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyVSwitchIds VSwitchIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyVSwitchIds : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public List<string> VSwitchId { get; set; }

        }

    }

}
