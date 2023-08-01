// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderQueryV2ResponseBodyModule Module { get; set; }
        public class TrainOrderQueryV2ResponseBodyModule : TeaModel {
            [NameInMap("change_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModuleChangeTicketInfoList> ChangeTicketInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleChangeTicketInfoList : TeaModel {
                [NameInMap("change_coach_no")]
                [Validation(Required=false)]
                public string ChangeCoachNo { get; set; }

                [NameInMap("change_gap_fee")]
                [Validation(Required=false)]
                public double? ChangeGapFee { get; set; }

                [NameInMap("change_handling_fee")]
                [Validation(Required=false)]
                public double? ChangeHandlingFee { get; set; }

                [NameInMap("change_seat_no")]
                [Validation(Required=false)]
                public string ChangeSeatNo { get; set; }

                [NameInMap("change_seat_type_name")]
                [Validation(Required=false)]
                public string ChangeSeatTypeName { get; set; }

                [NameInMap("change_service_fee")]
                [Validation(Required=false)]
                public double? ChangeServiceFee { get; set; }

                [NameInMap("change_train_no")]
                [Validation(Required=false)]
                public string ChangeTrainNo { get; set; }

                [NameInMap("change_train_type_name")]
                [Validation(Required=false)]
                public string ChangeTrainTypeName { get; set; }

                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("from_city_name")]
                [Validation(Required=false)]
                public string FromCityName { get; set; }

                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("to_city_name")]
                [Validation(Required=false)]
                public string ToCityName { get; set; }

                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                [NameInMap("use_ticket")]
                [Validation(Required=false)]
                public string UseTicket { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

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

                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                [NameInMap("exceed_thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdpartApplyId { get; set; }

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

                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_nick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModulePassengerInfoList : TeaModel {
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModuleRefundTicketInfoList> RefundTicketInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleRefundTicketInfoList : TeaModel {
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                [NameInMap("refund_service_fee")]
                [Validation(Required=false)]
                public double? RefundServiceFee { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("train_order_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleTrainOrderInfo TrainOrderInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfo : TeaModel {
                [NameInMap("train_info_list")]
                [Validation(Required=false)]
                public List<TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoList> TrainInfoList { get; set; }
                public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoList : TeaModel {
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("from_city_ad_code")]
                    [Validation(Required=false)]
                    public string FromCityAdCode { get; set; }

                    [NameInMap("from_city_name")]
                    [Validation(Required=false)]
                    public string FromCityName { get; set; }

                    [NameInMap("from_station_name")]
                    [Validation(Required=false)]
                    public string FromStationName { get; set; }

                    /// <summary>
                    /// itemId
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("run_time")]
                    [Validation(Required=false)]
                    public long? RunTime { get; set; }

                    [NameInMap("to_city_ad_code")]
                    [Validation(Required=false)]
                    public string ToCityAdCode { get; set; }

                    [NameInMap("to_city_name")]
                    [Validation(Required=false)]
                    public string ToCityName { get; set; }

                    [NameInMap("to_station_name")]
                    [Validation(Required=false)]
                    public string ToStationName { get; set; }

                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                    [NameInMap("train_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos> TrainTicketInfos { get; set; }
                    public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos : TeaModel {
                        [NameInMap("changed")]
                        [Validation(Required=false)]
                        public bool? Changed { get; set; }

                        [NameInMap("check_in_time")]
                        [Validation(Required=false)]
                        public string CheckInTime { get; set; }

                        [NameInMap("check_out_time")]
                        [Validation(Required=false)]
                        public string CheckOutTime { get; set; }

                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        [NameInMap("end_time")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("gmt_create")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmt_modify")]
                        [Validation(Required=false)]
                        public string GmtModify { get; set; }

                        [NameInMap("out_ticket_status")]
                        [Validation(Required=false)]
                        public string OutTicketStatus { get; set; }

                        [NameInMap("pay_type")]
                        [Validation(Required=false)]
                        public int? PayType { get; set; }

                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        [NameInMap("seat_type_name")]
                        [Validation(Required=false)]
                        public string SeatTypeName { get; set; }

                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        [NameInMap("service_fee")]
                        [Validation(Required=false)]
                        public double? ServiceFee { get; set; }

                        [NameInMap("start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ticket_no")]
                        [Validation(Required=false)]
                        public string TicketNo { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public double? TicketPrice { get; set; }

                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public int? TicketStatus { get; set; }

                        [NameInMap("train_type_name")]
                        [Validation(Required=false)]
                        public string TrainTypeName { get; set; }

                        [NameInMap("use_ticket")]
                        [Validation(Required=false)]
                        public string UseTicket { get; set; }

                        [NameInMap("user_id")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }

                [NameInMap("train_transfer_info")]
                [Validation(Required=false)]
                public TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo TrainTransferInfo { get; set; }
                public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo : TeaModel {
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    [NameInMap("end_time")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("from_city_ad_code")]
                    [Validation(Required=false)]
                    public string FromCityAdCode { get; set; }

                    [NameInMap("from_city_name")]
                    [Validation(Required=false)]
                    public string FromCityName { get; set; }

                    [NameInMap("from_station_name")]
                    [Validation(Required=false)]
                    public string FromStationName { get; set; }

                    [NameInMap("middle_city")]
                    [Validation(Required=false)]
                    public string MiddleCity { get; set; }

                    [NameInMap("middle_city_ad_code")]
                    [Validation(Required=false)]
                    public string MiddleCityAdCode { get; set; }

                    [NameInMap("middle_date")]
                    [Validation(Required=false)]
                    public string MiddleDate { get; set; }

                    [NameInMap("middle_station")]
                    [Validation(Required=false)]
                    public string MiddleStation { get; set; }

                    [NameInMap("middle_type")]
                    [Validation(Required=false)]
                    public string MiddleType { get; set; }

                    [NameInMap("start_time")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("to_city_ad_code")]
                    [Validation(Required=false)]
                    public string ToCityAdCode { get; set; }

                    [NameInMap("to_city_name")]
                    [Validation(Required=false)]
                    public string ToCityName { get; set; }

                    [NameInMap("to_station_name")]
                    [Validation(Required=false)]
                    public string ToStationName { get; set; }

                    [NameInMap("wait_time")]
                    [Validation(Required=false)]
                    public string WaitTime { get; set; }

                }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
