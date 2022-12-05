// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendMessageToGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendMessageToGroupResponseBodyResult Result { get; set; }
        public class SendMessageToGroupResponseBodyResult : TeaModel {
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

        }

    }

}
