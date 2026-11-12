// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetWorkflowDAGResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowDAGResponseBodyData Data { get; set; }
        public class GetWorkflowDAGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of workflow edges.</para>
            /// </summary>
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<GetWorkflowDAGResponseBodyDataEdges> Edges { get; set; }
            public class GetWorkflowDAGResponseBodyDataEdges : TeaModel {
                /// <summary>
                /// <para>The task ID of the source node of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public long? Source { get; set; }

                /// <summary>
                /// <para>The task ID of the target node of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            /// <summary>
            /// <para>The returned data type.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetWorkflowDAGResponseBodyDataNodes> Nodes { get; set; }
            public class GetWorkflowDAGResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oak-payment-async-job</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The coordinate information of the node.</para>
                /// </summary>
                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public GetWorkflowDAGResponseBodyDataNodesCoordinate Coordinate { get; set; }
                public class GetWorkflowDAGResponseBodyDataNodesCoordinate : TeaModel {
                    /// <summary>
                    /// <para>The height of the node. This field is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public float? Height { get; set; }

                    /// <summary>
                    /// <para>The width of the node. This field is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public float? Width { get; set; }

                    /// <summary>
                    /// <para>The X-axis coordinate of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <para>The Y-axis coordinate of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <para>The dependency policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DependentStrategy")]
                [Validation(Required=false)]
                public int? DependentStrategy { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>script_shell</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Disabled.</description></item>
                /// <item><description>1: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EF879D0-3B43-5AD1-9BF7-52418F9C5E73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
