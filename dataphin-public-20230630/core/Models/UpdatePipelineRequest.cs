// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public UpdatePipelineRequestContext Context { get; set; }
        public class UpdatePipelineRequestContext : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdatePipelineRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdatePipelineRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public UpdatePipelineRequestUpdateCommandNodeInfo NodeInfo { get; set; }
            public class UpdatePipelineRequestUpdateCommandNodeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public UpdatePipelineRequestUpdateCommandPipelineConfig PipelineConfig { get; set; }
            public class UpdatePipelineRequestUpdateCommandPipelineConfig : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<UpdatePipelineRequestUpdateCommandPipelineConfigHops> Hops { get; set; }
                public class UpdatePipelineRequestUpdateCommandPipelineConfigHops : TeaModel {
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_writer</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<UpdatePipelineRequestUpdateCommandPipelineConfigSteps> Steps { get; set; }
                public class UpdatePipelineRequestUpdateCommandPipelineConfigSteps : TeaModel {
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("StepType")]
                    [Validation(Required=false)]
                    public string StepType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PipelineJson")]
            [Validation(Required=false)]
            public string PipelineJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

        }

    }

}
