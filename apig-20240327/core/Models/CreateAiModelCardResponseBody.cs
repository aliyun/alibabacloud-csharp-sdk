// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelCardResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;modelCardId&quot;:&quot;mc-8c13d2b4f8a1&quot;,&quot;gatewayId&quot;:&quot;gw-8c13d2b4f8a1&quot;,&quot;modelProvider&quot;:&quot;qwen&quot;,&quot;modelName&quot;:&quot;qwen-plus&quot;,&quot;source&quot;:&quot;user&quot;,&quot;credit&quot;:{&quot;type&quot;:&quot;fixed&quot;,&quot;inputCost&quot;:1.5,&quot;outputCost&quot;:3,&quot;cacheCost&quot;:0.5},&quot;features&quot;:{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true},&quot;meta&quot;:{&quot;maxInputTokens&quot;:131072,&quot;maxOutputTokens&quot;:8192,&quot;maxTokens&quot;:131072,&quot;supportedInputModalities&quot;:[&quot;text&quot;,&quot;image&quot;],&quot;supportedOutputModalities&quot;:[&quot;text&quot;]},&quot;availablePaths&quot;:[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}],&quot;updateTime&quot;:&quot;2026-07-14 18:30:00&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAiModelCardResponseBodyData Data { get; set; }
        public class CreateAiModelCardResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}]</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<CreateAiModelCardResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class CreateAiModelCardResponseBodyDataAvailablePaths : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OpenAICompatible</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;fixed&quot;,&quot;inputCost&quot;:1.5,&quot;outputCost&quot;:3,&quot;cacheCost&quot;:0.5}</para>
            /// </summary>
            [NameInMap("credit")]
            [Validation(Required=false)]
            public CreateAiModelCardResponseBodyDataCredit Credit { get; set; }
            public class CreateAiModelCardResponseBodyDataCredit : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("cacheCost")]
                [Validation(Required=false)]
                public float? CacheCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.5</para>
                /// </summary>
                [NameInMap("inputCost")]
                [Validation(Required=false)]
                public float? InputCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("outputCost")]
                [Validation(Required=false)]
                public float? OutputCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true}</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public Dictionary<string, object> Features { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;maxInputTokens&quot;:131072,&quot;maxOutputTokens&quot;:8192,&quot;maxTokens&quot;:131072,&quot;supportedInputModalities&quot;:[&quot;text&quot;,&quot;image&quot;],&quot;supportedOutputModalities&quot;:[&quot;text&quot;]}</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public CreateAiModelCardResponseBodyDataMeta Meta { get; set; }
            public class CreateAiModelCardResponseBodyDataMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>131072</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>131072</para>
                /// </summary>
                [NameInMap("maxTokens")]
                [Validation(Required=false)]
                public long? MaxTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;,&quot;image&quot;]</para>
                /// </summary>
                [NameInMap("supportedInputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedInputModalities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;]</para>
                /// </summary>
                [NameInMap("supportedOutputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedOutputModalities { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mc-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("modelCardId")]
            [Validation(Required=false)]
            public string ModelCardId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("modelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-07-14 18:30:00</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
