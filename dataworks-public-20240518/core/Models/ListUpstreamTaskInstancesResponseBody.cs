// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListUpstreamTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListUpstreamTaskInstancesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListUpstreamTaskInstancesResponseBodyPagingInfo : TeaModel {
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
            /// <para>The instances.</para>
            /// </summary>
            [NameInMap("TaskInstances")]
            [Validation(Required=false)]
            public List<ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstances> TaskInstances { get; set; }
            public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstances : TeaModel {
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
                /// <para>The account ID of the creator.</para>
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
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource DataSource { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource : TeaModel {
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

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

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
                /// <para>The account ID of the modifier.</para>
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
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodNumber")]
                [Validation(Required=false)]
                public int? PeriodNumber { get; set; }

                /// <summary>
                /// <para>The priority of the task. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The environment of the workspace.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod: production environment</description></item>
                /// <item><description>Dev: development environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("ProjectEnv")]
                [Validation(Required=false)]
                [Obsolete]
                public string ProjectEnv { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The rerun mode.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AllDenied: The task cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
                /// <item><description>FailureAllowed: The task can be rerun only after it fails to run.</description></item>
                /// <item><description>AllAllowed: The task can be rerun regardless of whether it is successfully run or fails to run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The number of times the instance is run. By default, the value starts from 1.</para>
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
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime Runtime { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime : TeaModel {
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
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource RuntimeResource { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The default number of compute units (CUs) configured for task running.</para>
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
                /// <item><description>NotRun: The instance is not run.</description></item>
                /// <item><description>Running: The instance is running.</description></item>
                /// <item><description>WaitTime: The instance is waiting for the scheduling time to arrive.</description></item>
                /// <item><description>CheckingCondition: Branch conditions are being checked for the instance.</description></item>
                /// <item><description>WaitResource: The instance is waiting for resources.</description></item>
                /// <item><description>Failure: The instance fails to be run.</description></item>
                /// <item><description>Success: The instance is successfully run.</description></item>
                /// <item><description>Checking: Data quality is being checked for the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The dependency type.</para>
                /// </summary>
                [NameInMap("StepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The running mode of the instance after it is triggered. This parameter takes effect only if the TriggerType parameter is set to Scheduler.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause</description></item>
                /// <item><description>Skip</description></item>
                /// <item><description>Normal</description></item>
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
                /// <para>The method to trigger instance scheduling.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: scheduling cycle-based trigger</description></item>
                /// <item><description>Manual: manual trigger</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

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
                /// <item><description>SmokeTest</description></item>
                /// <item><description>SupplementData</description></item>
                /// <item><description>Manual</description></item>
                /// <item><description>ManualWorkflow</description></item>
                /// <item><description>Normal</description></item>
                /// <item><description>ManualFlow</description></item>
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

            [NameInMap("UpstreamTaskInstances")]
            [Validation(Required=false)]
            public List<ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstances> UpstreamTaskInstances { get; set; }
            public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstances : TeaModel {
                /// <summary>
                /// <para>The dependency type.</para>
                /// </summary>
                [NameInMap("DependencyType")]
                [Validation(Required=false)]
                public string DependencyType { get; set; }

                /// <summary>
                /// <para>The information about a task instance.</para>
                /// </summary>
                [NameInMap("TaskInstance")]
                [Validation(Required=false)]
                public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstance TaskInstance { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstance : TeaModel {
                    [NameInMap("BaselineId")]
                    [Validation(Required=false)]
                    public long? BaselineId { get; set; }

                    [NameInMap("Bizdate")]
                    [Validation(Required=false)]
                    public long? Bizdate { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceDataSource DataSource { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceDataSource : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public long? FinishedTime { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    [NameInMap("PeriodNumber")]
                    [Validation(Required=false)]
                    public int? PeriodNumber { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The rerun mode.</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    [NameInMap("RunNumber")]
                    [Validation(Required=false)]
                    public int? RunNumber { get; set; }

                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntime Runtime { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntime : TeaModel {
                        [NameInMap("Gateway")]
                        [Validation(Required=false)]
                        public string Gateway { get; set; }

                        [NameInMap("ProcessId")]
                        [Validation(Required=false)]
                        public string ProcessId { get; set; }

                    }

                    [NameInMap("RuntimeResource")]
                    [Validation(Required=false)]
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntimeResource RuntimeResource { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntimeResource : TeaModel {
                        [NameInMap("Cu")]
                        [Validation(Required=false)]
                        public string Cu { get; set; }

                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        [NameInMap("ResourceGroupId")]
                        [Validation(Required=false)]
                        public string ResourceGroupId { get; set; }

                    }

                    [NameInMap("StartedTime")]
                    [Validation(Required=false)]
                    public long? StartedTime { get; set; }

                    /// <summary>
                    /// <para>The status of the instance.</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                    /// <summary>
                    /// <para>The task type.</para>
                    /// </summary>
                    [NameInMap("TaskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("TriggerRecurrence")]
                    [Validation(Required=false)]
                    public string TriggerRecurrence { get; set; }

                    [NameInMap("TriggerTime")]
                    [Validation(Required=false)]
                    public long? TriggerTime { get; set; }

                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    [NameInMap("WorkflowId")]
                    [Validation(Required=false)]
                    public long? WorkflowId { get; set; }

                    [NameInMap("WorkflowInstanceId")]
                    [Validation(Required=false)]
                    public long? WorkflowInstanceId { get; set; }

                    [NameInMap("WorkflowInstanceType")]
                    [Validation(Required=false)]
                    public string WorkflowInstanceType { get; set; }

                    [NameInMap("WorkflowName")]
                    [Validation(Required=false)]
                    public string WorkflowName { get; set; }

                }

            }

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
