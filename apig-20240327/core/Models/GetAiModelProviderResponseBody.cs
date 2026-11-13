// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetAiModelProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned if the request succeeds.</para>
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
            /// <para>The list of AI service summaries currently bound to the model provider.</para>
            /// </summary>
            [NameInMap("boundServices")]
            [Validation(Required=false)]
            public List<ServiceInfo> BoundServices { get; set; }

            /// <summary>
            /// <para>The default AI service ID. This field is empty if it is not set. The persisted value is returned as is in read operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("defaultServiceId")]
            [Validation(Required=false)]
            public string DefaultServiceId { get; set; }

            /// <summary>
            /// <para>The display name of the model provider. The length cannot exceed 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen Cloud / Alibaba Cloud Model Studio</para>
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
            /// <para>The list of model cards currently associated with the model provider.</para>
            /// </summary>
            [NameInMap("modelCards")]
            [Validation(Required=false)]
            public List<GetAiModelProviderResponseBodyDataModelCards> ModelCards { get; set; }
            public class GetAiModelProviderResponseBodyDataModelCards : TeaModel {
                /// <summary>
                /// <para>The list of invocation paths supported by the model. Each item contains a path and a type.</para>
                /// </summary>
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<GetAiModelProviderResponseBodyDataModelCardsAvailablePaths> AvailablePaths { get; set; }
                public class GetAiModelProviderResponseBodyDataModelCardsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <para>The model invocation path. The length cannot exceed 2,048 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The protocol type corresponding to the path. The length cannot exceed 64 characters.</para>
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
                    /// <para>The cache hit token cost. The unit is Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <para>The input token cost. The unit is Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <para>The output token cost. The unit is Credits per million tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <para>The billing type. Currently, only fixed is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fixed</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The model capability toggles. The key is the name of a model capability supported by the API gateway, and the value is a Boolean value.</para>
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
                /// <para>The token limits and input and output modality information of the model.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public GetAiModelProviderResponseBodyDataModelCardsMeta Meta { get; set; }
                public class GetAiModelProviderResponseBodyDataModelCardsMeta : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of input tokens supported by the model. The value must be greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131072</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum number of output tokens supported by the model. The value must be greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8192</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum total number of context tokens supported by the model. The value must be greater than or equal to 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131072</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>The list of input modalities supported by the model. The list can contain up to 16 items, and each item cannot be empty.</para>
                    /// </summary>
                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    /// <summary>
                    /// <para>The list of output modalities supported by the model. The list can contain up to 16 items, and each item cannot be empty.</para>
                    /// </summary>
                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <para>The model card ID. This ID is generated by the system and starts with mc-.</para>
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
                /// <para>The identifier of the model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <para>The source of the model card. The value user is returned for instance-level model cards.</para>
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
                /// <para>The last update time of the model card. The format is yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-14 18:30:00</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The number of model cards currently associated with the model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("modelCount")]
            [Validation(Required=false)]
            public int? ModelCount { get; set; }

            /// <summary>
            /// <para>The model provider ID. This ID is generated by the system and starts with mp-.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            /// <summary>
            /// <para>The stable identifier of the model provider. The length cannot exceed 128 characters.</para>
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
            /// <para>The last update time of the model provider. The format is yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-14 18:30:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The response message. success is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
