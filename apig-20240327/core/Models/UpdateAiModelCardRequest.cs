// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelCardRequest : TeaModel {
        /// <summary>
        /// <para>The list of invocation paths supported by the model. Each item must contain both path and type. During an update, the entire list is overwritten.</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<UpdateAiModelCardRequestAvailablePaths> AvailablePaths { get; set; }
        public class UpdateAiModelCardRequestAvailablePaths : TeaModel {
            /// <summary>
            /// <para>The model invocation path, which is up to 2,048 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The protocol type corresponding to the path, which is up to 64 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAICompatible</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The credit billing information of the model. Currently, only the fixed type is supported, and the fee unit is Credits per million tokens. If not specified, all fees default to 0.</para>
        /// </summary>
        [NameInMap("credit")]
        [Validation(Required=false)]
        public UpdateAiModelCardRequestCredit Credit { get; set; }
        public class UpdateAiModelCardRequestCredit : TeaModel {
            /// <summary>
            /// <para>The cache hit token fee, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("cacheCost")]
            [Validation(Required=false)]
            public float? CacheCost { get; set; }

            /// <summary>
            /// <para>The input token fee, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("inputCost")]
            [Validation(Required=false)]
            public float? InputCost { get; set; }

            /// <summary>
            /// <para>The output token fee, in Credits per million tokens. The value must be greater than or equal to 0. If not specified, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("outputCost")]
            [Validation(Required=false)]
            public float? OutputCost { get; set; }

            /// <summary>
            /// <para>The billing type. Currently, only fixed is supported. If not specified, the default value is fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The model capability switches. The keys must be model capability names supported by the API gateway, and the values are Boolean values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true,&quot;promptCaching&quot;:false}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>The token limits and input and output modality information of the model.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public UpdateAiModelCardRequestMeta Meta { get; set; }
        public class UpdateAiModelCardRequestMeta : TeaModel {
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
            /// <para>The list of input modalities supported by the model. It can contain up to 16 items, and each item cannot be empty.</para>
            /// </summary>
            [NameInMap("supportedInputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedInputModalities { get; set; }

            /// <summary>
            /// <para>The list of output modalities supported by the model. It can contain up to 16 items, and each item cannot be empty.</para>
            /// </summary>
            [NameInMap("supportedOutputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedOutputModalities { get; set; }

        }

        /// <summary>
        /// <para>The model name. It must be unique within the same AI gateway instance and model provider, and be up to 256 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model provider identifier. It must reference an existing model provider in the target AI gateway instance and be up to 128 characters in length.</para>
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
