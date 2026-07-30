// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderQueryV2ResponseBodyModule Module { get; set; }
        public class TrainOrderQueryV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The change ticket information.</para>
            /// </summary>
            [NameInMap("change_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModuleChangeTicketInfoList> ChangeTicketInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleChangeTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The coach number after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>03</para>
                /// </summary>
                [NameInMap("change_coach_no")]
                [Validation(Required=false)]
                public string ChangeCoachNo { get; set; }

                /// <summary>
                /// <para>The refund for the price difference.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_gap_fee")]
                [Validation(Required=false)]
                public double? ChangeGapFee { get; set; }

                /// <summary>
                /// <para>The handling fee for the ticket change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_handling_fee")]
                [Validation(Required=false)]
                public double? ChangeHandlingFee { get; set; }

                /// <summary>
                /// <para>The change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2849819724653209258</para>
                /// </summary>
                [NameInMap("change_order_id")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The seat number after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>004C</para>
                /// </summary>
                [NameInMap("change_seat_no")]
                [Validation(Required=false)]
                public string ChangeSeatNo { get; set; }

                /// <summary>
                /// <para>The train type after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>二等座</para>
                /// </summary>
                [NameInMap("change_seat_type_name")]
                [Validation(Required=false)]
                public string ChangeSeatTypeName { get; set; }

                /// <summary>
                /// <para>The service fee for the ticket change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_service_fee")]
                [Validation(Required=false)]
                public double? ChangeServiceFee { get; set; }

                /// <summary>
                /// <para>The train number after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>D103</para>
                /// </summary>
                [NameInMap("change_train_no")]
                [Validation(Required=false)]
                public string ChangeTrainNo { get; set; }

                /// <summary>
                /// <para>The seat type after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高铁</para>
                /// </summary>
                [NameInMap("change_train_type_name")]
                [Validation(Required=false)]
                public string ChangeTrainTypeName { get; set; }

                /// <summary>
                /// <para>The station entry time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <para>The station exit time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <para>The arrival time of the changed ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The city-level departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("from_city_name")]
                [Validation(Required=false)]
                public string FromCityName { get; set; }

                /// <summary>
                /// <para>The departure station after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("from_station_name")]
                [Validation(Required=false)]
                public string FromStationName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The original ticket number before the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                /// <summary>
                /// <para>The 12306 ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m</para>
                /// </summary>
                [NameInMap("out_ticket_status")]
                [Validation(Required=false)]
                public string OutTicketStatus { get; set; }

                /// <summary>
                /// <para>The segment index of the journey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The 12306 ticket collection number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECW0603604</para>
                /// </summary>
                [NameInMap("short_ticket_no")]
                [Validation(Required=false)]
                public string ShortTicketNo { get; set; }

                /// <summary>
                /// <para>The departure time of the changed ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ticket gate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2B</para>
                /// </summary>
                [NameInMap("ticket_entrance")]
                [Validation(Required=false)]
                public string TicketEntrance { get; set; }

                /// <summary>
                /// <para>The ticket number after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

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
                /// <para>The city-level destination city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("to_city_name")]
                [Validation(Required=false)]
                public string ToCityName { get; set; }

                /// <summary>
                /// <para>The arrival station after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                /// <summary>
                /// <para>Indicates whether the ticket has been used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("use_ticket")]
                [Validation(Required=false)]
                public string UseTicket { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <para>The invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3815504</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>抬头发票</para>
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
            public TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1003784135</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The travel reason in the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州出差</para>
                /// </summary>
                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <para>The contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The contact phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12110002222</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <para>The enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>btripsy4yd7v0gdpdntpp</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The enterprise name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里商旅</para>
                /// </summary>
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// <para>The department ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>部门id</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <para>The department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>行政部</para>
                /// </summary>
                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <para>The excess application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>The third-party excess application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The order creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The order update time.</para>
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
                /// <para>42942924</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2849819724653209258</para>
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
                /// <para>The new order IDs associated with the supplementary booking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2849819724653209258</para>
                /// </summary>
                [NameInMap("replenish_order_ids")]
                [Validation(Required=false)]
                public string ReplenishOrderIds { get; set; }

                /// <summary>
                /// <para>The original order ID associated with the supplementary booking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2849819724653209258</para>
                /// </summary>
                [NameInMap("replenish_original_order_id")]
                [Validation(Required=false)]
                public string ReplenishOriginalOrderId { get; set; }

                /// <summary>
                /// <para>The external approval ID displayed to the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00021230721000002Test-2</para>
                /// </summary>
                [NameInMap("thirdPart_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                /// <summary>
                /// <para>The third-party application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01-2023-01214</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The third-party department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DHDI2209141OEGHWRN</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                /// <summary>
                /// <para>The DingTalk ID of the order creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231212</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The user nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>昵称</para>
                /// </summary>
                [NameInMap("user_nick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

            /// <summary>
            /// <para>The passenger information.</para>
            /// </summary>
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModulePassengerInfoList : TeaModel {
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
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The cost center code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-3345</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-PROJECT</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>133576</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-KDISL</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

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
                /// <para>The DingTalk ID of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The name of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
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
            /// <para>The order cost information.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <para>The transaction category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The creation time of the transaction record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669344020</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The passenger name. Multiple passengers are separated by a forward slash (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三/李四</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The transaction amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678910987654321</para>
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
            /// <para>The refund ticket information.</para>
            /// </summary>
            [NameInMap("refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderQueryV2ResponseBodyModuleRefundTicketInfoList> RefundTicketInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleRefundTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The refund application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>284981</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

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
                /// <para>The service fee for the refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("refund_service_fee")]
                [Validation(Required=false)]
                public double? RefundServiceFee { get; set; }

                /// <summary>
                /// <para>The ticket number for the refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The forward trip train information.</para>
            /// </summary>
            [NameInMap("train_order_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleTrainOrderInfo TrainOrderInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfo : TeaModel {
                /// <summary>
                /// <para>The train information.</para>
                /// </summary>
                [NameInMap("train_info_list")]
                [Validation(Required=false)]
                public List<TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoList> TrainInfoList { get; set; }
                public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoList : TeaModel {
                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-05-15T22:27Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-05-15T22:27Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The city-level departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("from_city_ad_code")]
                    [Validation(Required=false)]
                    public string FromCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The city-level departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("from_city_name")]
                    [Validation(Required=false)]
                    public string FromCityName { get; set; }

                    /// <summary>
                    /// <para>The departure station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("from_station_name")]
                    [Validation(Required=false)]
                    public string FromStationName { get; set; }

                    /// <summary>
                    /// <para>itemId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12312</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// <para>The travel duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("run_time")]
                    [Validation(Required=false)]
                    public long? RunTime { get; set; }

                    /// <summary>
                    /// <para>The county-level departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330127</para>
                    /// </summary>
                    [NameInMap("sub_from_city_ad_code")]
                    [Validation(Required=false)]
                    public string SubFromCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The county-level departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>淳安</para>
                    /// </summary>
                    [NameInMap("sub_from_city_ad_name")]
                    [Validation(Required=false)]
                    public string SubFromCityAdName { get; set; }

                    /// <summary>
                    /// <para>The county-level destination city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330483</para>
                    /// </summary>
                    [NameInMap("sub_to_city_code")]
                    [Validation(Required=false)]
                    public string SubToCityCode { get; set; }

                    /// <summary>
                    /// <para>The county-level destination city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>桐乡</para>
                    /// </summary>
                    [NameInMap("sub_to_city_name")]
                    [Validation(Required=false)]
                    public string SubToCityName { get; set; }

                    /// <summary>
                    /// <para>The city-level destination city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("to_city_ad_code")]
                    [Validation(Required=false)]
                    public string ToCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The city-level destination city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上海</para>
                    /// </summary>
                    [NameInMap("to_city_name")]
                    [Validation(Required=false)]
                    public string ToCityName { get; set; }

                    /// <summary>
                    /// <para>The destination station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上海</para>
                    /// </summary>
                    [NameInMap("to_station_name")]
                    [Validation(Required=false)]
                    public string ToStationName { get; set; }

                    /// <summary>
                    /// <para>The train number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>D11</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                    /// <summary>
                    /// <para>The ticket information.</para>
                    /// </summary>
                    [NameInMap("train_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos> TrainTicketInfos { get; set; }
                    public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the ticket has been changed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("changed")]
                        [Validation(Required=false)]
                        public bool? Changed { get; set; }

                        /// <summary>
                        /// <para>The station entry time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("check_in_time")]
                        [Validation(Required=false)]
                        public string CheckInTime { get; set; }

                        /// <summary>
                        /// <para>The station exit time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("check_out_time")]
                        [Validation(Required=false)]
                        public string CheckOutTime { get; set; }

                        /// <summary>
                        /// <para>The coach number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>01</para>
                        /// </summary>
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        /// <summary>
                        /// <para>The arrival time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("end_time")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The creation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("gmt_create")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        /// <summary>
                        /// <para>The modification time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("gmt_modify")]
                        [Validation(Required=false)]
                        public string GmtModify { get; set; }

                        /// <summary>
                        /// <para>The 12306 ticket status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("out_ticket_status")]
                        [Validation(Required=false)]
                        public string OutTicketStatus { get; set; }

                        /// <summary>
                        /// <para>The ticket payment method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("pay_type")]
                        [Validation(Required=false)]
                        public int? PayType { get; set; }

                        /// <summary>
                        /// <para>The seat number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>02A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        /// <summary>
                        /// <para>The seat type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>硬座</para>
                        /// </summary>
                        [NameInMap("seat_type_name")]
                        [Validation(Required=false)]
                        public string SeatTypeName { get; set; }

                        /// <summary>
                        /// <para>The segment index, starting from 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        /// <summary>
                        /// <para>The booking service fee.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("service_fee")]
                        [Validation(Required=false)]
                        public double? ServiceFee { get; set; }

                        /// <summary>
                        /// <para>The 12306 ticket collection number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ECW0603604</para>
                        /// </summary>
                        [NameInMap("short_ticket_no")]
                        [Validation(Required=false)]
                        public string ShortTicketNo { get; set; }

                        /// <summary>
                        /// <para>The departure time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-05-15T22:27Z</para>
                        /// </summary>
                        [NameInMap("start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The ticket gate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2B</para>
                        /// </summary>
                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <para>The ticket number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ew123121</para>
                        /// </summary>
                        [NameInMap("ticket_no")]
                        [Validation(Required=false)]
                        public string TicketNo { get; set; }

                        /// <summary>
                        /// <para>The ticket price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>400</para>
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
                        /// <para>高铁</para>
                        /// </summary>
                        [NameInMap("train_type_name")]
                        [Validation(Required=false)]
                        public string TrainTypeName { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ticket has been used.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("use_ticket")]
                        [Validation(Required=false)]
                        public string UseTicket { get; set; }

                        /// <summary>
                        /// <para>The DingTalk ID of the passenger associated with the ticket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>231212</para>
                        /// </summary>
                        [NameInMap("user_id")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The transfer information.</para>
                /// </summary>
                [NameInMap("train_transfer_info")]
                [Validation(Required=false)]
                public TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo TrainTransferInfo { get; set; }
                public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo : TeaModel {
                    /// <summary>
                    /// <para>The total duration in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-11-15 00:00:00</para>
                    /// </summary>
                    [NameInMap("end_time")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The city-level departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("from_city_ad_code")]
                    [Validation(Required=false)]
                    public string FromCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The city-level departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("from_city_name")]
                    [Validation(Required=false)]
                    public string FromCityName { get; set; }

                    /// <summary>
                    /// <para>The departure station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("from_station_name")]
                    [Validation(Required=false)]
                    public string FromStationName { get; set; }

                    /// <summary>
                    /// <para>The city-level transfer city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("middle_city")]
                    [Validation(Required=false)]
                    public string MiddleCity { get; set; }

                    /// <summary>
                    /// <para>The city-level transfer city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("middle_city_ad_code")]
                    [Validation(Required=false)]
                    public string MiddleCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The transfer date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-29 18:10:00</para>
                    /// </summary>
                    [NameInMap("middle_date")]
                    [Validation(Required=false)]
                    public string MiddleDate { get; set; }

                    /// <summary>
                    /// <para>The transfer station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州南</para>
                    /// </summary>
                    [NameInMap("middle_station")]
                    [Validation(Required=false)]
                    public string MiddleStation { get; set; }

                    /// <summary>
                    /// <para>The transfer mode. 1: same station. 2: different station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>同站</para>
                    /// </summary>
                    [NameInMap("middle_type")]
                    [Validation(Required=false)]
                    public string MiddleType { get; set; }

                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-11-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("start_time")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The county-level departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330127</para>
                    /// </summary>
                    [NameInMap("sub_from_city_ad_code")]
                    [Validation(Required=false)]
                    public string SubFromCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The county-level departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>淳安</para>
                    /// </summary>
                    [NameInMap("sub_from_city_ad_name")]
                    [Validation(Required=false)]
                    public string SubFromCityAdName { get; set; }

                    /// <summary>
                    /// <para>The county-level transfer city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330127</para>
                    /// </summary>
                    [NameInMap("sub_middle_city_code")]
                    [Validation(Required=false)]
                    public string SubMiddleCityCode { get; set; }

                    /// <summary>
                    /// <para>The county-level transfer city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>淳安</para>
                    /// </summary>
                    [NameInMap("sub_middle_city_name")]
                    [Validation(Required=false)]
                    public string SubMiddleCityName { get; set; }

                    /// <summary>
                    /// <para>The county-level destination city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330483</para>
                    /// </summary>
                    [NameInMap("sub_to_city_code")]
                    [Validation(Required=false)]
                    public string SubToCityCode { get; set; }

                    /// <summary>
                    /// <para>The county-level destination city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>桐乡</para>
                    /// </summary>
                    [NameInMap("sub_to_city_name")]
                    [Validation(Required=false)]
                    public string SubToCityName { get; set; }

                    /// <summary>
                    /// <para>The city-level destination city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("to_city_ad_code")]
                    [Validation(Required=false)]
                    public string ToCityAdCode { get; set; }

                    /// <summary>
                    /// <para>The city-level destination city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上海</para>
                    /// </summary>
                    [NameInMap("to_city_name")]
                    [Validation(Required=false)]
                    public string ToCityName { get; set; }

                    /// <summary>
                    /// <para>The destination station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上海</para>
                    /// </summary>
                    [NameInMap("to_station_name")]
                    [Validation(Required=false)]
                    public string ToStationName { get; set; }

                    /// <summary>
                    /// <para>The transfer wait time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("wait_time")]
                    [Validation(Required=false)]
                    public string WaitTime { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1213ds1d</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>123412dcdsac sd</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
