// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderListQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealOrderListQueryResponseBodyModule Module { get; set; }
        public class MealOrderListQueryResponseBodyModule : TeaModel {
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<MealOrderListQueryResponseBodyModuleOrderList> OrderList { get; set; }
            public class MealOrderListQueryResponseBodyModuleOrderList : TeaModel {
                [NameInMap("corp_pay_amount")]
                [Validation(Required=false)]
                public long? CorpPayAmount { get; set; }

                [NameInMap("merchant_name")]
                [Validation(Required=false)]
                public string MerchantName { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("pay_amount")]
                [Validation(Required=false)]
                public long? PayAmount { get; set; }

                [NameInMap("person_pay_amount")]
                [Validation(Required=false)]
                public long? PersonPayAmount { get; set; }

                [NameInMap("settle_time")]
                [Validation(Required=false)]
                public string SettleTime { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
