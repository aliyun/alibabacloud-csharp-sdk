// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderDetailQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
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
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    [NameInMap("book_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos> BookTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleBookInfosBookTrainInfosBookTicketInfos : TeaModel {
                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public int? TicketStatus { get; set; }

                        [NameInMap("ticket_type")]
                        [Validation(Required=false)]
                        public string TicketType { get; set; }

                    }

                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                [NameInMap("last_pay_time")]
                [Validation(Required=false)]
                public string LastPayTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("change_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleChangeInfos> ChangeInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleChangeInfos : TeaModel {
                [NameInMap("change_apply_id")]
                [Validation(Required=false)]
                public string ChangeApplyId { get; set; }

                [NameInMap("change_train_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos> ChangeTrainInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfos : TeaModel {
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    [NameInMap("arrive_time")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    [NameInMap("change_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos> ChangeTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleChangeInfosChangeTrainInfosChangeTicketInfos : TeaModel {
                        [NameInMap("change_cost")]
                        [Validation(Required=false)]
                        public long? ChangeCost { get; set; }

                        [NameInMap("change_diff")]
                        [Validation(Required=false)]
                        public long? ChangeDiff { get; set; }

                        [NameInMap("change_gap_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeGapHandingFee { get; set; }

                        [NameInMap("change_min_ticket_amount_handing_fee")]
                        [Validation(Required=false)]
                        public long? ChangeMinTicketAmountHandingFee { get; set; }

                        [NameInMap("coach_no")]
                        [Validation(Required=false)]
                        public string CoachNo { get; set; }

                        [NameInMap("fail_code")]
                        [Validation(Required=false)]
                        public string FailCode { get; set; }

                        [NameInMap("fail_reason")]
                        [Validation(Required=false)]
                        public string FailReason { get; set; }

                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        [NameInMap("real_ticket_price")]
                        [Validation(Required=false)]
                        public long? RealTicketPrice { get; set; }

                        [NameInMap("seat_no")]
                        [Validation(Required=false)]
                        public string SeatNo { get; set; }

                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        [NameInMap("ticket_entrance")]
                        [Validation(Required=false)]
                        public string TicketEntrance { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        [NameInMap("ticket_status")]
                        [Validation(Required=false)]
                        public string TicketStatus { get; set; }

                    }

                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                [NameInMap("limit_pay_time")]
                [Validation(Required=false)]
                public string LimitPayTime { get; set; }

                [NameInMap("out_change_apply_id")]
                [Validation(Required=false)]
                public string OutChangeApplyId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("offlineRefundDetails")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails> OfflineRefundDetails { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetails : TeaModel {
                [NameInMap("offline_refund_id")]
                [Validation(Required=false)]
                public string OfflineRefundId { get; set; }

                [NameInMap("offline_refund_infos")]
                [Validation(Required=false)]
                public List<TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos> OfflineRefundInfos { get; set; }
                public class TrainOrderDetailQueryResponseBodyModuleOfflineRefundDetailsOfflineRefundInfos : TeaModel {
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                [NameInMap("offline_refund_type")]
                [Validation(Required=false)]
                public string OfflineRefundType { get; set; }

                [NameInMap("refund_total_price")]
                [Validation(Required=false)]
                public long? RefundTotalPrice { get; set; }

            }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

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

                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    [NameInMap("cost_center_no")]
                    [Validation(Required=false)]
                    public string CostCenterNo { get; set; }

                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                    [NameInMap("invoice_id")]
                    [Validation(Required=false)]
                    public string InvoiceId { get; set; }

                    [NameInMap("invoice_title")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    [NameInMap("project_code")]
                    [Validation(Required=false)]
                    public string ProjectCode { get; set; }

                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                }

                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("passenger_mobile")]
                [Validation(Required=false)]
                public string PassengerMobile { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("valid_date_end")]
                [Validation(Required=false)]
                public string ValidDateEnd { get; set; }

            }

            [NameInMap("refund_infos")]
            [Validation(Required=false)]
            public List<TrainOrderDetailQueryResponseBodyModuleRefundInfos> RefundInfos { get; set; }
            public class TrainOrderDetailQueryResponseBodyModuleRefundInfos : TeaModel {
                [NameInMap("fail_code")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                [NameInMap("fail_msg")]
                [Validation(Required=false)]
                public string FailMsg { get; set; }

                [NameInMap("out_refund_id")]
                [Validation(Required=false)]
                public string OutRefundId { get; set; }

                /// <summary>
                /// String
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

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("refund_ticket_infos")]
                    [Validation(Required=false)]
                    public List<TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos> RefundTicketInfos { get; set; }
                    public class TrainOrderDetailQueryResponseBodyModuleRefundInfosRefundTrainInfoRefundTicketInfos : TeaModel {
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        [NameInMap("refund_cost")]
                        [Validation(Required=false)]
                        public long? RefundCost { get; set; }

                        [NameInMap("refund_price")]
                        [Validation(Required=false)]
                        public long? RefundPrice { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                    }

                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
