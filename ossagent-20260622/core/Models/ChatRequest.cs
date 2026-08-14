// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260622.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>The messages.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<ChatRequestMessages> Messages { get; set; }
        public class ChatRequestMessages : TeaModel {
            /// <summary>
            /// <para>The conversation text content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The role of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Q&amp;A session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
