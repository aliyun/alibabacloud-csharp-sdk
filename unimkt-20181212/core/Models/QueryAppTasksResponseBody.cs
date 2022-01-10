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
                public string AccountNo { get; set; }
                public int? AllContentStatus { get; set; }
                public long? Balance { get; set; }
                public long? BalanceDay { get; set; }
                public long? BrandUserId { get; set; }
                public long? ChargeCost { get; set; }
                public string ContentIds { get; set; }
                public string EndTime { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public int? OpenScene { get; set; }
                public int? PopularizePosition { get; set; }
                public string PriceType { get; set; }
                public int? Priority { get; set; }
                public long? ProxyUserId { get; set; }
                public long? Quota { get; set; }
                public long? QuotaDay { get; set; }
                public string StartTime { get; set; }
                public int? Status { get; set; }
                public string TimeSchema { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
