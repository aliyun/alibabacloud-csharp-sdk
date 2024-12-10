// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobOutputModelsResponseBody : TeaModel {
        [NameInMap("OutputModels")]
        [Validation(Required=false)]
        public List<ListTrainingJobOutputModelsResponseBodyOutputModels> OutputModels { get; set; }
        public class ListTrainingJobOutputModelsResponseBodyOutputModels : TeaModel {
            [NameInMap("CompressionSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompressionSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("EvaluationSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> EvaluationSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("InferenceSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> InferenceSpec { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListTrainingJobOutputModelsResponseBodyOutputModelsLabels> Labels { get; set; }
            public class ListTrainingJobOutputModelsResponseBodyOutputModelsLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>StableDiffusion</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;lr&quot;: 0.000001,
            ///       &quot;train_loss&quot;: 2.6345
            /// }</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metrics { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>region=cn-shanghai,workspaceId=1345,kind=PipelineRun,id=run-sakdbaskjdf</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PAIFlow</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TrainingSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> TrainingSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou.aliyuncs.com/path/to/output/channel/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
