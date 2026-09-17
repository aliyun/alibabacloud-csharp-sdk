// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220602.Models
{
    public class PromptAgentSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>product=HOLOGRES</para>
        /// </summary>
        [NameInMap("Caller-Context")]
        [Validation(Required=false)]
        public string CallerContext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2072736942627512345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public PromptAgentSessionRequestParams Params { get; set; }
        public class PromptAgentSessionRequestParams : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public PromptAgentSessionRequestParamsMeta Meta { get; set; }
            public class PromptAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot; }</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public object Context { get; set; }

            }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public List<PromptAgentSessionRequestParamsPrompt> Prompt { get; set; }
            public class PromptAgentSessionRequestParamsPrompt : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>User\&quot;s order details</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Meta")]
                [Validation(Required=false)]
                public PromptAgentSessionRequestParamsPromptMeta Meta { get; set; }
                public class PromptAgentSessionRequestParamsPromptMeta : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Hide")]
                    [Validation(Required=false)]
                    public bool? Hide { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>csv</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.csv</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2048000</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>How many skills do you have?</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_orders</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://${bucket}/${ossKey}</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>046d002e-0c68-4fa2-9fd8-341d9b85afb7</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
