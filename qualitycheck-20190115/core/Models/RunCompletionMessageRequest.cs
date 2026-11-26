// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RunCompletionMessageRequest : TeaModel {
        /// <summary>
        /// <para>The list of messages in the model request.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<RunCompletionMessageRequestMessages> Messages { get; set; }
        public class RunCompletionMessageRequestMessages : TeaModel {
            /// <summary>
            /// <para>The prompt content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Summarize the conversation in 50 words</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The conversation role. Valid values: user (customer), assistant (customer service representative), system (system message), and function (function).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The model specification. Valid values: TYXM_PLUS and TYXM_TURBO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TYXM_PLUS</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Server-Sent Events (SSE) responses. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
