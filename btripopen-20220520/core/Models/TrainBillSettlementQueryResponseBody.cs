// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainBillSettlementQueryResponseBodyModule Module { get; set; }
        public class TrainBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<TrainBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class TrainBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string ArrDate { get; set; }
                public string ArrStation { get; set; }
                public string ArrTime { get; set; }
                public string BillRecordTime { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerJobNo { get; set; }
                public string BookerName { get; set; }
                public string CapitalDirection { get; set; }
                public string CascadeDepartment { get; set; }
                public double? ChangeFee { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public double? Coupon { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string DeptDate { get; set; }
                public string DeptStation { get; set; }
                public string DeptTime { get; set; }
                public string FeeType { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OverApplyId { get; set; }
                public long? PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public double? RefundFee { get; set; }
                public string Remark { get; set; }
                public string RunTime { get; set; }
                public string SeatNo { get; set; }
                public string SeatType { get; set; }
                public double? ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public double? SettlementGrantFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public int? Status { get; set; }
                public string TicketNo { get; set; }
                public double? TicketPrice { get; set; }
                public string TrainNo { get; set; }
                public string TrainType { get; set; }
                public string TravelerId { get; set; }
                public string TravelerJobNo { get; set; }
                public string TravelerName { get; set; }
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
