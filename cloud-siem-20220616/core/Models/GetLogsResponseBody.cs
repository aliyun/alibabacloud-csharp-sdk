// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetLogsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLogsResponseBodyData Data { get; set; }
        public class GetLogsResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public GetLogsResponseBodyDataPageInfo PageInfo { get; set; }
            public class GetLogsResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public GetLogsResponseBodyDataResponseData ResponseData { get; set; }
            public class GetLogsResponseBodyDataResponseData : TeaModel {
                [NameInMap("CompleteOrNot")]
                [Validation(Required=false)]
                public bool? CompleteOrNot { get; set; }

                [NameInMap("Cost")]
                [Validation(Required=false)]
                public long? Cost { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("HasSql")]
                [Validation(Required=false)]
                public bool? HasSql { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                [NameInMap("Lines")]
                [Validation(Required=false)]
                public List<object> Lines { get; set; }

            }

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
