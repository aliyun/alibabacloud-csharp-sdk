// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMessageListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadMessageListResponseBodyData Data { get; set; }
        public class ReadMessageListResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<ReadMessageListResponseBodyDataRows> Rows { get; set; }
            public class ReadMessageListResponseBodyDataRows : TeaModel {
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public long? ClassId { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public int? Deleted { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public long? GmtCreated { get; set; }

                [NameInMap("GmtUpdate")]
                [Validation(Required=false)]
                public long? GmtUpdate { get; set; }

                [NameInMap("MassId")]
                [Validation(Required=false)]
                public long? MassId { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("MsgId")]
                [Validation(Required=false)]
                public long? MsgId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

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
