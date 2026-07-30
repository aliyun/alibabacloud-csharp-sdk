// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainApplyChangeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to accept no-seat tickets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not accepted.</description></item>
        /// <item><description>1: Accepted.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("accept_no_seat")]
        [Validation(Required=false)]
        public string AcceptNoSeat { get; set; }

        /// <summary>
        /// <para>The ticket information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_train_info_s")]
        [Validation(Required=false)]
        public List<TrainApplyChangeRequestChangeTrainInfoS> ChangeTrainInfoS { get; set; }
        public class TrainApplyChangeRequestChangeTrainInfoS : TeaModel {
            /// <summary>
            /// <para>The arrival station code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BTC</para>
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// <para>The ticket information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("change_ticket_info_s")]
            [Validation(Required=false)]
            public List<TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoS> ChangeTicketInfoS { get; set; }
            public class TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoS : TeaModel {
                /// <summary>
                /// <para>The passenger information.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("passenger_info")]
                [Validation(Required=false)]
                public TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoSPassengerInfo PassengerInfo { get; set; }
                public class TrainApplyChangeRequestChangeTrainInfoSChangeTicketInfoSPassengerInfo : TeaModel {
                    /// <summary>
                    /// <para>The certificate number, encrypted with SM4.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                    /// </summary>
                    [NameInMap("passenger_cert_no")]
                    [Validation(Required=false)]
                    public string PassengerCertNo { get; set; }

                    /// <summary>
                    /// <para>The certificate type, encrypted with SM4. This is an enumerated value.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>170d9ac6f8807f9ec603c688f45f78a41</para>
                    /// </summary>
                    [NameInMap("passenger_cert_type")]
                    [Validation(Required=false)]
                    public string PassengerCertType { get; set; }

                    /// <summary>
                    /// <para>The third-party passenger ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public string PassengerId { get; set; }

                    /// <summary>
                    /// <para>The passenger name, encrypted with SM4.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
                    /// </summary>
                    [NameInMap("passenger_name")]
                    [Validation(Required=false)]
                    public string PassengerName { get; set; }

                }

                /// <summary>
                /// <para>The seat type. This is an enumerated value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// <para>The ticket unit price, in cents.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public string TicketPrice { get; set; }

                /// <summary>
                /// <para>The ticket type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Adult.</description></item>
                /// <item><description>1: Child.</description></item>
                /// <item><description>2: Infant.</description></item>
                /// <item><description>3: Student.</description></item>
                /// <item><description>4: Other.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ticket_type")]
                [Validation(Required=false)]
                public string TicketType { get; set; }

            }

            /// <summary>
            /// <para>The seat selection string, passed according to seat selection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("choose_bed_s")]
            [Validation(Required=false)]
            public string ChooseBedS { get; set; }

            /// <summary>
            /// <para>The berth selection string, such as 1T2M3B, indicating the number of berths.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1T</para>
            /// </summary>
            [NameInMap("choose_seat_s")]
            [Validation(Required=false)]
            public string ChooseSeatS { get; set; }

            /// <summary>
            /// <para>The departure station code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BDC</para>
            /// </summary>
            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            /// <summary>
            /// <para>The departure time in the format of yyyy-MM-dd hh:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>The original departure time in the format of yyyy-MM-dd hh:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("original_dep_time")]
            [Validation(Required=false)]
            public string OriginalDepTime { get; set; }

            /// <summary>
            /// <para>The original train number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>K234</para>
            /// </summary>
            [NameInMap("original_train_no")]
            [Validation(Required=false)]
            public string OriginalTrainNo { get; set; }

            /// <summary>
            /// <para>The short train number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>K2345</para>
            /// </summary>
            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to force match seat preferences. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Force match.</description></item>
        /// <item><description>1: Do not force match.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("force_match")]
        [Validation(Required=false)]
        public string ForceMatch { get; set; }

        /// <summary>
        /// <para>Specifies whether to pay upon order creation. This feature is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_pay_now")]
        [Validation(Required=false)]
        public bool? IsPayNow { get; set; }

        /// <summary>
        /// <para>The business travel order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017028198411054446</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The change application ID assigned by the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("out_change_apply_id")]
        [Validation(Required=false)]
        public string OutChangeApplyId { get; set; }

        /// <summary>
        /// <para>The order ID assigned by the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
