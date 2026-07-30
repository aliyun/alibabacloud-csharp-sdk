// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetAiModelProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAiModelProviderResponseBodyData Data { get; set; }
        public class GetAiModelProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of AI service summaries currently bound to this model provider.</para>
            /// </summary>
            [NameInMap("boundServices")]
            [Validation(Required=false)]
            public List<ServiceInfo> BoundServices { get; set; }

            /// <summary>
            /// <para>The display name of the model provider. The maximum length is 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen Cloud / Alibaba Cloud Bailian.</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the AI gateway instance to which the model provider belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The list of model cards currently associated with this model provider.</para>
            /// </summary>
            [NameInMap("modelCards")]
            [Validation(Required=false)]
            public List<GetAiModelProviderResponseBodyDataModelCards> ModelCards { get; set; }
            public class GetAiModelProviderResponseBodyDataModelCards : TeaModel {
                /// <summary>
                /// <para>The list of invocation paths supported by the model. Each item contains both path and type.</para>
                /// </summary>
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<GetAiModelProviderResponseBodyDataModelCardsAvailablePaths> AvailablePaths { get; set; }
                public class GetAiModelProviderResponseBodyDataModelCardsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <para>The model invocation path. The maximum length is 2048 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The protocol type corresponding to the path. The maximum length is 64 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OpenAICompatible</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The credit billing information of the model. The unit is Credits per million tokens.</para>
                /// </summary>
                [NameInMap("credit")]
                [Validation(Required=false)]
                public GetAiModelProviderResponseBodyDataModelCardsCredit Credit { get; set; }
                public class GetAiModelProviderResponseBodyDataModelCardsCredit : TeaModel {
                    /// <summary>
                    /// <para>The cost of cache-hit tokens, in Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <para>The cost of input tokens, in Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <para>The cost of output tokens, in Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <para>The billing type. Only fixed is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fixed</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The model capability switches. Keys are model capability names supported by the API gateway, and values are Boolean.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <para>The ID of the AI gateway instance to which the model card belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-8c13d2b4f8a1</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The token limits and input/output modality information of the model.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public GetAiModelProviderResponseBodyDataModelCardsMeta Meta { get; set; }
                public class GetAiModelProviderResponseBodyDataModelCardsMeta : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of input tokens supported by the model. The value is greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131072</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum number of output tokens supported by the model. The value is greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8192</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum total number of context tokens supported by the model. The value is greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131072</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>The list of input modalities supported by the model. The list contains a maximum of 16 items, and each item cannot be empty.</para>
                    /// </summary>
                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    /// <summary>
                    /// <para>The list of output modalities supported by the model. The list contains a maximum of 16 items, and each item cannot be empty.</para>
                    /// </summary>
                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <para>The model card ID. Generated by the system and starts with mc-.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mc-8c13d2b4f8a1</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model provider identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <para>The source of the model card. Instance-level model cards return user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The URL of the model metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://https://dashscope-intl.aliyuncs.com">http://https://dashscope-intl.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("sourceURL")]
                [Validation(Required=false)]
                public string SourceURL { get; set; }

                /// <summary>
                /// <para>The last update time of the model card, in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-14 18:30:00</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The number of model cards currently associated with this model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("modelCount")]
            [Validation(Required=false)]
            public int? ModelCount { get; set; }

            /// <summary>
            /// <para>The model provider ID. Generated by the system and starts with mp-.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            /// <summary>
            /// <para>The stable model provider identifier. The maximum length is 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The source of the model provider. Valid values: user and builtin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The last update time of the model provider, in the format of yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-14 18:30:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The response message. success is returned for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is generated by the system for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
