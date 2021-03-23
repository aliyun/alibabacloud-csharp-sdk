// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDeductLogResponseBody : TeaModel {
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
        public QuerySavingsPlansDeductLogResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDeductLogResponseBodyData : TeaModel {
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
            public List<QuerySavingsPlansDeductLogResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDeductLogResponseBodyDataItems : TeaModel {
                public string InstanceId { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string SavingsType { get; set; }
                public string BillModule { get; set; }
                public string DeductFee { get; set; }
                public string DeductRate { get; set; }
                public long? UserId { get; set; }
                public string DeductCommodity { get; set; }
                public string DeductInstanceId { get; set; }
                public string DiscountRate { get; set; }
            }
        };

    }

}
