// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>Error codes</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data of the workflow.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkFlowResponseBodyData Data { get; set; }
        public class GetWorkFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic information of the workflow.</para>
            /// </summary>
            [NameInMap("WorkFlowInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowInfo WorkFlowInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowInfo : TeaModel {
                /// <summary>
                /// <para>The description of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my first workflow</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The name of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workflow_111</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The status of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successful</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time expression of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 2 * * ?</para>
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// <para>The time type of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// <para>The ID of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234xxx</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

            /// <summary>
            /// <para>The node information of the workflow.</para>
            /// </summary>
            [NameInMap("WorkFlowNodeInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowNodeInfo WorkFlowNodeInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowNodeInfo : TeaModel {
                /// <summary>
                /// <para>The workflow edges.</para>
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges> Edges { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges : TeaModel {
                    /// <summary>
                    /// <para>The ID of the source job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    /// <summary>
                    /// <para>The ID of the object job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                /// <summary>
                /// <para>The list of workflow nodes.</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes> Nodes { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes : TeaModel {
                    /// <summary>
                    /// <para>The ID of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456xxx</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>job_111</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The status of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>workflow is not existed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45678xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
