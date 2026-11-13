// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The client unique code of the workflow, which is used to implement asynchronous and idempotent operations. If you do not specify this parameter when creating a workflow, the system automatically generates one and uniquely binds it to the resource ID. If you specify this parameter when updating or deleting a resource, it must be the same as the client unique code used during creation.</para>
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
            /// <para>The dependency type.</para>
            /// <list type="bullet">
            /// <item><description>CrossCycleDependsOnChildren: Cross-cycle dependency on first-level child nodes.</description></item>
            /// <item><description>CrossCycleDependsOnSelf: Cross-cycle dependency on the node itself.</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: Cross-cycle dependency on other nodes.</description></item>
            /// <item><description>Normal: Same-cycle dependency.</description></item>
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
            /// <para>The output identifier of the upstream task. This field is returned for same-cycle dependencies with an input configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The ID of the upstream task. This field is returned for a cross-cycle dependency on another node or a same-cycle dependency with no input configured.</para>
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
        /// <para>The instance generation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T+1: Generates the instance on the next day.</description></item>
        /// <item><description>Immediately: Generates the instance immediately. Note: Periodic instances are generated normally only if the scheduled time of the workflow is at least 10 minutes after the workflow publish time. Real-time instance generation is not supported during the full instance generation period (22:00 to 24:00). You can submit and publish workflows during this period, but instances are not regenerated after submission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>The name.</para>
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
            /// <para>The list of workflow task output definitions.</para>
            /// </summary>
            [NameInMap("TaskOutputs")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestOutputsTaskOutputs> TaskOutputs { get; set; }
            public class UpdateWorkflowRequestOutputsTaskOutputs : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The parameter list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>para1=$bizdate para2=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The list of workflow tags.</para>
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
        /// <para>The list of tasks.</para>
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
            /// <para>The client unique code of the task, which is used to implement asynchronous and idempotent operations. If you do not specify this parameter when creating a task, the system automatically generates one and uniquely binds it to the resource ID. If you specify this parameter when updating or deleting a resource, it must be the same as the client unique code used during creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientUniqueCode")]
            [Validation(Required=false)]
            public string ClientUniqueCode { get; set; }

            /// <summary>
            /// <para>The associated data source information.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksDataSource DataSource { get; set; }
            public class UpdateWorkflowRequestTasksDataSource : TeaModel {
                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The dependency information. Note: If this field is not specified or is an empty array, all Dependencies configurations are deleted by default.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksDependencies> Dependencies { get; set; }
            public class UpdateWorkflowRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <para>The dependency type.</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: Cross-cycle dependency on first-level child nodes.</description></item>
                /// <item><description>CrossCycleDependsOnSelf: Cross-cycle dependency on the node itself.</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: Cross-cycle dependency on other nodes.</description></item>
                /// <item><description>Normal: Same-cycle dependency.</description></item>
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
                /// <para>The output identifier of the upstream task. This field is returned for same-cycle dependencies with an input configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>The ID of the upstream task. This field is returned for a cross-cycle dependency on another node or a same-cycle dependency with no input configured.</para>
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
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project environment.</para>
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
            /// <para>The task ID. If you specify this field, a full update is performed on the corresponding task. If you leave this field empty, a new task is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The input information. Note: If this field is left empty, all Inputs configurations are deleted by default.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksInputs Inputs { get; set; }
            public class UpdateWorkflowRequestTasksInputs : TeaModel {
                /// <summary>
                /// <para>The list of variable definitions. Note: If this field is not specified or is an empty array, all Inputs.Variables configurations are deleted by default.</para>
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
                    /// <item><description>Constant: Constant.</description></item>
                    /// <item><description>PassThrough: Parameter node output.</description></item>
                    /// <item><description>System: Variable.</description></item>
                    /// <item><description>NodeOutput: Script output.</description></item>
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
            /// <para>The output information. Note: If this field is left empty, all Outputs configurations are deleted by default.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksOutputs Outputs { get; set; }
            public class UpdateWorkflowRequestTasksOutputs : TeaModel {
                /// <summary>
                /// <para>The list of task output definitions. Note: If this field is not specified or is an empty array, all TaskOutputs configurations are deleted by default.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<UpdateWorkflowRequestTasksOutputsTaskOutputs> TaskOutputs { get; set; }
                public class UpdateWorkflowRequestTasksOutputsTaskOutputs : TeaModel {
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
                /// <para>The list of variable definitions. Note: If this field is not specified or is an empty array, all Outputs.Variables configurations are deleted by default.</para>
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
                    /// <item><description>Constant: Constant.</description></item>
                    /// <item><description>PassThrough: Parameter node output.</description></item>
                    /// <item><description>System: Variable.</description></item>
                    /// <item><description>NodeOutput: Script output.</description></item>
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
            /// <para>The retry interval, in seconds.</para>
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
            /// <item><description>FailureAllowed: The task can be rerun only if it fails.</description></item>
            /// <item><description>AllAllowed: The task can be rerun whether it succeeds or fails.</description></item>
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
            /// <para>The number of retries. This parameter takes effect only when the task is configured to be rerunnable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RerunTimes")]
            [Validation(Required=false)]
            public int? RerunTimes { get; set; }

            /// <summary>
            /// <para>The runtime environment configurations, such as the resource group information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class UpdateWorkflowRequestTasksRuntimeResource : TeaModel {
                /// <summary>
                /// <para>The number of compute units (CUs) consumed by the task execution configuration.</para>
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
            /// <para>The script information.</para>
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
            /// <para>The list of task tags. Note: If this field is not specified or is an empty array, all Tags configurations are deleted by default.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksTags> Tags { get; set; }
            public class UpdateWorkflowRequestTasksTags : TeaModel {
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
            /// <para>The timeout period for task execution, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The trigger mode of the task.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksTrigger Trigger { get; set; }
            public class UpdateWorkflowRequestTasksTrigger : TeaModel {
                /// <summary>
                /// <para>The running mode when the task is triggered. This parameter takes effect only when type is set to Scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: Paused.</description></item>
                /// <item><description>Skip: Dry run.</description></item>
                /// <item><description>Normal: Normal execution.</description></item>
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
                /// <para>The trigger type.</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: Triggered by a scheduling cycle.</description></item>
                /// <item><description>Manual: Triggered manually.</description></item>
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
            /// <para>The cron expression. This parameter takes effect only when Type is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The time when the scheduled trigger stops taking effect. This parameter takes effect only when Type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the scheduled trigger takes effect. This parameter takes effect only when Type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The trigger type.</para>
            /// <list type="bullet">
            /// <item><description>Scheduler: Triggered by a scheduling cycle.</description></item>
            /// <item><description>Manual: Triggered manually.</description></item>
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
