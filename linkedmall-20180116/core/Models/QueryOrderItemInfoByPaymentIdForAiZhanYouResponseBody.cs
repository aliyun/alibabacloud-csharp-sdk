// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LmOrderList")]
        [Validation(Required=false)]
        public QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseBodyLmOrderListLmOrderList : TeaModel {
                public long? LmOrderId { get; set; }
                public string ItemName { get; set; }
                public string SkuName { get; set; }
                public long? SkuId { get; set; }
                public string LmItemId { get; set; }
                public long? ItemId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
