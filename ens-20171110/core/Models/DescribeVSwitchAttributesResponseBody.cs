// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchAttributesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>253</para>
        /// </summary>
        [NameInMap("AvailableIpAddressCount")]
        [Validation(Required=false)]
        public long? AvailableIpAddressCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-06-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is my vswitch.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>C0003****2A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Test-switch</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
