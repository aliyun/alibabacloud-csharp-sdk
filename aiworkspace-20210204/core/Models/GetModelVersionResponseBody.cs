// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetModelVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The model is pending approval.</para>
        /// </description></item>
        /// <item><description><para>Approved: The model is approved for publishing.</para>
        /// </description></item>
        /// <item><description><para>Rejected: The model is rejected for publishing.</para>
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
        /// <para>The model format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OfflineModel</para>
        /// </description></item>
        /// <item><description><para>SavedModel</para>
        /// </description></item>
        /// <item><description><para>Keras H5</para>
        /// </description></item>
        /// <item><description><para>Frozen Pb</para>
        /// </description></item>
        /// <item><description><para>Caffe Prototxt</para>
        /// </description></item>
        /// <item><description><para>TorchScript</para>
        /// </description></item>
        /// <item><description><para>XGBoost</para>
        /// </description></item>
        /// <item><description><para>PMML</para>
        /// </description></item>
        /// <item><description><para>AlinkModel</para>
        /// </description></item>
        /// <item><description><para>ONNX</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SavedModel</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The model framework. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pytorch
        /// -XGBoost</para>
        /// </description></item>
        /// <item><description><para>Keras</para>
        /// </description></item>
        /// <item><description><para>Caffe</para>
        /// </description></item>
        /// <item><description><para>Alink</para>
        /// </description></item>
        /// <item><description><para>Xflow</para>
        /// </description></item>
        /// <item><description><para>TensorFlow</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TensorFlow</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The UTC time when the model was created. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the model was last updated. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Describes how to apply the model to a downstream inference service. For example, this can describe the processor and container for Elastic Algorithm Service (EAS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Processor&quot;: &quot;tensorflow_gpu_1.12&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InferenceSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceSpec { get; set; }

        /// <summary>
        /// <para>The list of labels for the model version.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
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
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the source type is Custom, this field has no limits.</para>
        /// </description></item>
        /// <item><description><para>If the source is PAIFlow or TrainingService, the format is:</para>
        /// </description></item>
        /// </list>
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>The parameters are:</para>
        /// <list type="bullet">
        /// <item><description><para>region: The ID of the Alibaba Cloud region.</para>
        /// </description></item>
        /// <item><description><para>workspaceId: The workspace ID.</para>
        /// </description></item>
        /// <item><description><para>kind: The type. Valid values: PipelineRun (PAI pipeline) and ServiceJob (training service).</para>
        /// </description></item>
        /// <item><description><para>id: The unique identifier.</para>
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
        /// <item><description><para>Custom: The model is a custom model.</para>
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
        /// <para>The training configuration. This is the configuration for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The URI of the model version. This is the storage location of the model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>The HTTP or HTTPS URL of the model. Example: <c>https://myweb.com/mymodel.tar.gz</c>.</para>
        /// </description></item>
        /// <item><description><para>If the model is stored in Object Storage Service (OSS), the format is <c>oss://&lt;bucket&gt;.&lt;endpoint&gt;/object</c>. For more information about how to configure the endpoint, see <a href="https://help.aliyun.com/document_detail/31837.html">Endpoints</a>. Example: <c>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890******</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The description of the model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General sentiment analysis.</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
