// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundPreCalV2ResponseBodyModule Module { get; set; }
        public class FlightRefundPreCalV2ResponseBodyModule : TeaModel {
            [NameInMap("multi_refund_fee_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS> MultiRefundFeeDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS : TeaModel {
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                [NameInMap("refund_charge_fee")]
                [Validation(Required=false)]
                public long? RefundChargeFee { get; set; }

            }

            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            [NameInMap("refund_charge_fee")]
            [Validation(Required=false)]
            public long? RefundChargeFee { get; set; }

            [NameInMap("refund_reason_option_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS> RefundReasonOptionDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS : TeaModel {
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public bool? Volunteer { get; set; }

            }

            [NameInMap("service_charge_fee")]
            [Validation(Required=false)]
            public long? ServiceChargeFee { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
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
