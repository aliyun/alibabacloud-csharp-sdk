// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network topology edge information at the cluster level.</para>
        /// </summary>
        [NameInMap("ClusterNetwork")]
        [Validation(Required=false)]
        public DescribeClusterNetworkResponseBodyClusterNetwork ClusterNetwork { get; set; }
        public class DescribeClusterNetworkResponseBodyClusterNetwork : TeaModel {
            /// <summary>
            /// <para>The list of topology edge information.</para>
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkEdge> Edge { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkEdge : TeaModel {
                /// <summary>
                /// <para>The destination node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfb41a869c71e4678a97021582dd8****</para>
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// <para>The destination node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: cluster.</description></item>
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
                /// <para>The source node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfb41a869c71e4678a97021582dd8****</para>
                /// </summary>
                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                /// <summary>
                /// <para>The source node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: cluster.</description></item>
                /// <item><description><b>internet</b>: external network node.</description></item>
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
            /// <para>The list of node information.</para>
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkNode> Node { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkNode : TeaModel {
                /// <summary>
                /// <para>The container firewall switch status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: disabled.</description></item>
                /// <item><description><b>1</b>: enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CnnfSwitch")]
                [Validation(Required=false)]
                public int? CnnfSwitch { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
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
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testwww</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network topology switch status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ON</b>: enabled.</description></item>
                /// <item><description><b>OFF</b>: disabled.</description></item>
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
                /// <item><description><b>0</b>: safe.</description></item>
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
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: cluster.</description></item>
                /// <item><description><b>internet</b>: external network node outside the cluster.</description></item>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C286491D-4A2F-589A-B63B-D2AD3DA9BD71</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
