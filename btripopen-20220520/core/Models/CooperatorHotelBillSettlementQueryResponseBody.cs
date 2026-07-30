// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorHotelBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result details.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public CooperatorHotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CooperatorHotelBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open12ilgn********m5UlMg700</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The data collection.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CooperatorHotelBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class CooperatorHotelBillSettlementQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The adjustment time in the format yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>124</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <para>The applied arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                /// <summary>
                /// <para>The applied arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西安</para>
                /// </summary>
                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <para>The applied departure city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                /// <summary>
                /// <para>The applied departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                /// <summary>
                /// <para>The approval extended custom field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <para>The approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sdasdas123324</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The email address of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@gmail.com">123@gmail.com</a></para>
                /// </summary>
                [NameInMap("approver_email")]
                [Validation(Required=false)]
                public string ApproverEmail { get; set; }

                /// <summary>
                /// <para>The approver ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("approver_id")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                /// <summary>
                /// <para>The approver name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("approver_name")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                /// <summary>
                /// <para>The average number of room nights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("average_nights")]
                [Validation(Required=false)]
                public double? AverageNights { get; set; }

                /// <summary>
                /// <para>The work location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("base_location")]
                [Validation(Required=false)]
                public string BaseLocation { get; set; }

                /// <summary>
                /// <para>The recording time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <para>The booking channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PC端</para>
                /// </summary>
                [NameInMap("book_channel")]
                [Validation(Required=false)]
                public string BookChannel { get; set; }

                /// <summary>
                /// <para>The booking type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>线上预定</para>
                /// </summary>
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                /// <summary>
                /// <para>The reason for booking at a non-negotiated rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("book_reason")]
                [Validation(Required=false)]
                public string BookReason { get; set; }

                /// <summary>
                /// <para>The booking time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <para>The booker ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The booker employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zs123</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                /// <summary>
                /// <para>The name of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <para>The hotel group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>万豪</para>
                /// </summary>
                [NameInMap("brand_group")]
                [Validation(Required=false)]
                public string BrandGroup { get; set; }

                /// <summary>
                /// <para>The hotel brand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>万豪</para>
                /// </summary>
                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                /// <summary>
                /// <para>The business trip purpose.</para>
                /// 
                /// <b>Example:</b>
                /// <para>采购</para>
                /// </summary>
                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                /// <summary>
                /// <para>The capital direction.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>支出</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// <para>The cascading department hierarchy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>技术部-开发部</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - category</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>国内酒店</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The check-in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-13</para>
                /// </summary>
                [NameInMap("check_in_date")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                /// <summary>
                /// <para>The check-out time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-15</para>
                /// </summary>
                [NameInMap("checkout_date")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                /// <summary>
                /// <para>The check-in city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西安</para>
                /// </summary>
                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The check-in county-level city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西安</para>
                /// </summary>
                [NameInMap("city_county")]
                [Validation(Required=false)]
                public string CityCounty { get; set; }

                /// <summary>
                /// <para>The check-in county-level city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_county_code")]
                [Validation(Required=false)]
                public int? CityCountyCode { get; set; }

                /// <summary>
                /// <para>The service provider bill code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN240102113438277278</para>
                /// </summary>
                [NameInMap("cooperator_bill_code")]
                [Validation(Required=false)]
                public string CooperatorBillCode { get; set; }

                /// <summary>
                /// <para>The service provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里商旅</para>
                /// </summary>
                [NameInMap("cooperator_name")]
                [Validation(Required=false)]
                public string CooperatorName { get; set; }

                /// <summary>
                /// <para>The service provider order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO20240125162800280928</para>
                /// </summary>
                [NameInMap("cooperator_order_id")]
                [Validation(Required=false)]
                public string CooperatorOrderId { get; set; }

                /// <summary>
                /// <para>The enterprise refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("corp_refund_fee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                /// <summary>
                /// <para>The total enterprise payment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_total_fee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The CW code of the cost-bearing department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code1</para>
                /// </summary>
                [NameInMap("cost_department")]
                [Validation(Required=false)]
                public string CostDepartment { get; set; }

                /// <summary>
                /// <para>The traveler custom attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;key1\&quot;:\&quot;value1\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;,\&quot;key3\&quot;:\&quot;value3\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("custom_content")]
                [Validation(Required=false)]
                public string CustomContent { get; set; }

                /// <summary>
                /// <para>The leaf-level department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The reason for exceeding the travel policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                /// <summary>
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>酒店预订</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - fee_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>赔付</para>
                /// </summary>
                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                /// <summary>
                /// <para>The miscellaneous fees.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                /// <summary>
                /// <para>The penalty amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("fines")]
                [Validation(Required=false)]
                public double? Fines { get; set; }

                /// <summary>
                /// <para>The overseas employee identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("foreigners_tag")]
                [Validation(Required=false)]
                public string ForeignersTag { get; set; }

                /// <summary>
                /// <para>The Fu-point payment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("fu_point_fee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅酒店</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>Indicates whether the guest departed early.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("is_early_departure")]
                [Validation(Required=false)]
                public string IsEarlyDeparture { get; set; }

                /// <summary>
                /// <para>Indicates whether the rate is a negotiated rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("is_negotiation")]
                [Validation(Required=false)]
                public string IsNegotiation { get; set; }

                /// <summary>
                /// <para>Indicates whether the room is shared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("is_share_str")]
                [Validation(Required=false)]
                public string IsShareStr { get; set; }

                /// <summary>
                /// <para>Location</para>
                /// 
                /// <b>Example:</b>
                /// <para>新加坡</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The mapping company code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>q1</para>
                /// </summary>
                [NameInMap("mapping_company_code")]
                [Validation(Required=false)]
                public string MappingCompanyCode { get; set; }

                /// <summary>
                /// <para>The number of nights stayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                /// <summary>
                /// <para>The order ID or Fu-point issuance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                /// <summary>
                /// <para>The order status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>预订成功</para>
                /// </summary>
                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <para>The order type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>面付</para>
                /// </summary>
                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The excess approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <para>The cost-bearing department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <para>The cost-bearing department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The personal refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("person_refund_fee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                /// <summary>
                /// <para>The personal payment for excess and miscellaneous fees.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                /// <summary>
                /// <para>The position.</para>
                /// 
                /// <b>Example:</b>
                /// <para>开发</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <para>The position level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>初级</para>
                /// </summary>
                [NameInMap("position_level")]
                [Validation(Required=false)]
                public string PositionLevel { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72328485</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <para>The OA account of the processor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>www123</para>
                /// </summary>
                [NameInMap("processor_oa_code")]
                [Validation(Required=false)]
                public string ProcessorOaCode { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目名称</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The coupon amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("promotion_fee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试单</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The travel policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reserve_rule")]
                [Validation(Required=false)]
                public int? ReserveRule { get; set; }

                /// <summary>
                /// <para>The room sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>房间1</para>
                /// </summary>
                [NameInMap("room_no")]
                [Validation(Required=false)]
                public string RoomNo { get; set; }

                /// <summary>
                /// <para>The number of rooms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_number")]
                [Validation(Required=false)]
                public int? RoomNumber { get; set; }

                /// <summary>
                /// <para>The room price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>105.0</para>
                /// </summary>
                [NameInMap("room_price")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                /// <summary>
                /// <para>The room type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大床房</para>
                /// </summary>
                [NameInMap("room_type")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                /// <summary>
                /// <para>The service fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - settlement_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>企业月结</para>
                /// </summary>
                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                /// <summary>
                /// <para>The settlement amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110.0</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <para>The complimentary portion of the settlement amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <para>The settlement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <para>The settlement type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>企业月结</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <para>SIO</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIO</para>
                /// </summary>
                [NameInMap("sio")]
                [Validation(Required=false)]
                public string Sio { get; set; }

                /// <summary>
                /// <para>The hotel star rating.</para>
                /// 
                /// <b>Example:</b>
                /// <para>一星级</para>
                /// </summary>
                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <para>The recording status.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The recording status description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - status</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>入账成功</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The sub-order ID (currently available for car services).</para>
                /// 
                /// <b>Example:</b>
                /// <para>166564408</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <para>The tax rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <para>The external invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <para>The total number of room nights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("total_nights")]
                [Validation(Required=false)]
                public int? TotalNights { get; set; }

                /// <summary>
                /// <para>The capital direction description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - capital_direction</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>支出</para>
                /// </summary>
                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <para>The email address of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@gmail.com">123@gmail.com</a></para>
                /// </summary>
                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                /// <summary>
                /// <para>The traveler user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The traveler employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zs123</para>
                /// </summary>
                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                /// <summary>
                /// <para>The traveler type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                /// <summary>
                /// <para>The traveler type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                /// <summary>
                /// <para>The traveler name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// <para>The voucher type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                /// <summary>
                /// <para>The voucher type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value descriptions - voucher_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>增值税发票</para>
                /// </summary>
                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

            }

            /// <summary>
            /// <para>The billing end date in the format yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <para>The billing start date in the format yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-13</para>
            /// </summary>
            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            /// <summary>
            /// <para>The scroll ID. In scroll mode, this value can be used as an input parameter for the next query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1qwe</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-<b><b>-</b></b>-****-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
