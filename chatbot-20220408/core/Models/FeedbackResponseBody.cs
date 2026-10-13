// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackResponseBody : TeaModel {
        /// <summary>
        /// <para>The feedback type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>good: Like.</description></item>
        /// <item><description>bad: Dislike.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>good</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>The ID that uniquely identifies a single message in a session window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ca40988-4f99-47ad-ac96-9060d0f81db9</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4e5eea71-f326-450c-8849-49515473ef64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
