// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateChangeResponseBody : TeaModel {
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
        public TrainFeeCalculateChangeResponseBodyModule Module { get; set; }
        public class TrainFeeCalculateChangeResponseBodyModule : TeaModel {
            [NameInMap("change_train_details")]
            [Validation(Required=false)]
            public List<TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetails> ChangeTrainDetails { get; set; }
            public class TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>BTC</para>
                /// </summary>
                [NameInMap("arr_station_code")]
                [Validation(Required=false)]
                public string ArrStationCode { get; set; }

                [NameInMap("change_ticket_details")]
                [Validation(Required=false)]
                public List<TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetailsChangeTicketDetails> ChangeTicketDetails { get; set; }
                public class TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetailsChangeTicketDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("change_fee")]
                    [Validation(Required=false)]
                    public long? ChangeFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("change_rate")]
                    [Validation(Required=false)]
                    public long? ChangeRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("change_refund_fee")]
                    [Validation(Required=false)]
                    public long? ChangeRefundFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("change_refund_rate")]
                    [Validation(Required=false)]
                    public long? ChangeRefundRate { get; set; }

                    [NameInMap("passenger_info")]
                    [Validation(Required=false)]
                    public TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetailsChangeTicketDetailsPassengerInfo PassengerInfo { get; set; }
                    public class TrainFeeCalculateChangeResponseBodyModuleChangeTrainDetailsChangeTicketDetailsPassengerInfo : TeaModel {
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
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("passenger_id")]
                        [Validation(Required=false)]
                        public string PassengerId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
                        /// </summary>
                        [NameInMap("passenger_name")]
                        [Validation(Required=false)]
                        public string PassengerName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("seat_type")]
                    [Validation(Required=false)]
                    public string SeatType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BDC</para>
                /// </summary>
                [NameInMap("dep_station_code")]
                [Validation(Required=false)]
                public string DepStationCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>K2345</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("distribute_order_id")]
            [Validation(Required=false)]
            public string DistributeOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1683901850297448200</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
