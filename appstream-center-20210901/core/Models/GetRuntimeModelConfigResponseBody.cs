// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeModelConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuntimeModelConfigResponseBodyData Data { get; set; }
        public class GetRuntimeModelConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default model (format: providerName/llmCode).</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian/qwen3.6-plus</para>
            /// </summary>
            [NameInMap("DefaultModel")]
            [Validation(Required=false)]
            public string DefaultModel { get; set; }

            /// <summary>
            /// <para>The list of model providers.</para>
            /// </summary>
            [NameInMap("ModelProviderList")]
            [Validation(Required=false)]
            public List<GetRuntimeModelConfigResponseBodyDataModelProviderList> ModelProviderList { get; set; }
            public class GetRuntimeModelConfigResponseBodyDataModelProviderList : TeaModel {
                /// <summary>
                /// <para>The list of model information.</para>
                /// </summary>
                [NameInMap("LlmInfoList")]
                [Validation(Required=false)]
                public List<GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoList> LlmInfoList { get; set; }
                public class GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoList : TeaModel {
                    /// <summary>
                    /// <para>The model description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Qwen3.6原生视觉语言系列Plus模型，展现出与当前顶尖前沿模型相媲美的卓越性能，模型效果相较3.5系列显著提升。模型在Agentic coding、前端编程、Vibe coding等代码能力、多模态万物识别、OCR、物体定位等能力上显著增强。</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The list of model features, such as function-calling, web-search, and structured-outputs.</para>
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<string> Features { get; set; }

                    /// <summary>
                    /// <para>The inference metadata, including request and response modalities.</para>
                    /// </summary>
                    [NameInMap("InferenceMetadata")]
                    [Validation(Required=false)]
                    public GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListInferenceMetadata InferenceMetadata { get; set; }
                    public class GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListInferenceMetadata : TeaModel {
                        /// <summary>
                        /// <para>The list of request modalities, such as Text, Image, and Audio.</para>
                        /// </summary>
                        [NameInMap("RequestModality")]
                        [Validation(Required=false)]
                        public List<string> RequestModality { get; set; }

                        /// <summary>
                        /// <para>The list of response modalities, such as Text, Image, and Audio.</para>
                        /// </summary>
                        [NameInMap("ResponseModality")]
                        [Validation(Required=false)]
                        public List<string> ResponseModality { get; set; }

                    }

                    /// <summary>
                    /// <para>The model code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen3.6-plus</para>
                    /// </summary>
                    [NameInMap("LlmCode")]
                    [Validation(Required=false)]
                    public string LlmCode { get; set; }

                    /// <summary>
                    /// <para>The model name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Qwen3.6-Plus</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The publish time in ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-04T06:25:17.000+00:00</para>
                    /// </summary>
                    [NameInMap("PublishedTime")]
                    [Validation(Required=false)]
                    public string PublishedTime { get; set; }

                    /// <summary>
                    /// <para>The model risk type. This parameter is returned only when the request parameter IncludeRiskInfo is set to true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                }

                /// <summary>
                /// <para>The model provider template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mpt-xxxx</para>
                /// </summary>
                [NameInMap("ModelProviderTemplateId")]
                [Validation(Required=false)]
                public string ModelProviderTemplateId { get; set; }

                /// <summary>
                /// <para>The model provider template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>百炼</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The model provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("ProviderName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <para>The configured model group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <para>The model group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-template-001</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            /// <summary>
            /// <para>The model template association type (returned only when an association exists).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runtime</para>
            /// </summary>
            [NameInMap("ModelTemplateRefType")]
            [Validation(Required=false)]
            public string ModelTemplateRefType { get; set; }

            /// <summary>
            /// <para>The resource group ID to which the runtime belongs. The value is null if the runtime is not associated with a resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
