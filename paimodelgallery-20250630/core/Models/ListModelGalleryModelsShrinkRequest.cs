// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class ListModelGalleryModelsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The collection to which the model belongs. The collection for ModelGallery models is QuickStart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuickStart</para>
        /// </summary>
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public string Collections { get; set; }

        /// <summary>
        /// <para>Specifies whether model compression is supported.</para>
        /// </summary>
        [NameInMap("Compressible")]
        [Validation(Required=false)]
        public bool? Compressible { get; set; }

        /// <summary>
        /// <para>The list of conditions.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string ConditionsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether deep thinking is supported.</para>
        /// </summary>
        [NameInMap("DeepThink")]
        [Validation(Required=false)]
        public bool? DeepThink { get; set; }

        /// <summary>
        /// <para>Specifies whether online experience is supported.</para>
        /// </summary>
        [NameInMap("Demonstrable")]
        [Validation(Required=false)]
        public bool? Demonstrable { get; set; }

        /// <summary>
        /// <para>Specifies whether deployment is supported.</para>
        /// </summary>
        [NameInMap("Deployable")]
        [Validation(Required=false)]
        public bool? Deployable { get; set; }

        /// <summary>
        /// <para>Specifies whether distillation is supported.</para>
        /// </summary>
        [NameInMap("Distillable")]
        [Validation(Required=false)]
        public bool? Distillable { get; set; }

        /// <summary>
        /// <para>The domain used to filter the model list. For example, aigc (generative AI), nlp (natural language processing), or cv (computer vision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aigc</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether evaluation is supported.</para>
        /// </summary>
        [NameInMap("Evaluable")]
        [Validation(Required=false)]
        public bool? Evaluable { get; set; }

        /// <summary>
        /// <para>Specifies whether FunctionCall is supported.</para>
        /// </summary>
        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public bool? FunctionCall { get; set; }

        /// <summary>
        /// <para>The model name. By default, fuzzy match is used to filter the model list. Enclose the name in double quotation marks for exact match. For example, &quot;DeepSeek-V3.2&quot; exactly matches the model DeepSeek-V3.2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-235B-A22B-Thinking-2507</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model series. For example, PAI Optimized Model, Qwen, Wan-AI, GLM, Baichuan, DeepSeek, Kimi, MiniMax, Yi, InternLM, InternVL, OpenAI, NVIDIA, Gemma, Phi, dots_vlm, Llama, Mistral, Stable Diffusion, FLUX, Byte Dance, StepFun AI, ERNIE Bot, Tencent Hunyuan, or YOLO.</para>
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
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The sort order for the specified sort field in a paged query. Default value: ASC.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The model source used to filter models that belong to a specific community or organization. For example, ModelScope, PAI, or NIM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number of the model list. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of models to display on each page in a paged query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query condition. Fuzzy match is performed across multiple fields such as ModelName, Domain, and Task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The sort field for a paged query. Currently, the GmtCreateTime field is used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtCreateTime: the model creation time.</para>
        /// </description></item>
        /// <item><description><para>GmtLatestVersionModified: the time when the latest model version was updated.</para>
        /// </description></item>
        /// <item><description><para>OrderNumber: the ordinal number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The supported compression resources, such as CPU, GPU, or GP7V. For example, if you specify GP7V, only models that support compression on GP7V resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedCompressionResource")]
        [Validation(Required=false)]
        public string SupportedCompressionResource { get; set; }

        /// <summary>
        /// <para>The supported distillation resources, such as CPU, GPU, or GP7V. For example, if you specify GP7V, only models that support distillation on GP7V resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedDistillationResource")]
        [Validation(Required=false)]
        public string SupportedDistillationResource { get; set; }

        /// <summary>
        /// <para>The supported evaluation resources, such as CPU, GPU, or GP7V. For example, if you specify GP7V, only models that support evaluation on GP7V resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedEvaluationResource")]
        [Validation(Required=false)]
        public string SupportedEvaluationResource { get; set; }

        /// <summary>
        /// <para>The supported deployment resources, such as CPU, GPU, or GP7V. For example, if you specify GP7V, only models that support deployment on GP7V resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedInferenceResource")]
        [Validation(Required=false)]
        public string SupportedInferenceResource { get; set; }

        /// <summary>
        /// <para>The supported training resources, such as CPU, GPU, or GP7V. For example, if you specify GP7V, only models that support training on GP7V resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedTrainingResource")]
        [Validation(Required=false)]
        public string SupportedTrainingResource { get; set; }

        /// <summary>
        /// <para>The list of labels.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

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
        /// <para>Specifies whether training is supported.</para>
        /// </summary>
        [NameInMap("Trainable")]
        [Validation(Required=false)]
        public bool? Trainable { get; set; }

    }

}
