// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorFlightBillSettlementQueryResponseBody : TeaModel {
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
        /// <para>The response message.</para>
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
        public CooperatorFlightBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CooperatorFlightBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category of the data.</para>
            /// <list type="bullet">
            /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CooperatorFlightBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class CooperatorFlightBillSettlementQueryResponseBodyModuleItems : TeaModel {
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
                /// <para>The number of days booked in advance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("advance_day")]
                [Validation(Required=false)]
                public int? AdvanceDay { get; set; }

                /// <summary>
                /// <para>The airline two-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AB</para>
                /// </summary>
                [NameInMap("airline_corp_code")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                /// <summary>
                /// <para>The airline name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国航空</para>
                /// </summary>
                [NameInMap("airline_corp_name")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                /// <summary>
                /// <para>The Alipay PID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123aaa</para>
                /// </summary>
                [NameInMap("alipay_id")]
                [Validation(Required=false)]
                public string AlipayId { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a123</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <para>The arrival city code specified in the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CD</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name specified in the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>成都</para>
                /// </summary>
                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <para>The departure city code specified in the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AB</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city name specified in the application.</para>
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
                /// <para>1004430880</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The email address of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:abc@123.com">abc@123.com</a></para>
                /// </summary>
                [NameInMap("approver_email")]
                [Validation(Required=false)]
                public string ApproverEmail { get; set; }

                /// <summary>
                /// <para>The ID of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("approver_id")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                /// <summary>
                /// <para>The name of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("approver_name")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                /// <summary>
                /// <para>The arrival airport three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CKG</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>成都</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city code (six-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>成都双流国际机场</para>
                /// </summary>
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

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
                /// <para>The original ticket number before rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>012-002145</para>
                /// </summary>
                [NameInMap("before_ticket_no")]
                [Validation(Required=false)]
                public string BeforeTicketNo { get; set; }

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
                /// <para>移动端</para>
                /// </summary>
                [NameInMap("book_channel")]
                [Validation(Required=false)]
                public string BookChannel { get; set; }

                /// <summary>
                /// <para>The booking type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>线上预订</para>
                /// </summary>
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

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
                /// <para>1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The booker employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                /// <summary>
                /// <para>The booker name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <para>The discount amount based on the business travel price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("btrip_coupon_fee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                /// <summary>
                /// <para>The airport construction fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.0</para>
                /// </summary>
                [NameInMap("build_fee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

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
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YS</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class_code")]
                [Validation(Required=false)]
                public string CabinClassCode { get; set; }

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
                /// <para>技术部-测试部</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - category</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>国内机票</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The flight change fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// <para>The flight change reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>升舱</para>
                /// </summary>
                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                /// <summary>
                /// <para>The service provider bill code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN24010****277278</para>
                /// </summary>
                [NameInMap("cooperator_bill_code")]
                [Validation(Required=false)]
                public string CooperatorBillCode { get; set; }

                /// <summary>
                /// <para>The service provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>飞小猪分销</para>
                /// </summary>
                [NameInMap("cooperator_name")]
                [Validation(Required=false)]
                public string CooperatorName { get; set; }

                /// <summary>
                /// <para>The service provider order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DF24020****07739</para>
                /// </summary>
                [NameInMap("cooperator_order_id")]
                [Validation(Required=false)]
                public string CooperatorOrderId { get; set; }

                /// <summary>
                /// <para>The order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_pay_order_fee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

                /// <summary>
                /// <para>The enterprise payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_settle_price")]
                [Validation(Required=false)]
                public double? CorpSettlePrice { get; set; }

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
                /// <para>cs1</para>
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
                /// <para>The coupon amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

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
                /// <para>The departure airport three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JHG</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure city code (six-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>TAO</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The leaf-level department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试部</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1112</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dept_city")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// <para>The departure date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01</para>
                /// </summary>
                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:30:00</para>
                /// </summary>
                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// <para>The discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

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
                /// <para>机票预订</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - fee_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>赔付</para>
                /// </summary>
                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CZ3590</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The order trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拼接中转</para>
                /// </summary>
                [NameInMap("flight_trip_type")]
                [Validation(Required=false)]
                public string FlightTripType { get; set; }

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
                /// <para>The sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <para>The insurance fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("insurance_fee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                /// <summary>
                /// <para>The insurance policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234A</para>
                /// </summary>
                [NameInMap("insurance_number")]
                [Validation(Required=false)]
                public string InsuranceNumber { get; set; }

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
                /// <para>The itinerary type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>直达</para>
                /// </summary>
                [NameInMap("item_type")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The itinerary number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6666666666</para>
                /// </summary>
                [NameInMap("itinerary_num")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                /// <summary>
                /// <para>The itinerary amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("itinerary_price")]
                [Validation(Required=false)]
                public double? ItineraryPrice { get; set; }

                /// <summary>
                /// <para>Location</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.844005,30.054384</para>
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
                /// <para>The mileage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("mileage")]
                [Validation(Required=false)]
                public int? Mileage { get; set; }

                /// <summary>
                /// <para>The departure time of the lowest-price flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("most_difference_dept_time")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                /// <summary>
                /// <para>The discount of the lowest-price flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("most_difference_discount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                /// <summary>
                /// <para>The flight number of the lowest-price flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("most_difference_flight_no")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                /// <summary>
                /// <para>The price difference from the lowest available price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("most_difference_price")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                /// <summary>
                /// <para>The reason for not selecting the lowest-price flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("most_difference_reason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                /// <summary>
                /// <para>The lowest flight price. This is a new field that is not yet available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("most_price")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                /// <summary>
                /// <para>The discount amount based on the negotiated price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("negotiation_coupon_fee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

                /// <summary>
                /// <para>The fuel surcharge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.0</para>
                /// </summary>
                [NameInMap("oil_fee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                /// <summary>
                /// <para>The order ID or reward issuance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <para>The booking ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-234232532</para>
                /// </summary>
                [NameInMap("order_ticket_no")]
                [Validation(Required=false)]
                public string OrderTicketNo { get; set; }

                /// <summary>
                /// <para>The approval ID for exceeding the travel policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <para>The ID of the department to which the cost is attributed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <para>The name of the department to which the cost is attributed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The personal payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
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
                /// <para>The reason for not booking in advance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("pre_book_tip")]
                [Validation(Required=false)]
                public string PreBookTip { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60399513</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <para>The OA account of the handler.</para>
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
                /// <para>测试项目</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The refund handling fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                /// <summary>
                /// <para>The refund reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("refund_result")]
                [Validation(Required=false)]
                public string RefundResult { get; set; }

                /// <summary>
                /// <para>The handling fee for refunding a changed ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20.0</para>
                /// </summary>
                [NameInMap("refund_upgrade_cost")]
                [Validation(Required=false)]
                public double? RefundUpgradeCost { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a duplicate refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("repeat_refund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                /// <summary>
                /// <para>The selling price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("seal_price")]
                [Validation(Required=false)]
                public double? SealPrice { get; set; }

                /// <summary>
                /// <para>The flight segment information in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;voyage&quot;: &quot;PKX-CAN&quot;, &quot;arrCity&quot;: &quot;广州&quot;, &quot;arrDate&quot;: &quot;2025-03-20&quot;, &quot;arrTime&quot;: &quot;14:45:00&quot;, &quot;depCity&quot;: &quot;北京&quot;, &quot;depDate&quot;: &quot;2025-03-20&quot;, &quot;depTime&quot;: &quot;11:30:00&quot;, &quot;flightNo&quot;: &quot;CZ3112&quot;, &quot;cabinClass&quot;: &quot;经济舱&quot;, &quot;voyageName&quot;: &quot;北京-广州&quot;, &quot;arrCityCode&quot;: &quot;BJS&quot;, &quot;depCityCode&quot;: &quot;CAN&quot;, &quot;airlineCompany&quot;: &quot;南方航空&quot;, &quot;arrAirportCode&quot;: &quot;CAN&quot;, &quot;arrAirportName&quot;: &quot;白云国际机场&quot;, &quot;cabinClassCode&quot;: &quot;K&quot;, &quot;depAirportCode&quot;: &quot;PKX&quot;, &quot;depAirportName&quot;: &quot;大兴国际机场&quot;, &quot;airlineCompanyCode&quot;: &quot;CZ&quot;}, {&quot;voyage&quot;: &quot;CAN-BKK&quot;, &quot;arrCity&quot;: &quot;曼谷&quot;, &quot;arrDate&quot;: &quot;2025-03-20&quot;, &quot;arrTime&quot;: &quot;19:20:00&quot;, &quot;depCity&quot;: &quot;广州&quot;, &quot;depDate&quot;: &quot;2025-03-20&quot;, &quot;depTime&quot;: &quot;17:20:00&quot;, &quot;flightNo&quot;: &quot;CZ8019&quot;, &quot;cabinClass&quot;: &quot;经济舱&quot;, &quot;voyageName&quot;: &quot;广州-曼谷&quot;, &quot;arrCityCode&quot;: &quot;CAN&quot;, &quot;depCityCode&quot;: &quot;BKK&quot;, &quot;airlineCompany&quot;: &quot;南方航空&quot;, &quot;arrAirportCode&quot;: &quot;BKK&quot;, &quot;arrAirportName&quot;: &quot;素万那普国际机场&quot;, &quot;cabinClassCode&quot;: &quot;K&quot;, &quot;depAirportCode&quot;: &quot;CAN&quot;, &quot;depAirportName&quot;: &quot;白云国际机场&quot;, &quot;airlineCompanyCode&quot;: &quot;CZ&quot;}]</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public string SegmentList { get; set; }

                /// <summary>
                /// <para>The service fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - settlement_type</a></description></item>
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
                /// <para>200.0</para>
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
                /// <para>The recording status.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The posting status description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - status</a></description></item>
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
                /// <para>169551103</para>
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
                /// <para>cs2</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-2345</para>
                /// </summary>
                [NameInMap("ticket_id")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                /// <summary>
                /// <para>The itinerary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trade")]
                [Validation(Required=false)]
                public string Trade { get; set; }

                /// <summary>
                /// <para>The capital direction description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - capital_direction</a></description></item>
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
                /// <para><a href="mailto:abc@123.com">abc@123.com</a></para>
                /// </summary>
                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                /// <summary>
                /// <para>The traveler user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The traveler employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                /// <summary>
                /// <para>The traveler type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>外部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                /// <summary>
                /// <para>The traveler type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>外部员工</para>
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
                /// <para>The price difference for the flight change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("upgrade_cost")]
                [Validation(Required=false)]
                public double? UpgradeCost { get; set; }

                /// <summary>
                /// <para>The voucher type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration value descriptions</a>.</description></item>
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
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Value Description - voucher_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>增值税发票</para>
                /// </summary>
                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

                /// <summary>
                /// <para>The itinerary (cities).</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州-成都</para>
                /// </summary>
                [NameInMap("voyage_name")]
                [Validation(Required=false)]
                public string VoyageName { get; set; }

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
            /// <para>The scroll ID. In scroll mode, this can be used as an input parameter for the next query.</para>
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
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-<b><b>-</b></b>-****-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: successful.</para>
        /// </description></item>
        /// <item><description><para>false: failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
