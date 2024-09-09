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

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
