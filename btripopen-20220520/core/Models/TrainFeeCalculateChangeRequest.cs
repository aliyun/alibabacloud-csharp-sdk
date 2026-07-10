// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateChangeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_train_details")]
        [Validation(Required=false)]
        public List<TrainFeeCalculateChangeRequestChangeTrainDetails> ChangeTrainDetails { get; set; }
        public class TrainFeeCalculateChangeRequestChangeTrainDetails : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("original_dep_time")]
            [Validation(Required=false)]
            public string OriginalDepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("original_train_no")]
            [Validation(Required=false)]
            public string OriginalTrainNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("passenger_info")]
            [Validation(Required=false)]
            public TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo PassengerInfo { get; set; }
            public class TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("distribute_order_id")]
        [Validation(Required=false)]
        public string DistributeOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
