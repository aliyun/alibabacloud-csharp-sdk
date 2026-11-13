// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelSourceModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned for a successful request, and a specific business error code is returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the operation on the AI model in the model source.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateAiModelSourceModelResponseBodyData Data { get; set; }
        public class UpdateAiModelSourceModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The protocols and invocation paths supported by the model.</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<UpdateAiModelSourceModelResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class UpdateAiModelSourceModelResponseBodyDataAvailablePaths : TeaModel {
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
            public UpdateAiModelSourceModelResponseBodyDataCredit Credit { get; set; }
            public class UpdateAiModelSourceModelResponseBodyDataCredit : TeaModel {
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
            /// <para>The set of capabilities declared by the model. The key is the capability name, and the value indicates whether the capability is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;nativeStreaming&quot;:true}</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public Dictionary<string, object> Features { get; set; }

            /// <summary>
            /// <para>The ID of the AI gateway instance to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d00000000000000000000</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The token limits and input and output modality information of the model.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public UpdateAiModelSourceModelResponseBodyDataMeta Meta { get; set; }
            public class UpdateAiModelSourceModelResponseBodyDataMeta : TeaModel {
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
            /// <para>The model identifier. For standard models, use the source model card ID. For logical model entries, use the vm- identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("modelCardId")]
            [Validation(Required=false)]
            public string ModelCardId { get; set; }

            /// <summary>
            /// <para>The actual model name used by the upstream service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The stable identifier of the provider to which the model belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("modelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

            /// <summary>
            /// <para>The model source ID. Use the modelSourceId returned by CreateAiModelSource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ms-d00000000000000000000</para>
            /// </summary>
            [NameInMap("modelSourceId")]
            [Validation(Required=false)]
            public string ModelSourceId { get; set; }

            /// <summary>
            /// <para>The display name of the model source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Model Studio model source</para>
            /// </summary>
            [NameInMap("modelSourceName")]
            [Validation(Required=false)]
            public string ModelSourceName { get; set; }

            /// <summary>
            /// <para>The current version of the associated model source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("modelSourceVersion")]
            [Validation(Required=false)]
            public long? ModelSourceVersion { get; set; }

            /// <summary>
            /// <para>The synchronization status of the model pricing configuration. A value of Pending indicates that the current version has not been synchronized, and a value of Ready indicates that the current version has been synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("pricingStatus")]
            [Validation(Required=false)]
            public string PricingStatus { get; set; }

            /// <summary>
            /// <para>The ID of the actual AI service bound to the model source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The source of the model asset. A value of user indicates a user model, and a value of builtin indicates a system built-in model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The time of the most recent business update. The time is in RFC 3339 format and in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-12T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The current version of the object, which is used for conditional validation during updates or deletions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The response message, which describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
