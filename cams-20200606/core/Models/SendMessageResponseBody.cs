// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendMessageResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public SendMessageResponseBodyModule Module { get; set; }
        public class SendMessageResponseBodyModule : TeaModel {
            [NameInMap("FromId")]
            [Validation(Required=false)]
            public string FromId { get; set; }
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }
            [NameInMap("ToId")]
            [Validation(Required=false)]
            public string ToId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
