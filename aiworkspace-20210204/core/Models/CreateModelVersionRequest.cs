// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateModelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The version is pending approval.</para>
        /// </description></item>
        /// <item><description><para>Approved: The version is approved for deployment.</para>
        /// </description></item>
        /// <item><description><para>Rejected: The version is rejected for deployment.</para>
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
        /// <para>The compression configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CompressionSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> CompressionSpec { get; set; }

        /// <summary>
        /// <para>The distillation configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("DistillationSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> DistillationSpec { get; set; }

        /// <summary>
        /// <para>The evaluation configurations.</para>
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
        /// <para>The format of the model. Valid values:</para>
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
        /// <para>The framework of the model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pytorch</para>
        /// </description></item>
        /// <item><description><para>XGBoost</para>
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
        /// <para>The configurations for downstream inference services, such as the processor and container for Elastic Algorithm Service (EAS). Example:
        /// <c>{ &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot; }</c></para>
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
        /// <para>The list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The model metrics.
        /// The serialized data cannot exceed 8,192 bytes in length.</para>
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
        /// <para>The extended fields. This parameter is a JSON string.</para>
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
        /// <item><description><para>If SourceType is set to Custom, this parameter has no format restrictions.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is PAIFlow or TrainingService, the value must be in the following format:</para>
        /// </description></item>
        /// </list>
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>The fields are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>region: The ID of the Alibaba Cloud region.</para>
        /// </description></item>
        /// <item><description><para>workspaceId: The ID of the workspace.</para>
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
        /// <item><description><para>Custom (default): The model is custom.</para>
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
        /// <para>The training configurations. These configurations are used for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The URI of the model version, which is the storage location of the model. The following types of model URIs are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>An HTTP or HTTPS URL of the model. Example: <c>https://myweb.com/mymodel.tar.gz</c>.</para>
        /// </description></item>
        /// <item><description><para>If the model is stored in Object Storage Service (OSS), the URI must be in the <c>oss://&lt;bucket&gt;.&lt;endpoint&gt;/object</c> format. For more information about endpoints, see <a href="https://help.aliyun.com/document_detail/31837.html">Endpoints</a>. Example: <c>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The description of the model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment analysis.</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The model version. The version must be unique within the model. If you do not specify this parameter, the first version defaults to <b>0.1.0</b>. The minor version number is then incremented by 1 for each subsequent version. For example, the second version defaults to <b>0.2.0</b>.
        /// A version number consists of a major version, a minor version, and a patch version, separated by periods (.). The major and minor versions are numbers. The patch version can start with a number and contain underscores (_) and letters. Examples: 1.1.0 and 2.3.4_beta.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
