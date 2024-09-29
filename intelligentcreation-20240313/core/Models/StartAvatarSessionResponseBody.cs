// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class StartAvatarSessionResponseBody : TeaModel {
        [NameInMap("channelToken")]
        [Validation(Required=false)]
        public string ChannelToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0E8B1746-AE35-5C4B-A3A8-345B274AE32C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>121dlsga4o7golrl1hoja</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("webSocketUrl")]
        [Validation(Required=false)]
        public string WebSocketUrl { get; set; }

    }

}
