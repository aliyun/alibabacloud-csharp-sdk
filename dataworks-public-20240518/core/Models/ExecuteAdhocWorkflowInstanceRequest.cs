// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ExecuteAdhocWorkflowInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ExecuteAdhocWorkflowInstanceRequestTasks> Tasks { get; set; }
        public class ExecuteAdhocWorkflowInstanceRequestTasks : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientUniqueCode")]
            [Validation(Required=false)]
            public string ClientUniqueCode { get; set; }

            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksDataSource DataSource { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksDataSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>mysql_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<ExecuteAdhocWorkflowInstanceRequestTasksDependencies> Dependencies { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksDependencies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

            }

            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksInputs Inputs { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksInputs : TeaModel {
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<ExecuteAdhocWorkflowInstanceRequestTasksInputsVariables> Variables { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksInputsVariables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>key1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Value1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksOutputs Outputs { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksOutputs : TeaModel {
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<ExecuteAdhocWorkflowInstanceRequestTasksOutputsTaskOutputs> TaskOutputs { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksOutputsTaskOutputs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pre.odps_sql_demo_0</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<ExecuteAdhocWorkflowInstanceRequestTasksOutputsVariables> Variables { get; set; }
                public class ExecuteAdhocWorkflowInstanceRequestTasksOutputsVariables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>key1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Constant</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksRuntimeResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public ExecuteAdhocWorkflowInstanceRequestTasksScript Script { get; set; }
            public class ExecuteAdhocWorkflowInstanceRequestTasksScript : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>echo &quot;helloWorld&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>para1=$bizdate</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
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
