// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundPreCalResponseBodyModule Module { get; set; }
        public class FlightRefundPreCalResponseBodyModule : TeaModel {
            [NameInMap("flight_change")]
            [Validation(Required=false)]
            public bool? FlightChange { get; set; }

            [NameInMap("item_unit_id")]
            [Validation(Required=false)]
            public string ItemUnitId { get; set; }

            [NameInMap("multi_refund_cal_list")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleMultiRefundCalList> MultiRefundCalList { get; set; }
            public class FlightRefundPreCalResponseBodyModuleMultiRefundCalList : TeaModel {
                [NameInMap("can_apply_refund")]
                [Validation(Required=false)]
                public bool? CanApplyRefund { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            [NameInMap("return_reason")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleReturnReason> ReturnReason { get; set; }
            public class FlightRefundPreCalResponseBodyModuleReturnReason : TeaModel {
                [NameInMap("extend_desc")]
                [Validation(Required=false)]
                public string ExtendDesc { get; set; }

                [NameInMap("person")]
                [Validation(Required=false)]
                public int? Person { get; set; }

                [NameInMap("reason_code")]
                [Validation(Required=false)]
                public int? ReasonCode { get; set; }

                [NameInMap("reason_show")]
                [Validation(Required=false)]
                public string ReasonShow { get; set; }

                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public int? Volunteer { get; set; }

            }

            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
