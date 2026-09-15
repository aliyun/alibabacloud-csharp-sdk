// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelRequest : TeaModel {
        /// <summary>
        /// <para>The model update request body. At least one non-null parameter must be provided among description, contextSize, maxTokens, and capabilities.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelRequestBody Body { get; set; }
        public class UpdateModelRequestBody : TeaModel {
            /// <summary>
            /// <para>The model capability configuration. When an object is provided, it replaces the existing capability configuration as a whole. Capability fields not included in the object are treated as false. Providing an empty object {} sets all capabilities to false. If this parameter is not provided or set to null, the original configuration is retained.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public UpdateModelRequestBodyCapabilities Capabilities { get; set; }
            public class UpdateModelRequestBodyCapabilities : TeaModel {
                /// <summary>
                /// <para>Specifies whether the model supports audio input or output. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports document input. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports invoking multiple tools in a single response. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports reasoning. A value of true indicates that it is supported. A value of false indicates that it is not supported. This field is a capability marker and is not used to set reasoning intensity or reasoning token budget.</para>
                /// </summary>
                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports streaming tool invocation. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports tool invocation. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports video input. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports image input. A value of true indicates that it is supported. A value of false indicates that it is not supported.</para>
                /// </summary>
                [NameInMap("vision")]
                [Validation(Required=false)]
                public bool? Vision { get; set; }

            }

            /// <summary>
            /// <para>The context token limit of the model. The minimum value is 1000. The updated value must not be less than maxTokens. If maxTokens is not provided in this request, the existing value is used for validation. If this parameter is not provided or set to null, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            /// <summary>
            /// <para>The model description. The maximum length is 255 characters after leading and trailing whitespace is removed. Providing an empty string clears the description. If this parameter is not provided or set to null, the original value is retained. Modifying only the description does not refresh the model configuration of associated Agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens per generation. The value must be a positive integer. If contextSize is configured, the updated maxTokens must not exceed contextSize. If contextSize is not provided in this request, the existing value is used for validation. If this parameter is not provided or set to null, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

        }

        /// <summary>
        /// <para>The client token for idempotency. Not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
