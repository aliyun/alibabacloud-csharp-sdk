// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class SendCustomMessageToAllResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendCustomMessageToAllResponseBodyResult Result { get; set; }
        public class SendCustomMessageToAllResponseBodyResult : TeaModel {
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }
        };

    }

}
