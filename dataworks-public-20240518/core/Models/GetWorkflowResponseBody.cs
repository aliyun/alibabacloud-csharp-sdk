// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the workflow.</para>
        /// </summary>
        [NameInMap("Workflow")]
        [Validation(Required=false)]
        public GetWorkflowResponseBodyWorkflow Workflow { get; set; }
        public class GetWorkflowResponseBodyWorkflow : TeaModel {
            /// <summary>
            /// <para>The client unique code of the workflow, which is used to implement asynchronous and idempotent operations. If you do not specify this parameter when creating the workflow, the system automatically generates one and uniquely binds the code to the resource ID. If you specify this parameter when updating or deleting the resource, it must be the same as the client unique code used during creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientUniqueCode")]
            [Validation(Required=false)]
            public string ClientUniqueCode { get; set; }

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
            /// <para>The account ID of the user who created the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The dependency information.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowDependencies> Dependencies { get; set; }
            public class GetWorkflowResponseBodyWorkflowDependencies : TeaModel {
                /// <summary>
                /// <para>The dependency type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency on first-level child nodes.</description></item>
                /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency on the node itself.</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes.</description></item>
                /// <item><description>Normal: same-cycle dependency.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The output identifier of the upstream task. This field is returned when the dependency type is same-cycle dependency and the input content is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>The ID of the upstream task. This field is returned when the dependency type is cross-cycle dependency on other nodes or same-cycle dependency without input content configured. It is not returned in other cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UpstreamTaskId")]
                [Validation(Required=false)]
                public long? UpstreamTaskId { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test workflow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the workflow.</para>
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
            /// <para>The account ID of the user who modified the workflow.</para>
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
            /// <para>Workflow</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public GetWorkflowResponseBodyWorkflowOutputs Outputs { get; set; }
            public class GetWorkflowResponseBodyWorkflowOutputs : TeaModel {
                /// <summary>
                /// <para>The list of task output definitions.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<GetWorkflowResponseBodyWorkflowOutputsTaskOutputs> TaskOutputs { get; set; }
                public class GetWorkflowResponseBodyWorkflowOutputsTaskOutputs : TeaModel {
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

            }

            /// <summary>
            /// <para>The account ID of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The list of parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>para1=$bizdate para2=$[yyyymmdd]</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The ID of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowTags> Tags { get; set; }
            public class GetWorkflowResponseBodyWorkflowTags : TeaModel {
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
            /// <para>The list of tasks.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowTasks> Tasks { get; set; }
            public class GetWorkflowResponseBodyWorkflowTasks : TeaModel {
                /// <summary>
                /// <para>The ID of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The client unique code of the task, which is used to implement asynchronous and idempotent operations. If you do not specify this parameter when creating the task, the system automatically generates one and uniquely binds the code to the resource ID. If you specify this parameter when updating or deleting the resource, it must be the same as the client unique code used during creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
                /// </summary>
                [NameInMap("ClientUniqueCode")]
                [Validation(Required=false)]
                public string ClientUniqueCode { get; set; }

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
                public GetWorkflowResponseBodyWorkflowTasksDataSource DataSource { get; set; }
                public class GetWorkflowResponseBodyWorkflowTasksDataSource : TeaModel {
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
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
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
                /// <para>The account ID of the user who modified the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
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
                /// <para>The priority of the task. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The retry time interval, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RerunInterval")]
                [Validation(Required=false)]
                public int? RerunInterval { get; set; }

                /// <summary>
                /// <para>Specifies whether the task can be rerun. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AllDenied: The task cannot be rerun regardless of whether it succeeds or fails.</description></item>
                /// <item><description>FailureAllowed: The task can be rerun only when it fails.</description></item>
                /// <item><description>AllAllowed: The task can be rerun after either success or failure.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The number of retries. This parameter takes effect only when the task is configured to allow reruns.</para>
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
                public GetWorkflowResponseBodyWorkflowTasksRuntimeResource RuntimeResource { get; set; }
                public class GetWorkflowResponseBodyWorkflowTasksRuntimeResource : TeaModel {
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
                /// <para>The timeout period for task execution, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The running mode when the task is triggered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: paused.</description></item>
                /// <item><description>Skip: dry run.</description></item>
                /// <item><description>Normal: normal running.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("TriggerRecurrence")]
                [Validation(Required=false)]
                public string TriggerRecurrence { get; set; }

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
            /// <para>The trigger method.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public GetWorkflowResponseBodyWorkflowTrigger Trigger { get; set; }
            public class GetWorkflowResponseBodyWorkflowTrigger : TeaModel {
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
                /// <para>The expiration time of the periodic trigger. This parameter takes effect only when Type is set to Scheduler.</para>
                /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>1970-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1970-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The running mode when the workflow is triggered. This parameter takes effect only when Type is set to Scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: paused.</description></item>
                /// <item><description>Skip: dry run.</description></item>
                /// <item><description>Normal: normal running.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>The start time for periodic triggers. This parameter takes effect only when Type is set to Scheduler.</para>
                /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>1970-01-01 00:00:00</c>. The example does not include a time zone identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1970-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The trigger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: triggered by a scheduling period.</description></item>
                /// <item><description>Manual: manually triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
