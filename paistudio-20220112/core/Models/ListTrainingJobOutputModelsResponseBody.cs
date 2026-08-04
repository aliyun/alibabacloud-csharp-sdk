// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobOutputModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of models produced by training.</para>
        /// </summary>
        [NameInMap("OutputModels")]
        [Validation(Required=false)]
        public List<ListTrainingJobOutputModelsResponseBodyOutputModels> OutputModels { get; set; }
        public class ListTrainingJobOutputModelsResponseBodyOutputModels : TeaModel {
            /// <summary>
            /// <para>Model compression configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("CompressionSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompressionSpec { get; set; }

            /// <summary>
            /// <para>Model evaluation configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("EvaluationSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> EvaluationSpec { get; set; }

            /// <summary>
            /// <para>Model inference configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("InferenceSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> InferenceSpec { get; set; }

            /// <summary>
            /// <para>List of tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListTrainingJobOutputModelsResponseBodyOutputModelsLabels> Labels { get; set; }
            public class ListTrainingJobOutputModelsResponseBodyOutputModelsLabels : TeaModel {
                /// <summary>
                /// <para>Tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RootModelName</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen2-0.5</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Training job metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;Results&quot;: [
            ///           {
            ///             &quot;Dataset&quot;: {
            ///               &quot;Train&quot;: &quot;oss://somebucket.oss-cn-hangzhou.aliyuncs.com/datasets/Chinese-medical-dialogue-data/chinese_medical_train_sampled.json&quot;
            ///             },
            ///             &quot;Metrics&quot;: {
            ///               &quot;loss&quot;: 2.1276
            ///             }
            ///           }
            ///         ]
            /// }</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metrics { get; set; }

            /// <summary>
            /// <para>Name of the training output data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            /// <summary>
            /// <para>Source ID (optional):</para>
            /// <list type="bullet">
            /// <item><description><para>If the source is Custom, there are no format requirements.</para>
            /// </description></item>
            /// <item><description><para>If the source is PAIFlow, use the format: region=cn-shanghai,workspaceId=1345,kind=PipelineRun,id=run-sakdbaskjdf.</para>
            /// </description></item>
            /// <item><description><para>If the source is TrainingService, use the format: region=cn-shanghai,workspaceId=1345,kind=TrainingJob,id=job-sakdbaskjdf.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>region=cn-shanghai,workspaceId=1345,kind=PipelineRun,id=run-sakdbaskjdf</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>Source (the type of job that produced the model). Default: Custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAIFlow</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>Model training configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TrainingSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> TrainingSpec { get; set; }

            /// <summary>
            /// <para>Link to the training output data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou.aliyuncs.com/path/to/output/channel/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
