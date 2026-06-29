// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateNodeSupplementRequest : TeaModel {
        /// <summary>
        /// <para>Create backfill request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateNodeSupplementRequestCreateCommand CreateCommand { get; set; }
        public class CreateNodeSupplementRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>Bulk mode: Include all downstream nodes. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainAllDownStream")]
            [Validation(Required=false)]
            public bool? ContainAllDownStream { get; set; }

            /// <summary>
            /// <para>Downstream node IDs. Specifies downstream nodes for execution.</para>
            /// </summary>
            [NameInMap("DownStreamNodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList> DownStreamNodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList : TeaModel {
                /// <summary>
                /// <para>Field ID</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2323232</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>End business date</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21</para>
            /// </summary>
            [NameInMap("EndBizDate")]
            [Validation(Required=false)]
            public string EndBizDate { get; set; }

            /// <summary>
            /// <para>Filter list: Used together with ContainAllDownStream. You can include or exclude items based on project, node, and other criteria. Default value: empty.</para>
            /// </summary>
            [NameInMap("FilterList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandFilterList> FilterList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandFilterList : TeaModel {
                /// <summary>
                /// <para>Specifies whether to exclude the matched items. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public bool? Exclude { get; set; }

                /// <summary>
                /// <para>Filter key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROJECT: project</description></item>
                /// <item><description>NODE_OUTPUT_NAME: node output name</description></item>
                /// <item><description>NODE_NAME: node name</description></item>
                /// <item><description>NODE_ID: node ID</description></item>
                /// <item><description>TARGETS: specified endpoints</description></item>
                /// <item><description>SOURCES: specified start points</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NODE_OUTPUT_NAME</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Filter value list</para>
                /// </summary>
                [NameInMap("ValueList")]
                [Validation(Required=false)]
                public List<string> ValueList { get; set; }

            }

            /// <summary>
            /// <para>Runtime global parameters</para>
            /// </summary>
            [NameInMap("GlobalParamList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandGlobalParamList> GlobalParamList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandGlobalParamList : TeaModel {
                /// <summary>
                /// <para>Parameter key</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Parameter value</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Latest trigger time (HH:MM). This parameter applies only to hourly tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:59</para>
            /// </summary>
            [NameInMap("MaxDueTime")]
            [Validation(Required=false)]
            public string MaxDueTime { get; set; }

            /// <summary>
            /// <para>Earliest trigger time (HH:MM). This parameter applies only to hourly tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("MinDueTime")]
            [Validation(Required=false)]
            public string MinDueTime { get; set; }

            /// <summary>
            /// <para>Backfill name. If not specified, a name is automatically generated by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Root nodes for backfill. Multiple root nodes are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeIdList> NodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeIdList : TeaModel {
                /// <summary>
                /// <para>Field ID list: Can be specified when the node is a logical table node ID. If not specified, the entire table is used by default.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>Node ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1232324</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>Runtime custom parameters, configured per node</para>
            /// </summary>
            [NameInMap("NodeParamsList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeParamsList> NodeParamsList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeParamsList : TeaModel {
                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_23324</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Parameter list</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<CreateNodeSupplementRequestCreateCommandNodeParamsListParamList> ParamList { get; set; }
                public class CreateNodeSupplementRequestCreateCommandNodeParamsListParamList : TeaModel {
                    /// <summary>
                    /// <para>Parameter key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Parameter value</para>
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
            /// <para>Concurrency. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            /// <summary>
            /// <para>Project ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101121</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Start business date</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21</para>
            /// </summary>
            [NameInMap("StartBizDate")]
            [Validation(Required=false)]
            public string StartBizDate { get; set; }

        }

        /// <summary>
        /// <para>Environment identifier.</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment.</description></item>
        /// <item><description>PROD (default): production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
