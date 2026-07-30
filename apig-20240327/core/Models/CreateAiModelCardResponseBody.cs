// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelCardResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The model card information returned after successful creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;modelCardId&quot;:&quot;mc-8c13d2b4f8a1&quot;,&quot;gatewayId&quot;:&quot;gw-8c13d2b4f8a1&quot;,&quot;modelProvider&quot;:&quot;qwen&quot;,&quot;modelName&quot;:&quot;qwen-plus&quot;,&quot;source&quot;:&quot;user&quot;,&quot;credit&quot;:{&quot;type&quot;:&quot;fixed&quot;,&quot;inputCost&quot;:1.5,&quot;outputCost&quot;:3,&quot;cacheCost&quot;:0.5},&quot;features&quot;:{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true},&quot;meta&quot;:{&quot;maxInputTokens&quot;:131072,&quot;maxOutputTokens&quot;:8192,&quot;maxTokens&quot;:131072,&quot;supportedInputModalities&quot;:[&quot;text&quot;,&quot;image&quot;],&quot;supportedOutputModalities&quot;:[&quot;text&quot;]},&quot;availablePaths&quot;:[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}],&quot;updateTime&quot;:&quot;2026-07-14 18:30:00&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAiModelCardResponseBodyData Data { get; set; }
        public class CreateAiModelCardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of invocation paths supported by the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}]</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<CreateAiModelCardResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class CreateAiModelCardResponseBodyDataAvailablePaths : TeaModel {
                /// <summary>
                /// <para>The model invocation path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The protocol type corresponding to the path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAICompatible</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The credit billing information of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;fixed&quot;,&quot;inputCost&quot;:1.5,&quot;outputCost&quot;:3,&quot;cacheCost&quot;:0.5}</para>
            /// </summary>
            [NameInMap("credit")]
            [Validation(Required=false)]
            public CreateAiModelCardResponseBodyDataCredit Credit { get; set; }
            public class CreateAiModelCardResponseBodyDataCredit : TeaModel {
                /// <summary>
                /// <para>The cache hit token cost, in Credits per million tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("cacheCost")]
                [Validation(Required=false)]
                public float? CacheCost { get; set; }

                /// <summary>
                /// <para>The input token cost, in Credits per million tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.5</para>
                /// </summary>
                [NameInMap("inputCost")]
                [Validation(Required=false)]
                public float? InputCost { get; set; }

                /// <summary>
                /// <para>The output token cost, in Credits per million tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("outputCost")]
                [Validation(Required=false)]
                public float? OutputCost { get; set; }

                /// <summary>
                /// <para>The billing type. Currently, fixed is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The model capability switches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true}</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public Dictionary<string, object> Features { get; set; }

            /// <summary>
            /// <para>The AI gateway instance ID to which the model card belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-8c13d2b4f8a1</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The token limits and input/output modality information of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;maxInputTokens&quot;:131072,&quot;maxOutputTokens&quot;:8192,&quot;maxTokens&quot;:131072,&quot;supportedInputModalities&quot;:[&quot;text&quot;,&quot;image&quot;],&quot;supportedOutputModalities&quot;:[&quot;text&quot;]}</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public CreateAiModelCardResponseBodyDataMeta Meta { get; set; }
            public class CreateAiModelCardResponseBodyDataMeta : TeaModel {
                /// <summary>
                /// <para>The maximum number of input tokens supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131072</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <para>The maximum number of output tokens supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <para>The maximum total number of context tokens supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131072</para>
                /// </summary>
                [NameInMap("maxTokens")]
                [Validation(Required=false)]
                public long? MaxTokens { get; set; }

                /// <summary>
                /// <para>The list of input modalities supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;,&quot;image&quot;]</para>
                /// </summary>
                [NameInMap("supportedInputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedInputModalities { get; set; }

                /// <summary>
                /// <para>The list of output modalities supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;]</para>
                /// </summary>
                [NameInMap("supportedOutputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedOutputModalities { get; set; }

            }

            /// <summary>
            /// <para>The model card ID.</para>
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
            /// <para>The source of the model card. Currently, user is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
