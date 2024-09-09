// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class VerifySendMessageRequest : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("messageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        [NameInMap("messageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

    }

}
