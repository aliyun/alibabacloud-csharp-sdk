// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class HotelBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<HotelBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class HotelBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("check_in_date")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                [NameInMap("checkout_date")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("corp_refund_fee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                [NameInMap("corp_total_fee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                [NameInMap("fu_point_fee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("is_negotiation")]
                [Validation(Required=false)]
                public string IsNegotiation { get; set; }

                [NameInMap("is_share_str")]
                [Validation(Required=false)]
                public string IsShareStr { get; set; }

                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("person_refund_fee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("promotion_fee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("room_number")]
                [Validation(Required=false)]
                public int? RoomNumber { get; set; }

                [NameInMap("room_price")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                [NameInMap("room_type")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("total_nights")]
                [Validation(Required=false)]
                public int? TotalNights { get; set; }

                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

            }

            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
