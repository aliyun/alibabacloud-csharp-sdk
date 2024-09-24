// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application network topology.</para>
        /// </summary>
        [NameInMap("AppNetwork")]
        [Validation(Required=false)]
        public GetAppNetworkResponseBodyAppNetwork AppNetwork { get; set; }
        public class GetAppNetworkResponseBodyAppNetwork : TeaModel {
            /// <summary>
            /// <para>The information about the topology edge.</para>
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkEdge> Edge { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkEdge : TeaModel {
                /// <summary>
                /// <para>The ID of the destination node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// <para>The type of the destination node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: an application</description></item>
                /// <item><description><b>internet</b>: a network node in another cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                /// <summary>
                /// <para>The ID of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3534</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The number of the destination port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The ID of the source node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                /// <summary>
                /// <para>The type of the source node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: an application</description></item>
                /// <item><description><b>internet</b>: a network node in another cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("SrcNodeType")]
                [Validation(Required=false)]
                public string SrcNodeType { get; set; }

            }

            /// <summary>
            /// <para>The namespace.</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNamespace> Namespace { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNamespace : TeaModel {
                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the custom namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The information about the application node.</para>
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNode> Node { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNode : TeaModel {
                /// <summary>
                /// <para>The list of the container IDs.</para>
                /// </summary>
                [NameInMap("ContainerIds")]
                [Validation(Required=false)]
                public List<string> ContainerIds { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1274</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>3</b>: high</description></item>
                /// <item><description><b>2</b>: medium</description></item>
                /// <item><description><b>1</b>: low</description></item>
                /// <item><description><b>0</b>: warning</description></item>
                /// <item><description><b>-1</b>: unknown</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: an application</description></item>
                /// <item><description><b>internet</b>: a network node in another cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D46EDB0-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
