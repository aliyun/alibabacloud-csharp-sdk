// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainApplyRefundRequest : TeaModel {
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_refund_id")]
        [Validation(Required=false)]
        public string OutRefundId { get; set; }

        [NameInMap("refund_train_infos")]
        [Validation(Required=false)]
        public List<TrainApplyRefundRequestRefundTrainInfos> RefundTrainInfos { get; set; }
        public class TrainApplyRefundRequestRefundTrainInfos : TeaModel {
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("refund_passenger_infos")]
            [Validation(Required=false)]
            public List<TrainApplyRefundRequestRefundTrainInfosRefundPassengerInfos> RefundPassengerInfos { get; set; }
            public class TrainApplyRefundRequestRefundTrainInfosRefundPassengerInfos : TeaModel {
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

            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

    }

}
