// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetInterveneGlobalReplyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInterveneGlobalReplyResponseBodyData Data { get; set; }
        public class GetInterveneGlobalReplyResponseBodyData : TeaModel {
            [NameInMap("ReplyMessagList")]
            [Validation(Required=false)]
            public List<GetInterveneGlobalReplyResponseBodyDataReplyMessagList> ReplyMessagList { get; set; }
            public class GetInterveneGlobalReplyResponseBodyDataReplyMessagList : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ReplyType")]
                [Validation(Required=false)]
                public string ReplyType { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
