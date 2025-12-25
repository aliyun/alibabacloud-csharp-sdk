// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateWorkflowDAGRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-a1804a3226d</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Dag")]
        [Validation(Required=false)]
        public UpdateWorkflowDAGRequestDag Dag { get; set; }
        public class UpdateWorkflowDAGRequestDag : TeaModel {
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<UpdateWorkflowDAGRequestDagEdges> Edges { get; set; }
            public class UpdateWorkflowDAGRequestDagEdges : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public long? Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<UpdateWorkflowDAGRequestDagNodes> Nodes { get; set; }
            public class UpdateWorkflowDAGRequestDagNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;logicType&quot;: &quot;status_branch&quot;,
                ///     &quot;conditionResult&quot;: {
                ///         &quot;successList&quot;: [
                ///             {
                ///                 &quot;jobName&quot;: &quot;status-job4&quot;,
                ///                 &quot;jobId&quot;: &quot;269&quot;
                ///             }
                ///         ],
                ///         &quot;failedList&quot;: [
                ///             {
                ///                 &quot;jobName&quot;: &quot;status-job5&quot;,
                ///                 &quot;jobId&quot;: &quot;270&quot;
                ///             }
                ///         ]
                ///     },
                ///     &quot;dependence&quot;: {
                ///         &quot;relation&quot;: &quot;AND&quot;,
                ///         &quot;dependList&quot;: [
                ///             {
                ///                 &quot;relation&quot;: &quot;AND&quot;,
                ///                 &quot;dependItemList&quot;: [
                ///                     {
                ///                         &quot;jobName&quot;: &quot;status-job1&quot;,
                ///                         &quot;jobId&quot;: 265,
                ///                         &quot;status&quot;: [
                ///                             4
                ///                         ]
                ///                     },
                ///                     {
                ///                         &quot;jobName&quot;: &quot;status-job2&quot;,
                ///                         &quot;jobId&quot;: 266,
                ///                         &quot;status&quot;: [
                ///                             5
                ///                         ]
                ///                     }
                ///                 ]
                ///             },
                ///             {
                ///                 &quot;relation&quot;: &quot;AND&quot;,
                ///                 &quot;dependItemList&quot;: [
                ///                     {
                ///                         &quot;jobName&quot;: &quot;status-job3&quot;,
                ///                         &quot;jobId&quot;: 267,
                ///                         &quot;status&quot;: [
                ///                             4
                ///                         ]
                ///                     }
                ///                 ]
                ///             }
                ///         ]
                ///     }
                /// }</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public UpdateWorkflowDAGRequestDagNodesCoordinate Coordinate { get; set; }
                public class UpdateWorkflowDAGRequestDagNodesCoordinate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public float? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public float? Width { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1137005</para>
        /// </summary>
        [NameInMap("DagVersion")]
        [Validation(Required=false)]
        public string DagVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

    }

}
