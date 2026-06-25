// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetWorkflowExecutionDAGResponseBody : TeaModel {
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
        /// <para>The data returned for the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowExecutionDAGResponseBodyData Data { get; set; }
        public class GetWorkflowExecutionDAGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of edges in the workflow DAG.</para>
            /// </summary>
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<GetWorkflowExecutionDAGResponseBodyDataEdges> Edges { get; set; }
            public class GetWorkflowExecutionDAGResponseBodyDataEdges : TeaModel {
                /// <summary>
                /// <para>The ID of the source node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The ID of the target node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

            /// <summary>
            /// <para>A list of nodes in the workflow DAG.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetWorkflowExecutionDAGResponseBodyDataNodes> Nodes { get; set; }
            public class GetWorkflowExecutionDAGResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cua-xxl-job-executor</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The coordinates of the node.</para>
                /// </summary>
                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public GetWorkflowExecutionDAGResponseBodyDataNodesCoordinate Coordinate { get; set; }
                public class GetWorkflowExecutionDAGResponseBodyDataNodesCoordinate : TeaModel {
                    /// <summary>
                    /// <para>The height of the node. This parameter is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public float? Height { get; set; }

                    /// <summary>
                    /// <para>The width of the node. This parameter is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public float? Width { get; set; }

                    /// <summary>
                    /// <para>The x-coordinate of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <para>The y-coordinate of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <para>The unique ID for the job execution (node).</para>
                /// 
                /// <b>Example:</b>
                /// <para>7491777526619542799</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>script_shell</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The execution status of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Unknown</para>
                /// </description></item>
                /// <item><description><para>1: Waiting</para>
                /// </description></item>
                /// <item><description><para>2: Queued</para>
                /// </description></item>
                /// <item><description><para>3: Running</para>
                /// </description></item>
                /// <item><description><para>4: Succeeded</para>
                /// </description></item>
                /// <item><description><para>5: Failed</para>
                /// </description></item>
                /// <item><description><para>6: Killed</para>
                /// </description></item>
                /// <item><description><para>7: Held</para>
                /// </description></item>
                /// <item><description><para>8: Marked as successful</para>
                /// </description></item>
                /// <item><description><para>9: Skipped</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
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
        /// <para>Parameter format error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3835AA29-2298-5434-BC53-9CC377CDFD2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
