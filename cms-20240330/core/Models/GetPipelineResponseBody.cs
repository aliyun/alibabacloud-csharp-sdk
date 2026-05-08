// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace test</para>
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
            /// <para>runOnce</para>
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
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
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
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineNodes> Nodes { get; set; }
            public class GetPipelineResponseBodyPipelineNodes : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3430AE20-AFFF-597C-B553-2DF04B2933AA</para>
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
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logstore</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T14:09:11Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
