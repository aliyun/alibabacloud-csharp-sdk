// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// <para>The baseline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The time when the instance started running.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                /// <summary>
                /// <para>The time when the instance started waiting for resources.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                /// <summary>
                /// <para>The time when the instance started waiting for scheduling.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                /// <summary>
                /// <para>The data timestamp of the scheduled node. This is typically the day before the node runs.</para>
                /// <para>The value is a 13-digit number, such as <c>1590336000000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590336000000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The business process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>The connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The user who triggered the instance to run. For example, if user Test triggered a data backfill instance, the CreateUser is Test.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The scheduled runtime of the node.</para>
                /// <para>The value is a 13-digit number, such as <c>1590422400000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590422400000</para>
                /// </summary>
                [NameInMap("CycTime")]
                [Validation(Required=false)]
                public long? CycTime { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33845</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// <para>The type of the workflow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DAILY(0): daily scheduling workflow.</description></item>
                /// <item><description>MANUAL(1): manual task workflow.</description></item>
                /// <item><description>SMOKE_TEST(2): smoke testing workflow.</description></item>
                /// <item><description>SUPPLY_DATA(3): data backfill workflow.</description></item>
                /// <item><description>MANUAL_FLOW(4): manually triggered dataflow PAI workflow (such as running a workflow in the IDE).</description></item>
                /// <item><description>BUSINESS_PROCESS_DAG(5): manual business process workflow.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("DagType")]
                [Validation(Required=false)]
                public string DagType { get; set; }

                /// <summary>
                /// <para>The DQC partitioning rule string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;projectName&quot;:&quot;ztjy_dim&quot;,&quot;tableName&quot;:&quot;dim_user_agent_manage_area_a&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyy-mm-dd-1]&quot;}]</para>
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// <para>The DQC type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: associated with DQC.</description></item>
                /// <item><description>1: not associated with DQC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public int? DqcType { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The error message of the instance run. You can call <a href="https://help.aliyun.com/document_detail/173983.html">GetInstanceLog</a> to obtain the error information of the executed task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error message</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the scheduled node finished running.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The time when the scheduled node was last modified.</para>
                /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590416703313</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33115</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kzh</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The parameter information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bizdate=$bizdate tbods=$tbods</para>
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// <para>The priority of the instance. Valid values: 1, 3, 5, 7, and 8.</para>
                /// <para>A larger value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the associated business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("RelatedFlowId")]
                [Validation(Required=false)]
                public long? RelatedFlowId { get; set; }

                /// <summary>
                /// <para>The interval at which the node is rescheduled after a failure. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60000</para>
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance task can be rerun.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// <para>The status of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NOT_RUN(1): The node is not run.</description></item>
                /// <item><description>WAIT_TIME(2): The node is waiting for the scheduled time to arrive.</description></item>
                /// <item><description>WAIT_RESOURCE(3): The node has been sent to the execution engine and is waiting for resources to be scheduled.</description></item>
                /// <item><description>RUNNING(4): The node is running.</description></item>
                /// <item><description>CHECKING(7): The node has finished running and has been sent to Data Quality for data verification.</description></item>
                /// <item><description>CHECKING_CONDITION(8): The node has finished running and is undergoing branch condition verification.</description></item>
                /// <item><description>WAIT_TRIGGER(9): The node is waiting to be triggered. A trigger-based node enters this state after the waiting time elapses.</description></item>
                /// <item><description>FAILURE(5): The node failed to run.</description></item>
                /// <item><description>SUCCESS(6): The node ran successfully.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NOT_RUN</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of remaining reruns for the instance. The value can be empty or an integer greater than or equal to 0.</para>
                /// <list type="bullet">
                /// <item><description>Empty: The node corresponding to this instance does not have automatic rerun configured.</description></item>
                /// <item><description>0: The instance cannot be rerun.</description></item>
                /// <item><description>An integer greater than 0 (n): The instance can be rerun n times. For example, if the value is 1, the remaining rerun count is 1. If the value is 2, the remaining rerun count is 2, and so on. The initial value is the automatic rerun count defined for the corresponding node plus 1.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskRerunTime")]
                [Validation(Required=false)]
                public int? TaskRerunTime { get; set; }

                /// <summary>
                /// <para>The scheduling type of the task instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL(0): The node is a normal scheduled node that is triggered by daily scheduling.</description></item>
                /// <item><description>MANUAL(1): The node is a manual node that is not triggered by daily scheduling.</description></item>
                /// <item><description>PAUSE(2): The node is a frozen node that is triggered by daily scheduling but is set to failed when scheduling starts.</description></item>
                /// <item><description>SKIP(3): The node is a dry-run node that is triggered by daily scheduling but is set to successful when scheduling starts.</description></item>
                /// <item><description>SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. It exists only in temporary workflows and is set to successful when scheduling starts.</description></item>
                /// <item><description>SKIP_CYCLE(5): The node is a weekly or monthly node whose scheduling cycle has not arrived. It is triggered by daily scheduling but is set to successful when scheduling starts.</description></item>
                /// <item><description>CONDITION_UNCHOOSE(6): The upstream instance contains a branch (IF) node, but this downstream node is not selected by the branch node and is set to a dry-run node.</description></item>
                /// <item><description>REALTIME_DEPRECATED(7): The node is an expired periodic instance generated in real time. This type of node is set to successful.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL(0)</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ProjectNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The project does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
