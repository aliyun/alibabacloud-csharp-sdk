// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyExecutePolicy ExecutePolicy { get; set; }
        public class GetPipelineResponseBodyExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The execution mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>runOnce</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The configuration for a one-time execution.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyRunOnce RunOnce { get; set; }
            public class GetPipelineResponseBodyExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time of the execution, as a Unix timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time of the execution, as a Unix timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1772519013</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The configuration for a scheduled execution.</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The start time of the execution, as a Unix timestamp.</para>
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
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The nodes in the pipeline.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineNodes> Nodes { get; set; }
            public class GetPipelineResponseBodyPipelineNodes : TeaModel {
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
                /// <para>The parameters for the node.</para>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3430AE20-AFFF-597C-B553-2DF04B2933AA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pipeline\&quot;s data sink.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySink Sink { get; set; }
        public class GetPipelineResponseBodySink : TeaModel {
            /// <summary>
            /// <para>The dataset configuration.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkDataset Dataset { get; set; }
            public class GetPipelineResponseBodySinkDataset : TeaModel {
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
        /// <para>The pipeline\&quot;s data source.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            /// <summary>
            /// <para>The configuration of the Log Service Logstore.</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
                /// <summary>
                /// <para>The name of the Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The type of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstore</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The update time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T14:09:11Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

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

}
