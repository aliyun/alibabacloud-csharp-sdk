// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The pipeline description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public CreatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class CreatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The execution mode. Set to <c>runOnce</c> for a single execution, or <c>scheduled</c> for a recurring execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>runOnce</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The configuration for a one-time execution. This parameter is required when <c>executePolicy.mode</c> is set to <c>runOnce</c>.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class CreatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The configuration for a scheduled execution. This parameter is required when <c>executePolicy.mode</c> is set to <c>scheduled</c>.</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class CreatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The start timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The execution interval in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        /// <summary>
        /// <para>The pipeline configuration.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public CreatePipelineRequestPipeline Pipeline { get; set; }
        public class CreatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The pipeline nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class CreatePipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node_1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node parameters.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dedup-fuzzy</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The pipeline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pipeline-name-1</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The data sink for the processed output.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public CreatePipelineRequestSink Sink { get; set; }
        public class CreatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The destination dataset configuration. This parameter is required when <c>sink.type</c> is set to <c>dataset</c>.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public CreatePipelineRequestSinkDataset Dataset { get; set; }
            public class CreatePipelineRequestSinkDataset : TeaModel {
                /// <summary>
                /// <para>The dataset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset_1</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace-test</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The sink type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The data source.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public CreatePipelineRequestSource Source { get; set; }
        public class CreatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The Log Service Logstore configuration. This parameter is required when <c>source.type</c> is set to <c>logstore</c>.</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceLogstore Logstore { get; set; }
            public class CreatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <para>The Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The Log Service Project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The query statement to filter logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status:500 and method:GET</para>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstore</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
