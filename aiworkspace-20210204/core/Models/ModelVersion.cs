// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ModelVersion : TeaModel {
        /// <summary>
        /// <para>The approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: pending.</description></item>
        /// <item><description>Approved: approved for going live.</description></item>
        /// <item><description>Rejected: not approved for going live.</description></item>
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
        /// <para>The model format.</para>
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
        /// <para>The model framework.</para>
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
        /// <para>The UTC time of model creation, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the model was last updated, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Describes how to apply the model to downstream inference applications, such as specifying the EAS processor or container. Example:
        /// <c>{     &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot; }</c></para>
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
        /// <para>The label list.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ModelVersionLabels> Labels { get; set; }
        public class ModelVersionLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The model metrics.</para>
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
        /// <para>The extended fields. JsonString type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>155770209******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the source type is Custom, this field has no restrictions.</para>
        /// </description></item>
        /// <item><description><para>If the source type is PAIFlow or TrainingService, the format is:</para>
        /// </description></item>
        /// </list>
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>region is the Alibaba Cloud region ID. workspaceId is the workspace ID. kind specifies the type. Valid values: PipelineRun (PAI workflow) and ServiceJob (training service). id is the unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The model source type. Default value: Custom.</para>
        /// <list type="bullet">
        /// <item><description>Custom: custom.</description></item>
        /// <item><description>PAIFlow: PAI workflow.</description></item>
        /// <item><description>TrainingService: PAI training service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The training configuration. Used for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The model version URI, which specifies the model storage location. This can be an HTTP(S) address of the model, such as <c>https://myweb.com/mymodel.tar.gz</c>. If the model is stored in OSS, the format is <c>oss://&lt;bucket&gt;.&lt;endpoint&gt;/object</c>. You can query the endpoint in the OSS console. Example: <c>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>155770209******</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The model version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment analysis</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The model version, unique within the model. If not specified, the first version defaults to <c>0.1.0</c>, and subsequent versions increment the minor version number by 1. For example, the second version defaults to <c>0.2.0</c>.</para>
        /// <para>The version number consists of a major version number, a minor version number, and a stage version number, separated by <c>.</c>. The major and minor version numbers are numeric. The stage version number starts with a digit, followed by <c>_</c> and letters. Examples: 1.1.0 or 2.3.4_beta.</para>
        /// <para>Regular expression reference: <c>&quot;^\\d+\\.\\d+\\.\\d+(_\\w+)?$&quot;</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
