// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealBillSettlementQueryResponseBody : TeaModel {
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

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("consumer_scene")]
                [Validation(Required=false)]
                public string ConsumerScene { get; set; }

                [NameInMap("corp_settle_fee")]
                [Validation(Required=false)]
                public double? CorpSettleFee { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("main_apply_id")]
                [Validation(Required=false)]
                public string MainApplyId { get; set; }

                [NameInMap("meal_address")]
                [Validation(Required=false)]
                public string MealAddress { get; set; }

                [NameInMap("meal_city")]
                [Validation(Required=false)]
                public string MealCity { get; set; }

                [NameInMap("meal_city_code")]
                [Validation(Required=false)]
                public string MealCityCode { get; set; }

                [NameInMap("meal_rule")]
                [Validation(Required=false)]
                public string MealRule { get; set; }

                [NameInMap("meal_scene")]
                [Validation(Required=false)]
                public string MealScene { get; set; }

                [NameInMap("merchant_category")]
                [Validation(Required=false)]
                public string MerchantCategory { get; set; }

                [NameInMap("merchant_name")]
                [Validation(Required=false)]
                public string MerchantName { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                [NameInMap("person_settle_price")]
                [Validation(Required=false)]
                public double? PersonSettlePrice { get; set; }

                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                [NameInMap("share_dinner")]
                [Validation(Required=false)]
                public string ShareDinner { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("store_address")]
                [Validation(Required=false)]
                public string StoreAddress { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                [NameInMap("third_part_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

            }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
