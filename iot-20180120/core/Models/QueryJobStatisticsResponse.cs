// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryJobStatisticsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryJobStatisticsResponseData Data { get; set; }
        public class QueryJobStatisticsResponseData : TeaModel {
            [NameInMap("Cancelled")]
            [Validation(Required=true)]
            public int? Cancelled { get; set; }

            [NameInMap("Failed")]
            [Validation(Required=true)]
            public int? Failed { get; set; }

            [NameInMap("InProgress")]
            [Validation(Required=true)]
            public int? InProgress { get; set; }

            [NameInMap("Queued")]
            [Validation(Required=true)]
            public int? Queued { get; set; }

            [NameInMap("Rejected")]
            [Validation(Required=true)]
            public int? Rejected { get; set; }

            [NameInMap("Sent")]
            [Validation(Required=true)]
            public int? Sent { get; set; }

            [NameInMap("Succeeded")]
            [Validation(Required=true)]
            public int? Succeeded { get; set; }

            [NameInMap("TimeOut")]
            [Validation(Required=true)]
            public int? TimeOut { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

        }

    }

}
