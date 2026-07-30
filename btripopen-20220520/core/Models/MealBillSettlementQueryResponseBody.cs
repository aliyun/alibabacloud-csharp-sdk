// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The description message.</para>
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
        public MealBillSettlementQueryResponseBodyModule Module { get; set; }
        public class MealBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category.</para>
            /// <list type="bullet">
            /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{商旅企业id}</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The data collection (used by the new API).</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<MealBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class MealBillSettlementQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The adjustment time in yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

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
                /// <para>The bill record time.</para>
                /// <list type="bullet">
                /// <item><description>Time format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm\\&quot;Z\\&quot;</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

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
                /// <para>The third-party user ID of the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the booker.</para>
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
                /// <para>The capital direction.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                /// <summary>
                /// <para>The cascading department.</para>
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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - category</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>用餐</para>
                /// </summary>
                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                /// <summary>
                /// <para>The consumption reported address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市某餐厅</para>
                /// </summary>
                [NameInMap("consume_report_address")]
                [Validation(Required=false)]
                public string ConsumeReportAddress { get; set; }

                /// <summary>
                /// <para>The consumption reported city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("consume_report_city")]
                [Validation(Required=false)]
                public string ConsumeReportCity { get; set; }

                /// <summary>
                /// <para>The consumption reported city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGN</para>
                /// </summary>
                [NameInMap("consume_report_city_code")]
                [Validation(Required=false)]
                public string ConsumeReportCityCode { get; set; }

                /// <summary>
                /// <para>The consumption scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>到店餐饮</para>
                /// </summary>
                [NameInMap("consumer_scene")]
                [Validation(Required=false)]
                public string ConsumerScene { get; set; }

                /// <summary>
                /// <para>The enterprise payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_settle_fee")]
                [Validation(Required=false)]
                public double? CorpSettleFee { get; set; }

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
                /// <para>The cost-bearing department CW code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code1</para>
                /// </summary>
                [NameInMap("cost_department")]
                [Validation(Required=false)]
                public string CostDepartment { get; set; }

                /// <summary>
                /// <para>The leaf department.</para>
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
                /// <para>1112</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The fee type.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>70101</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                /// <summary>
                /// <para>The fee type description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - fee_type</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>赔付</para>
                /// </summary>
                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

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
                /// <para>The main approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("main_apply_id")]
                [Validation(Required=false)]
                public string MainApplyId { get; set; }

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
                /// <para>The merchant address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市某区某街道</para>
                /// </summary>
                [NameInMap("meal_address")]
                [Validation(Required=false)]
                public string MealAddress { get; set; }

                /// <summary>
                /// <para>The merchant city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("meal_city")]
                [Validation(Required=false)]
                public string MealCity { get; set; }

                /// <summary>
                /// <para>The merchant city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGN</para>
                /// </summary>
                [NameInMap("meal_city_code")]
                [Validation(Required=false)]
                public string MealCityCode { get; set; }

                /// <summary>
                /// <para>The meal reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX原因</para>
                /// </summary>
                [NameInMap("meal_reason")]
                [Validation(Required=false)]
                public string MealReason { get; set; }

                /// <summary>
                /// <para>The meal rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>差旅用餐-员工</para>
                /// </summary>
                [NameInMap("meal_rule")]
                [Validation(Required=false)]
                public string MealRule { get; set; }

                /// <summary>
                /// <para>The meal scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>差旅用餐</para>
                /// </summary>
                [NameInMap("meal_scene")]
                [Validation(Required=false)]
                public string MealScene { get; set; }

                /// <summary>
                /// <para>The merchant category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MEAL</para>
                /// </summary>
                [NameInMap("merchant_category")]
                [Validation(Required=false)]
                public string MerchantCategory { get; set; }

                /// <summary>
                /// <para>The merchant name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>某餐厅</para>
                /// </summary>
                [NameInMap("merchant_name")]
                [Validation(Required=false)]
                public string MerchantName { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002039196909288346</para>
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
                /// <para>The personal payment amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60698599</para>
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
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试单</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - settlement_type</a></description></item>
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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <para>Indicates whether the meal is shared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>否</para>
                /// </summary>
                [NameInMap("share_dinner")]
                [Validation(Required=false)]
                public string ShareDinner { get; set; }

                /// <summary>
                /// <para>The billing status.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The billing status description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - status</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>入账成功</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The store name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>某餐厅</para>
                /// </summary>
                [NameInMap("store_address")]
                [Validation(Required=false)]
                public string StoreAddress { get; set; }

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
                /// <para>The external invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs2</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <para>The third-party approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_part_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                /// <summary>
                /// <para>The third-party application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7244-1968</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The capital direction description.</para>
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - capital_direction</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>支出</para>
                /// </summary>
                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <para>The third-party user ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The employee ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                /// <summary>
                /// <para>The traveler member type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>外部员工</para>
                /// </summary>
                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                /// <summary>
                /// <para>The diner type.</para>
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
                /// <list type="bullet">
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5042012">Bill API enum value descriptions</a>.</description></item>
                /// </list>
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
                /// <item><description>For valid values, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.429d281f3ftb0u&docId=5042012">Bill API enum value descriptions - voucher_type</a></description></item>
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
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002039195025156700</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The billing end date in yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <para>The billing start date in yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-01</para>
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
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2695</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

            /// <summary>
            /// <para>The total count (used by the new API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
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
        /// <para>210bcc3a********d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
