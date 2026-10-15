// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppChatRequest : TeaModel {
        /// <summary>
        /// <para>The bot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zero2</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>The chat ID passed in to resume a conversation after execution is interrupted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b465fe1-6f06-4899-af9f-d43d9338df25</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The conversation ID. This parameter is required from the second round onward in multi-turn conversation scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593fe1a2-d0b4-4fde-a2b0-78ad6a438d41</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The list of conversation messages in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\r\n  {\r\n    \&quot;role\&quot;: \&quot;user\&quot;,\r\n    \&quot;content\&quot;: \&quot;Prove that there are only five platonic solids, namely the tetrahedron, octahedron, icosahedron, cube, and dodecahedron.\&quot;\r\n  }\r\n]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public string Messages { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>857240041851344</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

    }

}
