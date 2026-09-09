// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListTaskInstancesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListTaskInstancesResponseBodyPagingInfo : TeaModel {
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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of task instances.</para>
            /// </summary>
            [NameInMap("TaskInstances")]
            [Validation(Required=false)]
            public List<ListTaskInstancesResponseBodyPagingInfoTaskInstances> TaskInstances { get; set; }
            public class ListTaskInstancesResponseBodyPagingInfoTaskInstances : TeaModel {
                /// <summary>
                /// <para>The baseline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The business date.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The account ID of the user who created the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The data source information associated with the instance.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource DataSource { get; set; }
                public class ListTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the instance finished running.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public long? FinishedTime { get; set; }

                /// <summary>
                /// <para>The unique identifier of the task instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The account ID of the user who last modified the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The type of the most recent operation on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TriggerDqc</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The account ID of the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The period number. Indicates which scheduling cycle of the day the instance belongs to.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodNumber")]
                [Validation(Required=false)]
                public int? PeriodNumber { get; set; }

                /// <summary>
                /// <para>The run priority of the node. Minimum value: 1. Maximum value: 8. A larger value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The project environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod: production.</description></item>
                /// <item><description>Dev: development.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("ProjectEnv")]
                [Validation(Required=false)]
                public string ProjectEnv { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The rerun configuration for the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AllDenied: rerun is not allowed regardless of success or failure.</description></item>
                /// <item><description>FailureAllowed: rerun is allowed only upon failure.</description></item>
                /// <item><description>AllAllowed: rerun is allowed regardless of success or failure.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The current run number, starting from 1 by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunNumber")]
                [Validation(Required=false)]
                public int? RunNumber { get; set; }

                /// <summary>
                /// <para>The runtime information of the instance.</para>
                /// </summary>
                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime Runtime { get; set; }
                public class ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime : TeaModel {
                    /// <summary>
                    /// <para>The machine on which the instance runs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai.1.2</para>
                    /// </summary>
                    [NameInMap("Gateway")]
                    [Validation(Required=false)]
                    public string Gateway { get; set; }

                    /// <summary>
                    /// <para>The unique run ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3_123</para>
                    /// </summary>
                    [NameInMap("ProcessId")]
                    [Validation(Required=false)]
                    public string ProcessId { get; set; }

                }

                /// <summary>
                /// <para>The resource group information associated with the instance.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource RuntimeResource { get; set; }
                public class ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The compute unit (CU) consumption configured for the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public string Cu { get; set; }

                    /// <summary>
                    /// <para>The image ID configured for the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-xxxxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The identifier of the schedule resource group configured for the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>The list of script parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=val1 para2=val2</para>
                /// </summary>
                [NameInMap("ScriptParameters")]
                [Validation(Required=false)]
                public string ScriptParameters { get; set; }

                /// <summary>
                /// <para>The time when the instance started running.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("StartedTime")]
                [Validation(Required=false)]
                public long? StartedTime { get; set; }

                /// <summary>
                /// <para>The run status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NotRun: not run.</description></item>
                /// <item><description>Running: running.</description></item>
                /// <item><description>WaitTime: waiting for the TriggerTime to arrive.</description></item>
                /// <item><description>CheckingCondition: checking branch conditions.</description></item>
                /// <item><description>WaitResource: waiting for resources.</description></item>
                /// <item><description>Failure: execution failed.</description></item>
                /// <item><description>Success: execution succeeded.</description></item>
                /// <item><description>Checking: submitted for qualityrule check.</description></item>
                /// <item><description>WaitTrigger: waiting for an external trigger. Trigger-based nodes enter this status after the waiting period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the corresponding node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The name of the corresponding node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL node</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The type of the corresponding node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The timeout period for node execution, in seconds.</para>
                /// <para>Note: The scheduling system rounds the configured value to the nearest hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The run mode at the time of triggering. This parameter takes effect when TriggerType is set to Scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: paused.</description></item>
                /// <item><description>Skip: dry run.</description></item>
                /// <item><description>Normal: normal run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("TriggerRecurrence")]
                [Validation(Required=false)]
                public string TriggerRecurrence { get; set; }

                /// <summary>
                /// <para>The scheduled trigger time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("TriggerTime")]
                [Validation(Required=false)]
                public long? TriggerTime { get; set; }

                /// <summary>
                /// <para>The trigger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: triggered by a scheduling cycle.</description></item>
                /// <item><description>Manual: manually triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                /// <summary>
                /// <para>The unified workflow instance ID. All instances within the same business date under a single trigger share the same value for this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UnifiedWorkflowInstanceId")]
                [Validation(Required=false)]
                public long? UnifiedWorkflowInstanceId { get; set; }

                /// <summary>
                /// <para>The time when the instance entered the waiting-for-resource state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("WaitingResourceTime")]
                [Validation(Required=false)]
                public long? WaitingResourceTime { get; set; }

                /// <summary>
                /// <para>The time when the instance entered the waiting-for-scheduled-time state.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("WaitingTriggerTime")]
                [Validation(Required=false)]
                public long? WaitingTriggerTime { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

                /// <summary>
                /// <para>The ID of the workflow instance to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowInstanceId")]
                [Validation(Required=false)]
                public long? WorkflowInstanceId { get; set; }

                /// <summary>
                /// <para>The type of the workflow instance to which the instance belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SmokeTest: smoke test.</description></item>
                /// <item><description>SupplementData: data backfill.</description></item>
                /// <item><description>Manual: manually triggered.</description></item>
                /// <item><description>ManualWorkflow: manual workflow.</description></item>
                /// <item><description>Normal: periodic scheduling.</description></item>
                /// <item><description>ManualFlow: manually triggered workflow.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("WorkflowInstanceType")]
                [Validation(Required=false)]
                public string WorkflowInstanceType { get; set; }

                /// <summary>
                /// <para>The name of the workflow to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test workflow</para>
                /// </summary>
                [NameInMap("WorkflowName")]
                [Validation(Required=false)]
                public string WorkflowName { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
