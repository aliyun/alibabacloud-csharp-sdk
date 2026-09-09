// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about the task instance.</para>
        /// </summary>
        [NameInMap("TaskInstance")]
        [Validation(Required=false)]
        public GetTaskInstanceResponseBodyTaskInstance TaskInstance { get; set; }
        public class GetTaskInstanceResponseBodyTaskInstance : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
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
            public GetTaskInstanceResponseBodyTaskInstanceDataSource DataSource { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceDataSource : TeaModel {
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
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the node instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The input information.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public GetTaskInstanceResponseBodyTaskInstanceInputs Inputs { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceInputs : TeaModel {
                /// <summary>
                /// <para>The list of variable definitions.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<GetTaskInstanceResponseBodyTaskInstanceInputsVariables> Variables { get; set; }
                public class GetTaskInstanceResponseBodyTaskInstanceInputsVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Key1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: constant.</description></item>
                    /// <item><description>PassThrough: output of a parameter node.</description></item>
                    /// <item><description>System: variable.</description></item>
                    /// <item><description>NodeOutput: script output.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Constant</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Value1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The account ID of the user who modified the instance.</para>
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
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public GetTaskInstanceResponseBodyTaskInstanceOutputs Outputs { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceOutputs : TeaModel {
                /// <summary>
                /// <para>The list of task output definitions.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<GetTaskInstanceResponseBodyTaskInstanceOutputsTaskOutputs> TaskOutputs { get; set; }
                public class GetTaskInstanceResponseBodyTaskInstanceOutputsTaskOutputs : TeaModel {
                    /// <summary>
                    /// <para>The output identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pre.odps_sql_demo_0</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

                /// <summary>
                /// <para>The list of variable definitions.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<GetTaskInstanceResponseBodyTaskInstanceOutputsVariables> Variables { get; set; }
                public class GetTaskInstanceResponseBodyTaskInstanceOutputsVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: constant.</description></item>
                    /// <item><description>PassThrough: output of a parameter node.</description></item>
                    /// <item><description>System: variable.</description></item>
                    /// <item><description>NodeOutput: script output.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Constant</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

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
            /// <para>The period number. Indicates which scheduling cycle of the day the task instance is in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodNumber")]
            [Validation(Required=false)]
            public int? PeriodNumber { get; set; }

            /// <summary>
            /// <para>The running priority of the task. Minimum value: 1. Maximum value: 8. A larger value indicates a higher priority. Default value: 1.</para>
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
            /// <item><description>Prod: Production.</description></item>
            /// <item><description>Dev: Development.</description></item>
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
            /// <para>The rerun configuration of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: reruns are not allowed regardless of whether the task fails or succeeds.</description></item>
            /// <item><description>AllAllowed: reruns are allowed regardless of whether the task fails or succeeds.</description></item>
            /// <item><description>FailureAllowed: reruns are allowed only when the task fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllAllowed</para>
            /// </summary>
            [NameInMap("RerunMode")]
            [Validation(Required=false)]
            public string RerunMode { get; set; }

            /// <summary>
            /// <para>The current run number. The value starts from 1 by default.</para>
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
            public GetTaskInstanceResponseBodyTaskInstanceRuntime Runtime { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceRuntime : TeaModel {
                /// <summary>
                /// <para>The machine on which the task runs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai.1.2</para>
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// <para>The unique ID of the run.</para>
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
            public GetTaskInstanceResponseBodyTaskInstanceRuntimeResource RuntimeResource { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceRuntimeResource : TeaModel {
                /// <summary>
                /// <para>The compute unit (CU) consumption configured for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The image ID configured for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The identifier of the schedule resource group configured for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The running script information.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public GetTaskInstanceResponseBodyTaskInstanceScript Script { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceScript : TeaModel {
                /// <summary>
                /// <para>The script content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo &quot;helloWorld&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The list of script parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=$bizdate</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

            }

            /// <summary>
            /// <para>The start time of the run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <para>The instance running status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NotRun: Not run.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// <item><description>WaitTime: Waiting for the TriggerTime to arrive.</description></item>
            /// <item><description>CheckingCondition: Checking branch conditions.</description></item>
            /// <item><description>WaitResource: Waiting for resources.</description></item>
            /// <item><description>Failure: Execution failed.</description></item>
            /// <item><description>Success: Execution succeeded.</description></item>
            /// <item><description>Checking: Submitted for data quality check.</description></item>
            /// <item><description>WaitTrigger: Waiting for an external trigger. Trigger-based nodes enter this status after the waiting time elapses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of node tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTaskInstanceResponseBodyTaskInstanceTags> Tags { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceTags : TeaModel {
                /// <summary>
                /// <para>The label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the corresponding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the corresponding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL node</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the corresponding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The timeout period for task execution. Unit: seconds.</para>
            /// <para>Note: The scheduling system rounds the configured value to the nearest hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The running mode when triggered. This parameter takes effect when TriggerType is set to Scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: a normal scheduled task that is scheduled on a regular basis.</description></item>
            /// <item><description>Manual: a manual task that is not scheduled on a regular basis.</description></item>
            /// <item><description>Pause: a paused task that is scheduled on a regular basis but is set to failed when scheduling starts.</description></item>
            /// <item><description>Skip: a dry-run task that is scheduled on a regular basis but is set to succeeded when scheduling starts.</description></item>
            /// <item><description>SkipUnchoose: a task that is not selected in a temporary workflow. This value exists only in temporary workflows. The task is set to succeeded when scheduling starts.</description></item>
            /// <item><description>SkipCycle: a weekly or monthly task whose running cycle has not arrived. The task is scheduled on a regular basis but is set to succeeded when scheduling starts.</description></item>
            /// <item><description>ConditionUnchoose: a downstream node that is not selected by an upstream branch (IF) node. The task directly becomes a dry run.</description></item>
            /// <item><description>RealtimeDeprecated: an expired periodic instance generated in real time. The task is set to succeeded.</description></item>
            /// <item><description>PauseCalendar: the instance is paused because a calendar is referenced.</description></item>
            /// <item><description>SkipCalendar: the instance is a dry run because a calendar is referenced.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("TriggerTime")]
            [Validation(Required=false)]
            public long? TriggerTime { get; set; }

            /// <summary>
            /// <para>The trigger type. You can obtain the trigger type from the Trigger.Type response parameter of the GetTask operation. Valid values:</para>
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
            /// <para>The unified workflow instance ID. All task instances within the same business date under a single trigger share the same value for this field.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("WaitingTriggerTime")]
            [Validation(Required=false)]
            public long? WaitingTriggerTime { get; set; }

            /// <summary>
            /// <para>The ID of the workflow to which the task instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

            /// <summary>
            /// <para>The ID of the workflow instance to which the task instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the workflow instance to which the task instance belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SmokeTest: test.</description></item>
            /// <item><description>SupplementData: data backfill.</description></item>
            /// <item><description>Manual: manual task.</description></item>
            /// <item><description>ManualWorkflow: manual workflow.</description></item>
            /// <item><description>Normal: periodic scheduling.</description></item>
            /// <item><description>ManualFlow: manually executed business flow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("WorkflowInstanceType")]
            [Validation(Required=false)]
            public string WorkflowInstanceType { get; set; }

            /// <summary>
            /// <para>The name of the workflow to which the task instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test workflow</para>
            /// </summary>
            [NameInMap("WorkflowName")]
            [Validation(Required=false)]
            public string WorkflowName { get; set; }

        }

    }

}
