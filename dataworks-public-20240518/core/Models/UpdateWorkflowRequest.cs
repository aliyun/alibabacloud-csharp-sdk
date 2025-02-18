// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The client-side unique code of the workflow for asynchronous and idempotent implementation. If not specified during creation, the system will automatically generate the code, which will be uniquely bound to the resource ID. If you specify this parameter when updating and deleting resources, it should be consistent with the client unique code when creating resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>Dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<UpdateWorkflowRequestDependencies> Dependencies { get; set; }
        public class UpdateWorkflowRequestDependencies : TeaModel {
            /// <summary>
            /// <para>The type of the dependency.</para>
            /// <list type="bullet">
            /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency level-1 child nodes</description></item>
            /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
            /// <item><description>Normal: same-cycle dependency</description></item>
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
            /// <para>The output identifier of the upstream task. (This field is returned when <c>same cycle dependence</c> and input content is set)</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The Id of the upstream task. (This field is returned when the input content is not set for <c>cross-cycle dependency other nodes</c> and <c>same-cycle dependency </c>, otherwise it is not returned)</para>
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
        /// <item><description>Prod: Production</description></item>
        /// <item><description>Dev: Development</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The list of parameters.</para>
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
            /// <para>The value of the tag.</para>
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
            /// <para>The client-side unique code of the task, which is used to implement asynchronous and idempotent functions. If not specified during creation, the system will automatically generate the code, which will be uniquely bound to the resource ID. If you specify this parameter when updating and deleting resources, it should be consistent with the client unique code when creating resources.</para>
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
            /// <para>Dependency information.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksDependencies> Dependencies { get; set; }
            public class UpdateWorkflowRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <para>The type of the dependency.</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency level-1 child nodes</description></item>
                /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
                /// <item><description>Normal: same-cycle dependency</description></item>
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
                /// <para>The output identifier of the upstream task. (This field is returned when the input content is set depending on the same cycle)</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>The Id of the upstream task. (This field is returned when the input content is not set for cross-cycle dependencies on other nodes and same-cycle dependencies.</para>
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
            /// <item><description>Prod: Production</description></item>
            /// <item><description>Dev: Development</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the task. If you enter this field, a full update is performed on the corresponding task. If you do not enter this field, a new task is created.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Enter information.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksInputs Inputs { get; set; }
            public class UpdateWorkflowRequestTasksInputs : TeaModel {
                /// <summary>
                /// <para>The list of variable definitions.</para>
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
                    /// <para>Type.</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: Constant</description></item>
                    /// <item><description>PassThrough: parameter node output</description></item>
                    /// <item><description>System: variable</description></item>
                    /// <item><description>NodeOutput: script output</description></item>
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
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksOutputs Outputs { get; set; }
            public class UpdateWorkflowRequestTasksOutputs : TeaModel {
                /// <summary>
                /// <para>The list of task output definitions.</para>
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
                /// <para>The list of variable definitions.</para>
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
                    /// <para>Type.</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: Constant</description></item>
                    /// <item><description>PassThrough: parameter node output</description></item>
                    /// <item><description>System: variable</description></item>
                    /// <item><description>NodeOutput: script output</description></item>
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
            /// <para>The configuration of whether the task is allowed to rerun.</para>
            /// <list type="bullet">
            /// <item><description>AllDenied (failure or success cannot be rerun)</description></item>
            /// <item><description>FailureAllowed (only failures can be rerun)</description></item>
            /// <item><description>AllAllowed (run again if failed or successful)</description></item>
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
            /// <para>The number of retries that take effect when the task is set to rerun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RerunTimes")]
            [Validation(Required=false)]
            public int? RerunTimes { get; set; }

            /// <summary>
            /// <para>Configuration of the runtime environment, such as resource group information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class UpdateWorkflowRequestTasksRuntimeResource : TeaModel {
                /// <summary>
                /// <para>Configure CU consumption for task running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The ID of the image configured for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The identifier of the scheduling resource group configured for running the task.</para>
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
            /// <para>Run the script information.</para>
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
            /// <para>The list of task tags.</para>
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
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The timeout period of the task execution, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The trigger method of the task.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public UpdateWorkflowRequestTasksTrigger Trigger { get; set; }
            public class UpdateWorkflowRequestTasksTrigger : TeaModel {
                /// <summary>
                /// <para>The operation mode when the trigger is triggered. It takes effect when type = Scheduler.</para>
                /// <list type="bullet">
                /// <item><description>Pause: Pause</description></item>
                /// <item><description>Skip: empty run</description></item>
                /// <item><description>Normal: Normal operation</description></item>
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
                /// <para>The type of the trigger method.</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: the scheduling cycle is triggered.</description></item>
                /// <item><description>Manual: manually triggered</description></item>
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
            /// <para>Cron expression, which takes effect when type = Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The expiration time of the periodic trigger, which takes effect when type = Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the cycle trigger takes effect. It takes effect when type = Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The type of the trigger method.</para>
            /// <list type="bullet">
            /// <item><description>Scheduler: the scheduling cycle is triggered.</description></item>
            /// <item><description>Manual: manually triggered</description></item>
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
