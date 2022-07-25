// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGroupedSecurityEventMarkMissListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryGroupedSecurityEventMarkMissListResponseBodyList> List { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyList : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("DisposalWay")]
            [Validation(Required=false)]
            public string DisposalWay { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("EventNameOriginal")]
            [Validation(Required=false)]
            public string EventNameOriginal { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("EventTypeOriginal")]
            [Validation(Required=false)]
            public string EventTypeOriginal { get; set; }

            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("FiledAliasName")]
            [Validation(Required=false)]
            public string FiledAliasName { get; set; }

            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public string Uuids { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo PageInfo { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
