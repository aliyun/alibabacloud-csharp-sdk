// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmOrderList")]
        [Validation(Required=false)]
        public QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderListLmOrderList : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LmOrderId")]
                [Validation(Required=false)]
                public long? LmOrderId { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuName")]
                [Validation(Required=false)]
                public string SkuName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
