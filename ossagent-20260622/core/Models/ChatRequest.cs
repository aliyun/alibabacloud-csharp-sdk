// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260622.Models
{
    public class ChatRequest : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<ChatRequestMessages> Messages { get; set; }
        public class ChatRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
