// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowGraphResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9D91166-A626-5F4E-9CA6-7AB10C59DBD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The list of DAG variables of the task flow.</para>
        /// </summary>
        [NameInMap("TaskFlowGraph")]
        [Validation(Required=false)]
        public GetTaskFlowGraphResponseBodyTaskFlowGraph TaskFlowGraph { get; set; }
        public class GetTaskFlowGraphResponseBodyTaskFlowGraph : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task flow is editable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: editable</description></item>
            /// <item><description><b>false</b>: non-editable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// <para>The name of the task flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DagName")]
            [Validation(Required=false)]
            public string DagName { get; set; }

            /// <summary>
            /// <para>The list of task flow edges.</para>
            /// </summary>
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphEdges Edges { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdges : TeaModel {
                [NameInMap("Edge")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge> Edge { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge : TeaModel {
                    /// <summary>
                    /// <para>The ID of the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15***</para>
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    /// <summary>
                    /// <para>The ID of the task flow edge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The ID of the end node on the edge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44***</para>
                    /// </summary>
                    [NameInMap("NodeEnd")]
                    [Validation(Required=false)]
                    public long? NodeEnd { get; set; }

                    /// <summary>
                    /// <para>The ID of the start node on the edge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44***</para>
                    /// </summary>
                    [NameInMap("NodeFrom")]
                    [Validation(Required=false)]
                    public long? NodeFrom { get; set; }

                }

            }

            /// <summary>
            /// <para>The node list of the task flow.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphNodes Nodes { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodes : TeaModel {
                [NameInMap("Node")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode> Node { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode : TeaModel {
                    /// <summary>
                    /// <para>The ID of the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15***</para>
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    /// <summary>
                    /// <para>The position of the node in the DAG.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;x\&quot;:541,\&quot;y\&quot;:322,\&quot;layoutType\&quot;:\&quot;Horizontal\&quot;}</para>
                    /// </summary>
                    [NameInMap("GraphParam")]
                    [Validation(Required=false)]
                    public string GraphParam { get; set; }

                    /// <summary>
                    /// <para>The advanced configuration of the node.</para>
                    /// </summary>
                    [NameInMap("NodeConfig")]
                    [Validation(Required=false)]
                    public string NodeConfig { get; set; }

                    /// <summary>
                    /// <para>The configuration of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ODI3OTNRVC****UHVFT29&quot;}</para>
                    /// </summary>
                    [NameInMap("NodeContent")]
                    [Validation(Required=false)]
                    public string NodeContent { get; set; }

                    /// <summary>
                    /// <para>The ID of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44***</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// <para>The name of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The type of the node. For more information about the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/424705.html">NodeType parameter</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public long? NodeType { get; set; }

                    /// <summary>
                    /// <para>The time variables for the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;variables\&quot;:[{\&quot;name\&quot;:\&quot;Today\&quot;,\&quot;pattern\&quot;:\&quot;yyyy-MM-dd|+1d\&quot;}]}</para>
                    /// </summary>
                    [NameInMap("TimeVariables")]
                    [Validation(Required=false)]
                    public string TimeVariables { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the task flow. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: invalid</description></item>
            /// <item><description><b>1</b>: not scheduled</description></item>
            /// <item><description><b>2</b>: to be scheduled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
