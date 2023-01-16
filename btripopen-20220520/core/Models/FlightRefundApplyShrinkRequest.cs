// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyShrinkRequest : TeaModel {
        [NameInMap("corp_refund_price")]
        [Validation(Required=false)]
        public long? CorpRefundPrice { get; set; }

        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        [NameInMap("display_refund_money")]
        [Validation(Required=false)]
        public string DisplayRefundMoney { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        [NameInMap("item_unit_ids")]
        [Validation(Required=false)]
        public string ItemUnitIds { get; set; }

        [NameInMap("passenger_segment_info_list")]
        [Validation(Required=false)]
        public string PassengerSegmentInfoListShrink { get; set; }

        [NameInMap("personal_refund_price")]
        [Validation(Required=false)]
        public long? PersonalRefundPrice { get; set; }

        [NameInMap("reason_detail")]
        [Validation(Required=false)]
        public string ReasonDetail { get; set; }

        [NameInMap("reason_type")]
        [Validation(Required=false)]
        public int? ReasonType { get; set; }

        [NameInMap("refund_voucher_info")]
        [Validation(Required=false)]
        public string RefundVoucherInfoShrink { get; set; }

        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

    }

}
