// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationPlusRequest : TeaModel {
        /// <summary>
        /// <para>The moderation service.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>chat_detection_pro: moderation of interactive content of private chats_Professional</description></item>
        /// <item><description>llm_response_moderation: moderation of text generated by LLMs</description></item>
        /// <item><description>llm_query_moderation: moderation of input text of LLMs</description></item>
        /// <item><description>nickname_detection_pro: moderation of user nicknames_Professional</description></item>
        /// <item><description>comment_detection_pro: moderation of comment content of public chats_Professional</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llm_query_moderation</para>
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
