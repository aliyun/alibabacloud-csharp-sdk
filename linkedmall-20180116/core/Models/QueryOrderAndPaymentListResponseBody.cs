// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderAndPaymentListResponseBody : TeaModel {
        [NameInMap("PostFee")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyPostFee PostFee { get; set; }
        public class QueryOrderAndPaymentListResponseBodyPostFee : TeaModel {
            [NameInMap("FundAmount")]
            [Validation(Required=false)]
            public long? FundAmount { get; set; }
            [NameInMap("FundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }
            [NameInMap("FundAmountMoney")]
            [Validation(Required=false)]
            public long? FundAmountMoney { get; set; }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("LmOrderList")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderAndPaymentListResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList : TeaModel {
                [NameInMap("FundAmount")]
                [Validation(Required=false)]
                public long? FundAmount { get; set; }

                [NameInMap("FundType")]
                [Validation(Required=false)]
                public string FundType { get; set; }

                [NameInMap("FundAmountMoney")]
                [Validation(Required=false)]
                public long? FundAmountMoney { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
