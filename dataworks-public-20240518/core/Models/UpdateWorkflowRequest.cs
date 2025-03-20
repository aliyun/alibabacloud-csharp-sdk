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
            /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency on level-1 descendant nodes</description></item>
            /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency on the current node</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
            /// <item><description>Normal: same-cycle scheduling dependency</description></item>
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
            /// <para>The identifier of the output of the ancestor task. This parameter is returned only if <c>same-cycle scheduling dependencies</c> and the node input are configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The ancestor task ID. This parameter is returned only if <c>cross-cycle scheduling dependencies</c> or <c>same-cycle scheduling dependencies</c> and the node input are not configured.</para>
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
        /// <para>The environment of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production environment</description></item>
        /// <item><description>Dev: development environment</description></item>
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
        /// <para>The tasks.</para>
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
            /// <para>The unique code of the client. This parameter is used to create a task asynchronously and implement the idempotence of the task. If you do not specify this parameter when you create the task, the system automatically generates a unique code. The unique code is uniquely associated with the task ID. If you specify this parameter when you update or delete the task, the value of this parameter must be the unique code that is used to create the task.</para>
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
            /// <para>The dependency information.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<UpdateWorkflowRequestTasksDependencies> Dependencies { get; set; }
            public class UpdateWorkflowRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <para>The dependency type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency on level-1 descendant nodes</description></item>
                /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency on the current node</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
                /// <item><description>Normal: same-cycle scheduling dependency</description></item>
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
                /// <para>The identifier of the output of the ancestor task. This parameter is returned only if <c>same-cycle scheduling dependencies</c> and the node input are configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>The ancestor task ID. This parameter is returned only if <c>cross-cycle scheduling dependencies</c> or <c>same-cycle scheduling dependencies</c> and the node input are not configured.</para>
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
            /// <para>The environment of the workspace. Valid values:</para>
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
            /// <para>The task ID. If you configure this parameter, full update is performed on the task. If you do not configure this parameter, another task is created.</para>
            /// <para>This parameter is required.</para>
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
            public UpdateWorkflowRequestTasksInputs Inputs { get; set; }
            public class UpdateWorkflowRequestTasksInputs : TeaModel {
                /// <summary>
                /// <para>The variables.</para>
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
                    /// <item><description>Constant: constant</description></item>
                    /// <item><description>PassThrough: node output</description></item>
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
                /// <para>The task outputs.</para>
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
                /// <para>The variables.</para>
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
                    /// <item><description>Constant: constant</description></item>
                    /// <item><description>PassThrough: node output</description></item>
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
            /// <para>The rerun interval. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RerunInterval")]
            [Validation(Required=false)]
            public int? RerunInterval { get; set; }

            /// <summary>
            /// <para>The rerun mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: The task cannot be rerun regardless of whether the task is successfully run or fails to run.</description></item>
            /// <item><description>FailureAllowed: The task can be rerun only after it fails to run.</description></item>
            /// <item><description>AllAllowed: The task can be rerun regardless of whether the task is successfully run or fails to run.</description></item>
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
                /// <para>The script parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=$bizdate</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

            }

            /// <summary>
            /// <para>The tags.</para>
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
            /// <para>The timeout period of task running. Unit: seconds.</para>
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
                /// <item><description>Scheduler: periodic scheduling</description></item>
                /// <item><description>Manual: manual scheduling</description></item>
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
            /// <para>The CRON expression. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The end time of the time range during which the workflow is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the time range during which the workflow is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
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
            /// <item><description>Scheduler: periodic scheduling</description></item>
            /// <item><description>Manual: manual scheduling</description></item>
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
