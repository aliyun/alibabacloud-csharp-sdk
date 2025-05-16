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
        /// <item><description>Pending</description></item>
        /// <item><description>Approved</description></item>
        /// <item><description>Rejected</description></item>
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
        /// <para>The evaluation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EvaluationSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvaluationSpec { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
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
        /// <item><description>OfflineModel</description></item>
        /// <item><description>SavedModel</description></item>
        /// <item><description>Keras H5</description></item>
        /// <item><description>Frozen Pb</description></item>
        /// <item><description>Caffe Prototxt</description></item>
        /// <item><description>TorchScript</description></item>
        /// <item><description>XGBoost</description></item>
        /// <item><description>PMML</description></item>
        /// <item><description>AlinkModel</description></item>
        /// <item><description>ONNX</description></item>
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
        /// <item><description>Pytorch</description></item>
        /// <item><description>XGBoost</description></item>
        /// <item><description>Keras</description></item>
        /// <item><description>Caffe</description></item>
        /// <item><description>Alink</description></item>
        /// <item><description>Xflow</description></item>
        /// <item><description>TensorFlow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TensorFlow</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>Describes how to apply to downstream inference services. For example, describe the processor and container of EAS. Example: <c>{ &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot; }</c></para>
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
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The metrics for the model. The length after serialization is limited to 8,192.</para>
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
        /// <para>The extended field. This is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The ID of the model source.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to Custom, this parameter is not limited.</description></item>
        /// <item><description>If SourceType is set to PAIFlow or TrainingService, the ID of the model source is in the following format:</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>Take note of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>region indicates the region ID.</description></item>
        /// <item><description>workspaceId indicates the workspace ID.</description></item>
        /// <item><description>kind indicates the type. Valid values: PipelineRun (PAIFlow) and ServiceJob (training service).</description></item>
        /// <item><description>id indicates the unique identifier.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the model source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom (default)</description></item>
        /// <item><description>PAIFlow</description></item>
        /// <item><description>TrainingService: the Platform for AI (PAI) training service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The training configurations, which is used for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The URI of the model version, which is the location where the model is stored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The HTTP(S) address of the model. Example: <c>https://myweb.com/mymodel.tar.gz</c>.</description></item>
        /// <item><description>The OSS path of the model, in the format of <c>oss://&lt;bucket&gt;.&lt;endpoint&gt;/object</c>. For information about endpoints, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>. Example: <c>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</c>.</description></item>
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
        /// <para>The version description.</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The model version, which is unique for each model. If you leave this parameter empty, the first version is <b>0.1.0</b> by default. After that, the minor version number is increased by 1 in sequence. For example, the second version number is <b>0.2.0</b>. A version number consists of a major version number, a minor version number, and a stage version number, separated by periods (.). The major version number and minor version number are numeric. The stage version number begins with a digit and can include numbers, underscores, and letters. For example, the version number is 1.1.0 or 2.3.4_beta.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
