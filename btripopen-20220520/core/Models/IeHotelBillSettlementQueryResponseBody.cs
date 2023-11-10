// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeHotelBillSettlementQueryResponseBody : TeaModel {
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
        public IeHotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class IeHotelBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<IeHotelBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class IeHotelBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("amount_currency")]
                [Validation(Required=false)]
                public string AmountCurrency { get; set; }

                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("average_nights")]
                [Validation(Required=false)]
                public double? AverageNights { get; set; }

                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_reason")]
                [Validation(Required=false)]
                public string BookReason { get; set; }

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

                [NameInMap("brand_group")]
                [Validation(Required=false)]
                public string BrandGroup { get; set; }

                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                [NameInMap("business_expense")]
                [Validation(Required=false)]
                public long? BusinessExpense { get; set; }

                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

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

                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fines")]
                [Validation(Required=false)]
                public double? Fines { get; set; }

                [NameInMap("foreign_business_expense")]
                [Validation(Required=false)]
                public long? ForeignBusinessExpense { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_star")]
                [Validation(Required=false)]
                public string HotelStar { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("is_early_departure")]
                [Validation(Required=false)]
                public string IsEarlyDeparture { get; set; }

                [NameInMap("is_negotiation")]
                [Validation(Required=false)]
                public string IsNegotiation { get; set; }

                [NameInMap("is_share_str")]
                [Validation(Required=false)]
                public string IsShareStr { get; set; }

                [NameInMap("main_apply_id")]
                [Validation(Required=false)]
                public string MainApplyId { get; set; }

                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

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

                [NameInMap("rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("reserve_rule")]
                [Validation(Required=false)]
                public int? ReserveRule { get; set; }

                [NameInMap("room_no")]
                [Validation(Required=false)]
                public string RoomNo { get; set; }

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

                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                [NameInMap("third_part_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("total_nights")]
                [Validation(Required=false)]
                public int? TotalNights { get; set; }

                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

            }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
