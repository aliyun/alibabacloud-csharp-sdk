// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The description of the pipeline, which helps users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的流水线</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy. If specified, the existing execution policy is entirely overwritten.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public UpdatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class UpdatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The scheduling mode, such as Scheduled (timed scheduling) or RunOnce (one-time execution).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The configuration for one-time execution.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class UpdatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The data processing start time, in UNIX millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The data processing end time, in UNIX millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200000</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The timed scheduling configuration.</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class UpdatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time, in UNIX millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The scheduling interval, such as 1h.</para>
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
        /// <para>The pipeline configuration (node orchestration). If specified, the existing pipeline configuration is entirely overwritten.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineRequestPipeline Pipeline { get; set; }
        public class UpdatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class UpdatePipelineRequestPipelineNodes : TeaModel {
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
                /// <para>The node parameters in key-value format. The parameters vary by node type.</para>
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
        /// <para>The pipeline sink (data write destination). If specified, the existing sink configuration is entirely overwritten.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSink Sink { get; set; }
        public class UpdatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The destination dataset configuration.</para>
            /// </summary>
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
            /// <para>The sink type, such as Dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pipeline data source. If specified, the existing source configuration is entirely overwritten.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSource Source { get; set; }
        public class UpdatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The SLS Logstore datasource config.</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSourceLogstore Logstore { get; set; }
            public class UpdatePipelineRequestSourceLogstore : TeaModel {
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
            /// <para>The data source type, such as SLS.</para>
            /// 
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
