// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarBillSettlementQueryResponseBody : TeaModel {
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
        public CarBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CarBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category.</para>
            /// <list type="bullet">
            /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The third-party enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第三方企业id</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<CarBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class CarBillSettlementQueryResponseBodyModuleDataList : TeaModel {
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
                /// <para>34534543545345</para>
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
                /// <para>审批单号</para>
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
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>长沙市</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city (6-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-02</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The arrival location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>天街</para>
                /// </summary>
                [NameInMap("arr_location")]
                [Validation(Required=false)]
                public string ArrLocation { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13:51:43</para>
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
                /// <para>The bill record time.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm\\&quot;Z\\&quot;</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <para>The billing entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江阿里商旅旅行社有限公司余杭分公司</para>
                /// </summary>
                [NameInMap("billing_entity")]
                [Validation(Required=false)]
                public string BillingEntity { get; set; }

                /// <summary>
                /// <para>The car usage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自用订单</para>
                /// </summary>
                [NameInMap("book_model")]
                [Validation(Required=false)]
                public string BookModel { get; set; }

                /// <summary>
                /// <para>The booking time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15 22:27:00</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <para>The third-party user ID of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>预定人第三方用户id</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The booker employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70022164</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                /// <summary>
                /// <para>The booker name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三三</para>
                /// </summary>
                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <para>The car service reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>市内交通</para>
                /// </summary>
                [NameInMap("business_category")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                /// <summary>
                /// <para>The capital direction.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// <para>The vehicle type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济型</para>
                /// </summary>
                [NameInMap("car_level")]
                [Validation(Required=false)]
                public string CarLevel { get; set; }

                /// <summary>
                /// <para>The cascading department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国东南分公司-业务部</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - category</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>用车</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2391-CN90.150</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The cost department CW code.</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                /// <summary>
                /// <para>The business travel discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.7</para>
                /// </summary>
                [NameInMap("coupon_price")]
                [Validation(Required=false)]
                public double? CouponPrice { get; set; }

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
                /// <para>The departure city (6-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The leaf department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>业务部</para>
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
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>长沙市</para>
                /// </summary>
                [NameInMap("dept_city")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// <para>The departure date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-13</para>
                /// </summary>
                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// <para>The departure location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>长沙南站</para>
                /// </summary>
                [NameInMap("dept_location")]
                [Validation(Required=false)]
                public string DeptLocation { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13:46:05</para>
                /// </summary>
                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                /// <summary>
                /// <para>The driver surcharge details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高速费:5;路桥费:5</para>
                /// </summary>
                [NameInMap("driver_add_detail")]
                [Validation(Required=false)]
                public string DriverAddDetail { get; set; }

                /// <summary>
                /// <para>The driver surcharge total.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("driver_add_fee")]
                [Validation(Required=false)]
                public double? DriverAddFee { get; set; }

                /// <summary>
                /// <para>The estimated distance in kilometers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29.07</para>
                /// </summary>
                [NameInMap("estimate_drive_distance")]
                [Validation(Required=false)]
                public string EstimateDriveDistance { get; set; }

                /// <summary>
                /// <para>The estimated amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>69</para>
                /// </summary>
                [NameInMap("estimate_price")]
                [Validation(Required=false)]
                public double? EstimatePrice { get; set; }

                /// <summary>
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>40107</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - fee_type</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>赔付</para>
                /// </summary>
                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>4988580</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三投资有限公司</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The supplier vehicle type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高德</para>
                /// </summary>
                [NameInMap("level_name")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

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
                /// <para>The car service purpose.</para>
                /// 
                /// <b>Example:</b>
                /// <para>家</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110285961234324</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.7</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                /// <summary>
                /// <para>The over-limit approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34535465346</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <para>The cost-bearing department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202300000</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <para>The cost-bearing department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试二部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The personal payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("person_settle_fee")]
                [Validation(Required=false)]
                public double? PersonSettleFee { get; set; }

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
                /// <para>4988580</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <para>The processor OA account.</para>
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
                /// <para>23423432423</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>生产-音卓自制线-公共</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The protocol price discount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.01</para>
                /// </summary>
                [NameInMap("protocol_discount_fee")]
                [Validation(Required=false)]
                public double? ProtocolDiscountFee { get; set; }

                /// <summary>
                /// <para>The supplier vehicle type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>首汽约车</para>
                /// </summary>
                [NameInMap("provider_name")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

                /// <summary>
                /// <para>The actual distance driven in kilometers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.00</para>
                /// </summary>
                [NameInMap("real_drive_distance")]
                [Validation(Required=false)]
                public string RealDriveDistance { get; set; }

                /// <summary>
                /// <para>The actual pickup point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>长沙南站</para>
                /// </summary>
                [NameInMap("real_from_addr")]
                [Validation(Required=false)]
                public string RealFromAddr { get; set; }

                /// <summary>
                /// <para>The actual drop-off point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>梅溪湖中心15</para>
                /// </summary>
                [NameInMap("real_to_addr")]
                [Validation(Required=false)]
                public string RealToAddr { get; set; }

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
                /// <para>The scene ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("scene_id")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The scene name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>福利</para>
                /// </summary>
                [NameInMap("scene_name")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>The service fee. Displayed only when feeType is 40111.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>12.7</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - settlement_type</a>.</description></item>
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
                /// <para>5</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <para>The settlement amount - prepaid grant portion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.11</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <para>The settlement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15 22:27:00</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
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
                /// <para>The special attention order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
                /// </summary>
                [NameInMap("special_order")]
                [Validation(Required=false)]
                public string SpecialOrder { get; set; }

                /// <summary>
                /// <para>The special attention reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>关注</para>
                /// </summary>
                [NameInMap("special_reason")]
                [Validation(Required=false)]
                public string SpecialReason { get; set; }

                /// <summary>
                /// <para>The billing status.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - status</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>入账成功</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123232</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <para>The post-trip approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("supplement_apply_id")]
                [Validation(Required=false)]
                public string SupplementApplyId { get; set; }

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
                /// <para>The order type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>实时订单</para>
                /// </summary>
                [NameInMap("time_type")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// <para>The capital direction description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - capital_direction</a>.</description></item>
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
                /// <para>The third-party user ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出行人第三方用户id</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The traveler employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70022164</para>
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
                /// <para>The traveler name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// <para>Indicates whether the employee confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
                /// </summary>
                [NameInMap("user_confirm_desc")]
                [Validation(Required=false)]
                public string UserConfirmDesc { get; set; }

                /// <summary>
                /// <para>The car service scene ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TRAVEL</para>
                /// </summary>
                [NameInMap("vehicle_scene_id")]
                [Validation(Required=false)]
                public string VehicleSceneId { get; set; }

                /// <summary>
                /// <para>The car service scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>差旅用车</para>
                /// </summary>
                [NameInMap("vehicle_scene_name")]
                [Validation(Required=false)]
                public string VehicleSceneName { get; set; }

                /// <summary>
                /// <para>The voucher type.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - voucher_type</a>.</description></item>
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
            /// <para>The billing update end date in yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <para>The billing update start date in yyyy-MM-dd format.</para>
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
            /// <para>2695</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>210bcc3a********d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
