// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyResponseBody : TeaModel {
        /// <summary>
        /// 请求 RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundApplyResponseBodyData Data { get; set; }
        public class RefundApplyResponseBodyData : TeaModel {
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            [NameInMap("refund_results")]
            [Validation(Required=false)]
            public List<RefundApplyResponseBodyDataRefundResults> RefundResults { get; set; }
            public class RefundApplyResponseBodyDataRefundResults : TeaModel {
                [NameInMap("fail_reason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                [NameInMap("refund_passengers")]
                [Validation(Required=false)]
                public List<RefundApplyResponseBodyDataRefundResultsRefundPassengers> RefundPassengers { get; set; }
                public class RefundApplyResponseBodyDataRefundResultsRefundPassengers : TeaModel {
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
