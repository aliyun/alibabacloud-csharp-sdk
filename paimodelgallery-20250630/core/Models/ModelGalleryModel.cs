// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class ModelGalleryModel : TeaModel {
        /// <summary>
        /// <para>The collection to which the model belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuickStart</para>
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>Indicates whether compression is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Compressible")]
        [Validation(Required=false)]
        public bool? Compressible { get; set; }

        /// <summary>
        /// <para>Indicates whether deep thinking is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeepThink")]
        [Validation(Required=false)]
        public bool? DeepThink { get; set; }

        /// <summary>
        /// <para>Indicates whether online experience is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Demonstrable")]
        [Validation(Required=false)]
        public bool? Demonstrable { get; set; }

        /// <summary>
        /// <para>Indicates whether deployment is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deployable")]
        [Validation(Required=false)]
        public bool? Deployable { get; set; }

        /// <summary>
        /// <para>Indicates whether distillation is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Distillable")]
        [Validation(Required=false)]
        public bool? Distillable { get; set; }

        /// <summary>
        /// <para>The domain. For example, aigc (generative AI), nlp (natural language processing), or cv (computer vision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aigc</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Indicates whether evaluation is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Evaluable")]
        [Validation(Required=false)]
        public bool? Evaluable { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether FunctionCall is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public bool? FunctionCall { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-03T07:21:28.000Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The update time of the latest model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-03T07:21:28.000Z</para>
        /// </summary>
        [NameInMap("GmtLatestVersionModified")]
        [Validation(Required=false)]
        public string GmtLatestVersionModified { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-03T07:21:28.000Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The latest model version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("LatestVersionName")]
        [Validation(Required=false)]
        public string LatestVersionName { get; set; }

        /// <summary>
        /// <para>The model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Large language model</para>
        /// </summary>
        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// <para>The model documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://</para>
        /// </summary>
        [NameInMap("ModelDoc")]
        [Validation(Required=false)]
        public string ModelDoc { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-8npjorqxl8gmdo72nj</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-235B-A22B-Thinking-2507</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model series.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen</para>
        /// </summary>
        [NameInMap("ModelSeries")]
        [Validation(Required=false)]
        public string ModelSeries { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LoRA</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The ordinal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <para>The model source, used to filter the list of models that belong to a specific community or organization. For example, ModelScope, PAI, or NIM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAI</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The number of parameters, in millions (M).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("ParameterSize")]
        [Validation(Required=false)]
        public long? ParameterSize { get; set; }

        /// <summary>
        /// <para>The search keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("SearchWords")]
        [Validation(Required=false)]
        public string SearchWords { get; set; }

        /// <summary>
        /// <para>The supported compression methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Methods&quot;: [{
        ///     &quot;Method&quot;: &quot;Quantization&quot;,
        ///     &quot;SubMethod&quot;: &quot;MinMax-8Bit&quot;,
        ///     &quot;Resource&quot;: &quot;GPU&quot;
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("SupportedCompressionMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedCompressionMethods { get; set; }

        /// <summary>
        /// <para>The resources supported for compression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU,GP7V</para>
        /// </summary>
        [NameInMap("SupportedCompressionResources")]
        [Validation(Required=false)]
        public string SupportedCompressionResources { get; set; }

        /// <summary>
        /// <para>The supported distillation methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Methods&quot;: [{
        ///     &quot;Method&quot;: &quot;EasyDistill&quot;,
        ///     &quot;SubMethod&quot;: &quot;DataSynthesis&quot;,
        ///     &quot;Resource&quot;: &quot;GPU&quot;
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("SupportedDistillationMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedDistillationMethods { get; set; }

        /// <summary>
        /// <para>The resources supported for distillation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU,GP7V</para>
        /// </summary>
        [NameInMap("SupportedDistillationResources")]
        [Validation(Required=false)]
        public string SupportedDistillationResources { get; set; }

        /// <summary>
        /// <para>The supported evaluation methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Methods&quot;: [{
        ///     &quot;Method&quot;: &quot;Single-Node-Standard&quot;,
        ///     &quot;Resource&quot;: &quot;GPU&quot;
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("SupportedEvaluationMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedEvaluationMethods { get; set; }

        /// <summary>
        /// <para>The resources supported for evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU,GP7V</para>
        /// </summary>
        [NameInMap("SupportedEvaluationResources")]
        [Validation(Required=false)]
        public string SupportedEvaluationResources { get; set; }

        /// <summary>
        /// <para>The supported deployment methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Methods&quot;: [{
        ///     &quot;framework&quot;: &quot;blade&quot;,
        ///     &quot;scenario&quot;: &quot;nvidia-standard&quot;,
        ///     &quot;Resource&quot;: &quot;GPU&quot;
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("SupportedInferenceMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedInferenceMethods { get; set; }

        /// <summary>
        /// <para>The resources supported for deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU,GP7V</para>
        /// </summary>
        [NameInMap("SupportedInferenceResources")]
        [Validation(Required=false)]
        public string SupportedInferenceResources { get; set; }

        /// <summary>
        /// <para>The supported training methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Methods&quot;: [{
        ///     &quot;Method&quot;: &quot;SFT&quot;,
        ///     &quot;SubMethod&quot;: &quot;LoRA_LLM&quot;,
        ///     &quot;Resource&quot;: &quot;GPU&quot;
        ///   }]
        /// }</para>
        /// </summary>
        [NameInMap("SupportedTrainingMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedTrainingMethods { get; set; }

        /// <summary>
        /// <para>The resources supported for training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU,GP7V</para>
        /// </summary>
        [NameInMap("SupportedTrainingResources")]
        [Validation(Required=false)]
        public string SupportedTrainingResources { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ModelGalleryModelTags Tags { get; set; }
        public class ModelGalleryModelTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The task. For example, large-language-model (large language model), image-classification (image classification), or embedding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>large-language-model</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <para>Indicates whether training is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Trainable")]
        [Validation(Required=false)]
        public bool? Trainable { get; set; }

    }

}
