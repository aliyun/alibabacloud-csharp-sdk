// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The application network topology information.</para>
        /// </summary>
        [NameInMap("AppNetwork")]
        [Validation(Required=false)]
        public GetAppNetworkResponseBodyAppNetwork AppNetwork { get; set; }
        public class GetAppNetworkResponseBodyAppNetwork : TeaModel {
            /// <summary>
            /// <para>The topology edge information.</para>
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkEdge> Edge { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkEdge : TeaModel {
                /// <summary>
                /// <para>The destination node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// <para>The destination node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: application.</description></item>
                /// <item><description><b>internet</b>: external network node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                /// <summary>
                /// <para>The edge ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3534</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The destination port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The source node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                /// <summary>
                /// <para>The source node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: application.</description></item>
                /// <item><description><b>internet</b>: external network node.</description></item>
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
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The namespace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The application node information.</para>
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNode> Node { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNode : TeaModel {
                /// <summary>
                /// <para>The list of container IDs.</para>
                /// </summary>
                [NameInMap("ContainerIds")]
                [Validation(Required=false)]
                public List<string> ContainerIds { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1274</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
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
                /// <item><description><b>3</b>: High.</description></item>
                /// <item><description><b>2</b>: Medium.</description></item>
                /// <item><description><b>1</b>: Low.</description></item>
                /// <item><description><b>0</b>: Safe.</description></item>
                /// <item><description><b>-1</b>: Unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>app</b>: application</description></item>
                /// <item><description><b>internet</b>: external network node.</description></item>
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
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D46EDB0-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
