// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service. Valid values: nickname_detection: user nickname chat_detection: chat interactions comment_detection: dynamic comments pgc_detection: professionally-generated content (PGC) teaching materials</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pgc_detection: moderation of PGC teaching materials</description></item>
        /// <item><description>nickname_detection: user nickname moderation</description></item>
        /// <item><description>comment_multilingual_pro: multi-language moderation in international business scenarios</description></item>
        /// <item><description>chat_detection: moderation of interactive content of private chats</description></item>
        /// <item><description>ad_compliance_detection: advertising law compliance identification</description></item>
        /// <item><description>comment_detection: moderation of comment content of public chats</description></item>
        /// <item><description>ai_art_detection: AI-generated text identfication</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nickname_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;Content to be moderated&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
