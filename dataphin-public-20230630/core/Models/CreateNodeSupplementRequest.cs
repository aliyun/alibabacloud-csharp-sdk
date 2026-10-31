// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateNodeSupplementRequest : TeaModel {
        /// <summary>
        /// <para>The data backfill request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateNodeSupplementRequestCreateCommand CreateCommand { get; set; }
        public class CreateNodeSupplementRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include all downstream nodes in massive mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainAllDownStream")]
            [Validation(Required=false)]
            public bool? ContainAllDownStream { get; set; }

            /// <summary>
            /// <para>The IDs of the downstream nodes to run. This parameter takes effect only when ContainAllDownStream is set to false.</para>
            /// </summary>
            [NameInMap("DownStreamNodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList> DownStreamNodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList : TeaModel {
                /// <summary>
                /// <para>The field IDs.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2323232</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The end business date. Format: YYYY-MM-DD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21</para>
            /// </summary>
            [NameInMap("EndBizDate")]
            [Validation(Required=false)]
            public string EndBizDate { get; set; }

            /// <summary>
            /// <para>The execution status of idle nodes. Valid values: NORMAL, PAUSED, and IDLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ExecuteStatusOfIdleNode")]
            [Validation(Required=false)]
            public string ExecuteStatusOfIdleNode { get; set; }

            /// <summary>
            /// <para>The execution status of paused nodes. Valid values: NORMAL, PAUSED, and IDLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ExecuteStatusOfPauseNode")]
            [Validation(Required=false)]
            public string ExecuteStatusOfPauseNode { get; set; }

            /// <summary>
            /// <para>The filter list. This parameter is used together with ContainAllDownStream to include or exclude items such as projects and nodes. Default value: empty.</para>
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
                /// <para>The filter key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROJECT: project</description></item>
                /// <item><description>NODE_OUTPUT_NAME: node output name</description></item>
                /// <item><description>NODE_NAME: node name</description></item>
                /// <item><description>NODE_ID: node ID</description></item>
                /// <item><description>TARGETS: specified destination</description></item>
                /// <item><description>SOURCES: specified source</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NODE_OUTPUT_NAME</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of filter values.</para>
                /// </summary>
                [NameInMap("ValueList")]
                [Validation(Required=false)]
                public List<string> ValueList { get; set; }

            }

            /// <summary>
            /// <para>The global parameters at runtime.</para>
            /// </summary>
            [NameInMap("GlobalParamList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandGlobalParamList> GlobalParamList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandGlobalParamList : TeaModel {
                /// <summary>
                /// <para>The parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The latest trigger time. Format: HH:MM. This parameter is dedicated to hourly nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:59</para>
            /// </summary>
            [NameInMap("MaxDueTime")]
            [Validation(Required=false)]
            public string MaxDueTime { get; set; }

            /// <summary>
            /// <para>The earliest trigger time. Format: HH:MM. This parameter is dedicated to hourly nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("MinDueTime")]
            [Validation(Required=false)]
            public string MinDueTime { get; set; }

            /// <summary>
            /// <para>The name of the data backfill task. If you do not specify this parameter, the system generates a name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the root nodes for data backfill. Multiple root nodes are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeIdList> NodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeIdList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs. This parameter can be specified when the node is a logical table node. If you do not specify this parameter, all fields in the table are used by default.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
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
            /// <para>The custom parameters at runtime, configured by node.</para>
            /// </summary>
            [NameInMap("NodeParamsList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeParamsList> NodeParamsList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeParamsList : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_23324</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The list of parameters.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<CreateNodeSupplementRequestCreateCommandNodeParamsListParamList> ParamList { get; set; }
                public class CreateNodeSupplementRequestCreateCommandNodeParamsListParamList : TeaModel {
                    /// <summary>
                    /// <para>The parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The parameter value.</para>
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
            /// <para>The concurrency. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101121</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Corresponds to the Task Run Time option in the data backfill dialog box on the page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: ignores the scheduled run time of instances and runs all instances immediately.</description></item>
            /// <item><description>false: waits for the scheduled run time of instances and runs each instance only when its scheduled time is reached.
            /// Default value: true.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RunImmediately")]
            [Validation(Required=false)]
            public bool? RunImmediately { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ScheduleResourceGroupId")]
            [Validation(Required=false)]
            public string ScheduleResourceGroupId { get; set; }

            /// <summary>
            /// <para>The start business date. Format: YYYY-MM-DD.</para>
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
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment </description></item>
        /// <item><description>PROD: production environment (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
