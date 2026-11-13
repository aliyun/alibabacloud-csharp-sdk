// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelSourceModelRequest : TeaModel {
        /// <summary>
        /// <para>The protocols and invocation paths supported by the model.</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<CreateAiModelSourceModelRequestAvailablePaths> AvailablePaths { get; set; }
        public class CreateAiModelSourceModelRequestAvailablePaths : TeaModel {
            /// <summary>
            /// <para>The invocation path for the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The protocol type used for the invocation path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI/v1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The credit pricing configuration for the model.</para>
        /// </summary>
        [NameInMap("credit")]
        [Validation(Required=false)]
        public CreateAiModelSourceModelRequestCredit Credit { get; set; }
        public class CreateAiModelSourceModelRequestCredit : TeaModel {
            /// <summary>
            /// <para>The number of credits per million cached input tokens. The value must be a non-negative number. A value of 0 indicates that the cached input is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("cacheCost")]
            [Validation(Required=false)]
            public float? CacheCost { get; set; }

            /// <summary>
            /// <para>The number of credits per million input tokens. The value must be a non-negative number. A value of 0 indicates that the input is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("inputCost")]
            [Validation(Required=false)]
            public float? InputCost { get; set; }

            /// <summary>
            /// <para>The number of credits per million output tokens. The value must be a non-negative number. A value of 0 indicates that the output is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("outputCost")]
            [Validation(Required=false)]
            public float? OutputCost { get; set; }

            /// <summary>
            /// <para>The pricing method. Currently, only fixed (fixed credit pricing) is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The set of capabilities declared for the model. The key is the capability name and the value indicates whether the capability is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nativeStreaming&quot;:true}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>The token limits and the input and output modality information for the model.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public CreateAiModelSourceModelRequestMeta Meta { get; set; }
        public class CreateAiModelSourceModelRequestMeta : TeaModel {
            /// <summary>
            /// <para>The maximum number of input tokens supported by the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32768</para>
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
            /// <para>The maximum number of context tokens supported by the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40960</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

            /// <summary>
            /// <para>The input modalities supported by the model.</para>
            /// </summary>
            [NameInMap("supportedInputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedInputModalities { get; set; }

            /// <summary>
            /// <para>The output modalities supported by the model.</para>
            /// </summary>
            [NameInMap("supportedOutputModalities")]
            [Validation(Required=false)]
            public List<string> SupportedOutputModalities { get; set; }

        }

        /// <summary>
        /// <para>The actual model name used by the upstream service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The ID of the model source. Use the modelSourceId returned by the CreateAiModelSource operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-d00000000000000000000</para>
        /// </summary>
        [NameInMap("modelSourceId")]
        [Validation(Required=false)]
        public string ModelSourceId { get; set; }

        /// <summary>
        /// <para>The client token generated by the caller to identify the same creation or retry operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1907ca4-952c-4c5f-8d1f-0aa6ae339c96</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
