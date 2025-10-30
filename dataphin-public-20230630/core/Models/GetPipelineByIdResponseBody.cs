// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPipelineByIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPipelineByIdResponseBodyData Data { get; set; }
        public class GetPipelineByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public GetPipelineByIdResponseBodyDataNodeInfo NodeInfo { get; set; }
            public class GetPipelineByIdResponseBodyDataNodeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>comment</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

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

            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public GetPipelineByIdResponseBodyDataPipelineConfig PipelineConfig { get; set; }
            public class GetPipelineByIdResponseBodyDataPipelineConfig : TeaModel {
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<GetPipelineByIdResponseBodyDataPipelineConfigHops> Hops { get; set; }
                public class GetPipelineByIdResponseBodyDataPipelineConfigHops : TeaModel {
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps_writer</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<GetPipelineByIdResponseBodyDataPipelineConfigSteps> Steps { get; set; }
                public class GetPipelineByIdResponseBodyDataPipelineConfigSteps : TeaModel {
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
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
            /// <para>123</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
