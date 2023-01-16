// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingApplyResponseBodyModule Module { get; set; }
        public class TicketChangingApplyResponseBodyModule : TeaModel {
            [NameInMap("booking_changed_total_fee")]
            [Validation(Required=false)]
            public int? BookingChangedTotalFee { get; set; }

            [NameInMap("booking_origin_total_fee")]
            [Validation(Required=false)]
            public int? BookingOriginTotalFee { get; set; }

            [NameInMap("booking_price_changed")]
            [Validation(Required=false)]
            public bool? BookingPriceChanged { get; set; }

            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            [NameInMap("can_pay")]
            [Validation(Required=false)]
            public bool? CanPay { get; set; }

            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public long? ChangeFee { get; set; }

            [NameInMap("deadline_time")]
            [Validation(Required=false)]
            public string DeadlineTime { get; set; }

            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            [NameInMap("max_retry_times")]
            [Validation(Required=false)]
            public int? MaxRetryTimes { get; set; }

            [NameInMap("next_retry_interval")]
            [Validation(Required=false)]
            public long? NextRetryInterval { get; set; }

            [NameInMap("retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            [NameInMap("retry_client_tips")]
            [Validation(Required=false)]
            public string RetryClientTips { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("upgrade_fee")]
            [Validation(Required=false)]
            public long? UpgradeFee { get; set; }

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
