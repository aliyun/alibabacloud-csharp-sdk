// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class QueryAmountResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryAmountResponseBodyData Data { get; set; }
        public class QueryAmountResponseBodyData : TeaModel {
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryAmountResponseBodyDataItems> Items { get; set; }
            public class QueryAmountResponseBodyDataItems : TeaModel {
                [NameInMap("aliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("amountRatio")]
                [Validation(Required=false)]
                public string AmountRatio { get; set; }

                [NameInMap("listFee")]
                [Validation(Required=false)]
                public string ListFee { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("tier")]
                [Validation(Required=false)]
                public string Tier { get; set; }

                [NameInMap("totalAmount")]
                [Validation(Required=false)]
                public string TotalAmount { get; set; }

            }

            [NameInMap("scopeNote")]
            [Validation(Required=false)]
            public string ScopeNote { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public QueryAmountResponseBodyDataTotal Total { get; set; }
            public class QueryAmountResponseBodyDataTotal : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("listFee")]
                [Validation(Required=false)]
                public string ListFee { get; set; }

                [NameInMap("totalAmount")]
                [Validation(Required=false)]
                public string TotalAmount { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("retryAble")]
        [Validation(Required=false)]
        public bool? RetryAble { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
