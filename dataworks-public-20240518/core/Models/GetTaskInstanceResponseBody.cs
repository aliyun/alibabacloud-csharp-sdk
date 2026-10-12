// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the task instance.</para>
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
            /// <para>The business date. The value is a 13-digit UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
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
            /// <para>The information about the data source associated with the instance.</para>
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
            /// <para>The completion time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
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
                    /// <para>The type of the variable. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: The variable is a constant.</description></item>
                    /// <item><description>PassThrough: The variable is the output of a parameter node.</description></item>
                    /// <item><description>System: The variable is a system variable.</description></item>
                    /// <item><description>NodeOutput: The variable is the script output.</description></item>
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
            /// <para>The update time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The account ID of the user who updated the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The type of the latest operation on the instance.</para>
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
                    /// <para>The type of the variable. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: The variable is a constant.</description></item>
                    /// <item><description>PassThrough: The variable is the output of a parameter node.</description></item>
                    /// <item><description>System: The variable is a system variable.</description></item>
                    /// <item><description>NodeOutput: The variable is the script output.</description></item>
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
            /// <para>The account ID of the task owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The period number. This indicates the sequence of the execution cycle for the task instance on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodNumber")]
            [Validation(Required=false)]
            public int? PeriodNumber { get; set; }

            /// <summary>
            /// <para>The execution priority of the task. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
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
            /// <para>The configuration that specifies whether the task can be rerun. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: The task cannot be rerun regardless of whether it fails or succeeds.</description></item>
            /// <item><description>AllAllowed: The task can be rerun regardless of whether it fails or succeeds.</description></item>
            /// <item><description>FailureAllowed: The task can be rerun only if it fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllAllowed</para>
            /// </summary>
            [NameInMap("RerunMode")]
            [Validation(Required=false)]
            public string RerunMode { get; set; }

            /// <summary>
            /// <para>The current number of runs. Default value: 1.</para>
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
                /// <para>The machine on which the task is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai.1.2</para>
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// <para>The unique ID of the execution process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T3_123</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

            }

            /// <summary>
            /// <para>The information about the resource group associated with the instance.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public GetTaskInstanceResponseBodyTaskInstanceRuntimeResource RuntimeResource { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceRuntimeResource : TeaModel {
                /// <summary>
                /// <para>The compute unit (CU) consumption configured for task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The ID of the image configured for task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The identifier of the scheduling resource group configured for task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The information about the execution script.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public GetTaskInstanceResponseBodyTaskInstanceScript Script { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceScript : TeaModel {
                /// <summary>
                /// <para>The content of the script.</para>
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
            /// <para>The start time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <para>The running status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NotRun: Not run.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// <item><description>WaitTime: Waiting for the trigger time.</description></item>
            /// <item><description>CheckingCondition: Checking branch conditions.</description></item>
            /// <item><description>WaitResource: Waiting for resources.</description></item>
            /// <item><description>Failure: Execution failed.</description></item>
            /// <item><description>Success: Execution succeeded.</description></item>
            /// <item><description>Checking: Submitted for data quality check.</description></item>
            /// <item><description>WaitTrigger: Waiting for an external trigger. Triggered nodes change to this status after the waiting time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of task tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTaskInstanceResponseBodyTaskInstanceTags> Tags { get; set; }
            public class GetTaskInstanceResponseBodyTaskInstanceTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL node</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The timeout period for task execution, in seconds.</para>
            /// <para>Note: The scheduling system rounds the configured value to the nearest hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The run mode upon trigger. This parameter takes effect only when TriggerType is set to Scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The task is a normal scheduled task and is scheduled on a daily basis.</description></item>
            /// <item><description>Manual: The task is a manual task and is not scheduled on a daily basis.</description></item>
            /// <item><description>Pause: The task is paused. It is scheduled on a daily basis, but is directly set to failed when the scheduling is triggered.</description></item>
            /// <item><description>Skip: The task performs a dry run. It is scheduled on a daily basis, but is directly set to successful when the scheduling is triggered.</description></item>
            /// <item><description>SkipUnchoose: The task is an unselected task in a temporary workflow. It exists only in temporary workflows and is directly set to successful when the scheduling is triggered.</description></item>
            /// <item><description>SkipCycle: The task is a weekly or monthly task that has not reached its execution cycle. It is scheduled on a daily basis, but is directly set to successful when the scheduling is triggered.</description></item>
            /// <item><description>ConditionUnchoose: The downstream node is not selected by an upstream branch (IF) node. The task is directly set to a dry run.</description></item>
            /// <item><description>RealtimeDeprecated: The task is an expired periodic instance generated in real time. It is directly set to successful.</description></item>
            /// <item><description>PauseCalendar: The instance is paused due to a referenced calendar.</description></item>
            /// <item><description>SkipCalendar: The instance performs a dry run due to a referenced calendar.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TriggerRecurrence")]
            [Validation(Required=false)]
            public string TriggerRecurrence { get; set; }

            /// <summary>
            /// <para>The scheduled trigger time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
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
            /// <item><description>Scheduler: The task is triggered by a scheduling cycle.</description></item>
            /// <item><description>Manual: The task is triggered manually.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduler</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The unified workflow instance ID. The value of this field is the same for all task instances within a specific business date under a single trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("UnifiedWorkflowInstanceId")]
            [Validation(Required=false)]
            public long? UnifiedWorkflowInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the instance starts waiting for resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("WaitingResourceTime")]
            [Validation(Required=false)]
            public long? WaitingResourceTime { get; set; }

            /// <summary>
            /// <para>The time when the instance starts waiting for the scheduled trigger. The value is a 13-digit UNIX timestamp in milliseconds.</para>
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
            /// <item><description>SmokeTest: The instance is a smoke test.</description></item>
            /// <item><description>SupplementData: The instance is for data backfill.</description></item>
            /// <item><description>Manual: The instance is a manual task.</description></item>
            /// <item><description>ManualWorkflow: The instance is a manual workflow.</description></item>
            /// <item><description>Normal: The instance uses periodic scheduling.</description></item>
            /// <item><description>ManualFlow: The instance is a manually executed business flow.</description></item>
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
