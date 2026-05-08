// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public CreatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class CreatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>runOnce</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class CreatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class CreatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public CreatePipelineRequestPipeline Pipeline { get; set; }
        public class CreatePipelineRequestPipeline : TeaModel {
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class CreatePipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>node_1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dedup-fuzzy</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pipeline-name-1</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public CreatePipelineRequestSink Sink { get; set; }
        public class CreatePipelineRequestSink : TeaModel {
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public CreatePipelineRequestSinkDataset Dataset { get; set; }
            public class CreatePipelineRequestSinkDataset : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dataset_1</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>workspace-test</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("source")]
        [Validation(Required=false)]
        public CreatePipelineRequestSource Source { get; set; }
        public class CreatePipelineRequestSource : TeaModel {
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceLogstore Logstore { get; set; }
            public class CreatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>status:500 and method:GET</para>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logstore</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
