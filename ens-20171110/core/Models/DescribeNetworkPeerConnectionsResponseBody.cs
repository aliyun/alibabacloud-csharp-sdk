// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkPeerConnectionsResponseBody : TeaModel {
        [NameInMap("NetworkPeerConnects")]
        [Validation(Required=false)]
        public List<DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnects> NetworkPeerConnects { get; set; }
        public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnects : TeaModel {
            [NameInMap("AcceptingNetwork")]
            [Validation(Required=false)]
            public DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsAcceptingNetwork AcceptingNetwork { get; set; }
            public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsAcceptingNetwork : TeaModel {
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n-5q28114****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-5q28114****</para>
            /// </summary>
            [NameInMap("AcceptingNetworkId")]
            [Validation(Required=false)]
            public string AcceptingNetworkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-31T06:43:29Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-dongguan-9</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pcc-521pzxdg****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsNetwork Network { get; set; }
            public class DescribeNetworkPeerConnectionsResponseBodyNetworkPeerConnectsNetwork : TeaModel {
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n-5q73bm****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-5q73bm****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
