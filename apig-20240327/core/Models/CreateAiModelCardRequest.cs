// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelCardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}]</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<CreateAiModelCardRequestAvailablePaths> AvailablePaths { get; set; }
        public class CreateAiModelCardRequestAvailablePaths : TeaModel {
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
        public CreateAiModelCardRequestCredit Credit { get; set; }
        public class CreateAiModelCardRequestCredit : TeaModel {
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
        /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true,&quot;promptCaching&quot;:false}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        public CreateAiModelCardRequestMeta Meta { get; set; }
        public class CreateAiModelCardRequestMeta : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("modelProvider")]
        [Validation(Required=false)]
        public string ModelProvider { get; set; }

    }

}
