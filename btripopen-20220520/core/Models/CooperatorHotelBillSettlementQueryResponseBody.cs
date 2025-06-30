// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorHotelBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CooperatorHotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CooperatorHotelBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>open12ilgngll7us7v10Bm5UlMg700</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CooperatorHotelBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class CooperatorHotelBillSettlementQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>124</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sdasdas123324</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("average_nights")]
                [Validation(Required=false)]
                public double? AverageNights { get; set; }

                [NameInMap("base_location")]
                [Validation(Required=false)]
                public string BaseLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_channel")]
                [Validation(Required=false)]
                public string BookChannel { get; set; }

                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                [NameInMap("book_reason")]
                [Validation(Required=false)]
                public string BookReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zs123</para>
                /// </summary>
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

                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

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
                /// <para>2024-02-13</para>
                /// </summary>
                [NameInMap("check_in_date")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-15</para>
                /// </summary>
                [NameInMap("checkout_date")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_county")]
                [Validation(Required=false)]
                public string CityCounty { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_county_code")]
                [Validation(Required=false)]
                public int? CityCountyCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IN240102113438277278</para>
                /// </summary>
                [NameInMap("cooperator_bill_code")]
                [Validation(Required=false)]
                public string CooperatorBillCode { get; set; }

                [NameInMap("cooperator_name")]
                [Validation(Required=false)]
                public string CooperatorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HO20240125162800280928</para>
                /// </summary>
                [NameInMap("cooperator_order_id")]
                [Validation(Required=false)]
                public string CooperatorOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("corp_refund_fee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_total_fee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("cost_department")]
                [Validation(Required=false)]
                public string CostDepartment { get; set; }

                [NameInMap("custom_content")]
                [Validation(Required=false)]
                public string CustomContent { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("fines")]
                [Validation(Required=false)]
                public double? Fines { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("fu_point_fee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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

                [NameInMap("mapping_company_code")]
                [Validation(Required=false)]
                public string MappingCompanyCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("person_refund_fee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("position_level")]
                [Validation(Required=false)]
                public string PositionLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72328485</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("processor_oa_code")]
                [Validation(Required=false)]
                public string ProcessorOaCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("promotion_fee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reserve_rule")]
                [Validation(Required=false)]
                public int? ReserveRule { get; set; }

                [NameInMap("room_no")]
                [Validation(Required=false)]
                public string RoomNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_number")]
                [Validation(Required=false)]
                public int? RoomNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>105.0</para>
                /// </summary>
                [NameInMap("room_price")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                [NameInMap("room_type")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110.0</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>166564408</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("total_nights")]
                [Validation(Required=false)]
                public int? TotalNights { get; set; }

                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zs123</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

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
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
