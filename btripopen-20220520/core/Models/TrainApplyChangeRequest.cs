// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainApplyChangeRequest : TeaModel {
        [NameInMap("accept_no_seat")]
        [Validation(Required=false)]
        public string AcceptNoSeat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("change_train_info_s")]
        [Validation(Required=false)]
        public List<TrainApplyChangeRequestChangeTrainInfoS> ChangeTrainInfoS { get; set; }
        public class TrainApplyChangeRequestChangeTrainInfoS : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("change_ticket_info_s")]
            [Validation(Required=false)]
            public List<TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoS> ChangeTicketInfoS { get; set; }
            public class TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoS : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("passenger_info")]
                [Validation(Required=false)]
                public TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoSPassengerInfo PassengerInfo { get; set; }
                public class TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoSPassengerInfo : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("passenger_cert_no")]
                    [Validation(Required=false)]
                    public string PassengerCertNo { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("passenger_cert_type")]
                    [Validation(Required=false)]
                    public string PassengerCertType { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("passenger_name")]
                    [Validation(Required=false)]
                    public string PassengerName { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public string TicketPrice { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ticket_type")]
                [Validation(Required=false)]
                public string TicketType { get; set; }

            }

            [NameInMap("choose_bed_s")]
            [Validation(Required=false)]
            public string ChooseBedS { get; set; }

            [NameInMap("choose_seat_s")]
            [Validation(Required=false)]
            public string ChooseSeatS { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("original_dep_time")]
            [Validation(Required=false)]
            public string OriginalDepTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("original_train_no")]
            [Validation(Required=false)]
            public string OriginalTrainNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        [NameInMap("force_match")]
        [Validation(Required=false)]
        public string ForceMatch { get; set; }

        [NameInMap("is_pay_now")]
        [Validation(Required=false)]
        public bool? IsPayNow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_change_apply_id")]
        [Validation(Required=false)]
        public string OutChangeApplyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
