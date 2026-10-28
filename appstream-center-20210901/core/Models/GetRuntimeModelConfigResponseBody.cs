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
            /// <para>The default model, in the format of providerName/llmCode.</para>
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
                    /// <para>The credit consumption multiplier. If this parameter is empty, it indicates that the model does not participate in credit billing.</para>
                    /// </summary>
                    [NameInMap("CreditMultiplier")]
                    [Validation(Required=false)]
                    public GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListCreditMultiplier CreditMultiplier { get; set; }
                    public class GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListCreditMultiplier : TeaModel {
                        /// <summary>
                        /// <para>The upper limit of the multiplier. If this parameter is empty, it indicates that there is no upper limit. For example, if Min is 1 and Max is empty, it is displayed as 1x and above.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public float? Max { get; set; }

                        /// <summary>
                        /// <para>The lower limit of the multiplier. When it is equal to Max, it is a fixed multiplier. For example, if Min and Max are both 2, it is displayed as 2x.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public float? Min { get; set; }

                    }

                    /// <summary>
                    /// <para>The model description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The Qwen3.6 native vision-language Plus model series demonstrates exceptional performance comparable to current top-tier frontier models, with significantly improved model effects compared to the 3.5 series. The model shows significant enhancements in coding capabilities such as agentic coding, front-end programming, and vibe coding, as well as in multimodal universal recognition, OCR, and object localization</para>
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
                    /// <para>The published time in ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-04T06:25:17.000+00:00</para>
                    /// </summary>
                    [NameInMap("PublishedTime")]
                    [Validation(Required=false)]
                    public string PublishedTime { get; set; }

                    /// <summary>
                    /// <para>The model risk type. This parameter is returned only when the IncludeRiskInfo request parameter is set to true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the model provider template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mpt-xxxx</para>
                /// </summary>
                [NameInMap("ModelProviderTemplateId")]
                [Validation(Required=false)]
                public string ModelProviderTemplateId { get; set; }

                /// <summary>
                /// <para>The name of the model provider template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Model Studio</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("ProviderName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the configured model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-template-001</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            /// <summary>
            /// <para>The model template association type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runtime</para>
            /// </summary>
            [NameInMap("ModelTemplateRefType")]
            [Validation(Required=false)]
            public string ModelTemplateRefType { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the runtime belongs. If the runtime does not belong to any resource group, the value is null.</para>
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
