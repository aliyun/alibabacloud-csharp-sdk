// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListGrantVSwitchEnisResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network interface controller (NIC) information.</para>
        /// </summary>
        [NameInMap("GrantVSwitchEnis")]
        [Validation(Required=false)]
        public List<ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis> GrantVSwitchEnis { get; set; }
        public class ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis : TeaModel {
            /// <summary>
            /// <para>The description of the elastic network interfaces (ENIs). This describes the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>created by CBN</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interfaces (ENIs). This is the network interface controller (NIC) identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0w172vv82kxzb49****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The name of the elastic network interfaces (ENIs). This is the network interface controller (NIC) name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-eni-name</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The primary private IP IPv4 address of the elastic network interfaces (ENIs). This is the network interface controller (NIC) primary private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>192.168.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether the elastic network interface (ENI) is created by a transit router for routing and forwarding purposes.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The ENI is created by a transit router.</description></item>
            /// <item><description><b>false</b>: The ENI is not created by a transit router.</description></item>
            /// </list>
            /// <para>Elastic network interfaces (ENIs) created by transit routers cannot serve as multicast sources or multicast members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TransitRouterFlag")]
            [Validation(Required=false)]
            public bool? TransitRouterFlag { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-p0w9s2ig1jnwgrbzl****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC-connected instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w9alkte4w2htrqe****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBFE1736-2F33-5309-9954-875B11E9519D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// <remarks>
        /// <para>Notice: When you use the MaxResults and NextToken parameters for paging, the returned Total parameter value is meaningless.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
