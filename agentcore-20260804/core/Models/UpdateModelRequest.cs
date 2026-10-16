// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelRequest : TeaModel {
        /// <summary>
        /// <para>The model update request body. You must specify at least one non-null parameter among description, contextSize, maxTokens, and capabilities.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelRequestBody Body { get; set; }
        public class UpdateModelRequestBody : TeaModel {
            /// <summary>
            /// <para>The model capability configuration. When an object is passed, the original capability configuration is replaced as a whole. Capability fields that are not specified in the object are treated as false. Passing an empty object {} sets all capabilities to false. If this parameter is not passed or is set to null, the original configuration is retained.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public UpdateModelRequestBodyCapabilities Capabilities { get; set; }
            public class UpdateModelRequestBodyCapabilities : TeaModel {
                /// <summary>
                /// <para>Specifies whether the model supports audio input or output. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports document input. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke tool calling multiple times in a single response. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports reasoning capabilities. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.
                /// This field is a capability flag and is not used to set the reasoning intensity or reasoning token budget.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke streaming tool calling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke tool calling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports video input. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports image input. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("vision")]
                [Validation(Required=false)]
                public bool? Vision { get; set; }

            }

            /// <summary>
            /// <para>The context token limit of the model. The minimum value is 1000. The updated value must not be less than maxTokens. If maxTokens is not specified in the current request, the existing value is used for validation. If this parameter is not passed or is set to null, the original value is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            /// <summary>
            /// <para>The model description. The maximum length is 255 characters after leading and trailing whitespace is removed. Passing an empty string clears the description. If this parameter is not passed or is set to null, the original value is retained. Modifying only the description does not refresh the model configurations of associated agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens for a single generation of the model. The value must be a positive integer. If contextSize is configured, the updated maxTokens must not be greater than contextSize. If contextSize is not specified in the current request, the existing value is used for validation. If this parameter is not passed or is set to null, the original value is retained.</para>
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
