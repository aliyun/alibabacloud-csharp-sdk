// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryJobStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryJobStatisticsResponseBodyData Data { get; set; }
        public class QueryJobStatisticsResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Queued")]
            [Validation(Required=false)]
            public int? Queued { get; set; }
            [NameInMap("Sent")]
            [Validation(Required=false)]
            public int? Sent { get; set; }
            [NameInMap("InProgress")]
            [Validation(Required=false)]
            public int? InProgress { get; set; }
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }
            [NameInMap("Rejected")]
            [Validation(Required=false)]
            public int? Rejected { get; set; }
            [NameInMap("TimeOut")]
            [Validation(Required=false)]
            public int? TimeOut { get; set; }
            [NameInMap("Cancelled")]
            [Validation(Required=false)]
            public int? Cancelled { get; set; }
        };

    }

}
