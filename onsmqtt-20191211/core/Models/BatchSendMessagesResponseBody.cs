// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class BatchSendMessagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Responses")]
        [Validation(Required=false)]
        public List<BatchSendMessagesResponseBodyResponses> Responses { get; set; }
        public class BatchSendMessagesResponseBodyResponses : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

        }

    }

}
