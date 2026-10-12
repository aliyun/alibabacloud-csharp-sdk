// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListNodesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListNodesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of data development nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyPagingInfoNodes> Nodes { get; set; }
            public class ListNodesResponseBodyPagingInfoNodes : TeaModel {
                /// <summary>
                /// <para>The timestamp when the data development node was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722910655000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data source.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesDataSource DataSource { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The description of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The unique identifier of the data development node.</para>
                /// <remarks>
                /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation to fail only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>860438872620113XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node input.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesInputs Inputs { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesInputs : TeaModel {
                    /// <summary>
                    /// <para>The list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesInputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesInputsNodeOutputs : TeaModel {
                        /// <summary>
                        /// <para>The node output.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>623731286945488XXXX</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>The name of the destination data table generated by the node. This field provides a semantic name that is easy to understand and helps users quickly identify the output content. It is used only for display and remarks, and has no actual logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of tables.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesInputsTables> Tables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesInputsTables : TeaModel {
                        /// <summary>
                        /// <para>The table ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.autotest.test_output_table_1</para>
                        /// </summary>
                        [NameInMap("Guid")]
                        [Validation(Required=false)]
                        public string Guid { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesInputsVariables> Variables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesInputsVariables : TeaModel {
                        /// <summary>
                        /// <para>The type of the artifact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Variable</para>
                        /// </summary>
                        [NameInMap("ArtifactType")]
                        [Validation(Required=false)]
                        public string ArtifactType { get; set; }

                        /// <summary>
                        /// <para>The ID of the variable.</para>
                        /// <remarks>
                        /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0, and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>543211286945488XXXX</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>input</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The node to which the variable belongs.</para>
                        /// </summary>
                        [NameInMap("Node")]
                        [Validation(Required=false)]
                        public ListNodesResponseBodyPagingInfoNodesInputsVariablesNode Node { get; set; }
                        public class ListNodesResponseBodyPagingInfoNodesInputsVariablesNode : TeaModel {
                            /// <summary>
                            /// <para>The node output.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>623731286945488XXXX</para>
                            /// </summary>
                            [NameInMap("Output")]
                            [Validation(Required=false)]
                            public string Output { get; set; }

                        }

                        /// <summary>
                        /// <para>The scope of the input variable. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>WorkSpace</description></item>
                        /// <item><description>NodeParameter</description></item>
                        /// <item><description>NodeContext</description></item>
                        /// <item><description>Workflow</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeParameter</para>
                        /// </summary>
                        [NameInMap("Scope")]
                        [Validation(Required=false)]
                        public string Scope { get; set; }

                        /// <summary>
                        /// <para>The type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NoKvVariableExpression</description></item>
                        /// <item><description>Constant</description></item>
                        /// <item><description>PassThrough</description></item>
                        /// <item><description>System</description></item>
                        /// <item><description>NodeOutput</description></item>
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
                        /// <para>222</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The timestamp when the data development node was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722910655000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node output.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesOutputs Outputs { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesOutputs : TeaModel {
                    /// <summary>
                    /// <para>The list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesOutputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesOutputsNodeOutputs : TeaModel {
                        /// <summary>
                        /// <para>The node output.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>860438872620113XXXX</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>The name of the destination data table generated by the node. This field provides a semantic name that is easy to understand and helps users quickly identify the output content. It is used only for display and remarks, and has no actual logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of tables.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesOutputsTables> Tables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesOutputsTables : TeaModel {
                        /// <summary>
                        /// <para>The table ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.autotest.test_output_table_1</para>
                        /// </summary>
                        [NameInMap("Guid")]
                        [Validation(Required=false)]
                        public string Guid { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesOutputsVariables> Variables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesOutputsVariables : TeaModel {
                        /// <summary>
                        /// <para>The type of the artifact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Variable</para>
                        /// </summary>
                        [NameInMap("ArtifactType")]
                        [Validation(Required=false)]
                        public string ArtifactType { get; set; }

                        /// <summary>
                        /// <para>The ID of the variable.</para>
                        /// <remarks>
                        /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0, and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>623731286945488XXXX</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>output</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The node to which the variable belongs.</para>
                        /// </summary>
                        [NameInMap("Node")]
                        [Validation(Required=false)]
                        public ListNodesResponseBodyPagingInfoNodesOutputsVariablesNode Node { get; set; }
                        public class ListNodesResponseBodyPagingInfoNodesOutputsVariablesNode : TeaModel {
                            /// <summary>
                            /// <para>The node output.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>860438872620113XXXX</para>
                            /// </summary>
                            [NameInMap("Output")]
                            [Validation(Required=false)]
                            public string Output { get; set; }

                        }

                        /// <summary>
                        /// <para>The scope of the variable. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NodeParameter</description></item>
                        /// <item><description>NodeContext</description></item>
                        /// <item><description>Workflow</description></item>
                        /// <item><description>Workspace</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeParameter</para>
                        /// </summary>
                        [NameInMap("Scope")]
                        [Validation(Required=false)]
                        public string Scope { get; set; }

                        /// <summary>
                        /// <para>The type of the variable. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NoKvVariableExpression</description></item>
                        /// <item><description>Constant</description></item>
                        /// <item><description>PassThrough</description></item>
                        /// <item><description>System</description></item>
                        /// <item><description>NodeOutput</description></item>
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
                        /// <para>111</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The owner of the data development node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace storage management page to view the ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33233</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: The node runs normally.</description></item>
                /// <item><description>Pause: The node is paused, and the execution of downstream nodes that depend on the current node is blocked.</description></item>
                /// <item><description>Skip: The node is set to dry run. The system directly returns a success response with an execution duration of 0 seconds. This does not block the execution of downstream nodes or consume resources.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>The resource group information.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesRuntimeResource RuntimeResource { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The identifier of the resource group. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the identifier of the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_XXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456XXX</para>
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
                public ListNodesResponseBodyPagingInfoNodesScript Script { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesScript : TeaModel {
                    /// <summary>
                    /// <para>The script ID.</para>
                    /// <remarks>
                    /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation to fail only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>853573334108680XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The script path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root/demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The runtime.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListNodesResponseBodyPagingInfoNodesScriptRuntime Runtime { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command used to distinguish node types.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ODPS_SQL</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

                /// <summary>
                /// <para>The scheduling policy.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesStrategy Strategy { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The mode for generating instances. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>T+1</description></item>
                    /// <item><description>Immediately</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T+1</para>
                    /// </summary>
                    [NameInMap("InstanceMode")]
                    [Validation(Required=false)]
                    public string InstanceMode { get; set; }

                    /// <summary>
                    /// <para>The retry time interval, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>180000</para>
                    /// </summary>
                    [NameInMap("RerunInterval")]
                    [Validation(Required=false)]
                    public int? RerunInterval { get; set; }

                    /// <summary>
                    /// <para>The rerun mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Allowed</description></item>
                    /// <item><description>Denied</description></item>
                    /// <item><description>FailureAllowed</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Allowed</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The number of retries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("RerunTimes")]
                    [Validation(Required=false)]
                    public int? RerunTimes { get; set; }

                    /// <summary>
                    /// <para>The timeout period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The tag information. This field is currently not used.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListNodesResponseBodyPagingInfoNodesTags> Tags { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88888888888</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The trigger.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesTrigger Trigger { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesTrigger : TeaModel {
                    /// <summary>
                    /// <para>The cron expression for scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The end time of the trigger validity period. The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>9999-01-01 00:00:00</c>. This example does not include a time zone identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The trigger ID.</para>
                    /// <remarks>
                    /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation to fail only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>543680677872062XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The start time of the trigger validity period. The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>1970-01-01 00:00:00</c>. This example does not include a time zone identifier.</para>
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
                    /// <item><description>Scheduler: periodic scheduling.</description></item>
                    /// <item><description>Manual: manual trigger.</description></item>
                    /// <item><description>Steaming: streaming task.</description></item>
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

            /// <summary>
            /// <para>The page number of the requested data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2197B9C4-39CE-55EA-8EEA-FDBAE52DXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
