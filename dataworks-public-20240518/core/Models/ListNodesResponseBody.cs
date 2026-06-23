// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListNodesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListNodesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyPagingInfoNodes> Nodes { get; set; }
            public class ListNodesResponseBodyPagingInfoNodes : TeaModel {
                /// <summary>
                /// <para>The creation timestamp of the node.</para>
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
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is a <c>Long</c> in SDKs earlier than v8.0.0 and a <c>String</c> in v8.0.0 and later. <b>This change does not impact normal SDK use, as the parameter is returned in the type defined by your SDK.</b> Upgrading the SDK across v8.0.0 may cause compilation errors, which you must resolve by manually updating the data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>860438872620113XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node inputs.</para>
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
                        /// <para>A human-readable name for the input data table. This name is for display purposes only and has no functional effect.</para>
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
                    /// <para>The list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesInputsVariables> Variables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesInputsVariables : TeaModel {
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
                        /// <para>The variable ID.</para>
                        /// <remarks>
                        /// <para>Notice: </para>
                        /// </remarks>
                        /// <para>This parameter is a <c>Long</c> in SDKs earlier than v8.0.0 and a <c>String</c> in v8.0.0 and later. <b>This change does not impact normal SDK use, as the parameter is returned in the type defined by your SDK.</b> Upgrading the SDK across v8.0.0 may cause compilation errors, which you must resolve by manually updating the data type.</para>
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
                        /// <para>The scope of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>WorkSpace</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NodeParameter</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NodeContext</c></para>
                        /// </description></item>
                        /// <item><description><para><c>Workflow</c></para>
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
                        /// <item><description><para><c>NoKvVariableExpression</c></para>
                        /// </description></item>
                        /// <item><description><para><c>Constant</c></para>
                        /// </description></item>
                        /// <item><description><para><c>PassThrough</c></para>
                        /// </description></item>
                        /// <item><description><para><c>System</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NodeOutput</c></para>
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
                        /// <para>222</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The last modification timestamp of the node.</para>
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
                /// <para>The node outputs.</para>
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
                        /// <para>A human-readable name for the output data table. This name is for display purposes only and has no functional effect.</para>
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
                    /// <para>The list of variables.</para>
                    /// </summary>
                    [NameInMap("Variables")]
                    [Validation(Required=false)]
                    public List<ListNodesResponseBodyPagingInfoNodesOutputsVariables> Variables { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesOutputsVariables : TeaModel {
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
                        /// <para>The variable ID.</para>
                        /// <remarks>
                        /// <para>Notice: </para>
                        /// </remarks>
                        /// <para>This parameter is a <c>Long</c> in SDKs earlier than v8.0.0 and a <c>String</c> in v8.0.0 and later. <b>This change does not impact normal SDK use, as the parameter is returned in the type defined by your SDK.</b> Upgrading the SDK across v8.0.0 may cause compilation errors, which you must resolve by manually updating the data type.</para>
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
                        /// <para>The scope of the variable.</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>NodeParameter</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NodeContext</c></para>
                        /// </description></item>
                        /// <item><description><para><c>Workflow</c></para>
                        /// </description></item>
                        /// <item><description><para><c>Workspace</c></para>
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
                        /// <item><description><para><c>NoKvVariableExpression</c></para>
                        /// </description></item>
                        /// <item><description><para><c>Constant</c></para>
                        /// </description></item>
                        /// <item><description><para><c>PassThrough</c></para>
                        /// </description></item>
                        /// <item><description><para><c>System</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NodeOutput</c></para>
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
                /// <para>The owner of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace. You can find this ID on the Workspace Management page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33233</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The scheduling type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Normal</c>: The node runs as scheduled.</para>
                /// </description></item>
                /// <item><description><para><c>Pause</c>: The node is paused and blocks the execution of its downstream nodes.</para>
                /// </description></item>
                /// <item><description><para><c>Skip</c>: The node is skipped. The system immediately returns a success status with an execution duration of 0 seconds. This does not block downstream nodes or consume resources.</para>
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
                /// <para>Information about the resource group.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesRuntimeResource RuntimeResource { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The identifier of the resource group. You can obtain this identifier by calling the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_XXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456XXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>Information about the script.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesScript Script { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesScript : TeaModel {
                    /// <summary>
                    /// <para>The ID of the script.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <para>This parameter is a <c>Long</c> in SDKs earlier than v8.0.0 and a <c>String</c> in v8.0.0 and later. <b>This change does not impact normal SDK use, as the parameter is returned in the type defined by your SDK.</b> Upgrading the SDK across v8.0.0 may cause compilation errors, which you must resolve by manually updating the data type.</para>
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
                    /// <para>The runtime.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListNodesResponseBodyPagingInfoNodesScriptRuntime Runtime { get; set; }
                    public class ListNodesResponseBodyPagingInfoNodesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command that identifies the node type.</para>
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
                public ListNodesResponseBodyPagingInfoNodesStrategy Strategy { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The instance generation mode.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>T+1</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Immediately</c></para>
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
                    /// <para>The retry interval, in milliseconds.</para>
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
                    /// <item><description><para><c>Allowed</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Denied</c></para>
                    /// </description></item>
                    /// <item><description><para><c>FailureAllowed</c></para>
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
                    /// <para>The number of retries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("RerunTimes")]
                    [Validation(Required=false)]
                    public int? RerunTimes { get; set; }

                    /// <summary>
                    /// <para>The timeout duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The tags for the node. This parameter is not in use.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListNodesResponseBodyPagingInfoNodesTags> Tags { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesTags : TeaModel {
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
                    /// <para>The cron expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The end of the trigger\&quot;s validity period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the trigger.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <para>This parameter is a <c>Long</c> in SDKs earlier than v8.0.0 and a <c>String</c> in v8.0.0 and later. <b>This change does not impact normal SDK use, as the parameter is returned in the type defined by your SDK.</b> Upgrading the SDK across v8.0.0 may cause compilation errors, which you must resolve by manually updating the data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>543680677872062XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The start of the trigger\&quot;s validity period.</para>
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
                    /// <para>The type of the trigger.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Scheduler</c>: periodic scheduling</para>
                    /// </description></item>
                    /// <item><description><para><c>Manual</c>: manual trigger</para>
                    /// </description></item>
                    /// <item><description><para><c>Streaming</c>: streaming task</para>
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
            /// <para>The page number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the specified filter criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2197B9C4-39CE-55EA-8EEA-FDBAE52DXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
