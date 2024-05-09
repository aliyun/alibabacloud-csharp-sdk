// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateChangeRequest : TeaModel {
        [NameInMap("change_train_details")]
        [Validation(Required=false)]
        public List<TrainFeeCalculateChangeRequestChangeTrainDetails> ChangeTrainDetails { get; set; }
        public class TrainFeeCalculateChangeRequestChangeTrainDetails : TeaModel {
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("original_dep_time")]
            [Validation(Required=false)]
            public string OriginalDepTime { get; set; }

            [NameInMap("original_train_no")]
            [Validation(Required=false)]
            public string OriginalTrainNo { get; set; }

            [NameInMap("passenger_info")]
            [Validation(Required=false)]
            public TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo PassengerInfo { get; set; }
            public class TrainFeeCalculateChangeRequestChangeTrainDetailsPassengerInfo : TeaModel {
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

            }

            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        [NameInMap("distribute_order_id")]
        [Validation(Required=false)]
        public string DistributeOrderId { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
