// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderQueryResponseBodyModule Module { get; set; }
        public class TrainOrderQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of rescheduled tickets.</para>
            /// </summary>
            [NameInMap("change_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleChangeTicketInfoList> ChangeTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleChangeTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The carriage number after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>03</para>
                /// </summary>
                [NameInMap("change_coach_no")]
                [Validation(Required=false)]
                public string ChangeCoachNo { get; set; }

                /// <summary>
                /// <para>The price difference for rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_gap_fee")]
                [Validation(Required=false)]
                public double? ChangeGapFee { get; set; }

                /// <summary>
                /// <para>The rescheduling handling fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_handling_fee")]
                [Validation(Required=false)]
                public double? ChangeHandlingFee { get; set; }

                /// <summary>
                /// <para>The seat number after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>004C</para>
                /// </summary>
                [NameInMap("change_seat_no")]
                [Validation(Required=false)]
                public string ChangeSeatNo { get; set; }

                /// <summary>
                /// <para>The seat type after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Second class seat.</para>
                /// </summary>
                [NameInMap("change_seat_type_name")]
                [Validation(Required=false)]
                public string ChangeSeatTypeName { get; set; }

                /// <summary>
                /// <para>The rescheduling service fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_service_fee")]
                [Validation(Required=false)]
                public double? ChangeServiceFee { get; set; }

                /// <summary>
                /// <para>The rescheduled train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>D103</para>
                /// </summary>
                [NameInMap("change_train_no")]
                [Validation(Required=false)]
                public string ChangeTrainNo { get; set; }

                /// <summary>
                /// <para>The train type after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>High-speed rail.</para>
                /// </summary>
                [NameInMap("change_train_type_name")]
                [Validation(Required=false)]
                public string ChangeTrainTypeName { get; set; }

                /// <summary>
                /// <para>The check-in time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <para>The check-out time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <para>The arrival time of the rescheduled ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The departure station after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing.</para>
                /// </summary>
                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The original ticket number before rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                /// <summary>
                /// <para>The external ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m</para>
                /// </summary>
                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                /// <summary>
                /// <para>The departure time of the rescheduled ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The rescheduled ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The destination station after rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shanghai.</para>
                /// </summary>
                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <para>The invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11754</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test invoice title.</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The basic order information.</para>
            /// </summary>
            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <para>The application form ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11657</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The reason for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business trip.</para>
                /// </summary>
                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Smith.</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise ID.</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The enterprise name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise name.</para>
                /// </summary>
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// <para>The department ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department ID.</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <para>The department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department name.</para>
                /// </summary>
                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <para>The approval ID for exceeding the train ticket standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>The third-party approval ID for exceeding the train ticket standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022113021030003600001715</para>
                /// </summary>
                [NameInMap("exceed_third_part_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdPartApplyId { get; set; }

                /// <summary>
                /// <para>The time when the order was created.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the order was updated.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kaxasevesguikxn123kixnghid</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2627694109810885616</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <para>The third-party application form ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-EDES9898</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The third-party enterprise ID. Deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Third-party enterprise ID.</para>
                /// </summary>
                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kaxasevesguikxn123kixnghid</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The trip type specified in the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User ID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The list of passengers.</para>
            /// </summary>
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModulePassengerInfoList : TeaModel {
                /// <summary>
                /// <para>The cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11564</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test cost center.</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The cost center code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSP-01</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22562</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test project.</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-22562</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User ID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Smith.</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The passenger type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The list of order fees.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <para>The transaction category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The time when the transaction record was created.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The passenger names. Multiple names are separated by a forward slash (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Smith/Jane Doe.</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The transaction serial number of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312312001</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <para>The fund flow direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The list of refunded tickets.</para>
            /// </summary>
            [NameInMap("refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleRefundTicketInfoList> RefundTicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleRefundTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                /// <summary>
                /// <para>The service fee refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("refund_service_fee")]
                [Validation(Required=false)]
                public double? RefundServiceFee { get; set; }

                /// <summary>
                /// <para>The refunded ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            /// <summary>
            /// <para>The list of original ticket information.</para>
            /// </summary>
            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class TrainOrderQueryResponseBodyModuleTicketInfoList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the ticket has been rescheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                /// <summary>
                /// <para>The check-in time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <para>The check-out time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <para>The carriage number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("coach_no")]
                [Validation(Required=false)]
                public string CoachNo { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The external order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m</para>
                /// </summary>
                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                /// <summary>
                /// <para>The payment method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The seat number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A001</para>
                /// </summary>
                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                /// <summary>
                /// <para>The seat type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hard seat.</para>
                /// </summary>
                [NameInMap("seat_type_name")]
                [Validation(Required=false)]
                public string SeatTypeName { get; set; }

                /// <summary>
                /// <para>The booking service fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The ticket price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <para>The ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public int? TicketStatus { get; set; }

                /// <summary>
                /// <para>The train type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Express.</para>
                /// </summary>
                [NameInMap("train_type_name")]
                [Validation(Required=false)]
                public string TrainTypeName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User ID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The train information.</para>
            /// </summary>
            [NameInMap("train_info")]
            [Validation(Required=false)]
            public TrainOrderQueryResponseBodyModuleTrainInfo TrainInfo { get; set; }
            public class TrainOrderQueryResponseBodyModuleTrainInfo : TeaModel {
                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("from_city_ad_code")]
                [Validation(Required=false)]
                public string FromCityAdCode { get; set; }

                /// <summary>
                /// <para>The name of the departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing West Railway Station.</para>
                /// </summary>
                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                /// <summary>
                /// <para>The travel duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("run_time")]
                [Validation(Required=false)]
                public long? RunTime { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("to_city_ad_code")]
                [Validation(Required=false)]
                public string ToCityAdCode { get; set; }

                /// <summary>
                /// <para>The name of the destination station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou East Railway Station.</para>
                /// </summary>
                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                /// <summary>
                /// <para>The train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-150</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>The trace ID for logging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
