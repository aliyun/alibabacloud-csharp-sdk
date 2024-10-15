// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainFeeCalculateRefundRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("distribute_order_id")]
        [Validation(Required=false)]
        public string DistributeOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_train_infos")]
        [Validation(Required=false)]
        public List<TrainFeeCalculateRefundRequestRefundTrainInfos> RefundTrainInfos { get; set; }
        public class TrainFeeCalculateRefundRequestRefundTrainInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BDC</para>
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BTC</para>
            /// </summary>
            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("refund_passenger_infos")]
            [Validation(Required=false)]
            public List<TrainFeeCalculateRefundRequestRefundTrainInfosRefundPassengerInfos> RefundPassengerInfos { get; set; }
            public class TrainFeeCalculateRefundRequestRefundTrainInfosRefundPassengerInfos : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
                /// </summary>
                [NameInMap("passenger_cert_no")]
                [Validation(Required=false)]
                public string PassengerCertNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>170d9ac6f8807f9ec603c688f45f78a41</para>
                /// </summary>
                [NameInMap("passenger_cert_type")]
                [Validation(Required=false)]
                public string PassengerCertType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>K1234</para>
            /// </summary>
            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

    }

}
