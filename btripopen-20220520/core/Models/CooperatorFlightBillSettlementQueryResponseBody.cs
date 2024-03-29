// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorFlightBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CooperatorFlightBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CooperatorFlightBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CooperatorFlightBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class CooperatorFlightBillSettlementQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("advance_day")]
                [Validation(Required=false)]
                public int? AdvanceDay { get; set; }

                [NameInMap("airline_corp_code")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                [NameInMap("airline_corp_name")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                [NameInMap("alipay_id")]
                [Validation(Required=false)]
                public string AlipayId { get; set; }

                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

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

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

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

                [NameInMap("btrip_coupon_fee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                [NameInMap("build_fee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                [NameInMap("cooperator_bill_code")]
                [Validation(Required=false)]
                public string CooperatorBillCode { get; set; }

                [NameInMap("cooperator_name")]
                [Validation(Required=false)]
                public string CooperatorName { get; set; }

                [NameInMap("cooperator_order_id")]
                [Validation(Required=false)]
                public string CooperatorOrderId { get; set; }

                [NameInMap("corp_pay_order_fee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

                [NameInMap("corp_settle_price")]
                [Validation(Required=false)]
                public double? CorpSettlePrice { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("dept_city")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                [NameInMap("insurance_fee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                [NameInMap("insurance_number")]
                [Validation(Required=false)]
                public string InsuranceNumber { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("item_type")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                [NameInMap("itinerary_num")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                [NameInMap("itinerary_price")]
                [Validation(Required=false)]
                public double? ItineraryPrice { get; set; }

                [NameInMap("mileage")]
                [Validation(Required=false)]
                public int? Mileage { get; set; }

                [NameInMap("most_difference_dept_time")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                [NameInMap("most_difference_discount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                [NameInMap("most_difference_flight_no")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                [NameInMap("most_difference_price")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                [NameInMap("most_difference_reason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                [NameInMap("most_price")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                [NameInMap("negotiation_coupon_fee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

                [NameInMap("oil_fee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                [NameInMap("pre_book_tip")]
                [Validation(Required=false)]
                public string PreBookTip { get; set; }

                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                [NameInMap("refund_result")]
                [Validation(Required=false)]
                public string RefundResult { get; set; }

                [NameInMap("refund_upgrade_cost")]
                [Validation(Required=false)]
                public double? RefundUpgradeCost { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("repeat_refund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                [NameInMap("seal_price")]
                [Validation(Required=false)]
                public double? SealPrice { get; set; }

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

                [NameInMap("ticket_id")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                [NameInMap("trade")]
                [Validation(Required=false)]
                public string Trade { get; set; }

                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("upgrade_cost")]
                [Validation(Required=false)]
                public double? UpgradeCost { get; set; }

                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                [NameInMap("voyage_name")]
                [Validation(Required=false)]
                public string VoyageName { get; set; }

            }

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

        /// <summary>
        /// trace_id
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
