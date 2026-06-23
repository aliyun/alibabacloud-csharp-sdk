// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination information.</para>
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
                /// <para>The data timestamp.</para>
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
                /// <para>The account ID of the user who creates the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The information about the associated data source.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public long? FinishedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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
                /// <para>The account ID of the user who modifies the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

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
                /// <para>The sequence number of the cycle. This parameter indicates the cycle of the task instance on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodNumber")]
                [Validation(Required=false)]
                public int? PeriodNumber { get; set; }

                /// <summary>
                /// <para>The priority of the task. Minimum value: 1. Maximum value: 8. A larger value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The environment of the workspace.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Prod: production environment</para>
                /// </description></item>
                /// <item><description><para>Dev: development environment</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("ProjectEnv")]
                [Validation(Required=false)]
                public string ProjectEnv { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The rerun mode</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>AllDenied: The task cannot be rerun regardless of whether the task is successfully run or fails to run.</para>
                /// </description></item>
                /// <item><description><para>FailureAllowed: The task can be rerun only after it fails to run.</para>
                /// </description></item>
                /// <item><description><para>AllAllowed: The task can be rerun regardless of whether the task is successfully run or fails to run.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The number of times the task is run. By default, the value starts from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunNumber")]
                [Validation(Required=false)]
                public int? RunNumber { get; set; }

                /// <summary>
                /// <para>The runtime information about the instance.</para>
                /// </summary>
                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime Runtime { get; set; }
                public class ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime : TeaModel {
                    /// <summary>
                    /// <para>The host for running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai.1.2</para>
                    /// </summary>
                    [NameInMap("Gateway")]
                    [Validation(Required=false)]
                    public string Gateway { get; set; }

                    /// <summary>
                    /// <para>The instance run ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3_123</para>
                    /// </summary>
                    [NameInMap("ProcessId")]
                    [Validation(Required=false)]
                    public string ProcessId { get; set; }

                }

                /// <summary>
                /// <para>The information about the resource group with which the instance is associated.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource RuntimeResource { get; set; }
                public class ListTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The default number of CUs configured for task running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public string Cu { get; set; }

                    /// <summary>
                    /// <para>The ID of the image configured for task running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-xxxxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group for scheduling configured for task running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>The script parameter list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=val1 para2=val2</para>
                /// </summary>
                [NameInMap("ScriptParameters")]
                [Validation(Required=false)]
                public string ScriptParameters { get; set; }

                /// <summary>
                /// <para>The time when the instance started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("StartedTime")]
                [Validation(Required=false)]
                public long? StartedTime { get; set; }

                /// <summary>
                /// <para>The status of the instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NotRun: The instance is not run.</para>
                /// </description></item>
                /// <item><description><para>Running: The instance is running.</para>
                /// </description></item>
                /// <item><description><para>WaitTime: The instance is waiting for the scheduling time to arrive.</para>
                /// </description></item>
                /// <item><description><para>CheckingCondition: Branch conditions are being checked for the instance.</para>
                /// </description></item>
                /// <item><description><para>WaitResource: The instance is waiting for resources.</para>
                /// </description></item>
                /// <item><description><para>Failure: The instance fails to be run.</para>
                /// </description></item>
                /// <item><description><para>Success: The instance is successfully run.</para>
                /// </description></item>
                /// <item><description><para>Checking: Data quality is being checked for the instance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the task for which the instance is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The name of the task for which the instance is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL node</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The type of the task for which the instance is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The timeout period of task running. Unit: seconds.</para>
                /// <para>Note: The value of this parameter is rounded up by hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The running mode of the instance after it is triggered. This parameter takes effect only if the TriggerType parameter is set to Scheduler.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pause</para>
                /// </description></item>
                /// <item><description><para>Skip</para>
                /// </description></item>
                /// <item><description><para>Normal</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("TriggerRecurrence")]
                [Validation(Required=false)]
                public string TriggerRecurrence { get; set; }

                /// <summary>
                /// <para>The scheduling time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("TriggerTime")]
                [Validation(Required=false)]
                public long? TriggerTime { get; set; }

                /// <summary>
                /// <para>The trigger type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Scheduler: scheduling cycle-based trigger</para>
                /// </description></item>
                /// <item><description><para>Manual: manual trigger</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                /// <summary>
                /// <para>Unified workflow instance ID. All task instances triggered under the same data timestamp share the same value for this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UnifiedWorkflowInstanceId")]
                [Validation(Required=false)]
                public long? UnifiedWorkflowInstanceId { get; set; }

                /// <summary>
                /// <para>The timestamp for when it started waiting for resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("WaitingResourceTime")]
                [Validation(Required=false)]
                public long? WaitingResourceTime { get; set; }

                /// <summary>
                /// <para>The timestamp for when it started waiting for the scheduled time.</para>
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
                /// <para>The workflow instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowInstanceId")]
                [Validation(Required=false)]
                public long? WorkflowInstanceId { get; set; }

                /// <summary>
                /// <para>The type of the workflow instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SmokeTest</para>
                /// </description></item>
                /// <item><description><para>SupplementData</para>
                /// </description></item>
                /// <item><description><para>Manual</para>
                /// </description></item>
                /// <item><description><para>ManualWorkflow</para>
                /// </description></item>
                /// <item><description><para>Normal</para>
                /// </description></item>
                /// <item><description><para>ManualFlow</para>
                /// </description></item>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
