// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryShortUrlListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryShortUrlListNewResponseBodyList> List { get; set; }
        public class QueryShortUrlListNewResponseBodyList : TeaModel {
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtInvalidTime")]
            [Validation(Required=false)]
            public string GmtInvalidTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<QueryShortUrlListNewResponseBodyListRecord> Record { get; set; }
            public class QueryShortUrlListNewResponseBodyListRecord : TeaModel {
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                [NameInMap("GmtInvalidTime")]
                [Validation(Required=false)]
                public string GmtInvalidTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ShortUrl")]
                [Validation(Required=false)]
                public string ShortUrl { get; set; }

                [NameInMap("SourceUrl")]
                [Validation(Required=false)]
                public string SourceUrl { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TotalPv")]
                [Validation(Required=false)]
                public string TotalPv { get; set; }

                [NameInMap("TotalUv")]
                [Validation(Required=false)]
                public string TotalUv { get; set; }

            }

            [NameInMap("ShortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TotalPv")]
            [Validation(Required=false)]
            public string TotalPv { get; set; }

            [NameInMap("TotalUv")]
            [Validation(Required=false)]
            public string TotalUv { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
