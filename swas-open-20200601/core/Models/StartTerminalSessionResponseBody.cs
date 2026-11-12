// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class StartTerminalSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security token that is included in the request header of the WebSocket request for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxxaaz</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ffb90b6e-b18a-4a33-88cf-86fb88****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The URL of the WebSocket session that is used to remotely connect to the Simple Application Server instance. The URL contains the session ID (<c>SessionId</c>) and the security token (<c>SecurityToken</c>) that is used for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wss://xxxx</para>
        /// </summary>
        [NameInMap("WebSocketUrl")]
        [Validation(Required=false)]
        public string WebSocketUrl { get; set; }

    }

}
