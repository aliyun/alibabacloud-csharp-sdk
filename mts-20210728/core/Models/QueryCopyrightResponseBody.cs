// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryCopyrightResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCopyrightResponseBodyData> Data { get; set; }
        public class QueryCopyrightResponseBodyData : TeaModel {
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
