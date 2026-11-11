// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelRequest : TeaModel {
        /// <summary>
        /// <para>The model update request body. At least one non-null parameter among description, contextSize, maxTokens, and capabilities must be provided.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelRequestBody Body { get; set; }
        public class UpdateModelRequestBody : TeaModel {
            /// <summary>
            /// <para>The model capability configurations. When an object is passed, the original capability configurations are replaced as a whole. Unpassed capability fields within the object are treated as false. Passing an empty object {} sets all capabilities to false. If this parameter is omitted or passed as null, the original configurations are retained.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public UpdateModelRequestBodyCapabilities Capabilities { get; set; }
            public class UpdateModelRequestBodyCapabilities : TeaModel {
                /// <summary>
                /// <para>Specifies whether the model supports audio input or output.</para>
                /// </summary>
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports document input.</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke tool calling multiple times in a single response.</para>
                /// </summary>
                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports reasoning capabilities. A value of true indicates that reasoning is supported, and a value of false indicates that it is not supported. This field is a capability flag and is not used to set reasoning intensity or reasoning token budgets.</para>
                /// </summary>
                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke streaming tool calling.</para>
                /// </summary>
                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports tool calling.</para>
                /// </summary>
                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports video input.</para>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports image input.</para>
                /// </summary>
                [NameInMap("vision")]
                [Validation(Required=false)]
                public bool? Vision { get; set; }

            }

            /// <summary>
            /// <para>The context token limit of the model. The minimum value is 1000. The updated value must not be less than maxTokens. If maxTokens is not provided in the current request, the existing value is used for validation. If this parameter is omitted or passed as null, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            /// <summary>
            /// <para>The model description. The maximum length is 255 characters after leading and trailing whitespaces are removed. Pass an empty string to clear the description. If this parameter is omitted or passed as null, the original value is retained. Modifying only the description does not refresh the model configuration of associated agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens for a single generation by the model. The value must be a positive integer. If contextSize is configured, the updated maxTokens must not be greater than contextSize. If contextSize is not provided in the current request, the existing value is used for validation. If this parameter is omitted or passed as null, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

        }

        /// <summary>
        /// <para>The client token used for idempotence. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
