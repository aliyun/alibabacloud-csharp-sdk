// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The start time. The value is in ISO 8601 format. Z in the example indicates UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30T02:00:00.852Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The task failure message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Releasing [prod_main_mid_26e234cf] in region [cn-beijing] with weight [0]</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of node IDs.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7FD7411-9395-52E8-AF42-EB3A4A55446D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution steps.</para>
        /// </summary>
        [NameInMap("Steps")]
        [Validation(Required=false)]
        public List<DescribeTaskResponseBodySteps> Steps { get; set; }
        public class DescribeTaskResponseBodySteps : TeaModel {
            /// <summary>
            /// <para>The step failure message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>get taskinfo failed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The stage tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node scale-in</para>
            /// </summary>
            [NameInMap("StageTag")]
            [Validation(Required=false)]
            public string StageTag { get; set; }

            /// <summary>
            /// <para>The start time. Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30T2:00:00.852Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The step name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create_vpd</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <para>The step execution state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>execution_success</para>
            /// </summary>
            [NameInMap("StepState")]
            [Validation(Required=false)]
            public string StepState { get; set; }

            /// <summary>
            /// <para>The step type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("StepType")]
            [Validation(Required=false)]
            public string StepType { get; set; }

            /// <summary>
            /// <para>The subtasks.</para>
            /// </summary>
            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public List<DescribeTaskResponseBodyStepsSubTasks> SubTasks { get; set; }
            public class DescribeTaskResponseBodyStepsSubTasks : TeaModel {
                /// <summary>
                /// <para>The creation time. The Z in the example indicates UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-30T2:00:00.852Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The subtask failure message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Releasing [prod_main_mid_26e234cf] in region [cn-beijing] with weight [0]</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i158805051661047928377</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task execution state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("TaskState")]
                [Validation(Required=false)]
                public string TaskState { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cut_node_sub_task</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The update time. Uses ISO 8601 format. The Z in the example indicates UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-30T02:20:14.852Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The update time. Uses ISO 8601 format. The Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30T02:20:14.852Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The task state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cut_cluster</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The update time. Uses ISO 8601 format. The Z in the example indicates UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30T03:40:14.852Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
