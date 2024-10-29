// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyRequest : TeaModel {
        /// <summary>
        /// <para>order number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4966***617111</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>journeys for which a refund is being requested</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_journeys")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundJourneys> RefundJourneys { get; set; }
        public class RefundApplyRequestRefundJourneys : TeaModel {
            /// <summary>
            /// <para>segment list</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<RefundApplyRequestRefundJourneysSegmentList> SegmentList { get; set; }
            public class RefundApplyRequestRefundJourneysSegmentList : TeaModel {
                /// <summary>
                /// <para>arrival airport code (capitalized)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// <para>arrival city code (capitalized)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// <para>departure airport code (capitalized)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// <para>departure city code (capitalized)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

            }

        }

        /// <summary>
        /// <para>passengers that applying for a refund</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_passenger_list")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundPassengerList> RefundPassengerList { get; set; }
        public class RefundApplyRequestRefundPassengerList : TeaModel {
            /// <summary>
            /// <para>credential number</para>
            /// 
            /// <b>Example:</b>
            /// <para>411***********4411</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>first name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAN</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>last name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

        }

        /// <summary>
        /// <para>refund type and attachments</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_type")]
        [Validation(Required=false)]
        public RefundApplyRequestRefundType RefundType { get; set; }
        public class RefundApplyRequestRefundType : TeaModel {
            /// <summary>
            /// <para>attachment file URLs</para>
            /// <para>(note: upload the files using a separate file upload interface to get the file URLs)</para>
            /// 
            /// <b>Example:</b>
            /// <para>[xxx,yyy]</para>
            /// </summary>
            [NameInMap("file")]
            [Validation(Required=false)]
            public List<string> File { get; set; }

            /// <summary>
            /// <para>refund type </para>
            /// <para>2: voluntary (I want to change my travel plan/I don\&quot;t want to fly) </para>
            /// <para>5: involuntary, due to flight delay or cancellation, schedule changes, etc., by the airline </para>
            /// <para>6: involuntary, due to health reasons with a certificate from a hospital of at least secondary level A or above </para>
            /// <para> (note: attachments are not mandatory, but it is recommended to provide them for involuntary refunds as they can increase the success rate)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("refund_type_id")]
            [Validation(Required=false)]
            public int? RefundTypeId { get; set; }

            /// <summary>
            /// <para>remark</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark desc</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
