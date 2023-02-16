// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20230117.Models
{
    public class QueryAsyncJobListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAsyncJobListResponseBodyData Data { get; set; }
        public class QueryAsyncJobListResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryAsyncJobListResponseBodyDataResult> Result { get; set; }
            public class QueryAsyncJobListResponseBodyDataResult : TeaModel {
                [NameInMap("CallerParentId")]
                [Validation(Required=false)]
                public string CallerParentId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("PopApiName")]
                [Validation(Required=false)]
                public string PopApiName { get; set; }

                [NameInMap("PopProduct")]
                [Validation(Required=false)]
                public string PopProduct { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            [NameInMap("TotalRecord")]
            [Validation(Required=false)]
            public int? TotalRecord { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

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
