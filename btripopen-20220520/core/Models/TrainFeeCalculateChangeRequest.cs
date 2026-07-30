// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateChangeRequest : TeaModel {
        /// <summary>
        /// <para>The change ticket information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_train_details")]
        [Validation(Required=false)]
        public List<TrainFeeCalculateChangeRequestChangeTrainDetails> ChangeTrainDetails { get; set; }
        public class TrainFeeCalculateChangeRequestChangeTrainDetails : TeaModel {
            /// <summary>
            /// <para>The arrival station code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BDC</para>
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// <para>The departure station code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BTC</para>
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
            /// <para>The original departure time.</para>
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
            /// <para>The passenger information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("passenger_info")]
            [Validation(Required=false)]
            public TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo PassengerInfo { get; set; }
            public class TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo : TeaModel {
                /// <summary>
                /// <para>The passenger certificate number, encrypted with SM4.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
                /// </summary>
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                /// <summary>
                /// <para>The passenger certificate type, encrypted with SM4.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>170d9ac6f8807f9ec603c688f45f78a41</para>
                /// </summary>
                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                /// <summary>
                /// <para>The passenger name, encrypted with SM4.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

            }

            /// <summary>
            /// <para>The seat type for the change.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

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
        /// <para>The supplier order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("distribute_order_id")]
        [Validation(Required=false)]
        public string DistributeOrderId { get; set; }

        /// <summary>
        /// <para>The business travel order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2627694109810885616</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
