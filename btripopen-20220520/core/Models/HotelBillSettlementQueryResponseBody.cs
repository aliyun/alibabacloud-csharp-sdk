// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        public HotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class HotelBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category of the data.</para>
            /// <list type="bullet">
            /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
            /// </list>
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
            /// <para>btripiws********12ofjm</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<HotelBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class HotelBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                /// <summary>
                /// <para>The adjustment time in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

                /// <summary>
                /// <para>The negotiated rate discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.5</para>
                /// </summary>
                [NameInMap("agreement_promotion_fee")]
                [Validation(Required=false)]
                public double? AgreementPromotionFee { get; set; }

                /// <summary>
                /// <para>The payment serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>234432432</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <para>The applied arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MDG</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                /// <summary>
                /// <para>The applied arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>牡丹江</para>
                /// </summary>
                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <para>The applied departure city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HRB</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                /// <summary>
                /// <para>The applied departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>哈尔滨</para>
                /// </summary>
                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                /// <summary>
                /// <para>The approval extended custom field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;memo&quot;:&quot;备注&quot;}</para>
                /// </summary>
                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <para>The approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103208648</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The approver email address.</para>
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
                /// <para>zhangsan</para>
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
                public string AverageNights { get; set; }

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
                /// <para>The billing time.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm\\&quot;Z\\&quot;</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01T10:40Z</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <para>The invoicing entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江阿里商旅旅行社有限公司余杭分公司</para>
                /// </summary>
                [NameInMap("billing_entity")]
                [Validation(Required=false)]
                public string BillingEntity { get; set; }

                /// <summary>
                /// <para>The booking channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>移动端</para>
                /// </summary>
                [NameInMap("book_channel")]
                [Validation(Required=false)]
                public string BookChannel { get; set; }

                /// <summary>
                /// <para>The booking type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Online (self-service booking)</description></item>
                /// <item><description>Online (inquiry order)</description></item>
                /// <item><description>Offline agent booking</description></item>
                /// <item><description>Flexible booking</description></item>
                /// <item><description>Agent-assisted booking</description></item>
                /// <item><description>Offline order import</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>线上（自助预订）</para>
                /// </summary>
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                /// <summary>
                /// <para>The reason for booking at a non-negotiated rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX原因</para>
                /// </summary>
                [NameInMap("book_reason")]
                [Validation(Required=false)]
                public string BookReason { get; set; }

                /// <summary>
                /// <para>The booking time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01 00:17:05</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <para>The user_id of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_1234</para>
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
                /// <para>XXX集团</para>
                /// </summary>
                [NameInMap("brand_group")]
                [Validation(Required=false)]
                public string BrandGroup { get; set; }

                /// <summary>
                /// <para>The hotel brand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                /// <summary>
                /// <para>The custom budget number.</para>
                /// </summary>
                [NameInMap("budget_number")]
                [Validation(Required=false)]
                public string BudgetNumber { get; set; }

                /// <summary>
                /// <para>The custom business trip reason.</para>
                /// </summary>
                [NameInMap("business_reason")]
                [Validation(Required=false)]
                public string BusinessReason { get; set; }

                /// <summary>
                /// <para>The business trip reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>因公司要求，需要到XX同XX公司谈业务</para>
                /// </summary>
                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                /// <summary>
                /// <para>The cancellation/modification reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>退房</para>
                /// </summary>
                [NameInMap("cancel_or_modify_reason")]
                [Validation(Required=false)]
                public string CancelOrModifyReason { get; set; }

                /// <summary>
                /// <para>The cancellation/modification scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>提前离店</para>
                /// </summary>
                [NameInMap("cancel_or_modify_scene")]
                [Validation(Required=false)]
                public string CancelOrModifyScene { get; set; }

                /// <summary>
                /// <para>The capital direction.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// <para>The cascading department hierarchy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三-营运部-北方营运大区</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value description - category</a>.
                /// [_single.resp.200.props.module.data_list.items</description></item>
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
                /// <para>2021-10-14 00:00:00</para>
                /// </summary>
                [NameInMap("check_in_date")]
                [Validation(Required=false)]
                public string CheckInDate { get; set; }

                /// <summary>
                /// <para>The check-out time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-16 00:00:00</para>
                /// </summary>
                [NameInMap("checkout_date")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                /// <summary>
                /// <para>The check-in city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京市</para>
                /// </summary>
                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The check-in city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The check-in county-level city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX区</para>
                /// </summary>
                [NameInMap("city_county")]
                [Validation(Required=false)]
                public string CityCounty { get; set; }

                /// <summary>
                /// <para>The check-in county-level city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("city_county_code")]
                [Validation(Required=false)]
                public string CityCountyCode { get; set; }

                /// <summary>
                /// <para>The enterprise refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("corp_refund_fee")]
                [Validation(Required=false)]
                public double? CorpRefundFee { get; set; }

                /// <summary>
                /// <para>The enterprise payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("corp_total_fee")]
                [Validation(Required=false)]
                public double? CorpTotalFee { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三有限公司</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8b7f3cd-24324-097</para>
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
                /// <para>The custom approval order number.</para>
                /// </summary>
                [NameInMap("custom_apply_id")]
                [Validation(Required=false)]
                public string CustomApplyId { get; set; }

                /// <summary>
                /// <para>The custom attributes of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;key1\&quot;:\&quot;value1\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;,\&quot;key3\&quot;:\&quot;value3\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("custom_content")]
                [Validation(Required=false)]
                public string CustomContent { get; set; }

                /// <summary>
                /// <para>The estimated deductible tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("deductible_tax")]
                [Validation(Required=false)]
                public double? DeductibleTax { get; set; }

                /// <summary>
                /// <para>The leaf-level department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三大区</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>部门id</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The reason for exceeding the standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无低价机票，故超标购买</para>
                /// </summary>
                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                /// <summary>
                /// <para>The custom external traveler type.</para>
                /// </summary>
                [NameInMap("external_person_type")]
                [Validation(Required=false)]
                public string ExternalPersonType { get; set; }

                /// <summary>
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20101</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API Enumeration Value Description - fee_type</a>.</description></item>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("fees")]
                [Validation(Required=false)]
                public double? Fees { get; set; }

                /// <summary>
                /// <para>The penalty amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1</para>
                /// </summary>
                [NameInMap("fines")]
                [Validation(Required=false)]
                public double? Fines { get; set; }

                /// <summary>
                /// <para>The overseas employee identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("foreigners_tag")]
                [Validation(Required=false)]
                public string ForeignersTag { get; set; }

                /// <summary>
                /// <para>The Fu-point payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("fu_point_fee")]
                [Validation(Required=false)]
                public double? FuPointFee { get; set; }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>全季北京广渠路酒店(Season Beijing guangqu road branch)</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50****8</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <para>The insurance policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>P15548214852</para>
                /// </summary>
                [NameInMap("insurance_number")]
                [Validation(Required=false)]
                public string InsuranceNumber { get; set; }

                /// <summary>
                /// <para>The insurance fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.00</para>
                /// </summary>
                [NameInMap("insurance_price")]
                [Validation(Required=false)]
                public double? InsurancePrice { get; set; }

                /// <summary>
                /// <para>The insurance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人身意外险</para>
                /// </summary>
                [NameInMap("insurance_product_name")]
                [Validation(Required=false)]
                public string InsuranceProductName { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三有限公司</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>Indicates whether the guest checked out early.</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
                /// </summary>
                [NameInMap("is_early_departure")]
                [Validation(Required=false)]
                public string IsEarlyDeparture { get; set; }

                /// <summary>
                /// <para>Indicates whether the rate is a negotiated rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
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
                /// <para>上海</para>
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
                /// <para>The reason for not booking in advance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX原因</para>
                /// </summary>
                [NameInMap("no_advance_booking_reason")]
                [Validation(Required=false)]
                public string NoAdvanceBookingReason { get; set; }

                /// <summary>
                /// <para>The business travel order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002************464</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1088.96</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                /// <summary>
                /// <para>The order type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>预付</para>
                /// </summary>
                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The original travel standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("original_reserve_rule")]
                [Validation(Required=false)]
                public string OriginalReserveRule { get; set; }

                /// <summary>
                /// <para>The over-standard approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4234324</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <para>The ID of the cost-bearing department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202300000</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <para>The name of the cost-bearing department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试二部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The personal refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("person_refund_fee")]
                [Validation(Required=false)]
                public double? PersonRefundFee { get; set; }

                /// <summary>
                /// <para>The personal settlement fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88.96</para>
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
                /// <para>The primary key ID. If duplicate IDs exist, the latest record takes precedence (data may be updated).</para>
                /// 
                /// <b>Example:</b>
                /// <para>50****18</para>
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
                /// <para>223423432</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三生产-张三自制线-公共</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The coupon amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113.02</para>
                /// </summary>
                [NameInMap("promotion_fee")]
                [Validation(Required=false)]
                public double? PromotionFee { get; set; }

                /// <summary>
                /// <para>The recovery receipt amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.2</para>
                /// </summary>
                [NameInMap("recover_money_receipt_amt")]
                [Validation(Required=false)]
                public double? RecoverMoneyReceiptAmt { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>线下改签</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The travel standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reserve_rule")]
                [Validation(Required=false)]
                public string ReserveRule { get; set; }

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
                /// <para>2</para>
                /// </summary>
                [NameInMap("room_number")]
                [Validation(Required=false)]
                public int? RoomNumber { get; set; }

                /// <summary>
                /// <para>The room price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1201.98</para>
                /// </summary>
                [NameInMap("room_price")]
                [Validation(Required=false)]
                public double? RoomPrice { get; set; }

                /// <summary>
                /// <para>The room type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>零压高级大床房-(提前1天预订)(限内宾)(大床)含双早</para>
                /// </summary>
                [NameInMap("room_type")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("scene_id")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The scenario name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>福利</para>
                /// </summary>
                [NameInMap("scene_name")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>The service fee. Displayed only for feeType 20111 and 20112.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API Enumeration Value Description - settlement_type</a>.</description></item>
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
                /// <para>1000</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <para>The settlement amount - prepaid complimentary portion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.68</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <para>The settlement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-12 23:58:56</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <para>The settlement type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <para>sio</para>
                /// 
                /// <b>Example:</b>
                /// <para>sio</para>
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
                /// <para>The billing status.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The billing status description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API Enumeration Value Description - status</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>入账成功</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The tax rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AB0-CDE-1-F-1234567891011</para>
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
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API Enumeration Value Description - capital_direction</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>支出</para>
                /// </summary>
                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <para>The traveler email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@gmail.com">123@gmail.com</a></para>
                /// </summary>
                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                /// <summary>
                /// <para>The user_id of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出行人用户id</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>326246</para>
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
                /// <para>The traveler type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内部/外部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                /// <summary>
                /// <para>The name of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// <para>The reason for not booking the lowest price for the same room type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX原因</para>
                /// </summary>
                [NameInMap("unbooked_lowest_price_reason")]
                [Validation(Required=false)]
                public string UnbookedLowestPriceReason { get; set; }

                /// <summary>
                /// <para>The voucher type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value description</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                /// <summary>
                /// <para>The voucher type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enumeration value description - voucher_type</a>.</description></item>
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
            /// <para>The end time for the billing data query.</para>
            /// <list type="bullet">
            /// <item><description>Time format: <c>yyyy-MM-dd</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000-01-02</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <para>The start time for the billing data query.</para>
            /// <list type="bullet">
            /// <item><description>Time format: <c>yyyy-MM-dd</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000-01-01</para>
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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

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
        /// <para>Indicates whether the request is successful.</para>
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
        /// <para>210bcc3a********d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
