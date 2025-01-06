// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeConversationContextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{         &quot;CallingNumber&quot;: &quot;135815***&quot;,         &quot;AdditionalContext&quot;: &quot;&quot;,         &quot;ConversationId&quot;: &quot;361c8a53-0e29-42f3-8aa7-c7752d010399&quot;     }</para>
        /// </summary>
        [NameInMap("ConversationContext")]
        [Validation(Required=false)]
        public string ConversationContext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b19af5ce5314ac08108d1b33fe20e15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
