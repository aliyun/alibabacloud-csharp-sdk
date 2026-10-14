// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkPeerConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of the network peering connections.</para>
        /// </summary>
        [NameInMap("NetworkPeerConnects")]
        [Validation(Required=false)]
        public List<DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnects> NetworkPeerConnects { get; set; }
        public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnects : TeaModel {
            /// <summary>
            /// <para>Details of the accepter network.</para>
            /// </summary>
            [NameInMap("AcceptingNetwork")]
            [Validation(Required=false)]
            public DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsAcceptingNetwork AcceptingNetwork { get; set; }
            public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsAcceptingNetwork : TeaModel {
                /// <summary>
                /// <para>The CIDR blocks of the accepter network.</para>
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <para>The network ID of the accepter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-5q28114****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

            }

            /// <summary>
            /// <para>The network ID of the accepter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5q28114****</para>
            /// </summary>
            [NameInMap("AcceptingNetworkId")]
            [Validation(Required=false)]
            public string AcceptingNetworkId { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-31T06:43:29Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the network peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-dongguan-9</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the network peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcc-521pzxdg****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the network peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Details of the requester network.</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsNetwork Network { get; set; }
            public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsNetwork : TeaModel {
                /// <summary>
                /// <para>The CIDR blocks of the requester network.</para>
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <para>The network ID of the requester.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-5q73bm****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

            }

            /// <summary>
            /// <para>The network ID of the requester.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5q73bm****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The status of the network peering connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Creating</c>: The connection is being created.</para>
            /// </description></item>
            /// <item><description><para><c>Activated</c>: The connection is active.</para>
            /// </description></item>
            /// <item><description><para><c>Deleting</c>: The connection is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
