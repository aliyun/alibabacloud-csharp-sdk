// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220602.Models
{
    public class PromptAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;: 400, &quot;errorCode&quot;: &quot;0x50000000001&quot;, &quot;message&quot;: &quot;not exist session&quot;, &quot;data&quot;: null}</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public object Error { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>session/update</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;403e9e4a-457f-404e-9963-c5ca9b3997cf&quot;,&quot;update&quot;:{&quot;sessionUpdate&quot;:&quot;agent_message_chunk&quot;,&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;I have 13 skills.&quot;}}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>403e9e4a-457f-404e-9963-c5ca9b3997cf</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;stopReason&quot;:&quot;end_turn&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public object Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1789367332</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
