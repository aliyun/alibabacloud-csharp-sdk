// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of available IP addresses in the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>253</para>
        /// </summary>
        [NameInMap("AvailableIpAddressCount")]
        [Validation(Required=false)]
        public long? AvailableIpAddressCount { get; set; }

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
        /// <para>The time when the vSwitch was created. This value uses UTC and follows the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my vswitch.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the ENS edge zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("HaVipIds")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyHaVipIds HaVipIds { get; set; }
        public class DescribeVSwitchAttributesResponseBodyHaVipIds : TeaModel {
            [NameInMap("HaVipId")]
            [Validation(Required=false)]
            public List<string> HaVipId { get; set; }

        }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyInstanceIds InstanceIds { get; set; }
        public class DescribeVSwitchAttributesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyLoadBalancerIds LoadBalancerIds { get; set; }
        public class DescribeVSwitchAttributesResponseBodyLoadBalancerIds : TeaModel {
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public List<string> LoadBalancerId { get; set; }

        }

        [NameInMap("NatGatewayIds")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyNatGatewayIds NatGatewayIds { get; set; }
        public class DescribeVSwitchAttributesResponseBodyNatGatewayIds : TeaModel {
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public List<string> NatGatewayId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyNetworkInterfaceIds NetworkInterfaceIds { get; set; }
        public class DescribeVSwitchAttributesResponseBodyNetworkInterfaceIds : TeaModel {
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public List<string> NetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003****2A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The vSwitch is being configured.</para>
        /// </description></item>
        /// <item><description><para>Available: The vSwitch is active.</para>
        /// </description></item>
        /// <item><description><para>Releasing: The vSwitch is being released.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The name of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test-switch</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
