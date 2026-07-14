// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The pipeline description. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>从 SLS 采集 Trace 数据清洗入 Dataset</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scheduling policy.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public CreatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class CreatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The scheduling mode. Valid values: RunOnce (one-time execution) and Scheduled (periodic scheduling).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunOnce</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The one-time execution configuration. This parameter is required only when mode is set to RunOnce.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class CreatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time of the data processing window, in Unix seconds. The value must be less than toTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time of the data processing window, in Unix seconds. The value must be greater than fromTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The periodic scheduling configuration. This parameter is required only when mode is set to Scheduled.</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class CreatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time, in Unix milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The scheduling interval. Valid values: 1h, 6h, 12h, and 1d.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1h</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        /// <summary>
        /// <para>The pipeline configuration for node orchestration.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public CreatePipelineRequestPipeline Pipeline { get; set; }
        public class CreatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class CreatePipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node parameters in key-value format. The parameters vary depending on the node type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>transform</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The pipeline name. The name must be 3 to 63 characters in length and can contain only lowercase letters, digits, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The pipeline sink (data write destination).</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public CreatePipelineRequestSink Sink { get; set; }
        public class CreatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The destination dataset configuration.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public CreatePipelineRequestSinkDataset Dataset { get; set; }
            public class CreatePipelineRequestSinkDataset : TeaModel {
                /// <summary>
                /// <para>The name of the AgentSpace to which the destination dataset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The name of the destination dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

            }

            /// <summary>
            /// <para>The sink type. Currently, Dataset is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pipeline data source.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public CreatePipelineRequestSource Source { get; set; }
        public class CreatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The SLS Logstore datasource config.</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceLogstore Logstore { get; set; }
            public class CreatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <para>The name of the SLS Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the SLS project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The data filtered query statement in SLS query/analysis syntax.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>| SELECT *</description></item>
                /// </list>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The data source type. Currently, SLS is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token. A unique string generated by the client to ensure the idempotence of the create operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
