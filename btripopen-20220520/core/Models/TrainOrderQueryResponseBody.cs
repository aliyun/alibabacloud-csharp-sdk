// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderQueryResponseBodyModule Module { get; set; }
        public class TrainOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("change_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleChangeTicketInfoList> ChangeTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleChangeTicketInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>03</para>
                /// </summary>
                [NameInMap("change_coach_no")]
                [Validation(Required=false)]
                public string ChangeCoachNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_gap_fee")]
                [Validation(Required=false)]
                public double? ChangeGapFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_handling_fee")]
                [Validation(Required=false)]
                public double? ChangeHandlingFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>004C</para>
                /// </summary>
                [NameInMap("change_seat_no")]
                [Validation(Required=false)]
                public string ChangeSeatNo { get; set; }

                [NameInMap("change_seat_type_name")]
                [Validation(Required=false)]
                public string ChangeSeatTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_service_fee")]
                [Validation(Required=false)]
                public double? ChangeServiceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>D103</para>
                /// </summary>
                [NameInMap("change_train_no")]
                [Validation(Required=false)]
                public string ChangeTrainNo { get; set; }

                [NameInMap("change_train_type_name")]
                [Validation(Required=false)]
                public string ChangeTrainTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m</para>
                /// </summary>
                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11754</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>11657</para>
                /// </summary>
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

                /// <summary>
                /// <para>火车票超标审批id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>火车票超标审批三方id</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022113021030003600001715</para>
                /// </summary>
                [NameInMap("exceed_third_part_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdPartApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kaxasevesguikxn123kixnghid</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2627694109810885616</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-EDES9898</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kaxasevesguikxn123kixnghid</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>11564</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CSP-01</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22562</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-22562</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12312312001</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleRefundTicketInfoList> RefundTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleRefundTicketInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("refund_service_fee")]
                [Validation(Required=false)]
                public double? RefundServiceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleTicketInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("coach_no")]
                [Validation(Required=false)]
                public string CoachNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m</para>
                /// </summary>
                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A001</para>
                /// </summary>
                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                [NameInMap("seat_type_name")]
                [Validation(Required=false)]
                public string SeatTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public int? TicketStatus { get; set; }

                [NameInMap("train_type_name")]
                [Validation(Required=false)]
                public string TrainTypeName { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("train_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleTrainInfo TrainInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleTrainInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("from_city_ad_code")]
                [Validation(Required=false)]
                public string FromCityAdCode { get; set; }

                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("run_time")]
                [Validation(Required=false)]
                public long? RunTime { get; set; }

                [NameInMap("to_city_ad_code")]
                [Validation(Required=false)]
                public string ToCityAdCode { get; set; }

                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-150</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

            }

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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
