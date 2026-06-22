// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectRequest : TeaModel {
        /// <summary>
        /// <para>The query type of the element to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EDGE</b>: connection information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EDGE</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination node information, which is used to filter destination nodes.</para>
        /// </summary>
        [NameInMap("DstNode")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectRequestDstNode DstNode { get; set; }
        public class FindContainerNetworkConnectRequestDstNode : TeaModel {
            /// <summary>
            /// <para>The name of the container application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx-ingress-controller</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster to query.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>f5x833820xx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The namespace of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The list of node IDs.</para>
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>app</b>: application. The node type is application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The name of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-deployment-yacs-31144-39265-1384966-7f8c8cd578-h6mhb</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

        }

        /// <summary>
        /// <para>The end time of the network connectivity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649260799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The source node information, which is used to filter source nodes.</para>
        /// </summary>
        [NameInMap("SrcNode")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectRequestSrcNode SrcNode { get; set; }
        public class FindContainerNetworkConnectRequestSrcNode : TeaModel {
            /// <summary>
            /// <para>The name of the container application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prometheus-ack-arms-prometheus</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster to query.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>c56xxx1775dea0</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The namespace of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The list of node IDs.</para>
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>app</b>: application. The node type is application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The name of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-deployment-yacs-31144-39265-1384966-7f8c8cd578-h6mhb</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

        }

        /// <summary>
        /// <para>The start time of the network connectivity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666886400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
