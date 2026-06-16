// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的流水线</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyExecutePolicy ExecutePolicy { get; set; }
        public class GetPipelineResponseBodyExecutePolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyRunOnce RunOnce { get; set; }
            public class GetPipelineResponseBodyExecutePolicyRunOnce : TeaModel {
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
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
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
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineNodes> Nodes { get; set; }
            public class GetPipelineResponseBodyPipelineNodes : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySink Sink { get; set; }
        public class GetPipelineResponseBodySink : TeaModel {
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkDataset Dataset { get; set; }
            public class GetPipelineResponseBodySinkDataset : TeaModel {
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
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

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
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
