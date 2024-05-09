// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateRefundResponseBody : TeaModel {
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
        public TrainFeeCalculateRefundResponseBodyModule Module { get; set; }
        public class TrainFeeCalculateRefundResponseBodyModule : TeaModel {
            [NameInMap("distribute_order_id")]
            [Validation(Required=false)]
            public string DistributeOrderId { get; set; }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("refund_train_details")]
            [Validation(Required=false)]
            public List<TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetails> RefundTrainDetails { get; set; }
            public class TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetails : TeaModel {
                [NameInMap("arr_station_code")]
                [Validation(Required=false)]
                public string ArrStationCode { get; set; }

                [NameInMap("dep_station_code")]
                [Validation(Required=false)]
                public string DepStationCode { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("refund_ticket_details")]
                [Validation(Required=false)]
                public List<TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetailsRefundTicketDetails> RefundTicketDetails { get; set; }
                public class TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetailsRefundTicketDetails : TeaModel {
                    [NameInMap("can_refund")]
                    [Validation(Required=false)]
                    public bool? CanRefund { get; set; }

                    [NameInMap("passenger_info")]
                    [Validation(Required=false)]
                    public TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetailsRefundTicketDetailsPassengerInfo PassengerInfo { get; set; }
                    public class TrainFeeCalculateRefundResponseBodyModuleRefundTrainDetailsRefundTicketDetailsPassengerInfo : TeaModel {
                        [NameInMap("passenger_cert_no")]
                        [Validation(Required=false)]
                        public string PassengerCertNo { get; set; }

                        [NameInMap("passenger_cert_type")]
                        [Validation(Required=false)]
                        public string PassengerCertType { get; set; }

                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        [NameInMap("passenger_name")]
                        [Validation(Required=false)]
                        public string PassengerName { get; set; }

                    }

                    [NameInMap("refund_cost_fee")]
                    [Validation(Required=false)]
                    public long? RefundCostFee { get; set; }

                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                    [NameInMap("refund_rate")]
                    [Validation(Required=false)]
                    public long? RefundRate { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

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
