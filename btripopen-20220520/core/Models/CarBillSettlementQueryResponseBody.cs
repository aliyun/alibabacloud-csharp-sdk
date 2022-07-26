// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CarBillSettlementQueryResponseBodyModule Module { get; set; }
        public class CarBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<CarBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class CarBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string ArrCity { get; set; }
                public string ArrDate { get; set; }
                public string ArrLocation { get; set; }
                public string ArrTime { get; set; }
                public string BillRecordTime { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerJobNo { get; set; }
                public string BookerName { get; set; }
                public string BusinessCategory { get; set; }
                public string CapitalDirection { get; set; }
                public string CarLevel { get; set; }
                public string CascadeDepartment { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public double? Coupon { get; set; }
                public double? CouponPrice { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string DeptCity { get; set; }
                public string DeptDate { get; set; }
                public string DeptLocation { get; set; }
                public string DeptTime { get; set; }
                public string EstimateDriveDistance { get; set; }
                public double? EstimatePrice { get; set; }
                public string FeeType { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public string Memo { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OverApplyId { get; set; }
                public double? PersonSettleFee { get; set; }
                public long? PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public string ProviderName { get; set; }
                public string RealDriveDistance { get; set; }
                public string RealFromAddr { get; set; }
                public string RealToAddr { get; set; }
                public string Remark { get; set; }
                public double? ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public double? SettlementGrantFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public string SpecialOrder { get; set; }
                public string SpecialReason { get; set; }
                public int? Status { get; set; }
                public string SubOrderId { get; set; }
                public string TravelerId { get; set; }
                public string TravelerJobNo { get; set; }
                public string TravelerName { get; set; }
                public string UserConfirmDesc { get; set; }
                public int? VoucherType { get; set; }
            }
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }
            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }
        };

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
