// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>我的流水线</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public UpdatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class UpdatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class UpdatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1735747200000</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class UpdatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1h</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineRequestPipeline Pipeline { get; set; }
        public class UpdatePipelineRequestPipeline : TeaModel {
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class UpdatePipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>transform</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSink Sink { get; set; }
        public class UpdatePipelineRequestSink : TeaModel {
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSinkDataset Dataset { get; set; }
            public class UpdatePipelineRequestSinkDataset : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("source")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSource Source { get; set; }
        public class UpdatePipelineRequestSource : TeaModel {
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSourceLogstore Logstore { get; set; }
            public class UpdatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
