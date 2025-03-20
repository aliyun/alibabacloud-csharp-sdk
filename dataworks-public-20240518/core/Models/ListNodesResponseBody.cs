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
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyPagingInfoNodes> Nodes { get; set; }
            public class ListNodesResponseBodyPagingInfoNodes : TeaModel {
                /// <summary>
                /// <para>The time when the node was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722910655000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The information about the data source.</para>
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
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>860438872620113XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input of the node.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesInputs Inputs { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesInputs : TeaModel {
                    /// <summary>
                    /// <para>The node outputs.</para>
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

                    }

                    /// <summary>
                    /// <para>The tables.</para>
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
                    /// <para>The variables.</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>543211286945488XXXX</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

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
                            /// <para>The output of the node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>623731286945488XXXX</para>
                            /// </summary>
                            [NameInMap("Output")]
                            [Validation(Required=false)]
                            public string Output { get; set; }

                        }

                        /// <summary>
                        /// <para>The scope of the variable. Valid values:</para>
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
                        /// <para>222</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the node was last modified. This value is a UNIX timestamp.</para>
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
                /// <para>The output of the node.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesOutputs Outputs { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesOutputs : TeaModel {
                    /// <summary>
                    /// <para>The node outputs.</para>
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

                    }

                    /// <summary>
                    /// <para>The tables.</para>
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
                    /// <para>The variables.</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>623731286945488XXXX</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

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
                /// <para>The owner of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
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
                /// <item><description>Normal: The node is scheduled as expected.</description></item>
                /// <item><description>Pause: The node is paused, and the running of its descendant nodes is blocked.</description></item>
                /// <item><description>Skip: The node is dry run. The system does not actually run the node but directly prompts that the node is successfully run. The running duration of the node is 0 seconds. In addition, the node does not occupy resources or block the running of its descendant nodes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>The information about the resource group.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPagingInfoNodesRuntimeResource RuntimeResource { get; set; }
                public class ListNodesResponseBodyPagingInfoNodesRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_resgrop_xxx</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>853573334108680XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// <para>The instance generation mode. Valid values:</para>
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
                    /// <para>The rerun interval. Unit: milliseconds.</para>
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
                    /// <para>The number of reruns.</para>
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
                /// <para>The tags. This parameter is not in use.</para>
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
                    /// <para>The tag value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The scheduling task ID.</para>
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
                    /// <para>The CRON expression for scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 00 00 * * ?</para>
                    /// </summary>
                    [NameInMap("Cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>The end time of the validity period of the trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The trigger ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>543680677872062XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The start time of the validity period of the trigger.</para>
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
                    /// <item><description>Scheduler</description></item>
                    /// <item><description>Manual</description></item>
                    /// <item><description>Steaming</description></item>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2197B9C4-39CE-55EA-8EEA-FDBAE52DXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
