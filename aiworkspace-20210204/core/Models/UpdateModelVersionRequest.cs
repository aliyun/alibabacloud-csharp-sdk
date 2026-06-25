// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateModelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The model is pending approval.</para>
        /// </description></item>
        /// <item><description><para>Approved: The model is approved to be published.</para>
        /// </description></item>
        /// <item><description><para>Rejected: The model is not approved to be published.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <para>The compression configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CompressionSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> CompressionSpec { get; set; }

        /// <summary>
        /// <para>The distillation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("DistillationSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> DistillationSpec { get; set; }

        /// <summary>
        /// <para>The evaluation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EvaluationSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvaluationSpec { get; set; }

        /// <summary>
        /// <para>Other information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;CoverUris&quot;: [&quot;<a href="https://e***u.oss-cn-hangzhou.aliyuncs.com/st****017.preview.png%22%5D">https://e***u.oss-cn-hangzhou.aliyuncs.com/st****017.preview.png&quot;]</a>,
        ///     &quot;TrainedWords&quot;: [&quot;albedo_overlord&quot;]
        /// }</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <para>Describes how to apply the model to downstream inference applications. For example, describe the processor and container for Elastic Algorithm Service (EAS). Example:
        /// <c>{ &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot; }</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InferenceSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceSpec { get; set; }

        /// <summary>
        /// <para>The model metrics.
        /// The length cannot exceed 8,192 characters after serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Results&quot;: [{
        ///     &quot;Dataset&quot;: {
        ///       &quot;DatasetId&quot;: &quot;d-sdkjanksaklerhfd&quot;
        ///     },
        ///     &quot;Metrics&quot;: {
        ///       &quot;cer&quot;: 0.175
        ///     }
        ///   }, {
        ///     &quot;Dataset&quot;: {
        ///       &quot;Uri&quot;: &quot;oss://xxxx/&quot;
        ///     },
        ///     &quot;Metrics&quot;: {
        ///       &quot;cer&quot;: 0.172
        ///     }
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metrics { get; set; }

        /// <summary>
        /// <para>The extended field. This field is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the source type is Custom, this field has no restrictions.</para>
        /// </description></item>
        /// <item><description><para>If the source is PAIFlow or TrainingService, the format is as follows:</para>
        /// </description></item>
        /// </list>
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>region: the Alibaba Cloud region ID.</para>
        /// </description></item>
        /// <item><description><para>workspaceId: the workspace ID.</para>
        /// </description></item>
        /// <item><description><para>kind: the type. Valid values: PipelineRun (PAI pipeline) or ServiceJob (training service).</para>
        /// </description></item>
        /// <item><description><para>id: the unique identifier.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom (default): The model is a custom model.</para>
        /// </description></item>
        /// <item><description><para>PAIFlow: The model is from a PAI pipeline.</para>
        /// </description></item>
        /// <item><description><para>TrainingService: The model is from a PAI training service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The training configuration. This is used for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The description of the model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General sentiment analysis.</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
