// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PromptAgentSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1021418411</para>
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
                /// <para>{
                ///    &quot;key1&quot;: &quot;value1&quot;,
                ///    &quot;key2&quot;: &quot;value2&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public object Context { get; set; }

            }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public List<PromptAgentSessionRequestParamsPrompt> Prompt { get; set; }
            public class PromptAgentSessionRequestParamsPrompt : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Meta")]
                [Validation(Required=false)]
                public PromptAgentSessionRequestParamsPromptMeta Meta { get; set; }
                public class PromptAgentSessionRequestParamsPromptMeta : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true or false</para>
                    /// </summary>
                    [NameInMap("Hide")]
                    [Validation(Required=false)]
                    public bool? Hide { get; set; }

                }

                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
