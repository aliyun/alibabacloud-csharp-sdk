// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyRequest : TeaModel {
        /// <summary>
        /// <para>The order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4966***617111</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>The journeys for the refund application.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_journeys")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundJourneys> RefundJourneys { get; set; }
        public class RefundApplyRequestRefundJourneys : TeaModel {
            /// <summary>
            /// <para>The segment information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<RefundApplyRequestRefundJourneysSegmentList> SegmentList { get; set; }
            public class RefundApplyRequestRefundJourneysSegmentList : TeaModel {
                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport (uppercase).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the arrival city (uppercase).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure airport (uppercase).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure city (uppercase).</para>
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
        /// <para>The list of passengers for the refund application.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_passenger_list")]
        [Validation(Required=false)]
        public List<RefundApplyRequestRefundPassengerList> RefundPassengerList { get; set; }
        public class RefundApplyRequestRefundPassengerList : TeaModel {
            /// <summary>
            /// <para>The document number of the passenger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>411***********4411</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>The first name of the passenger.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAN</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>The last name of the passenger.</para>
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
        /// <para>The refund type. Attachments are required for involuntary refund applications.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_type")]
        [Validation(Required=false)]
        public RefundApplyRequestRefundType RefundType { get; set; }
        public class RefundApplyRequestRefundType : TeaModel {
            /// <summary>
            /// <para>The array of attachment file URLs. Upload files first by using the dedicated file upload operation to obtain the file URLs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[xxx,yyy]</para>
            /// </summary>
            [NameInMap("file")]
            [Validation(Required=false)]
            public List<string> File { get; set; }

            /// <summary>
            /// <para>The refund type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: Voluntary refund (change of travel plans or decision not to fly).</description></item>
            /// <item><description>5: Involuntary refund due to airline reasons such as flight delay, cancellation, or schedule change.</description></item>
            /// <item><description>6: Involuntary refund due to medical reasons with a certificate from a Grade II Class A hospital or above.</description></item>
            /// </list>
            /// <para>Note: Attachments are not mandatory, but providing attachments for involuntary refunds can improve the success rate of the refund application.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("refund_type_id")]
            [Validation(Required=false)]
            public int? RefundTypeId { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
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
