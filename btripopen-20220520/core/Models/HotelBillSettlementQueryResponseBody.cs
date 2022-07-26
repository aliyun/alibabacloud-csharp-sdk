// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelBillSettlementQueryResponseBodyModule Module { get; set; }
        public class HotelBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }
            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<HotelBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class HotelBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                public string AlipayTradeNo { get; set; }
                public string ApplyId { get; set; }
                public string BillRecordTime { get; set; }
                public string BookTime { get; set; }
                public string BookerId { get; set; }
                public string BookerJobNo { get; set; }
                public string BookerName { get; set; }
                public string CapitalDirection { get; set; }
                public string CascadeDepartment { get; set; }
                public string CheckInDate { get; set; }
                public string CheckoutDate { get; set; }
                public string City { get; set; }
                public string CityCode { get; set; }
                public double? CorpRefundFee { get; set; }
                public double? CorpTotalFee { get; set; }
                public string CostCenter { get; set; }
                public string CostCenterNumber { get; set; }
                public string Department { get; set; }
                public string DepartmentId { get; set; }
                public string FeeType { get; set; }
                public double? Fees { get; set; }
                public double? FuPointFee { get; set; }
                public string HotelName { get; set; }
                public string Index { get; set; }
                public string InvoiceTitle { get; set; }
                public string IsNegotiation { get; set; }
                public string IsShareStr { get; set; }
                public int? Nights { get; set; }
                public string OrderId { get; set; }
                public double? OrderPrice { get; set; }
                public string OrderType { get; set; }
                public string OverApplyId { get; set; }
                public double? PersonRefundFee { get; set; }
                public double? PersonSettlePrice { get; set; }
                public long? PrimaryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectName { get; set; }
                public double? PromotionFee { get; set; }
                public string Remark { get; set; }
                public int? RoomNumber { get; set; }
                public double? RoomPrice { get; set; }
                public string RoomType { get; set; }
                public double? ServiceFee { get; set; }
                public double? SettlementFee { get; set; }
                public double? SettlementGrantFee { get; set; }
                public string SettlementTime { get; set; }
                public string SettlementType { get; set; }
                public int? Status { get; set; }
                public int? TotalNights { get; set; }
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

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
