// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelCardRequest : TeaModel {
        /// <summary>
        /// <para>The list of invocation paths supported by the model. Each item must include both path and type. The list is overwritten as a whole during updates.</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<UpdateAiModelCardRequestAvailablePaths> AvailablePaths { get; set; }
        public class UpdateAiModelCardRequestAvailablePaths : TeaModel {
            /// <summary>
            /// <para>The model invocation path. Maximum length: 2048 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The protocol type of the path. Maximum length: 64 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAICompatible</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The credit billing information of the model. Only the fixed type is supported. The unit is Credits per million tokens. If not specified, all cost values default to 0.</para>
        /// </summary>
        [NameInMap("credit")]
        [Validation(Required=false)]
        public UpdateAiModelCardRequestCredit Credit { get; set; }
        public class UpdateAiModelCardRequestCredit : TeaModel {
            /// <summary>
            /// <para>The cache hit token cost in Credits per million tokens. The value must be greater than or equal to 0. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("cacheCost")]
            [Validation(Required=false)]
            public float? CacheCost { get; set; }

            /// <summary>
            /// <para>The input token cost in Credits per million tokens. The value must be greater than or equal to 0. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("inputCost")]
            [Validation(Required=false)]
            public float? InputCost { get; set; }

            /// <summary>
            /// <para>The output token cost in Credits per million tokens. The value must be greater than or equal to 0. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("outputCost")]
            [Validation(Required=false)]
            public float? OutputCost { get; set; }

            /// <summary>
            /// <para>The billing type. Only fixed is supported. Default value: fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The model capability switches. Keys must be model capability names supported by the API gateway. Values are Boolean.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true,&quot;promptCaching&quot;:false}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>The token limits and input/output modality information of the model.</para>
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
            /// <para>The list of input modalities supported by the model. The list contains up to 16 items, and each item must not be empty.</para>
            /// </summary>
            [NameInMap("supportedInputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedInputModalities { get; set; }

            /// <summary>
            /// <para>The list of output modalities supported by the model. The list contains up to 16 items, and each item must not be empty.</para>
            /// </summary>
            [NameInMap("supportedOutputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedOutputModalities { get; set; }

        }

        /// <summary>
        /// <para>The model name. The name must be unique within the same AI gateway instance and model provider. Maximum length: 256 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model provider identifier. The value must reference an existing model provider in the target AI gateway instance. Maximum length: 128 characters.</para>
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
