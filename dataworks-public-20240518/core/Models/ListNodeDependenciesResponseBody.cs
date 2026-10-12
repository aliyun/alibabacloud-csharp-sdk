// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodeDependenciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListNodeDependenciesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListNodeDependenciesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of queried dependent nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodeDependenciesResponseBodyPagingInfoNodes> Nodes { get; set; }
            public class ListNodeDependenciesResponseBodyPagingInfoNodes : TeaModel {
                /// <summary>
                /// <para>The timestamp when the data development node was created.</para>
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
                /// <para>Notice: This field is of the Long type before SDK 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK, and the parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>723932906364267XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node input.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesInputs Inputs { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesInputs : TeaModel {
                    /// <summary>
                    /// <para>The list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsNodeOutputs : TeaModel {
                        /// <summary>
                        /// <para>The output of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>860438872620113XXXX</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>The name of the destination data table generated by the node. This field provides an easy-to-understand semantic name to help you quickly identify the output content. It is used only for display and reference purposes and has no actual logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The table list.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsTables> Tables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsTables : TeaModel {
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
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariables> Variables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesInputsVariables : TeaModel {
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
                        /// <para>Notice: This field was of the Long type before SDK 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                        /// </remarks>
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
                            /// <para>The output of the node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>860438872620113XXXX</para>
                            /// </summary>
                            [NameInMap("Output")]
                            [Validation(Required=false)]
                            public string Output { get; set; }

                        }

                        /// <summary>
                        /// <para>The scope. Valid values:</para>
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
                        /// <para>111</para>
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
                /// <para>The output of the node.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public ListNodeDependenciesResponseBodyPagingInfoNodesOutputs Outputs { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputs : TeaModel {
                    /// <summary>
                    /// <para>The list of node outputs.</para>
                    /// </summary>
                    [NameInMap("NodeOutputs")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsNodeOutputs> NodeOutputs { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsNodeOutputs : TeaModel {
                        /// <summary>
                        /// <para>The output of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>463497880880954XXXX</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>The name of the destination data table generated by the node. This field provides an easy-to-understand semantic name to help you quickly identify the output content. It is used only for display and reference purposes and has no actual logical constraints.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testProject.testTableName</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The table list.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsTables> Tables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsTables : TeaModel {
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
                    public List<ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariables> Variables { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesOutputsVariables : TeaModel {
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
                        /// <para>Notice: This field was of the Long type before SDK 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                        /// </remarks>
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
                /// <para>The ID of the workspace to which the data development node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65133</para>
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
                public ListNodeDependenciesResponseBodyPagingInfoNodesRuntimeResource RuntimeResource { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_XXXX_XXXX</para>
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
                public ListNodeDependenciesResponseBodyPagingInfoNodesScript Script { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesScript : TeaModel {
                    /// <summary>
                    /// <para>The script ID.</para>
                    /// <remarks>
                    /// <para>Notice: This field is of the Long type before SDK 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK, and the parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
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
                    public ListNodeDependenciesResponseBodyPagingInfoNodesScriptRuntime Runtime { get; set; }
                    public class ListNodeDependenciesResponseBodyPagingInfoNodesScriptRuntime : TeaModel {
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
                public ListNodeDependenciesResponseBodyPagingInfoNodesStrategy Strategy { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The mode in which instances are generated. Valid values:</para>
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
                    /// <para>The retry time after it failed, in milliseconds.</para>
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
                /// <para>The tag information. This field is not used.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListNodeDependenciesResponseBodyPagingInfoNodesTags> Tags { get; set; }
                public class ListNodeDependenciesResponseBodyPagingInfoNodesTags : TeaModel {
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
                    /// <para>The cron expression for scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The end time when the schedule takes effect. The format is yyyy-MM-dd HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the trigger.</para>
                    /// <remarks>
                    /// <para>Notice: This field is of the Long type before SDK 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect the normal use of the SDK, and the parameter is still returned based on the type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>543680677872062XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The start time when the schedule takes effect. The format is yyyy-MM-dd HH:mm:ss.</para>
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
                    /// <item><description>Scheduler: Periodic scheduling.</description></item>
                    /// <item><description>Manual: Manual scheduling.</description></item>
                    /// <item><description>Streaming: Streaming scheduler.</description></item>
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
            /// <para>The page number of the returned page.</para>
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
            /// <para>The total number of entries that meet the specified conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204EAF68-CCE3-5112-8DA0-E7A60F02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
