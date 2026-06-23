// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunChatResultGenerationRequest : TeaModel {
        /// <summary>
        /// <para>Hyperparameters used for inference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;topP&quot;: 0.8}</para>
        /// </summary>
        [NameInMap("inferenceParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceParameters { get; set; }

        /// <summary>
        /// <para>Messages to input into the model.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestMessages> Messages { get; set; }
        public class RunChatResultGenerationRequestMessages : TeaModel {
            /// <summary>
            /// <para>Message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一个信息处理专家</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The model service type. Get this value from the /api/app/config API endpoint in the llmHelperTypeList field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Session ID. Use this to mark a conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237645726354</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Streaming mode. Set to true for streaming responses. Set to false for full responses. Default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>Tool information. Specify a list of tools the model can call. When multiple tools are provided, the model selects one to generate a response.</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestTools> Tools { get; set; }
        public class RunChatResultGenerationRequestTools : TeaModel {
            /// <summary>
            /// <para>An object containing name, description, and parameters.</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public RunChatResultGenerationRequestToolsFunction Function { get; set; }
            public class RunChatResultGenerationRequestToolsFunction : TeaModel {
                /// <summary>
                /// <para>A string describing the tool function. This helps the model decide when and how to call it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>工具函数的描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>A string representing the tool function name. It must contain only letters, digits, underscores, and hyphens. Maximum length is 64 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get_time</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>An object describing the tool parameters. It must be a valid JSON Schema.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public RunChatResultGenerationRequestToolsFunctionParameters Parameters { get; set; }
                public class RunChatResultGenerationRequestToolsFunctionParameters : TeaModel {
                    /// <summary>
                    /// <para>Properties.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///                             &quot;location&quot;: {
                    ///                                 &quot;type&quot;: &quot;string&quot;,
                    ///                                 &quot;description&quot;: &quot;The city and state, e.g. San Francisco, CA&quot;
                    ///                             },
                    ///                             &quot;unit&quot;: {
                    ///                                 &quot;type&quot;: &quot;string&quot;,
                    ///                                 &quot;enum&quot;: [
                    ///                                     &quot;celsius&quot;,
                    ///                                     &quot;fahrenheit&quot;
                    ///                                 ]
                    ///                             }
                    ///                         }</para>
                    /// </summary>
                    [NameInMap("properties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Properties { get; set; }

                    /// <summary>
                    /// <para>Type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>object</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>List of required parameters.</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public List<string> Required { get; set; }

            }

            /// <summary>
            /// <para>A string indicating the tool type. Currently, only &quot;function&quot; is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
