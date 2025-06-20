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
        /// <para>The create time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30T02:00:00.852Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error message returned for failed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Releasing [prod_main_mid_26e234cf] in region [cn-beijing] with weight [0]</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes.</para>
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
        /// <para>The steps.</para>
        /// </summary>
        [NameInMap("Steps")]
        [Validation(Required=false)]
        public List<DescribeTaskResponseBodySteps> Steps { get; set; }
        public class DescribeTaskResponseBodySteps : TeaModel {
            /// <summary>
            /// <para>The error message of the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>get taskinfo failed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The stage marker.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>机器释放: Machine release.</description></item>
            /// <item><description>节点并发初始化: Node concurrent initialization.</description></item>
            /// <item><description>节点释放: Node release.</description></item>
            /// <item><description>机器替换: Machine replacement.</description></item>
            /// <item><description>节点缩容: Node scale-in.</description></item>
            /// <item><description>提前续费: Early renewal.</description></item>
            /// <item><description>物理机清理: Physical machine cleanup.</description></item>
            /// <item><description>节点清理: Node cleanup.</description></item>
            /// <item><description>创建K8s集群: Create Kubernetes cluster.</description></item>
            /// <item><description>网络初始化: Network initialization.</description></item>
            /// <item><description>节点重启: Node restart.</description></item>
            /// <item><description>节点退订: Node unsubscribe.</description></item>
            /// <item><description>集群扩容: Cluster scale-out.</description></item>
            /// <item><description>异常机器释放: Abnormal machine release.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>节点缩容</para>
            /// </summary>
            [NameInMap("StageTag")]
            [Validation(Required=false)]
            public string StageTag { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30T2:00:00.852Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The name of the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create_vpd</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <para>The step status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>execution_success</description></item>
            /// <item><description>execution_failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>execution_success</para>
            /// </summary>
            [NameInMap("StepState")]
            [Validation(Required=false)]
            public string StepState { get; set; }

            /// <summary>
            /// <para>The type of the step.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: A normal step has only one successor step.</description></item>
            /// <item><description>dispersive: A dispersive step has multiple successor steps.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("StepType")]
            [Validation(Required=false)]
            public string StepType { get; set; }

            /// <summary>
            /// <para>The sub tasks.</para>
            /// </summary>
            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public List<DescribeTaskResponseBodyStepsSubTasks> SubTasks { get; set; }
            public class DescribeTaskResponseBodyStepsSubTasks : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-30T2:00:00.852Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The error message returned for failed sub tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Releasing [prod_main_mid_26e234cf] in region [cn-beijing] with weight [0]</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i158805051661047928377</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("TaskState")]
                [Validation(Required=false)]
                public string TaskState { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>reclone_node_sub_task</description></item>
                /// <item><description>initialize_bare_cluster</description></item>
                /// <item><description>extend_bare_cluster</description></item>
                /// <item><description>reclone_node</description></item>
                /// <item><description>reboot_node</description></item>
                /// <item><description>extend_ack_edge_cluster</description></item>
                /// <item><description>extend_cluster</description></item>
                /// <item><description>initialize_ack_edge_cluster</description></item>
                /// <item><description>cut_node_sub_task</description></item>
                /// <item><description>reboot_node_sub_task</description></item>
                /// <item><description>reclone_ack_edge_node</description></item>
                /// <item><description>initialize_cluster</description></item>
                /// <item><description>cut_cluster</description></item>
                /// <item><description>reclone_bare_node</description></item>
                /// <item><description>cut_bare_cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cut_node_sub_task</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-30T02:20:14.852Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30T02:20:14.852Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The task status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running</description></item>
        /// <item><description>execution_success</description></item>
        /// <item><description>execution_fail</description></item>
        /// <item><description>waiting_to_run</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>reclone_node_sub_task</description></item>
        /// <item><description>initialize_bare_cluster</description></item>
        /// <item><description>extend_bare_cluster</description></item>
        /// <item><description>reclone_node</description></item>
        /// <item><description>reboot_node</description></item>
        /// <item><description>extend_ack_edge_cluster</description></item>
        /// <item><description>extend_cluster</description></item>
        /// <item><description>initialize_ack_edge_cluster</description></item>
        /// <item><description>cut_node_sub_task</description></item>
        /// <item><description>reboot_node_sub_task</description></item>
        /// <item><description>reclone_ack_edge_node</description></item>
        /// <item><description>initialize_cluster</description></item>
        /// <item><description>cut_cluster</description></item>
        /// <item><description>reclone_bare_node</description></item>
        /// <item><description>cut_bare_cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cut_cluster</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30T03:40:14.852Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
