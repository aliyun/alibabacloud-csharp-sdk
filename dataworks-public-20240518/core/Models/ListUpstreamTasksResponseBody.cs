// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListUpstreamTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListUpstreamTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListUpstreamTasksResponseBodyPagingInfo : TeaModel {
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
            /// <para>The tasks.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListUpstreamTasksResponseBodyPagingInfoTasks> Tasks { get; set; }
            public class ListUpstreamTasksResponseBodyPagingInfoTasks : TeaModel {
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
                public ListUpstreamTasksResponseBodyPagingInfoTasksDataSource DataSource { get; set; }
                public class ListUpstreamTasksResponseBodyPagingInfoTasksDataSource : TeaModel {
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
                /// <para>The description of the task.</para>
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
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The instance generation mode. Valid values:</para>
                /// <para>T+1</para>
                /// <para>Immediately</para>
                /// 
                /// <b>Example:</b>
                /// <para>T+1</para>
                /// </summary>
                [NameInMap("InstanceMode")]
                [Validation(Required=false)]
                public string InstanceMode { get; set; }

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
                /// <para>The name of the task.</para>
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
                /// <para>The rerun interval. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RerunInterval")]
                [Validation(Required=false)]
                public int? RerunInterval { get; set; }

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
                /// <para>The number of times that the task is rerun. This parameter takes effect only if the RerunMode parameter is set to AllAllowed or FailureAllowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RerunTimes")]
                [Validation(Required=false)]
                public int? RerunTimes { get; set; }

                /// <summary>
                /// <para>The configurations of the runtime environment, such as the resource group information.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListUpstreamTasksResponseBodyPagingInfoTasksRuntimeResource RuntimeResource { get; set; }
                public class ListUpstreamTasksResponseBodyPagingInfoTasksRuntimeResource : TeaModel {
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
                /// <para>The scheduling dependency type. Valid values:</para>
                /// <para>Normal: same-cycle scheduling dependency</para>
                /// <para>CrossCycle: cross-cycle scheduling dependency</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("StepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

                /// <summary>
                /// <para>The timeout period of task running. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The method to trigger task scheduling.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListUpstreamTasksResponseBodyPagingInfoTasksTrigger Trigger { get; set; }
                public class ListUpstreamTasksResponseBodyPagingInfoTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>The CRON expression of the task. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The end time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
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
                    [NameInMap("Recurrence")]
                    [Validation(Required=false)]
                    public string Recurrence { get; set; }

                    /// <summary>
                    /// <para>The start time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
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
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduler: scheduling cycle-based trigger</description></item>
                    /// <item><description>Manual: manual trigger</description></item>
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
                /// <para>The type of the task.</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("UpstreamTasks")]
            [Validation(Required=false)]
            public List<ListUpstreamTasksResponseBodyPagingInfoUpstreamTasks> UpstreamTasks { get; set; }
            public class ListUpstreamTasksResponseBodyPagingInfoUpstreamTasks : TeaModel {
                /// <summary>
                /// <para>The dependency type.</para>
                /// </summary>
                [NameInMap("DependencyType")]
                [Validation(Required=false)]
                public string DependencyType { get; set; }

                [NameInMap("Task")]
                [Validation(Required=false)]
                public ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTask Task { get; set; }
                public class ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTask : TeaModel {
                    /// <summary>
                    /// <para>The ID of the baseline.</para>
                    /// </summary>
                    [NameInMap("BaselineId")]
                    [Validation(Required=false)]
                    public long? BaselineId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <para>The information about the data source.</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskDataSource DataSource { get; set; }
                    public class ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskDataSource : TeaModel {
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

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InstanceMode")]
                    [Validation(Required=false)]
                    public string InstanceMode { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The priority of the task. Valid values: 1 to 8.</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The interval between two consecutive reruns. Unit: seconds.</para>
                    /// </summary>
                    [NameInMap("RerunInterval")]
                    [Validation(Required=false)]
                    public int? RerunInterval { get; set; }

                    /// <summary>
                    /// <para>The rerun mode.</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The number of reruns.</para>
                    /// </summary>
                    [NameInMap("RerunTimes")]
                    [Validation(Required=false)]
                    public int? RerunTimes { get; set; }

                    /// <summary>
                    /// <para>The configurations of the runtime environment, such as the resource group information.</para>
                    /// </summary>
                    [NameInMap("RuntimeResource")]
                    [Validation(Required=false)]
                    public ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskRuntimeResource RuntimeResource { get; set; }
                    public class ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskRuntimeResource : TeaModel {
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

                    /// <summary>
                    /// <para>The timeout period of task running. Unit: seconds.</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// <para>The method to trigger the running of the task.</para>
                    /// </summary>
                    [NameInMap("Trigger")]
                    [Validation(Required=false)]
                    public ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskTrigger Trigger { get; set; }
                    public class ListUpstreamTasksResponseBodyPagingInfoUpstreamTasksTaskTrigger : TeaModel {
                        [NameInMap("Cron")]
                        [Validation(Required=false)]
                        public string Cron { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("Recurrence")]
                        [Validation(Required=false)]
                        public string Recurrence { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Timezone")]
                        [Validation(Required=false)]
                        public string Timezone { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the task.</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkflowId")]
                    [Validation(Required=false)]
                    public long? WorkflowId { get; set; }

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
