// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendWorkItemMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success. Other values indicate backend error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error description. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the assistant message. The reply is generated asynchronously in the background.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23456789-abcd-4ef0-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the existing topic session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89ab-4def-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The ID of the user message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-9abc-4def-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("userMessageId")]
        [Validation(Required=false)]
        public string UserMessageId { get; set; }

        /// <summary>
        /// <para>The work item ID in the request. If only conversationId is specified, a compatible ID in the legacy-topic:<conversationId> format is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
