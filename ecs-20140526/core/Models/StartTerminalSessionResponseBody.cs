// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB5173B0-8E80-564E-AAD1-3135412*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security token that is appended to the WebSocket request header for system verification of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d86c2df2-d19c-4bd8-b817-a19ef123****</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-hz023od0x9****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The URL of the WebSocket session for the remote connection to the ECS instance. The URL contains the session ID (SessionId) and the SecurityToken used for system verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wss://cn-hangzhou.axt.aliyuncs.com/session?sessionId=s-hz023od0x9****&amp;token=d86c2df2-d19c-4bd8-b817-a19ef123****</para>
        /// </summary>
        [NameInMap("WebSocketUrl")]
        [Validation(Required=false)]
        public string WebSocketUrl { get; set; }

    }

}
