// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderDetailQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealOrderDetailQueryResponseBodyModule Module { get; set; }
        public class MealOrderDetailQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("corp_code_order_id")]
            [Validation(Required=false)]
            public string CorpCodeOrderId { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_pay_amount")]
            [Validation(Required=false)]
            public long? CorpPayAmount { get; set; }

            [NameInMap("corp_refund_amount")]
            [Validation(Required=false)]
            public long? CorpRefundAmount { get; set; }

            [NameInMap("merchant_name")]
            [Validation(Required=false)]
            public string MerchantName { get; set; }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("order_sub_status")]
            [Validation(Required=false)]
            public int? OrderSubStatus { get; set; }

            [NameInMap("order_type")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("pay_amount")]
            [Validation(Required=false)]
            public long? PayAmount { get; set; }

            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            [NameInMap("person_pay_amount")]
            [Validation(Required=false)]
            public long? PersonPayAmount { get; set; }

            [NameInMap("person_refund_amount")]
            [Validation(Required=false)]
            public long? PersonRefundAmount { get; set; }

            [NameInMap("refund_amount")]
            [Validation(Required=false)]
            public long? RefundAmount { get; set; }

            [NameInMap("scene_name")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            [NameInMap("user_alipay_id")]
            [Validation(Required=false)]
            public string UserAlipayId { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
