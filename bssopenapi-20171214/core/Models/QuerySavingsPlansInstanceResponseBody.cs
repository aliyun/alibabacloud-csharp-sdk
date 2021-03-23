// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansInstanceResponseBodyData Data { get; set; }
        public class QuerySavingsPlansInstanceResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansInstanceResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansInstanceResponseBodyDataItems : TeaModel {
                public string InstanceId { get; set; }
                public string SavingsType { get; set; }
                public string InstanceFamily { get; set; }
                public string Region { get; set; }
                public string PoolValue { get; set; }
                public string Currency { get; set; }
                public string Status { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string PayMode { get; set; }
                public string PrepayFee { get; set; }
                public string TotalSave { get; set; }
                public string Utilization { get; set; }
                public bool? Share { get; set; }
            }
        };

    }

}
