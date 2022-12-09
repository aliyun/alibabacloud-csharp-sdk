// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalCallerReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistoricalCallerReportResponseBodyData Data { get; set; }
        public class GetHistoricalCallerReportResponseBodyData : TeaModel {
            [NameInMap("LastCallingTime")]
            [Validation(Required=false)]
            public long? LastCallingTime { get; set; }

            [NameInMap("TotalCalls")]
            [Validation(Required=false)]
            public long? TotalCalls { get; set; }

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

    }

}
