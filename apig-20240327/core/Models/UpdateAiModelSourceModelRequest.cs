// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelSourceModelRequest : TeaModel {
        /// <summary>
        /// <para>The protocols and invocation paths supported by the model.</para>
        /// </summary>
        [NameInMap("availablePaths")]
        [Validation(Required=false)]
        public List<UpdateAiModelSourceModelRequestAvailablePaths> AvailablePaths { get; set; }
        public class UpdateAiModelSourceModelRequestAvailablePaths : TeaModel {
            /// <summary>
            /// <para>The invocation path of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The protocol type used by the invocation path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI/v1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The credit pricing configuration of the model.</para>
        /// </summary>
        [NameInMap("credit")]
        [Validation(Required=false)]
        public UpdateAiModelSourceModelRequestCredit Credit { get; set; }
        public class UpdateAiModelSourceModelRequestCredit : TeaModel {
            /// <summary>
            /// <para>The number of credits per one million cached input tokens. The value must be a non-negative number. A value of 0 indicates that cached input is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("cacheCost")]
            [Validation(Required=false)]
            public float? CacheCost { get; set; }

            /// <summary>
            /// <para>The number of credits per one million input tokens. The value must be a non-negative number. A value of 0 indicates that the input is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("inputCost")]
            [Validation(Required=false)]
            public float? InputCost { get; set; }

            /// <summary>
            /// <para>The number of credits per one million output tokens. The value must be a non-negative number. A value of 0 indicates that the output is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("outputCost")]
            [Validation(Required=false)]
            public float? OutputCost { get; set; }

            /// <summary>
            /// <para>The pricing method. Currently, fixed credit pricing is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The expected object version. Use the version returned by the most recent query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The set of capabilities declared by the model. The key is the capability name, and the value indicates whether the capability is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nativeStreaming&quot;:true}</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>The token limits and input and output modality information of the model.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public UpdateAiModelSourceModelRequestMeta Meta { get; set; }
        public class UpdateAiModelSourceModelRequestMeta : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

    }

}
