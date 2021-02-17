// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessageResendByIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsDLQMessageResendByIdResponseBodyData Data { get; set; }
        public class OnsDLQMessageResendByIdResponseBodyData : TeaModel {
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public List<string> MsgId { get; set; }
        };

    }

}
