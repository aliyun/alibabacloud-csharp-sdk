// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunChatResultGenerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;topP&quot;: 0.8}</para>
        /// </summary>
        [NameInMap("inferenceParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceParameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestMessages> Messages { get; set; }
        public class RunChatResultGenerationRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>237645726354</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestTools> Tools { get; set; }
        public class RunChatResultGenerationRequestTools : TeaModel {
            [NameInMap("function")]
            [Validation(Required=false)]
            public RunChatResultGenerationRequestToolsFunction Function { get; set; }
            public class RunChatResultGenerationRequestToolsFunction : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>get_time</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public RunChatResultGenerationRequestToolsFunctionParameters Parameters { get; set; }
                public class RunChatResultGenerationRequestToolsFunctionParameters : TeaModel {
                    /// <summary>
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
                    /// <b>Example:</b>
                    /// <para>object</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("required")]
                [Validation(Required=false)]
                public List<string> Required { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
