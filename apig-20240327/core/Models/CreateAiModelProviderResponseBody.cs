// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelProviderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAiModelProviderResponseBodyData Data { get; set; }
        public class CreateAiModelProviderResponseBodyData : TeaModel {
            [NameInMap("boundServices")]
            [Validation(Required=false)]
            public List<ServiceInfo> BoundServices { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OpenAI</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-ucbx3s2m****</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("modelCards")]
            [Validation(Required=false)]
            public List<CreateAiModelProviderResponseBodyDataModelCards> ModelCards { get; set; }
            public class CreateAiModelProviderResponseBodyDataModelCards : TeaModel {
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<CreateAiModelProviderResponseBodyDataModelCardsAvailablePaths> AvailablePaths { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chat</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("credit")]
                [Validation(Required=false)]
                public CreateAiModelProviderResponseBodyDataModelCardsCredit Credit { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsCredit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.015</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.03</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.06</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>token</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;stream&quot;:true,&quot;tools&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-ucbx3s2m****</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public CreateAiModelProviderResponseBodyDataModelCardsMeta Meta { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsMeta : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>128000</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4096</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>132096</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mc-xxx****</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gpt-4</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>openai</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-03T10:48:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("modelCount")]
            [Validation(Required=false)]
            public int? ModelCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mp-xxx****</para>
            /// </summary>
            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>openai</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-03T10:48:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>464F9EA0-1052-51BD-8187-D292AA2D8D24</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
