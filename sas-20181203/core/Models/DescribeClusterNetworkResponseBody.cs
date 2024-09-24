// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the network topology edge in the cluster.</para>
        /// </summary>
        [NameInMap("ClusterNetwork")]
        [Validation(Required=false)]
        public DescribeClusterNetworkResponseBodyClusterNetwork ClusterNetwork { get; set; }
        public class DescribeClusterNetworkResponseBodyClusterNetwork : TeaModel {
            /// <summary>
            /// <para>An array that consists of information about the topology edge.</para>
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkEdge> Edge { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkEdge : TeaModel {
                /// <summary>
                /// <para>The ID of the destination node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfb41a869c71e4678a97021582dd8****</para>
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// <para>The type of the destination node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Set the value to <b>cluster</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                /// <summary>
                /// <para>The ID of the topology edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The port number of the topology edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6164</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The ID of the source node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfb41a869c71e4678a97021582dd8****</para>
                /// </summary>
                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                /// <summary>
                /// <para>The type of the source node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: a cluster.</description></item>
                /// <item><description><b>internet</b>: a network node outside the cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("SrcNodeType")]
                [Validation(Required=false)]
                public string SrcNodeType { get; set; }

            }

            /// <summary>
            /// <para>An array that consists of information about the node.</para>
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkNode> Node { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkNode : TeaModel {
                /// <summary>
                /// <para>The status of the microsegmentation switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: off.</description></item>
                /// <item><description><b>1</b>: on.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CnnfSwitch")]
                [Validation(Required=false)]
                public int? CnnfSwitch { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfeb7a9f99ce740e98c5595d0fe37****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: classic network.</description></item>
                /// <item><description><b>1</b>: virtual private cloud (VPC).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InterceptionType")]
                [Validation(Required=false)]
                public int? InterceptionType { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testwww</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the network topology switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ON</b></description></item>
                /// <item><description><b>OFF</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("NetTopoSwitch")]
                [Validation(Required=false)]
                public string NetTopoSwitch { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>3</b>: high.</description></item>
                /// <item><description><b>2</b>: medium.</description></item>
                /// <item><description><b>1</b>: low.</description></item>
                /// <item><description><b>0</b>: secure.</description></item>
                /// <item><description><b>-1</b>: unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: a cluster.</description></item>
                /// <item><description><b>internet</b>: a network node outside the cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C286491D-4A2F-589A-B63B-D2AD3DA9BD71</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
