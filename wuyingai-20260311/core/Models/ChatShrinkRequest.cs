// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Bearer + JWT returned by GetAccessToken. URL-encode the entire string and pass it as a query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bearer%20eyJhb****...****k</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <para>The user ID from the external system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The message list (JSON string), sorted in chronological order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Role&quot;:&quot;user&quot;,&quot;Content&quot;:[{&quot;Type&quot;:&quot;text&quot;,&quot;Text&quot;:&quot;你好&quot;}]}]</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("Resume")]
        [Validation(Required=false)]
        public bool? Resume { get; set; }

        /// <summary>
        /// <para>The routing key that specifies the backend instance to process the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("RoutingKey")]
        [Validation(Required=false)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn conversation context persistence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session-001</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The additional settings. Contains the output file mode control parameter OutputFileMode (string, valid values: url or base64. Defaults to base64 for legacy compatibility. We recommend url).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OutputFileMode&quot;: &quot;url&quot;}</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public string SettingsShrink { get; set; }

        /// <summary>
        /// <para>The streaming output control options. Contains IncludeReasoning (boolean, default true, specifies whether to include the model thinking process) and IncludeToolCalls (boolean, default true, specifies whether to include tool invocation details). If not specified or set to a null object, the behavior is consistent with the legacy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IncludeReasoning&quot;: false, &quot;IncludeToolCalls&quot;: false}</para>
        /// </summary>
        [NameInMap("StreamOptions")]
        [Validation(Required=false)]
        public string StreamOptionsShrink { get; set; }

        /// <summary>
        /// <para>The agent template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template-abc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
