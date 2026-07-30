// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainBillSettlementQueryResponseBody : TeaModel {
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
        public TrainBillSettlementQueryResponseBodyModule Module { get; set; }
        public class TrainBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category.</para>
            /// <list type="bullet">
            /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
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
            public List<TrainBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class TrainBillSettlementQueryResponseBodyModuleDataList : TeaModel {
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
                /// <para>The payment transaction number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021123432260</para>
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
                /// <para>103189557</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The email address of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@ee.com">123@ee.com</a></para>
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
                /// <para>The arrival city (6-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-13</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The arrival station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京朝阳</para>
                /// </summary>
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <para>The location of the arrival station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>桐乡</para>
                /// </summary>
                [NameInMap("arr_station_location")]
                [Validation(Required=false)]
                public string ArrStationLocation { get; set; }

                /// <summary>
                /// <para>The code of the arrival station location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330483</para>
                /// </summary>
                [NameInMap("arr_station_location_code")]
                [Validation(Required=false)]
                public string ArrStationLocationCode { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:30</para>
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
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <para>The booking time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-08 23:38:55</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <para>The booker ID (user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>al_xinuan.zsy</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>预定人工号</para>
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
                /// <para>The reason for the business trip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>因公司要求，需要到XX同XX公司谈业务</para>
                /// </summary>
                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                /// <summary>
                /// <para>The maximum price for the original standard seat class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("cabin_max_price")]
                [Validation(Required=false)]
                public double? CabinMaxPrice { get; set; }

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
                /// <para>The cascading department hierarchy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三事业群-营运部-北方营运大区</para>
                /// </summary>
                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - category</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>商旅火车票</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The attribution of the ticket change fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人</para>
                /// </summary>
                [NameInMap("change_affiliate_no")]
                [Validation(Required=false)]
                public string ChangeAffiliateNo { get; set; }

                /// <summary>
                /// <para>The approval ID for the ticket change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12325436456</para>
                /// </summary>
                [NameInMap("change_apply_id")]
                [Validation(Required=false)]
                public string ChangeApplyId { get; set; }

                /// <summary>
                /// <para>The ticket change fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.0</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// <para>The reason for the ticket change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>原航班时间与预计不符</para>
                /// </summary>
                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                /// <summary>
                /// <para>The coach number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11号</para>
                /// </summary>
                [NameInMap("coach_no")]
                [Validation(Required=false)]
                public string CoachNo { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三集团</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T85</para>
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
                /// <para>0</para>
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
                /// <para>The departure city (6-letter code).</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The location of the departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>淳安</para>
                /// </summary>
                [NameInMap("dep_station_location")]
                [Validation(Required=false)]
                public string DepStationLocation { get; set; }

                /// <summary>
                /// <para>The code of the departure station location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330127</para>
                /// </summary>
                [NameInMap("dep_station_location_code")]
                [Validation(Required=false)]
                public string DepStationLocationCode { get; set; }

                /// <summary>
                /// <para>The leaf-level department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北方营运大区</para>
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
                /// <para>The departure date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-14</para>
                /// </summary>
                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                /// <summary>
                /// <para>The departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>沈阳北</para>
                /// </summary>
                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:44</para>
                /// </summary>
                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

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
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>6001</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - fee_type</a></description></item>
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
                /// <para>4740293</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

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
                /// <para>The trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>直达</para>
                /// </summary>
                [NameInMap("is_transfer_order")]
                [Validation(Required=false)]
                public string IsTransferOrder { get; set; }

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
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EOW27271524563517</para>
                /// </summary>
                [NameInMap("long_ticket_no")]
                [Validation(Required=false)]
                public string LongTicketNo { get; set; }

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
                /// <para>The original standard seat class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>硬座</para>
                /// </summary>
                [NameInMap("max_cabin")]
                [Validation(Required=false)]
                public string MaxCabin { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23432692343243432</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                /// <summary>
                /// <para>The booking ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EOW27271524563517</para>
                /// </summary>
                [NameInMap("order_ticket_no")]
                [Validation(Required=false)]
                public string OrderTicketNo { get; set; }

                /// <summary>
                /// <para>The over-standard approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>534545345</para>
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
                /// <para>4740293</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <para>The ticket price printed on the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350.45</para>
                /// </summary>
                [NameInMap("print_ticket_price")]
                [Validation(Required=false)]
                public double? PrintTicketPrice { get; set; }

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
                /// <para>2345235435</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三-张三制线-公共</para>
                /// </summary>
                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The attribution of the refund fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>企业</para>
                /// </summary>
                [NameInMap("refund_affiliate_no")]
                [Validation(Required=false)]
                public string RefundAffiliateNo { get; set; }

                /// <summary>
                /// <para>The approval ID for the refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000001879032</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                /// <summary>
                /// <para>The ticket refund fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

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
                /// <para>The booking type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>免登录快捷购票</para>
                /// </summary>
                [NameInMap("reserve_mode")]
                [Validation(Required=false)]
                public string ReserveMode { get; set; }

                /// <summary>
                /// <para>The travel duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2时46分</para>
                /// </summary>
                [NameInMap("run_time")]
                [Validation(Required=false)]
                public string RunTime { get; set; }

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
                /// <para>The seat number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>004F</para>
                /// </summary>
                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                /// <summary>
                /// <para>The seat class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>二等座</para>
                /// </summary>
                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// <para>The service fee. Displayed only for feeType 6007 and 6008.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>23.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The settlement type description.</para>
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
                /// <para>350</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <para>The settlement amount - prepaid complimentary portion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.56</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <para>The settlement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-08 23:39:01</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                /// <summary>
                /// <para>The settlement type.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Billing API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <para>The ticket pickup number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EH2234567</para>
                /// </summary>
                [NameInMap("short_ticket_no")]
                [Validation(Required=false)]
                public string ShortTicketNo { get; set; }

                /// <summary>
                /// <para>SIO</para>
                /// 
                /// <b>Example:</b>
                /// <para>sio</para>
                /// </summary>
                [NameInMap("sio")]
                [Validation(Required=false)]
                public string Sio { get; set; }

                /// <summary>
                /// <para>The ticket grabbing acceleration package fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("speed_package_fee")]
                [Validation(Required=false)]
                public double? SpeedPackageFee { get; set; }

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
                /// <para>The description of the accounting status.</para>
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
                /// <para>The amount paid by the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ticket_corp_pay_price")]
                [Validation(Required=false)]
                public string TicketCorpPayPrice { get; set; }

                /// <summary>
                /// <para>The ticket number printed on the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2115242342342424067354</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The amount paid by the individual.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_person_pay_price")]
                [Validation(Required=false)]
                public string TicketPersonPayPrice { get; set; }

                /// <summary>
                /// <para>The ticket price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <para>The description of the capital direction.</para>
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
                /// <para>The train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>G906</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <para>The train type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高铁</para>
                /// </summary>
                [NameInMap("train_type")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

                /// <summary>
                /// <para>The email address of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@ee.com">123@ee.com</a></para>
                /// </summary>
                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                /// <summary>
                /// <para>The traveler ID (user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>出行人id</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出行人工号</para>
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
                /// <para>张三三</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                /// <summary>
                /// <para>The reason for verification failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>员工已自取</para>
                /// </summary>
                [NameInMap("verify_failed_reason")]
                [Validation(Required=false)]
                public string VerifyFailedReason { get; set; }

                /// <summary>
                /// <para>The verification status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("verify_status")]
                [Validation(Required=false)]
                public int? VerifyStatus { get; set; }

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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Billing API enum value descriptions - voucher_type</a></description></item>
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
            /// <para>The billing end date in yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-14</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <para>The billing start date in yyyy-MM-dd format.</para>
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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2694</para>
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
