// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
            [NameInMap("book_infos")]
            [Validation(Required=false)]
            public TrainOrderDetailQueryResponseBodyModuleBookInfos BookInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleBookInfos : TeaModel {
                [NameInMap("book_train_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfos> BookTrainInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-07 15:19:01</para>
                    /// </summary>
                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    [NameInMap("book_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos> BookTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>04</para>
                        /// </summary>
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1111</para>
                        /// </summary>
                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public int? TicketStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ticket_type")]
                        [Validation(Required=false)]
                        public string TicketType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>D1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("last_pay_time")]
                [Validation(Required=false)]
                public string LastPayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GW123456</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("change_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleChangeInfos> ChangeInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleChangeInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("change_apply_id")]
                [Validation(Required=false)]
                public string ChangeApplyId { get; set; }

                [NameInMap("change_train_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos> ChangeTrainInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    [NameInMap("change_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos> ChangeTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_cost")]
                        [Validation(Required=false)]
                        public long? ChangeCost { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_diff")]
                        [Validation(Required=false)]
                        public long? ChangeDiff { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_gap_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeGapHandingFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("change_min_ticket_amount_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeMinTicketAmountHandingFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>04</para>
                        /// </summary>
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4000</para>
                        /// </summary>
                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1A</para>
                        /// </summary>
                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public string TicketStatus { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>D1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("limit_pay_time")]
                [Validation(Required=false)]
                public string LimitPayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("out_change_apply_id")]
                [Validation(Required=false)]
                public string OutChangeApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("offlineRefundDetails")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails> OfflineRefundDetails { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("offline_refund_id")]
                [Validation(Required=false)]
                public string OfflineRefundId { get; set; }

                [NameInMap("offline_refund_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos> OfflineRefundInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("offline_refund_type")]
                [Validation(Required=false)]
                public string OfflineRefundType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("refund_total_price")]
                [Validation(Required=false)]
                public long? RefundTotalPrice { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017028198411054446</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3703184209587306496</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_info_s")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModulePassengerInfoS> PassengerInfoS { get; set; }
            public class TrainOrderDetailQueryResponseBodyModulePassengerInfoS : TeaModel {
                [NameInMap("cost_center_info")]
                [Validation(Required=false)]
                public TrainOrderDetailQueryResponseBodyModulePassengerInfoSCostCenterInfo CostCenterInfo { get; set; }
                public class TrainOrderDetailQueryResponseBodyModulePassengerInfoSCostCenterInfo : TeaModel {
                    [NameInMap("cascade_dept_name")]
                    [Validation(Required=false)]
                    public string CascadeDeptName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111111</para>
                    /// </summary>
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("cost_center_no")]
                    [Validation(Required=false)]
                    public string CostCenterNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>582000002311</para>
                    /// </summary>
                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11111</para>
                    /// </summary>
                    [NameInMap("invoice_id")]
                    [Validation(Required=false)]
                    public string InvoiceId { get; set; }

                    [NameInMap("invoice_title")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("project_code")]
                    [Validation(Required=false)]
                    public string ProjectCode { get; set; }

                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>170d9ac6f8807f9ec603c688f45f78a41</para>
                /// </summary>
                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
                /// </summary>
                [NameInMap("passenger_mobile")]
                [Validation(Required=false)]
                public string PassengerMobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
                /// </summary>
                [NameInMap("valid_date_end")]
                [Validation(Required=false)]
                public string ValidDateEnd { get; set; }

            }

            [NameInMap("refund_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleRefundInfos> RefundInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleRefundInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                /// <summary>
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

                [NameInMap("refund_train_info")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfo> RefundTrainInfo { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfo : TeaModel {
                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("refund_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos> RefundTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("refund_cost")]
                        [Validation(Required=false)]
                        public long? RefundCost { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("refund_price")]
                        [Validation(Required=false)]
                        public long? RefundPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>K1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210bc81a17090871660176894d008c</para>
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
