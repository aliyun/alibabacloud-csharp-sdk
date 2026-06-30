// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RunCompletionMessageRequest : TeaModel {
        /// <summary>
        /// <para>A list of messages that form the conversation history and the current prompt.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<RunCompletionMessageRequestMessages> Messages { get; set; }
        public class RunCompletionMessageRequestMessages : TeaModel {
            /// <summary>
            /// <para>The content of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请用50字总结一下对话</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The role of the message sender. Valid values: <c>user</c>, <c>agent</c>, <c>system</c>, and <c>function</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The model specification to use. Valid values: <c>TYXM_PLUS</c> and <c>TYXM_TURBO</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TYXM_PLUS</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to stream the response using Server-Sent Events (SSE). If <c>true</c>, the response is streamed. Defaults to <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
