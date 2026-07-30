// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelCardRequest : TeaModel {
        /// <summary>
        /// <para>The list of API paths supported by the model. Each item must include both path and type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;path&quot;:&quot;/v1/chat/completions&quot;,&quot;type&quot;:&quot;OpenAICompatible&quot;}]</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<CreateAiModelCardRequestAvailablePaths> AvailablePaths { get; set; }
        public class CreateAiModelCardRequestAvailablePaths : TeaModel {
            /// <summary>
            /// <para>The model invocation path. The value can be up to 2048 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The protocol type corresponding to the path. The value can be up to 64 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAICompatible</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The credit billing information of the model. Currently, only the fixed type is supported. The cost unit is Credits per million tokens. If not specified, all cost values default to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;fixed&quot;,&quot;inputCost&quot;:1.5,&quot;outputCost&quot;:3,&quot;cacheCost&quot;:0.5}</para>
        /// </summary>
        [NameInMap("credit")]
        [Validation(Required=false)]
        public CreateAiModelCardRequestCredit Credit { get; set; }
        public class CreateAiModelCardRequestCredit : TeaModel {
            /// <summary>
            /// <para>The cache hit token cost, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the value defaults to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("cacheCost")]
            [Validation(Required=false)]
            public float? CacheCost { get; set; }

            /// <summary>
            /// <para>The input token cost, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the value defaults to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("inputCost")]
            [Validation(Required=false)]
            public float? InputCost { get; set; }

            /// <summary>
            /// <para>The output token cost, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the value defaults to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("outputCost")]
            [Validation(Required=false)]
            public float? OutputCost { get; set; }

            /// <summary>
            /// <para>The billing type. Currently, only fixed is supported. If not specified, the value defaults to fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The model capability switches. Keys must be model capability names supported by API Gateway, and values must be Boolean.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true,&quot;promptCaching&quot;:false}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>The AI gateway instance ID. The target instance must exist, belong to the current account, and be of the AI gateway type.</para>
        /// <para>This parameter is required.</para>
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
        public CreateAiModelCardRequestMeta Meta { get; set; }
        public class CreateAiModelCardRequestMeta : TeaModel {
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
            /// <para>The list of input modalities supported by the model. The list can contain up to 16 items, and each item must not be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;text&quot;,&quot;image&quot;]</para>
            /// </summary>
            [NameInMap("supportedInputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedInputModalities { get; set; }

            /// <summary>
            /// <para>The list of output modalities supported by the model. The list can contain up to 16 items, and each item must not be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;text&quot;]</para>
            /// </summary>
            [NameInMap("supportedOutputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedOutputModalities { get; set; }

        }

        /// <summary>
        /// <para>The model name. The model name must be unique within the same AI gateway instance and the same model provider. The value can be up to 256 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model provider identifier. The value must reference an existing model provider in the target AI gateway instance. The value can be up to 128 characters in length.</para>
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
