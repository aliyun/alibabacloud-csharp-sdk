// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeFlightBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IeFlightBillSettlementQueryResponseBodyModule Module { get; set; }
        public class IeFlightBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>corp1</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<IeFlightBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class IeFlightBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("advance_day")]
                [Validation(Required=false)]
                public int? AdvanceDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_corp_code")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                [NameInMap("airline_corp_name")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021123432260</para>
                /// </summary>
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

                /// <summary>
                /// <para>审批扩展自定义字段</para>
                /// </summary>
                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>103189557</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAN</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_country")]
                [Validation(Required=false)]
                public string ArrCountry { get; set; }

                [NameInMap("arr_country_code")]
                [Validation(Required=false)]
                public string ArrCountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-02</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13:30:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-23T20:18Z</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-01 00:17:05</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>al_xinuan.zsy</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70022164</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("btrip_coupon_fee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>R</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.0</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>460</para>
                /// </summary>
                [NameInMap("corp_pay_order_fee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8b7f3cd-24324-097</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                [NameInMap("deductible_tax")]
                [Validation(Required=false)]
                public double? DeductibleTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KHN</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_country")]
                [Validation(Required=false)]
                public string DepCountry { get; set; }

                [NameInMap("dep_country_code")]
                [Validation(Required=false)]
                public string DepCountryCode { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2345866</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("dept_city")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-02</para>
                /// </summary>
                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>51%</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20101</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU9684</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4564547</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("insurance_fee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15548214852</para>
                /// </summary>
                [NameInMap("insurance_number")]
                [Validation(Required=false)]
                public string InsuranceNumber { get; set; }

                [NameInMap("insurance_product_name")]
                [Validation(Required=false)]
                public string InsuranceProductName { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-01 00:17:13</para>
                /// </summary>
                [NameInMap("most_difference_dept_time")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23%</para>
                /// </summary>
                [NameInMap("most_difference_discount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU9684</para>
                /// </summary>
                [NameInMap("most_difference_flight_no")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("most_difference_price")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                [NameInMap("most_difference_reason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("most_price")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("negotiation_coupon_fee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234223423423</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234324324423</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4564547</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23423432423</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("refund_change_cost")]
                [Validation(Required=false)]
                public double? RefundChangeCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                [NameInMap("refund_result")]
                [Validation(Required=false)]
                public string RefundResult { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("repeat_refund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>410</para>
                /// </summary>
                [NameInMap("seal_price")]
                [Validation(Required=false)]
                public double? SealPrice { get; set; }

                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public string SegmentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6.11</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-08 23:39:01</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123123232</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>125.6</para>
                /// </summary>
                [NameInMap("tax_fee")]
                [Validation(Required=false)]
                public double? TaxFee { get; set; }

                /// <summary>
                /// <para>税率</para>
                /// 
                /// <b>Example:</b>
                /// <para>6%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>781-6586234234324</para>
                /// </summary>
                [NameInMap("ticket_id")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAN-KUL-BKK</para>
                /// </summary>
                [NameInMap("trade")]
                [Validation(Required=false)]
                public string Trade { get; set; }

                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>54463464</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>326246</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

                [NameInMap("voyage_name")]
                [Validation(Required=false)]
                public string VoyageName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-14</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-13</para>
            /// </summary>
            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1402</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210e842b16611337974412836dae27</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
