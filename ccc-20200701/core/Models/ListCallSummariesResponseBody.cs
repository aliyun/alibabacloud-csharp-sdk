// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallSummariesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallSummariesResponseBodyData> Data { get; set; }
        public class ListCallSummariesResponseBodyData : TeaModel {
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
