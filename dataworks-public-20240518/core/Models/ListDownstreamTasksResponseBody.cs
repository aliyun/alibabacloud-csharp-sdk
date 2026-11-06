// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDownstreamTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDownstreamTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDownstreamTasksResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of downstream tasks.</para>
            /// </summary>
            [NameInMap("DownstreamTasks")]
            [Validation(Required=false)]
            public List<ListDownstreamTasksResponseBodyPagingInfoDownstreamTasks> DownstreamTasks { get; set; }
            public class ListDownstreamTasksResponseBodyPagingInfoDownstreamTasks : TeaModel {
                /// <summary>
                /// <para>The dependency type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: Same-cycle dependency.</description></item>
                /// <item><description>CrossCycle: Cross-cycle dependency.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("DependencyType")]
                [Validation(Required=false)]
                public string DependencyType { get; set; }

                /// <summary>
                /// <para>The details of the task.</para>
                /// </summary>
                [NameInMap("Task")]
                [Validation(Required=false)]
                public ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTask Task { get; set; }
                public class ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTask : TeaModel {
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
                    /// <para>The account ID of the user who created the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <para>The associated data source information.</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskDataSource DataSource { get; set; }
                    public class ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskDataSource : TeaModel {
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
                    /// <para>The project environment. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Prod: Production.</description></item>
                    /// <item><description>Dev: Development.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prod</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The instance generation mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>T+1: Generated on the next day.</description></item>
                    /// <item><description>Immediately: Generated immediately.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T+1</para>
                    /// </summary>
                    [NameInMap("InstanceMode")]
                    [Validation(Required=false)]
                    public string InstanceMode { get; set; }

                    /// <summary>
                    /// <para>The update time.</para>
                    /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710239005403</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The account ID of the user who updated the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SQL node</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

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
                    /// <para>The task priority. Valid values: 1 to 8.</para>
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
                    /// <para>The retry interval, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("RerunInterval")]
                    [Validation(Required=false)]
                    public int? RerunInterval { get; set; }

                    /// <summary>
                    /// <para>The rerun configuration of the task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AllDenied: The task cannot be rerun regardless of whether it succeeds or fails.</description></item>
                    /// <item><description>FailureAllowed: The task can be rerun only when it fails.</description></item>
                    /// <item><description>AllAllowed: The task can be rerun regardless of whether it succeeds or fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AllAllowed</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The number of retries. This parameter takes effect only when the task is configured to be rerunnable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("RerunTimes")]
                    [Validation(Required=false)]
                    public int? RerunTimes { get; set; }

                    /// <summary>
                    /// <para>The runtime environment configuration, such as the resource group information.</para>
                    /// </summary>
                    [NameInMap("RuntimeResource")]
                    [Validation(Required=false)]
                    public ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskRuntimeResource RuntimeResource { get; set; }
                    public class ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskRuntimeResource : TeaModel {
                        /// <summary>
                        /// <para>The number of compute units (CUs) consumed during task execution.</para>
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
                    /// <para>The task execution timeout period, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// <para>The trigger method of the task.</para>
                    /// </summary>
                    [NameInMap("Trigger")]
                    [Validation(Required=false)]
                    public ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskTrigger Trigger { get; set; }
                    public class ListDownstreamTasksResponseBodyPagingInfoDownstreamTasksTaskTrigger : TeaModel {
                        /// <summary>
                        /// <para>The cron expression. This parameter takes effect only when Type is set to Scheduler.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00 00 00 * * ?</para>
                        /// </summary>
                        [NameInMap("Cron")]
                        [Validation(Required=false)]
                        public string Cron { get; set; }

                        /// <summary>
                        /// <para>The expiration time of periodic triggering. This parameter takes effect only when Type is set to Scheduler.</para>
                        /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>9999-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9999-01-01 00:00:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The execution mode when the task is triggered. This parameter takes effect only when Type is set to Scheduler. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pause: Paused.</description></item>
                        /// <item><description>Skip: Dry run.</description></item>
                        /// <item><description>Normal: Normal execution.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("Recurrence")]
                        [Validation(Required=false)]
                        public string Recurrence { get; set; }

                        /// <summary>
                        /// <para>The effective time of periodic triggering. This parameter takes effect only when Type is set to Scheduler.</para>
                        /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>1970-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1970-01-01 00:00:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Asia/Shanghai</para>
                        /// </summary>
                        [NameInMap("Timezone")]
                        [Validation(Required=false)]
                        public string Timezone { get; set; }

                        /// <summary>
                        /// <para>The trigger type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Scheduler: Triggered by a scheduling cycle.</description></item>
                        /// <item><description>Manual: Manually triggered.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Scheduler</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The task type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ODPS_SQL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the workflow to which the task belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("WorkflowId")]
                    [Validation(Required=false)]
                    public long? WorkflowId { get; set; }

                }

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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The list of tasks. Use DownstreamTasks instead.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListDownstreamTasksResponseBodyPagingInfoTasks> Tasks { get; set; }
            public class ListDownstreamTasksResponseBodyPagingInfoTasks : TeaModel {
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
                /// <para>The account ID of the user who created the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The associated data source information.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListDownstreamTasksResponseBodyPagingInfoTasksDataSource DataSource { get; set; }
                public class ListDownstreamTasksResponseBodyPagingInfoTasksDataSource : TeaModel {
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
                /// <para>The project environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod: Production.</description></item>
                /// <item><description>Dev: Development.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The unique identifier of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The instance generation mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>T+1: Generated on the next day.</description></item>
                /// <item><description>Immediately: Generated immediately.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>T+1</para>
                /// </summary>
                [NameInMap("InstanceMode")]
                [Validation(Required=false)]
                public string InstanceMode { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The account ID of the user who updated the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL node</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>The task priority. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
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
                /// <para><b>[Deprecated]</b> The project environment. Use EnvType instead.</para>
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
                /// <para>The retry interval, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RerunInterval")]
                [Validation(Required=false)]
                public int? RerunInterval { get; set; }

                /// <summary>
                /// <para>The rerun configuration of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The number of retries. This parameter takes effect only when the task is configured to be rerunnable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RerunTimes")]
                [Validation(Required=false)]
                public int? RerunTimes { get; set; }

                /// <summary>
                /// <para>The runtime environment configuration, such as the resource group information.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListDownstreamTasksResponseBodyPagingInfoTasksRuntimeResource RuntimeResource { get; set; }
                public class ListDownstreamTasksResponseBodyPagingInfoTasksRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The number of compute units (CUs) consumed during task execution.</para>
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
                /// <para>The dependency type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: Same-cycle dependency.</description></item>
                /// <item><description>CrossCycle: Cross-cycle dependency.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("StepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

                /// <summary>
                /// <para>The task execution timeout period, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The trigger method of the task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDownstreamTasksResponseBodyPagingInfoTasksTrigger Trigger { get; set; }
                public class ListDownstreamTasksResponseBodyPagingInfoTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>The cron expression. This parameter takes effect only when Type is set to Scheduler.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The expiration time of periodic triggering. This parameter takes effect only when Type is set to Scheduler.</para>
                    /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>9999-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The running mode when the task is triggered. This parameter takes effect only when Type is set to Scheduler.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Recurrence")]
                    [Validation(Required=false)]
                    public string Recurrence { get; set; }

                    /// <summary>
                    /// <para>The effective time of periodic triggering. This parameter takes effect only when Type is set to Scheduler.</para>
                    /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>1970-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1970-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("Timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    /// <summary>
                    /// <para>The trigger type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scheduler</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the task belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
