// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodeDependenciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination settings.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListNodeDependenciesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListNodeDependenciesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>A list of dependent nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodeDependenciesResponseBodyPagingInfoNodes> Nodes { get; set; }
            public class ListNodeDependenciesResponseBodyPagingInfoNodes : TeaModel {
                /// <summary>
                /// <para>The creation timestamp of the data development node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data source.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesDataSource DataSource { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The data source name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The data source type.</para>
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
                /// <para>The unique ID of the data development node.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>The data type for this parameter is <c>Long</c> for SDKs earlier than v8.0.0 and <c>String</c> for SDK v8.0.0 and later. <b>This change does not affect normal usage, as the parameter\&quot;s data type matches the SDK definition.</b> However, upgrading from a pre-8.0.0 SDK version may cause a compilation error, requiring you to manually update the data type in your code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>723932906364267XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Details about the node\&quot;s inputs.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesInputs Inputs { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesInputs : TeaModel {
                    /// <summary>
                    /// <para>A list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsNodeOutputs : TeaModel {
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
                        /// <para>A human-readable name for the node\&quot;s target data table. This identifier is for display purposes only and does not enforce logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>A list of tables.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsTables> Tables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsTables : TeaModel {
                        /// <summary>
                        /// <para>The ID of the table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.autotest.test_output_table_1</para>
                        /// </summary>
                        [NameInMap("Guid")]
                        [Validation(Required=false)]
                        public string Guid { get; set; }

                    }

                    /// <summary>
                    /// <para>A list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariables> Variables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariables : TeaModel {
                        /// <summary>
                        /// <para>The artifact type.</para>
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
                        /// <para>Notice: </para>
                        /// </remarks>
                        /// <para>The data type for this parameter is <c>Long</c> for SDKs earlier than v8.0.0 and <c>String</c> for SDK v8.0.0 and later. <b>This change does not affect normal usage, as the parameter\&quot;s data type matches the SDK definition.</b> However, upgrading from a pre-8.0.0 SDK version may cause a compilation error, requiring you to manually update the data type in your code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>543218872620113XXXX</para>
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
                        public ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariablesNode Node { get; set; }
                        public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariablesNode : TeaModel {
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
                        /// <para>The scope of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para>NodeParameter</para>
                        /// </description></item>
                        /// <item><description><para>NodeContext</para>
                        /// </description></item>
                        /// <item><description><para>Workflow</para>
                        /// </description></item>
                        /// <item><description><para>Workspace</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeParameter</para>
                        /// </summary>
                        [NameInMap("Scope")]
                        [Validation(Required=false)]
                        public string Scope { get; set; }

                        /// <summary>
                        /// <para>The type of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para>NoKvVariableExpression</para>
                        /// </description></item>
                        /// <item><description><para>Constant</para>
                        /// </description></item>
                        /// <item><description><para>PassThrough</para>
                        /// </description></item>
                        /// <item><description><para>System</para>
                        /// </description></item>
                        /// <item><description><para>NodeOutput</para>
                        /// </description></item>
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
                /// <para>The last modification timestamp of the data development node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the data development node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Details about the node\&quot;s outputs.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesOutputs Outputs { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputs : TeaModel {
                    /// <summary>
                    /// <para>A list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsNodeOutputs : TeaModel {
                        /// <summary>
                        /// <para>The node output.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>463497880880954XXXX</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>A human-readable name for the node\&quot;s target data table. This identifier is for display purposes only and does not enforce logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>A list of tables.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsTables> Tables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsTables : TeaModel {
                        /// <summary>
                        /// <para>The ID of the table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.autotest.test_output_table_1</para>
                        /// </summary>
                        [NameInMap("Guid")]
                        [Validation(Required=false)]
                        public string Guid { get; set; }

                    }

                    /// <summary>
                    /// <para>A list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariables> Variables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariables : TeaModel {
                        /// <summary>
                        /// <para>The artifact type.</para>
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
                        /// <para>Notice: </para>
                        /// </remarks>
                        /// <para>The data type for this parameter is <c>Long</c> for SDKs earlier than v8.0.0 and <c>String</c> for SDK v8.0.0 and later. <b>This change does not affect normal usage, as the parameter\&quot;s data type matches the SDK definition.</b> However, upgrading from a pre-8.0.0 SDK version may cause a compilation error, requiring you to manually update the data type in your code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>543217824470354XXXX</para>
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
                        public ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariablesNode Node { get; set; }
                        public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariablesNode : TeaModel {
                            /// <summary>
                            /// <para>The node output that corresponds to the variable.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>463497880880954XXXX</para>
                            /// </summary>
                            [NameInMap("Output")]
                            [Validation(Required=false)]
                            public string Output { get; set; }

                        }

                        /// <summary>
                        /// <para>The scope of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para>NodeParameter</para>
                        /// </description></item>
                        /// <item><description><para>NodeContext</para>
                        /// </description></item>
                        /// <item><description><para>Workflow</para>
                        /// </description></item>
                        /// <item><description><para>Workspace</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeParameter</para>
                        /// </summary>
                        [NameInMap("Scope")]
                        [Validation(Required=false)]
                        public string Scope { get; set; }

                        /// <summary>
                        /// <para>The type of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para>NoKvVariableExpression</para>
                        /// </description></item>
                        /// <item><description><para>Constant</para>
                        /// </description></item>
                        /// <item><description><para>PassThrough</para>
                        /// </description></item>
                        /// <item><description><para>System</para>
                        /// </description></item>
                        /// <item><description><para>NodeOutput</para>
                        /// </description></item>
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
                /// <para>The ID of the project that contains the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65133</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The execution mode of the node.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Normal</c>: The node runs as normal.</para>
                /// </description></item>
                /// <item><description><para><c>Pause</c>: The node is paused. This action blocks the execution of downstream nodes that depend on this node.</para>
                /// </description></item>
                /// <item><description><para><c>Skip</c>: The node is skipped (dry run). The system immediately returns a success status with an execution time of 0 seconds. This action does not block downstream nodes or consume resources.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>Details about the resource group.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesRuntimeResource RuntimeResource { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The ID of the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_XXXX_XXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>Details about the script.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesScript Script { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesScript : TeaModel {
                    /// <summary>
                    /// <para>The ID of the script.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <para>The data type for this parameter is <c>Long</c> for SDKs earlier than v8.0.0 and <c>String</c> for SDK v8.0.0 and later. <b>This change does not affect normal usage, as the parameter\&quot;s data type matches the SDK definition.</b> However, upgrading from a pre-8.0.0 SDK version may cause a compilation error, requiring you to manually update the data type in your code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>853573334108680XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The path of the script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root/demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The runtime environment.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListNodeDependenciesResponseBodyPagingInfoNodesScriptRuntime Runtime { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command that is used to distinguish between node types.</para>
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
                /// <para>The scheduling strategy.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesStrategy Strategy { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The instance generation mode.</para>
                    /// <list type="bullet">
                    /// <item><description><para>T+1</para>
                    /// </description></item>
                    /// <item><description><para>Immediately</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T+1</para>
                    /// </summary>
                    [NameInMap("InstanceMode")]
                    [Validation(Required=false)]
                    public string InstanceMode { get; set; }

                    /// <summary>
                    /// <para>The retry interval after a failure, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>180000</para>
                    /// </summary>
                    [NameInMap("RerunInterval")]
                    [Validation(Required=false)]
                    public int? RerunInterval { get; set; }

                    /// <summary>
                    /// <para>The rerun mode.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Allowed</para>
                    /// </description></item>
                    /// <item><description><para>Denied</para>
                    /// </description></item>
                    /// <item><description><para>FailureAllowed</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Allowed</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The number of retries after a failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("RerunTimes")]
                    [Validation(Required=false)]
                    public int? RerunTimes { get; set; }

                    /// <summary>
                    /// <para>The timeout period, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>A list of tags. This parameter is currently not in use.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListNodeDependenciesResponseBodyPagingInfoNodesTags> Tags { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
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
                /// <para>580667964888595XXXX</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The trigger.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesTrigger Trigger { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesTrigger : TeaModel {
                    /// <summary>
                    /// <para>The cron expression used for scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The time when scheduling expires, in <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the trigger.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <para>The data type for this parameter is <c>Long</c> for SDKs earlier than v8.0.0 and <c>String</c> for SDK v8.0.0 and later. <b>This change does not affect normal usage, as the parameter\&quot;s data type matches the SDK definition.</b> However, upgrading from a pre-8.0.0 SDK version may cause a compilation error, requiring you to manually update the data type in your code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>543680677872062XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The time when scheduling becomes effective, in <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
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
                    /// <item><description><para><c>Scheduler</c>: Periodic scheduling.</para>
                    /// </description></item>
                    /// <item><description><para><c>Manual</c>: Manual scheduling.</para>
                    /// </description></item>
                    /// <item><description><para><c>Streaming</c>: Stream-based scheduling.</para>
                    /// </description></item>
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
            /// <para>The number of the page to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of matching entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204EAF68-CCE3-5112-8DA0-E7A60F02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
