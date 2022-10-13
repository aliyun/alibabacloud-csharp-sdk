// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryAppTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAppTasksResponseBodyData Data { get; set; }
        public class QueryAppTasksResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAppTasksResponseBodyDataList> List { get; set; }
            public class QueryAppTasksResponseBodyDataList : TeaModel {
                [NameInMap("AccountNo")]
                [Validation(Required=false)]
                public string AccountNo { get; set; }

                [NameInMap("AllContentStatus")]
                [Validation(Required=false)]
                public int? AllContentStatus { get; set; }

                [NameInMap("Balance")]
                [Validation(Required=false)]
                public long? Balance { get; set; }

                [NameInMap("BalanceDay")]
                [Validation(Required=false)]
                public long? BalanceDay { get; set; }

                [NameInMap("BrandUserId")]
                [Validation(Required=false)]
                public long? BrandUserId { get; set; }

                [NameInMap("ChargeCost")]
                [Validation(Required=false)]
                public long? ChargeCost { get; set; }

                [NameInMap("ContentIds")]
                [Validation(Required=false)]
                public string ContentIds { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OpenScene")]
                [Validation(Required=false)]
                public int? OpenScene { get; set; }

                [NameInMap("PopularizePosition")]
                [Validation(Required=false)]
                public int? PopularizePosition { get; set; }

                [NameInMap("PriceType")]
                [Validation(Required=false)]
                public string PriceType { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ProxyUserId")]
                [Validation(Required=false)]
                public long? ProxyUserId { get; set; }

                [NameInMap("Quota")]
                [Validation(Required=false)]
                public long? Quota { get; set; }

                [NameInMap("QuotaDay")]
                [Validation(Required=false)]
                public long? QuotaDay { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TimeSchema")]
                [Validation(Required=false)]
                public string TimeSchema { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
