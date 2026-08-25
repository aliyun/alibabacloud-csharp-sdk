// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class QueryQwenConferenceSgTicketPopResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryQwenConferenceSgTicketPopResponseBodyData Data { get; set; }
        public class QueryQwenConferenceSgTicketPopResponseBodyData : TeaModel {
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("ExtFields")]
            [Validation(Required=false)]
            public string ExtFields { get; set; }

            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            [NameInMap("SubmitId")]
            [Validation(Required=false)]
            public long? SubmitId { get; set; }

            [NameInMap("TicketToken")]
            [Validation(Required=false)]
            public string TicketToken { get; set; }

        }

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
