// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ExecuteAdhocWorkflowInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The data timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

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
        /// <para>The name of the workflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ExecuteAdhocWorkflowInstanceRequestTasks> Tasks { get; set; }
        public class ExecuteAdhocWorkflowInstanceRequestTasks : TeaModel {
            /// <summary>
            /// <para>The unique code of the client. This code uniquely identifies a task.</para>
            /// <para>This parameter is required.</para>
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
            public ExecuteAdhocWorkflowInstanceRequestTasksDataSource DataSource { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksDataSource : TeaModel {
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
            /// <para>The dependency information.</para>
            /// </summary>
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<ExecuteAdhocWorkflowInstanceRequestTasksDependencies> Dependencies { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <para>The identifier of the output of the ancestor task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

            }

            /// <summary>
            /// <para>The input information.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksInputs Inputs { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksInputs : TeaModel {
                /// <summary>
                /// <para>The variables.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<ExecuteAdhocWorkflowInstanceRequestTasksInputsVariables> Variables { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksInputsVariables : TeaModel {
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
                    /// <para>The value of the variable. You must configure this parameter in the <c>The ancestor output: The output variable name of the ancestor task</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Value1</para>
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
            /// <para>SQL node.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksOutputs Outputs { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksOutputs : TeaModel {
                /// <summary>
                /// <para>The task outputs.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<ExecuteAdhocWorkflowInstanceRequestTasksOutputsTaskOutputs> TaskOutputs { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksOutputsTaskOutputs : TeaModel {
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
                public List<ExecuteAdhocWorkflowInstanceRequestTasksOutputsVariables> Variables { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksOutputsVariables : TeaModel {
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
                    /// <item><description>System</description></item>
                    /// <item><description>Constant</description></item>
                    /// <item><description>NodeOutput</description></item>
                    /// <item><description>PassThrough</description></item>
                    /// </list>
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
            /// <para>The configurations of the runtime environment, such as the resource group information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksRuntimeResource : TeaModel {
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
            public ExecuteAdhocWorkflowInstanceRequestTasksScript Script { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksScript : TeaModel {
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
            /// <para>The timeout period of task running. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

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

    }

}
