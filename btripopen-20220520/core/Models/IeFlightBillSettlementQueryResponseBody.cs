// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeFlightBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        public IeFlightBillSettlementQueryResponseBodyModule Module { get; set; }
        public class IeFlightBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category of the data.</para>
            /// <list type="bullet">
            /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing enumeration summary</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
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
            /// <para>The list of billing data records.</para>
            /// </summary>
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<IeFlightBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class IeFlightBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                /// <summary>
                /// <para>The adjustment time. Format: yyyy-MM-dd HH:mm:ss.</para>
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
                /// <para>The two-letter IATA code of the airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA</para>
                /// </summary>
                [NameInMap("airline_corp_code")]
                [Validation(Required=false)]
                public string AirlineCorpCode { get; set; }

                /// <summary>
                /// <para>The airline name. When multiple airlines are involved, they are separated by a forward slash (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国国航</para>
                /// </summary>
                [NameInMap("airline_corp_name")]
                [Validation(Required=false)]
                public string AirlineCorpName { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20211********456080520</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <para>The three-letter airport code of the arrival city in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MDG</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival city in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>牡丹江</para>
                /// </summary>
                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <para>The three-letter airport code of the departure city in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HRB</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                /// <summary>
                /// <para>The name of the departure city in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>哈尔滨</para>
                /// </summary>
                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                /// <summary>
                /// <para>The custom extension field in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;memo&quot;:&quot;备注&quot;}</para>
                /// </summary>
                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <para>The travel approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103****557</para>
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
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("approver_name")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDG</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>巴黎</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The six-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival country/region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国</para>
                /// </summary>
                [NameInMap("arr_country")]
                [Validation(Required=false)]
                public string ArrCountry { get; set; }

                /// <summary>
                /// <para>The two-letter code of the arrival country/region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("arr_country_code")]
                [Validation(Required=false)]
                public string ArrCountryCode { get; set; }

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
                /// <para>The name of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Paris Charles de Gaulle Airport</para>
                /// </summary>
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22:00:00</para>
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
                /// <para>The time when the bill was recorded.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm\\&quot;Z\\&quot;</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01T00:00Z</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <para>The booking type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Online (self-service booking)</description></item>
                /// <item><description>Online (inquiry order)</description></item>
                /// <item><description>Offline booking by agent</description></item>
                /// <item><description>Flexible booking</description></item>
                /// <item><description>Booking by service representative</description></item>
                /// <item><description>Offline order import</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>线上（自助预订）；</para>
                /// </summary>
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                /// <summary>
                /// <para>The booking time.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd HH:mm</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-01 00:17:05</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <para>The ID of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The employee number of the booker.</para>
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
                /// <para>The discount amount from the business travel price, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("btrip_coupon_fee")]
                [Validation(Required=false)]
                public double? BtripCouponFee { get; set; }

                /// <summary>
                /// <para>The reason for the business trip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>因公司要求，需要到XX同XX公司谈业务</para>
                /// </summary>
                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The capital direction.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration values - capital_direction</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// <para>The department to which the traveler belongs, in cascading format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅事业群-运营部-华北营运大区</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - category</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>国际城市以及中国香港、中国澳门、中国台湾机票</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The rebooking fee, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.0</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// <para>The reason for rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>原航班时间与预计不符</para>
                /// </summary>
                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                /// <summary>
                /// <para>The order amount, in CNY.</para>
                /// <list type="bullet">
                /// <item><description>Calculation: order amount = settlement amount + bonus amount from enterprise prepaid or top-up.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>460</para>
                /// </summary>
                [NameInMap("corp_pay_order_fee")]
                [Validation(Required=false)]
                public double? CorpPayOrderFee { get; set; }

                /// <summary>
                /// <para>The name of the cost center to which the traveler belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>运营部成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cost_1234</para>
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
                /// <para>The face value of the coupon used, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>The estimated deductible tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("deductible_tax")]
                [Validation(Required=false)]
                public double? DeductibleTax { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PEK</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The six-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The name of the departure country/region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>美国</para>
                /// </summary>
                [NameInMap("dep_country")]
                [Validation(Required=false)]
                public string DepCountry { get; set; }

                /// <summary>
                /// <para>The two-letter code of the departure country/region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>US</para>
                /// </summary>
                [NameInMap("dep_country_code")]
                [Validation(Required=false)]
                public string DepCountryCode { get; set; }

                /// <summary>
                /// <para>The leaf-level department to which the traveler belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>华北运营大区</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The ID of the department to which the traveler belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>depart_1234</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
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
                /// <para>The name of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京首都国际机场</para>
                /// </summary>
                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// <para>The discount rate.</para>
                /// <list type="bullet">
                /// <item><description>Calculation: actual ticket price / published fare. For example, if the published fare is 1000 CNY and the actual ticket price is 800 CNY, the discount rate is 800/1000 = 80%.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>51%</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The reason for exceeding the limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无低价机票，故超标购买</para>
                /// </summary>
                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                /// <summary>
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration values - fee_type</a>.</description></item>
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
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - fee_type</a>.</description></item>
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
                /// <para>CA933</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

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
                /// <para>The sequence number.</para>
                /// <list type="bullet">
                /// <item><description>This is not a primary key. Use <c>primary_id</c> as the primary key.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>45****47</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>343458349722002</para>
                /// </summary>
                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <para>The insurance fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.3</para>
                /// </summary>
                [NameInMap("insurance_fee")]
                [Validation(Required=false)]
                public double? InsuranceFee { get; set; }

                /// <summary>
                /// <para>The insurance policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T100**************101</para>
                /// </summary>
                [NameInMap("insurance_number")]
                [Validation(Required=false)]
                public string InsuranceNumber { get; set; }

                /// <summary>
                /// <para>The insurance product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>旅游意外险</para>
                /// </summary>
                [NameInMap("insurance_product_name")]
                [Validation(Required=false)]
                public string InsuranceProductName { get; set; }

                /// <summary>
                /// <para>The invoice title associated with the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>飞小猪有限公司。</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>Location</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.385449,39.997733</para>
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
                /// <para>The departure time of the low-price flight in the low-price alert.</para>
                /// <list type="bullet">
                /// <item><description>Time format: yyyy-MM-dd HH:mm:ss.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("most_difference_dept_time")]
                [Validation(Required=false)]
                public string MostDifferenceDeptTime { get; set; }

                /// <summary>
                /// <para>The discount rate of the low-price ticket in the low-price alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23%</para>
                /// </summary>
                [NameInMap("most_difference_discount")]
                [Validation(Required=false)]
                public string MostDifferenceDiscount { get; set; }

                /// <summary>
                /// <para>The flight number of the low-price flight in the low-price alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU9684</para>
                /// </summary>
                [NameInMap("most_difference_flight_no")]
                [Validation(Required=false)]
                public string MostDifferenceFlightNo { get; set; }

                /// <summary>
                /// <para>The price difference between the current flight and the lowest-price flight in the low-price alert, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("most_difference_price")]
                [Validation(Required=false)]
                public double? MostDifferencePrice { get; set; }

                /// <summary>
                /// <para>The reason why the employee did not choose the low-price flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>原因为：xxx</para>
                /// </summary>
                [NameInMap("most_difference_reason")]
                [Validation(Required=false)]
                public string MostDifferenceReason { get; set; }

                /// <summary>
                /// <para><b>Not available</b> Low-price flight price: the lowest price flight in the low-price alert, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("most_price")]
                [Validation(Required=false)]
                public double? MostPrice { get; set; }

                /// <summary>
                /// <para>The discount amount from the negotiated price, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("negotiation_coupon_fee")]
                [Validation(Required=false)]
                public double? NegotiationCouponFee { get; set; }

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
                /// <para>The order status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <para>The over-limit approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>233****423</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <para>The ID of the cost attribution department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>depart_1234</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <para>The name of the cost attribution department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>运营部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

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
                /// <list type="bullet">
                /// <item><description>This value is updated when the billing data is updated.</description></item>
                /// <item><description>When <c>primary_id</c> values are the same, use the latest data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>45****47</para>
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
                /// <para>The ID of the project to which the traveler belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_1234</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The name of the project to which the traveler belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>运营生产项目</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The refund service fee after rebooking. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("refund_change_cost")]
                [Validation(Required=false)]
                public double? RefundChangeCost { get; set; }

                /// <summary>
                /// <para>The refund handling fee, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                /// <summary>
                /// <para>The reason for the refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>因公退票,因工作原因取消计划</para>
                /// </summary>
                [NameInMap("refund_result")]
                [Validation(Required=false)]
                public string RefundResult { get; set; }

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
                /// <para>Indicates whether the employee has repeated refund behavior. This field is usually empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
                /// </summary>
                [NameInMap("repeat_refund")]
                [Validation(Required=false)]
                public string RepeatRefund { get; set; }

                /// <summary>
                /// <para>The selling price or price difference, in CNY.</para>
                /// <list type="bullet">
                /// <item><description>Selling price: the ticket price excluding fuel surcharge and airport construction fee.</description></item>
                /// <item><description>Price difference: the price difference generated by refund, rebooking, or cabin class change.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>410</para>
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
                /// <para>The segment type. Identified at the segment level. The same order may contain different segments. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Intercontinental</description></item>
                /// <item><description>Intracontinental</description></item>
                /// <item><description>Domestic segment</description></item>
                /// <item><description>Hong Kong (China), Macao (China), Taiwan (China)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>洲际</para>
                /// </summary>
                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public string SegmentType { get; set; }

                /// <summary>
                /// <para>The service fee charged by the business travel platform, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.9</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - settlement_type</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>企业月结</para>
                /// </summary>
                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                /// <summary>
                /// <para>The settlement amount, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <para>The bonus portion of the settlement amount from enterprise prepaid credits, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.11</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <para>The settlement time.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd HH:mm:ss</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <para>The settlement type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration values - settlement_type</a>.</description></item>
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
                /// <para>The billing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The posting status description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - status</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>入账成功</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The sub-order ID. Currently only supported for the car service category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002************464-001</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <para>The tax fee, including airport construction fee and fuel surcharge. Displayed only for ticket booking or ticket refund. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125.6</para>
                /// </summary>
                [NameInMap("tax_fee")]
                [Validation(Required=false)]
                public double? TaxFee { get; set; }

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
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AB0-<b><b>-</b></b>-****1011</para>
                /// </summary>
                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <para>The ticket number. This is the unique identifier of the ticket and may appear multiple times in the response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>781-6586234234324</para>
                /// </summary>
                [NameInMap("ticket_id")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                /// <summary>
                /// <para>The itinerary. When multiple segments are included, they are connected with a hyphen (-).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PEK-CDG</para>
                /// </summary>
                [NameInMap("trade")]
                [Validation(Required=false)]
                public string Trade { get; set; }

                /// <summary>
                /// <para>The capital direction description.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - capital_direction</a>.</description></item>
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
                /// <para>The ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_2234</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The employee number of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_2234</para>
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
                /// <para>内部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                /// <summary>
                /// <para>The name of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// <para>The trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                /// <summary>
                /// <para>The voucher type.</para>
                /// <list type="bullet">
                /// <item><description>For enumeration values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enumeration values - settlement_type</a>.</description></item>
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
                /// <item><description>For enumeration values, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API Enumeration Values - voucher_type</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>增值税发票</para>
                /// </summary>
                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

                /// <summary>
                /// <para>The itinerary (city).</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京-杭州-上海</para>
                /// </summary>
                [NameInMap("voyage_name")]
                [Validation(Required=false)]
                public string VoyageName { get; set; }

            }

            /// <summary>
            /// <para>The end time for the billing data query.</para>
            /// <list type="bullet">
            /// <item><description>Time format: yyyy-MM-dd.</description></item>
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
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The pagination indicator. Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

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
        /// <para>Indicates whether the request is successful.</para>
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
