// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealBillSettlementQueryResponseBodyModule Module { get; set; }
        public class MealBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<MealBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class MealBillSettlementQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1004430880</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

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

                [NameInMap("consume_report_address")]
                [Validation(Required=false)]
                public string ConsumeReportAddress { get; set; }

                [NameInMap("consume_report_city")]
                [Validation(Required=false)]
                public string ConsumeReportCity { get; set; }

                [NameInMap("consume_report_city_code")]
                [Validation(Required=false)]
                public string ConsumeReportCityCode { get; set; }

                [NameInMap("consumer_scene")]
                [Validation(Required=false)]
                public string ConsumerScene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("corp_settle_fee")]
                [Validation(Required=false)]
                public double? CorpSettleFee { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs1</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1112</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70101</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("main_apply_id")]
                [Validation(Required=false)]
                public string MainApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("meal_address")]
                [Validation(Required=false)]
                public string MealAddress { get; set; }

                [NameInMap("meal_city")]
                [Validation(Required=false)]
                public string MealCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("meal_city_code")]
                [Validation(Required=false)]
                public string MealCityCode { get; set; }

                [NameInMap("meal_rule")]
                [Validation(Required=false)]
                public string MealRule { get; set; }

                [NameInMap("meal_scene")]
                [Validation(Required=false)]
                public string MealScene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MEAL</para>
                /// </summary>
                [NameInMap("merchant_category")]
                [Validation(Required=false)]
                public string MerchantCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("merchant_name")]
                [Validation(Required=false)]
                public string MerchantName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1002039196909288346</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60698599</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

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

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110.0</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
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

                [NameInMap("share_dinner")]
                [Validation(Required=false)]
                public string ShareDinner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("store_address")]
                [Validation(Required=false)]
                public string StoreAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs2</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_part_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7244-1968</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1002039195025156700</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-02</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-01</para>
            /// </summary>
            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2695</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
