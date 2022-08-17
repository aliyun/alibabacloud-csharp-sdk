// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderQueryResponseBodyModule Module { get; set; }
        public class TrainOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("change_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleChangeTicketInfoList> ChangeTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleChangeTicketInfoList : TeaModel {
                public string ChangeCoachNo { get; set; }
                public double? ChangeGapFee { get; set; }
                public double? ChangeHandlingFee { get; set; }
                public string ChangeSeatNo { get; set; }
                public string ChangeSeatTypeName { get; set; }
                public double? ChangeServiceFee { get; set; }
                public string ChangeTrainTypeName { get; set; }
                public string CheckInTime { get; set; }
                public string CheckOutTime { get; set; }
                public string EndTime { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string OriginTicketNo { get; set; }
                public string OutTicketStatus { get; set; }
                public string StartTime { get; set; }
                public string TicketNo { get; set; }
            }
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }
            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModulePassengerInfoList : TeaModel {
                public long? CostCenterId { get; set; }
                public string CostCenterName { get; set; }
                public string CostCenterNumber { get; set; }
                public string ProjectCode { get; set; }
                public long? ProjectId { get; set; }
                public string ProjectTitle { get; set; }
                public string ThirdpartProjectId { get; set; }
                public string UserId { get; set; }
                public string UserName { get; set; }
                public int? UserType { get; set; }
            }
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                public int? CategoryCode { get; set; }
                public string GmtCreate { get; set; }
                public string PassengerName { get; set; }
                public int? PayType { get; set; }
                public double? Price { get; set; }
                public string TradeId { get; set; }
                public int? Type { get; set; }
            }
            [NameInMap("refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleRefundTicketInfoList> RefundTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleRefundTicketInfoList : TeaModel {
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public double? RefundFee { get; set; }
                public double? RefundServiceFee { get; set; }
                public string TicketNo { get; set; }
            }
            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleTicketInfoList : TeaModel {
                public bool? Changed { get; set; }
                public string CheckInTime { get; set; }
                public string CheckOutTime { get; set; }
                public string CoachNo { get; set; }
                public string EndTime { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string OutTicketStatus { get; set; }
                public int? PayType { get; set; }
                public string SeatNo { get; set; }
                public string SeatTypeName { get; set; }
                public double? ServiceFee { get; set; }
                public string StartTime { get; set; }
                public string TicketNo { get; set; }
                public double? TicketPrice { get; set; }
                public int? TicketStatus { get; set; }
                public string TrainTypeName { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("train_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleTrainInfo TrainInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleTrainInfo : TeaModel {
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                [NameInMap("run_time")]
                [Validation(Required=false)]
                public long? RunTime { get; set; }

                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

            }
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
