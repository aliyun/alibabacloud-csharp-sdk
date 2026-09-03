// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class QueryMsgStatResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMsgStatResponseBodyData Data { get; set; }
        public class QueryMsgStatResponseBodyData : TeaModel {
            [NameInMap("Accept")]
            [Validation(Required=false)]
            public long? Accept { get; set; }

            [NameInMap("Arrive")]
            [Validation(Required=false)]
            public long? Arrive { get; set; }

            [NameInMap("ClosePush")]
            [Validation(Required=false)]
            public long? ClosePush { get; set; }

            [NameInMap("Dismiss")]
            [Validation(Required=false)]
            public long? Dismiss { get; set; }

            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            [NameInMap("Open")]
            [Validation(Required=false)]
            public long? Open { get; set; }

            [NameInMap("Sent")]
            [Validation(Required=false)]
            public long? Sent { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

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
