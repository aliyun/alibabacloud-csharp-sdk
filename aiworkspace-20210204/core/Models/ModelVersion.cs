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
        /// <para>The time when the model was created, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the model was last modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The inference configurations applied to the downstream, such as the configuration of the processor or container of Elastic Algorithm Service (EAS). Example: <c>{ &quot;processor&quot;: &quot;tensorflow_gpu_1.12&quot; }</c></para>
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
        public List<ModelVersionLabels> Labels { get; set; }
        public class ModelVersionLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

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
        /// <para>The extended field. The value is a JSON string.</para>
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
        /// <para>155770209******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description>If the source type is Custom, this field is not limited.</description></item>
        /// <item><description>If the source type is PAIFlow or TrainingService, the format is:</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>region is the ID of the Alibaba Cloud region. workspacceId is the ID of the workspace. kind is the type. Valid values: PipelineRun (PAIFlow pipeline) and ServiceJob (training service). id is the unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the model. Default value: Custom.</para>
        /// <list type="bullet">
        /// <item><description>Custom</description></item>
        /// <item><description>PAIFlow</description></item>
        /// <item><description>TrainingService</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The training configuration, used for fine-tuning and incremental training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TrainingSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingSpec { get; set; }

        /// <summary>
        /// <para>The URI of the model version, which is the location where the model is stored. The value can be the HTTP(S) address of the model, such as <c>https://myweb.com/mymodel.tar.gz</c>. If the model is stored in an Object Storage Service (OSS) bucket, the value is in the <c>oss://&lt;bucket&gt;.&lt;endpoint&gt;/object</c> format. The endpoint can be queried in the OSS console, such as <c>oss://mybucket.oss-cn-beijing.aliyuncs.com/mypath/</c>.</para>
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
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The model version, which is unique for the model. If you leave this parameter empty, <c>0.1.0</c> is the first version by default. Then, the minor version number incremented by 1 is used as the second version <c>0.2.0</c>.</para>
        /// <para>The version consists of a major version number, a minor version number, and a patch version number. The version numbers are separated with periods (<c>.</c>). The major and minor version numbers are digits, and the patch version number starts with a digit followed by an underscore (<c>_</c>) and a letter. such as 1.1.0 or 2.3.4_beta.</para>
        /// <para>Regular expression: <c>&quot;^\\\\d+\\\\.\\\\d+\\\\.\\\\d+(_\\\\w+)?$&quot;</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
