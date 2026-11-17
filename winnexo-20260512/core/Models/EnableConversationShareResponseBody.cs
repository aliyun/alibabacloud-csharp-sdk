// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class EnableConversationShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of SUCCESS indicates success. For failures, the corresponding error type is returned, such as ERR_BAD_REQUEST, ERR_VALIDATION_FAILED, or ERR_INTERNAL_SERVER_ERROR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid request parameters</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The ID of the source single-chat session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The current sharing scope. Valid values: PUBLIC and SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("shareAccessType")]
        [Validation(Required=false)]
        public string ShareAccessType { get; set; }

        /// <summary>
        /// <para>Indicates whether sharing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shareEnabled")]
        [Validation(Required=false)]
        public bool? ShareEnabled { get; set; }

        /// <summary>
        /// <para>The time when sharing was most recently enabled, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-16T13:00:00+00:00</para>
        /// </summary>
        [NameInMap("shareEnabledAt")]
        [Validation(Required=false)]
        public string ShareEnabledAt { get; set; }

        /// <summary>
        /// <para>The relative path for in-site sharing. This value is empty when sharing is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/10001/share/chat/token</para>
        /// </summary>
        [NameInMap("sharePath")]
        [Validation(Required=false)]
        public string SharePath { get; set; }

        /// <summary>
        /// <para>The sharing token. This token is present when sharing is enabled and can be used to access the public sharing preview API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleShareToken</para>
        /// </summary>
        [NameInMap("shareToken")]
        [Validation(Required=false)]
        public string ShareToken { get; set; }

        /// <summary>
        /// <para>The absolute URL of the current sharing link. This value is empty when sharing is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/10001/share/chat/token">https://example.com/10001/share/chat/token</a></para>
        /// </summary>
        [NameInMap("shareUrl")]
        [Validation(Required=false)]
        public string ShareUrl { get; set; }

        /// <summary>
        /// <para>The list of currently specified user group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("shareUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ShareUserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of currently specified user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("shareUserIds")]
        [Validation(Required=false)]
        public List<long?> ShareUserIds { get; set; }

    }

}
