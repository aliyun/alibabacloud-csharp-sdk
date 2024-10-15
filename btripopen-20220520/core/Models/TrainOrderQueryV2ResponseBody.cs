// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderQueryV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("ticket_entrance")]
                [Validation(Required=false)]
                public string TicketEntrance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS987JKDF</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public int? TicketStatus { get; set; }

                [NameInMap("to_city_name")]
                [Validation(Required=false)]
                public string ToCityName { get; set; }

                [NameInMap("to_station_name")]
                [Validation(Required=false)]
                public string ToStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("use_ticket")]
                [Validation(Required=false)]
                public string UseTicket { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12312</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public TrainOrderQueryV2ResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3815504</para>
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
            public TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class TrainOrderQueryV2ResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1003784135</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>12110002222</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>btripsy4yd7v0gdpdntpp</para>
                /// </summary>
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
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1422113021033961000</para>
                /// </summary>
                [NameInMap("exceed_thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdpartApplyId { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42942924</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2849819724653209258</para>
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

                [NameInMap("thirdPart_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>01-2023-01214</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DHDI2209141OEGHWRN</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231212</para>
                /// </summary>
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
                /// <para>CS-3345</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-PROJECT</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>133576</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-KDISL</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-22562</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
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
            public List<TrainOrderQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderQueryV2ResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669344020</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>176000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345678910987654321</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
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
                    /// <para>itemId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12312</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>D11</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                    [NameInMap("train_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos> TrainTicketInfos { get; set; }
                    public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainInfoListTrainTicketInfos : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("changed")]
                        [Validation(Required=false)]
                        public bool? Changed { get; set; }

                        [NameInMap("check_in_time")]
                        [Validation(Required=false)]
                        public string CheckInTime { get; set; }

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

                        [NameInMap("end_time")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("gmt_create")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmt_modify")]
                        [Validation(Required=false)]
                        public string GmtModify { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("out_ticket_status")]
                        [Validation(Required=false)]
                        public string OutTicketStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("pay_type")]
                        [Validation(Required=false)]
                        public int? PayType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>02A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        [NameInMap("seat_type_name")]
                        [Validation(Required=false)]
                        public string SeatTypeName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("service_fee")]
                        [Validation(Required=false)]
                        public double? ServiceFee { get; set; }

                        [NameInMap("start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ew123121</para>
                        /// </summary>
                        [NameInMap("ticket_no")]
                        [Validation(Required=false)]
                        public string TicketNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>400</para>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("use_ticket")]
                        [Validation(Required=false)]
                        public string UseTicket { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>231212</para>
                        /// </summary>
                        [NameInMap("user_id")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }

                [NameInMap("train_transfer_info")]
                [Validation(Required=false)]
                public TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo TrainTransferInfo { get; set; }
                public class TrainOrderQueryV2ResponseBodyModuleTrainOrderInfoTrainTransferInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-11-15 00:00:00</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-01-29 18:10:00</para>
                    /// </summary>
                    [NameInMap("middle_date")]
                    [Validation(Required=false)]
                    public string MiddleDate { get; set; }

                    [NameInMap("middle_station")]
                    [Validation(Required=false)]
                    public string MiddleStation { get; set; }

                    [NameInMap("middle_type")]
                    [Validation(Required=false)]
                    public string MiddleType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-11-01 00:00:00</para>
                    /// </summary>
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

                    /// <summary>
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
