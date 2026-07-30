// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderDetailQueryResponseBodyModule Module { get; set; }
        public class TrainOrderDetailQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The forward booking ticket details.</para>
            /// </summary>
            [NameInMap("book_infos")]
            [Validation(Required=false)]
            public TrainOrderDetailQueryResponseBodyModuleBookInfos BookInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleBookInfos : TeaModel {
                /// <summary>
                /// <para>The ticket information.</para>
                /// </summary>
                [NameInMap("book_train_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfos> BookTrainInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfos : TeaModel {
                    /// <summary>
                    /// <para>The arrival station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    /// <summary>
                    /// <para>The arrival station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头东</para>
                    /// </summary>
                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <para>The arrival time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-07 15:19:01</para>
                    /// </summary>
                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    /// <summary>
                    /// <para>The ticket information.</para>
                    /// </summary>
                    [NameInMap("book_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos> BookTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos : TeaModel {
                        /// <summary>
                        /// <para>The coach number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>04</para>
                        /// </summary>
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        /// <summary>
                        /// <para>The failure code. This is an enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1111</para>
                        /// </summary>
                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        /// <summary>
                        /// <para>The reason for ticketing failure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>出票失败</para>
                        /// </summary>
                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        /// <summary>
                        /// <para>The third-party passenger ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <para>The actual ticketing amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        /// <summary>
                        /// <para>The seat number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        /// <summary>
                        /// <para>The seat type. This is an enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        /// <summary>
                        /// <para>The ticket gate information in JSON format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <para>The ticket unit price, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        /// <summary>
                        /// <para>The ticket status. This is an enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public int? TicketStatus { get; set; }

                        /// <summary>
                        /// <para>The ticket type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: adult</description></item>
                        /// <item><description>1: child</description></item>
                        /// <item><description>2: infant</description></item>
                        /// <item><description>3: student</description></item>
                        /// <item><description>4: other</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ticket_type")]
                        [Validation(Required=false)]
                        public string TicketType { get; set; }

                    }

                    /// <summary>
                    /// <para>The departure station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    /// <summary>
                    /// <para>The departure station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头</para>
                    /// </summary>
                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <para>The departure time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The short train number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>D1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <para>The error code for ticketing failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                /// <summary>
                /// <para>The reason for ticketing failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出票失败</para>
                /// </summary>
                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                /// <summary>
                /// <para>The last payment time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("last_pay_time")]
                [Validation(Required=false)]
                public string LastPayTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The short ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GW123456</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            /// <summary>
            /// <para>The ticket change details.</para>
            /// </summary>
            [NameInMap("change_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleChangeInfos> ChangeInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleChangeInfos : TeaModel {
                /// <summary>
                /// <para>The business travel change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("change_apply_id")]
                [Validation(Required=false)]
                public string ChangeApplyId { get; set; }

                /// <summary>
                /// <para>The change ticket information.</para>
                /// </summary>
                [NameInMap("change_train_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos> ChangeTrainInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos : TeaModel {
                    /// <summary>
                    /// <para>The arrival station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    /// <summary>
                    /// <para>The arrival station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头东</para>
                    /// </summary>
                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <para>The arrival time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    /// <summary>
                    /// <para>The change ticket information.</para>
                    /// </summary>
                    [NameInMap("change_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos> ChangeTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos : TeaModel {
                        /// <summary>
                        /// <para>The total change handling fee, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_cost")]
                        [Validation(Required=false)]
                        public long? ChangeCost { get; set; }

                        /// <summary>
                        /// <para>The change price difference, in cents. A positive value indicates a payment is required, and a negative value indicates a refund.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_diff")]
                        [Validation(Required=false)]
                        public long? ChangeDiff { get; set; }

                        /// <summary>
                        /// <para>The handling fee for the price difference of the change, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_gap_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeGapHandingFee { get; set; }

                        /// <summary>
                        /// <para>The handling fee for changing to a lower fare, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_min_ticket_amount_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeMinTicketAmountHandingFee { get; set; }

                        /// <summary>
                        /// <para>The coach number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>04</para>
                        /// </summary>
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        /// <summary>
                        /// <para>The failure code. This is an enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4000</para>
                        /// </summary>
                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        /// <summary>
                        /// <para>The reason for ticketing failure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>出票失败</para>
                        /// </summary>
                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        /// <summary>
                        /// <para>The third-party passenger ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <para>The actual ticketing amount, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        /// <summary>
                        /// <para>The seat number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        /// <summary>
                        /// <para>The seat type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        /// <summary>
                        /// <para>The ticket gate information in JSON format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <para>The change ticket price, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        /// <summary>
                        /// <para>The ticket status. This is an enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public string TicketStatus { get; set; }

                    }

                    /// <summary>
                    /// <para>The departure station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    /// <summary>
                    /// <para>The departure station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头</para>
                    /// </summary>
                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <para>The departure time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The short train number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>D1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <para>The payment timeout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("limit_pay_time")]
                [Validation(Required=false)]
                public string LimitPayTime { get; set; }

                /// <summary>
                /// <para>The distributor change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("out_change_apply_id")]
                [Validation(Required=false)]
                public string OutChangeApplyId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The offline refund details.</para>
            /// </summary>
            [NameInMap("offlineRefundDetails")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails> OfflineRefundDetails { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails : TeaModel {
                /// <summary>
                /// <para>The refund order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("offline_refund_id")]
                [Validation(Required=false)]
                public string OfflineRefundId { get; set; }

                /// <summary>
                /// <para>The refund details.</para>
                /// </summary>
                [NameInMap("offline_refund_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos> OfflineRefundInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos : TeaModel {
                    /// <summary>
                    /// <para>The third-party passenger ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// <para>The refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                /// <summary>
                /// <para>The offline refund type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: offline refund</description></item>
                /// <item><description>2: offline change</description></item>
                /// <item><description>3: difference refund</description></item>
                /// <item><description>4: offline refund and change</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("offline_refund_type")]
                [Validation(Required=false)]
                public string OfflineRefundType { get; set; }

                /// <summary>
                /// <para>The total refund amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("refund_total_price")]
                [Validation(Required=false)]
                public long? RefundTotalPrice { get; set; }

            }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017028198411054446</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The distributor order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3703184209587306496</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The passenger list.</para>
            /// </summary>
            [NameInMap("passenger_info_s")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModulePassengerInfoS> PassengerInfoS { get; set; }
            public class TrainOrderDetailQueryResponseBodyModulePassengerInfoS : TeaModel {
                /// <summary>
                /// <para>The cost center information.</para>
                /// </summary>
                [NameInMap("cost_center_info")]
                [Validation(Required=false)]
                public TrainOrderDetailQueryResponseBodyModulePassengerInfoSCostCenterInfo CostCenterInfo { get; set; }
                public class TrainOrderDetailQueryResponseBodyModulePassengerInfoSCostCenterInfo : TeaModel {
                    /// <summary>
                    /// <para>The cascading department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>西北一部</para>
                    /// </summary>
                    [NameInMap("cascade_dept_name")]
                    [Validation(Required=false)]
                    public string CascadeDeptName { get; set; }

                    /// <summary>
                    /// <para>The cost center ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>111111</para>
                    /// </summary>
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    /// <summary>
                    /// <para>The cost center name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试</para>
                    /// </summary>
                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    /// <summary>
                    /// <para>The cost center number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("cost_center_no")]
                    [Validation(Required=false)]
                    public string CostCenterNo { get; set; }

                    /// <summary>
                    /// <para>The department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>582000002311</para>
                    /// </summary>
                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    /// <summary>
                    /// <para>The department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>西北</para>
                    /// </summary>
                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                    /// <summary>
                    /// <para>The invoice ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11111</para>
                    /// </summary>
                    [NameInMap("invoice_id")]
                    [Validation(Required=false)]
                    public string InvoiceId { get; set; }

                    /// <summary>
                    /// <para>The invoice title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>111111测试</para>
                    /// </summary>
                    [NameInMap("invoice_title")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// <para>The passenger information ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// <para>The project code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("project_code")]
                    [Validation(Required=false)]
                    public string ProjectCode { get; set; }

                    /// <summary>
                    /// <para>The project title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试</para>
                    /// </summary>
                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                }

                /// <summary>
                /// <para>The nationality code, encrypted with SM4. Required when the document type is not a national ID card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The ID document number, encrypted with SM4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                /// <summary>
                /// <para>The ID document type, encrypted with SM4. This is an enumerated value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>170d9ac6f8807f9ec603c688f45f78a41</para>
                /// </summary>
                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                /// <summary>
                /// <para>The passenger user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger mobile number, encrypted with SM4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
                /// </summary>
                [NameInMap("passenger_mobile")]
                [Validation(Required=false)]
                public string PassengerMobile { get; set; }

                /// <summary>
                /// <para>The passenger name, encrypted with SM4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The ID document expiration date, encrypted with SM4, in the format of yyyy-MM-dd. Required when the document type is not a national ID card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
                /// </summary>
                [NameInMap("valid_date_end")]
                [Validation(Required=false)]
                public string ValidDateEnd { get; set; }

            }

            /// <summary>
            /// <para>The refund details.</para>
            /// </summary>
            [NameInMap("refund_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleRefundInfos> RefundInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleRefundInfos : TeaModel {
                /// <summary>
                /// <para>The failure code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>失败</para>
                /// </summary>
                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                /// <summary>
                /// <para>The distributor refund order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456778</para>
                /// </summary>
                [NameInMap("out_refund_id")]
                [Validation(Required=false)]
                public string OutRefundId { get; set; }

                /// <summary>
                /// <para>String</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("refund_id")]
                [Validation(Required=false)]
                public string RefundId { get; set; }

                /// <summary>
                /// <para>The refund train information.</para>
                /// </summary>
                [NameInMap("refund_train_info")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfo> RefundTrainInfo { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfo : TeaModel {
                    /// <summary>
                    /// <para>The departure station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头东</para>
                    /// </summary>
                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <para>The arrival time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    /// <summary>
                    /// <para>The departure station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>包头</para>
                    /// </summary>
                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <para>The departure time, in the format of yyyy-MM-dd hh:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The refund train information.</para>
                    /// </summary>
                    [NameInMap("refund_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos> RefundTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos : TeaModel {
                        /// <summary>
                        /// <para>The third-party passenger ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <para>The refund service fee, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("refund_cost")]
                        [Validation(Required=false)]
                        public long? RefundCost { get; set; }

                        /// <summary>
                        /// <para>The refund amount, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("refund_price")]
                        [Validation(Required=false)]
                        public long? RefundPrice { get; set; }

                        /// <summary>
                        /// <para>The ticket unit price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                    }

                    /// <summary>
                    /// <para>The short train number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>K1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <para>The refund status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc81a17090871660176894d008c</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a05c16872420814992343d8a09</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
