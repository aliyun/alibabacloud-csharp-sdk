// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The unique code of the client. This parameter is used to create a workflow asynchronously and implement the idempotence of the workflow. If you do not specify this parameter when you create the workflow, the system automatically generates a unique code. The unique code is uniquely associated with the workflow ID. If you specify this parameter when you update or delete the workflow, the value of this parameter must be the unique code that is used to create the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>The dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<UpdateWorkflowRequestDependencies> Dependencies { get; set; }
        public class UpdateWorkflowRequestDependencies : TeaModel {
            /// <summary>
            /// <para>The dependency type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CrossCycleDependsOnChildren: Depends on level-1 downstream nodes across cycles</description></item>
            /// <item><description>CrossCycleDependsOnSelf: Depends on itself across cycles.</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: Depends on other nodes across cycles.</description></item>
            /// <item><description>Normal: Depends on nodes in the same cycle.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The output identifier of the upstream task. (This parameter is returned only if <c>Normal</c> is set and the node input is configured.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The ID of the upstream task. (This parameter is returned only if <c>Normal</c> or <c>CrossCycleDependsOnOtherNode</c> is set and the node input is not configured.)</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
        /// <list type="bullet">
        /// <item><description>Prod</description></item>
        /// <item><description>Dev</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The instance generation mode.</para>
        /// <list type="bullet">
        /// <item><description>T+1: the next day</description></item>
        /// <item><description>Immediately Note: Periodic instances will only be generated normally if the workflow\&quot;s scheduled time is more than 10 minutes after the workflow publication time. Real-time instance generation is not available during the batch instance generation period (23:30 to 24:00). While workflows can be published during this time, instances will not be regenerated immediately after submission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Workflow</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public UpdateWorkflowRequestOutputs Outputs { get; set; }
        public class UpdateWorkflowRequestOutputs : TeaModel {
            /// <summary>
            /// <para>The task outputs.</para>
            /// </summary>
            [NameInMap("TaskOutputs")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestOutputsTaskOutputs> TaskOutputs { get; set; }
            public class UpdateWorkflowRequestOutputsTaskOutputs : TeaModel {
                /// <summary>
                /// <para>The identifier of the output.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>para1=$bizdate para2=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateWorkflowRequestTags> Tags { get; set; }
        public class UpdateWorkflowRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>Details about tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<UpdateWorkflowRequestTasks> Tasks { get; set; }
        public class UpdateWorkflowRequestTasks : TeaModel {
            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("BaseLineId")]
            [Validation(Required=false)]
            public long? BaseLineId { get; set; }

            /// <summary>
            /// <para>The client-side unique token for the task, used to ensure asynchronous processing and idempotency. If not specified during creation, the system will automatically generate one. This token is uniquely associated with the resource ID. If provided when updating or deleting resources, this parameter must match the client token used during creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientUniqueCode")]
            [Validation(Required=false)]
            public string ClientUniqueCode { get; set; }

            /// <summary>
            /// <para>The information about the associated data source.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksDataSource DataSource { get; set; }
            public class UpdateWorkflowRequestTasksDataSource : TeaModel {
                /// <summary>
                /// <para>The data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The dependency information. Note: If this parameter is left empty or set to an empty array, all dependency configurations will be deleted.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksDependencies> Dependencies { get; set; }
            public class UpdateWorkflowRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <para>The dependency type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: Depends on level-1 downstream nodes across cycles</description></item>
                /// <item><description>CrossCycleDependsOnSelf: Depends on itself across cycles.</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: Depends on other nodes across cycles.</description></item>
                /// <item><description>Normal: Depends on nodes in the same cycle.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The output identifier of the upstream task. (This parameter is returned only if <c>Normal</c> is set and the node input is configured.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>The ID of the upstream task. (This parameter is returned only if <c>Normal</c> or <c>CrossCycleDependsOnOtherNode</c> is set and the node input is not configured.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UpstreamTaskId")]
                [Validation(Required=false)]
                public long? UpstreamTaskId { get; set; }

            }

            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project environment.</para>
            /// <list type="bullet">
            /// <item><description>Prod</description></item>
            /// <item><description>Dev</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the task. Specifying this field triggers a full update for the corresponding task. If left unspecified, a new task will be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The input information. By default, all input information is deleted if this parameter is set to null.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksInputs Inputs { get; set; }
            public class UpdateWorkflowRequestTasksInputs : TeaModel {
                /// <summary>
                /// <para>The variables. By default, the settings of all input variables are deleted if this parameter is set to null or not specified.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<UpdateWorkflowRequestTasksInputsVariables> Variables { get; set; }
                public class UpdateWorkflowRequestTasksInputsVariables : TeaModel {
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
                    /// <item><description>Constant: constant value.</description></item>
                    /// <item><description>PassThrough: node output.</description></item>
                    /// <item><description>System: variable.</description></item>
                    /// <item><description>NodeOutput: script output.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
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
            /// <para>The name of the task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL node</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output information. By default, all output information is deleted if this parameter is set to null.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksOutputs Outputs { get; set; }
            public class UpdateWorkflowRequestTasksOutputs : TeaModel {
                /// <summary>
                /// <para>The task outputs. By default, all task output information is deleted if this parameter is set to null or not specified.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<UpdateWorkflowRequestTasksOutputsTaskOutputs> TaskOutputs { get; set; }
                public class UpdateWorkflowRequestTasksOutputsTaskOutputs : TeaModel {
                    /// <summary>
                    /// <para>The identifier of the output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pre.odps_sql_demo_0</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

                /// <summary>
                /// <para>The variables. Note: The settings of all output variables are deleted if this parameter is set to null or not specified.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<UpdateWorkflowRequestTasksOutputsVariables> Variables { get; set; }
                public class UpdateWorkflowRequestTasksOutputsVariables : TeaModel {
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
                    /// <item><description>Constant: constant value.</description></item>
                    /// <item><description>PassThrough: node output.</description></item>
                    /// <item><description>System: variable.</description></item>
                    /// <item><description>NodeOutput: script output.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
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
            /// <para>The account ID of the owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The retry interval in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RerunInterval")]
            [Validation(Required=false)]
            public int? RerunInterval { get; set; }

            /// <summary>
            /// <para>Configuration for whether the task can be rerun.</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: The task cannot be rerun.</description></item>
            /// <item><description>FailureAllowed: The task can be rerun only after it fails.</description></item>
            /// <item><description>AllAllowed: The task can always be rerun.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllAllowed</para>
            /// </summary>
            [NameInMap("RerunMode")]
            [Validation(Required=false)]
            public string RerunMode { get; set; }

            /// <summary>
            /// <para>The number of retry attempts. Takes effect when the task is configured to allow reruns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RerunTimes")]
            [Validation(Required=false)]
            public int? RerunTimes { get; set; }

            /// <summary>
            /// <para>Runtime environment configurations, such as resource group information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class UpdateWorkflowRequestTasksRuntimeResource : TeaModel {
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
                /// <para>The image ID used in the task runtime configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The identifier of the scheduling resource group used in the task runtime configuration.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The run script information.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksScript Script { get; set; }
            public class UpdateWorkflowRequestTasksScript : TeaModel {
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
                /// <para>The script parameter list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=$bizdate</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

            }

            /// <summary>
            /// <para>The list of task tags. Note: If this field is unspecified or set to an empty array, all existing Tag configurations will be deleted by default.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksTags> Tags { get; set; }
            public class UpdateWorkflowRequestTasksTags : TeaModel {
                /// <summary>
                /// <para>The key of a tag.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of a tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The task execution timeout in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The trigger method.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksTrigger Trigger { get; set; }
            public class UpdateWorkflowRequestTasksTrigger : TeaModel {
                /// <summary>
                /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the Type parameter is set to Scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause</description></item>
                /// <item><description>Skip</description></item>
                /// <item><description>Normal</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>The trigger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: periodically triggered</description></item>
                /// <item><description>Manual</description></item>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The trigger method.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateWorkflowRequestTrigger Trigger { get; set; }
        public class UpdateWorkflowRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The Cron expression. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The expiration time of periodic triggering. Takes effect only when type is set to Scheduler. The value of this parameter is in the<c>yyyy-mm-dd hh:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when periodic triggering takes effect. This parameter takes effect only if the Type parameter is set to Scheduler. The value of this parameter is in the<c>yyyy-mm-dd hh:mm:ss</c> format.</para>
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
            /// <item><description>Scheduler: periodically triggered</description></item>
            /// <item><description>Manual</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
