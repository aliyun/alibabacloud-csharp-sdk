// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_journeys")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundJourneys> RefundJourneys { get; set; }
        public class RefundApplyRequestRefundJourneys : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<RefundApplyRequestRefundJourneysSegmentList> SegmentList { get; set; }
            public class RefundApplyRequestRefundJourneysSegmentList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_passenger_list")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundPassengerList> RefundPassengerList { get; set; }
        public class RefundApplyRequestRefundPassengerList : TeaModel {
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_type")]
        [Validation(Required=false)]
        public RefundApplyRequestRefundType RefundType { get; set; }
        public class RefundApplyRequestRefundType : TeaModel {
            [NameInMap("file")]
            [Validation(Required=false)]
            public List<string> File { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("refund_type_id")]
            [Validation(Required=false)]
            public int? RefundTypeId { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
