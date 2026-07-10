// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyV2Request : TeaModel {
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightRefundApplyV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightRefundApplyV2RequestPassengerSegmentRelations : TeaModel {
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        [NameInMap("pre_cal_type")]
        [Validation(Required=false)]
        public int? PreCalType { get; set; }

        [NameInMap("refund_reason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        [NameInMap("refund_reason_type")]
        [Validation(Required=false)]
        public int? RefundReasonType { get; set; }

        [NameInMap("ticket_nos")]
        [Validation(Required=false)]
        public List<string> TicketNos { get; set; }

        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

        [NameInMap("upload_pict_urls")]
        [Validation(Required=false)]
        public string UploadPictUrls { get; set; }

        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
