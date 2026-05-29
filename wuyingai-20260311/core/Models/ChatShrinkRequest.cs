// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Bearer%20eyJhb****...****k</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Role&quot;:&quot;user&quot;,&quot;Content&quot;:[{&quot;Type&quot;:&quot;text&quot;,&quot;Text&quot;:&quot;你好&quot;}]}]</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("RoutingKey")]
        [Validation(Required=false)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-session-001</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;OutputFileMode&quot;: &quot;url&quot;}</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public string SettingsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;IncludeReasoning&quot;: false, &quot;IncludeToolCalls&quot;: false}</para>
        /// </summary>
        [NameInMap("StreamOptions")]
        [Validation(Required=false)]
        public string StreamOptionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-abc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
