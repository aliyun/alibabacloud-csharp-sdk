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
            /// <para><b>[Deprecated]</b> The list of task instances. This field is deprecated. Use UpstreamTaskInstances instead.</para>
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
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource DataSource { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The data source name.</para>
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
                /// <para>The project environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
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
                /// <para>The account ID of the task owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The period number. Indicates which scheduling cycle of the day the task instance belongs to.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodNumber")]
                [Validation(Required=false)]
                public int? PeriodNumber { get; set; }

                /// <summary>
                /// <para>The task running priority. Minimum value: 1. Maximum value: 8. A larger value indicates a higher priority. Default value: 1.</para>
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
                /// <para>The project environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("ProjectEnv")]
                [Validation(Required=false)]
                [Obsolete]
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
                /// <para>The rerun configuration of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AllDenied: The node cannot be rerun regardless of whether it fails or succeeds.</description></item>
                /// <item><description>FailureAllowed: The node can be rerun only after it fails.</description></item>
                /// <item><description>AllAllowed: The node can be rerun regardless of whether it fails or succeeds.</description></item>
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
                /// <para>The instance runtime information.</para>
                /// </summary>
                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime Runtime { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntime : TeaModel {
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
                /// <para>The runtime environment configuration, such as resource group information.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource RuntimeResource { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoTaskInstancesRuntimeResource : TeaModel {
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
                /// <para>The time when the instance started running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("StartedTime")]
                [Validation(Required=false)]
                public long? StartedTime { get; set; }

                /// <summary>
                /// <para>The instance running status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The dependency type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("StepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

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
                /// <para>The timeout period for task execution, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The run mode when the instance is triggered. This parameter takes effect when TriggerType is set to Scheduler.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: paused</description></item>
                /// <item><description>Skip: dry run</description></item>
                /// <item><description>Normal: normal execution</description></item>
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
                /// <para>The trigger type.</para>
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
                /// <para>The ID of the workflow instance to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowInstanceId")]
                [Validation(Required=false)]
                public long? WorkflowInstanceId { get; set; }

                /// <summary>
                /// <para>The type of the workflow instance to which the instance belongs.</para>
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

            /// <summary>
            /// <para>The list of upstream task instances.</para>
            /// </summary>
            [NameInMap("UpstreamTaskInstances")]
            [Validation(Required=false)]
            public List<ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstances> UpstreamTaskInstances { get; set; }
            public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstances : TeaModel {
                /// <summary>
                /// <para>The dependency type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("DependencyType")]
                [Validation(Required=false)]
                public string DependencyType { get; set; }

                /// <summary>
                /// <para>The details of the task instance.</para>
                /// </summary>
                [NameInMap("TaskInstance")]
                [Validation(Required=false)]
                public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstance TaskInstance { get; set; }
                public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstance : TeaModel {
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
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceDataSource DataSource { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceDataSource : TeaModel {
                        /// <summary>
                        /// <para>The data source name.</para>
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
                    /// <para>The environment of the target data source. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prod</para>
                    /// </summary>
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
                    /// <para>The account ID of the task owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The period number. Indicates which scheduling cycle of the day the task instance belongs to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodNumber")]
                    [Validation(Required=false)]
                    public int? PeriodNumber { get; set; }

                    /// <summary>
                    /// <para>The task running priority. Minimum value: 1. Maximum value: 8. A larger value indicates a higher priority. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

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
                    /// <para>The configuration that specifies whether the task can be rerun.</para>
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
                    /// <para>The instance runtime information.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntime Runtime { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntime : TeaModel {
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
                    /// <para>The runtime environment configuration, such as resource group information.</para>
                    /// </summary>
                    [NameInMap("RuntimeResource")]
                    [Validation(Required=false)]
                    public ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntimeResource RuntimeResource { get; set; }
                    public class ListUpstreamTaskInstancesResponseBodyPagingInfoUpstreamTaskInstancesTaskInstanceRuntimeResource : TeaModel {
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
                    /// <para>The time when the instance started running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710239005403</para>
                    /// </summary>
                    [NameInMap("StartedTime")]
                    [Validation(Required=false)]
                    public long? StartedTime { get; set; }

                    /// <summary>
                    /// <para>The instance running status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

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
                    /// <para>The timeout period for task execution, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// <para>The run mode when the instance is triggered. This parameter takes effect when TriggerType is set to Scheduler.</para>
                    /// <para>Valid values:</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710239005403</para>
                    /// </summary>
                    [NameInMap("TriggerTime")]
                    [Validation(Required=false)]
                    public long? TriggerTime { get; set; }

                    /// <summary>
                    /// <para>The trigger type.</para>
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
                    /// <para>The ID of the workflow instance to which the instance belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("WorkflowInstanceId")]
                    [Validation(Required=false)]
                    public long? WorkflowInstanceId { get; set; }

                    /// <summary>
                    /// <para>The type of the workflow instance to which the instance belongs.</para>
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

            }

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
