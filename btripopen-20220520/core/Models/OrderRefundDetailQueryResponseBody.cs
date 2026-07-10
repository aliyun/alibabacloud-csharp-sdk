// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class OrderRefundDetailQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public OrderRefundDetailQueryResponseBodyModule Module { get; set; }
        public class OrderRefundDetailQueryResponseBodyModule : TeaModel {
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("refund_details")]
            [Validation(Required=false)]
            public List<OrderRefundDetailQueryResponseBodyModuleRefundDetails> RefundDetails { get; set; }
            public class OrderRefundDetailQueryResponseBodyModuleRefundDetails : TeaModel {
                [NameInMap("person_pay_channel")]
                [Validation(Required=false)]
                public string PersonPayChannel { get; set; }

                [NameInMap("person_refund_id")]
                [Validation(Required=false)]
                public string PersonRefundId { get; set; }

                [NameInMap("refund_amount")]
                [Validation(Required=false)]
                public long? RefundAmount { get; set; }

                [NameInMap("refund_amount_corp")]
                [Validation(Required=false)]
                public long? RefundAmountCorp { get; set; }

                [NameInMap("refund_amount_person")]
                [Validation(Required=false)]
                public long? RefundAmountPerson { get; set; }

                [NameInMap("supplier_refund_id")]
                [Validation(Required=false)]
                public string SupplierRefundId { get; set; }

            }

            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
