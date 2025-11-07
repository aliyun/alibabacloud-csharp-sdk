// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichRequest : TeaModel {
        /// <summary>
        /// <para>Number of adult passengers (1-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>Cabin class: ALL_CABIN: All cabin classes; Y: Economy; FC: First Class and Business Class; S: Premium Economy; YS: Economy and Premium Economy; YSC: Economy, Premium Economy, and Business Class;</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>Number of child passengers (0-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>Number of infant passengers (0-9)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>Trip information</para>
        /// </summary>
        [NameInMap("journey_param_list")]
        [Validation(Required=false)]
        public List<EnrichRequestJourneyParamList> JourneyParamList { get; set; }
        public class EnrichRequestJourneyParamList : TeaModel {
            /// <summary>
            /// <para>Arrival city three-letter code (uppercase)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <para>Departure city three-letter code (uppercase)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// <para>Departure date (yyyyMMdd)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230310</para>
            /// </summary>
            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

            /// <summary>
            /// <para>Specified segment information for this trip</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("segment_param_list")]
            [Validation(Required=false)]
            public List<EnrichRequestJourneyParamListSegmentParamList> SegmentParamList { get; set; }
            public class EnrichRequestJourneyParamListSegmentParamList : TeaModel {
                /// <summary>
                /// <para>Flight arrival airport three-letter code (uppercase)</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// <para>Flight arrival city three-letter code (uppercase)</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// <para>Cabin</para>
                /// 
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>Child cabin</para>
                /// 
                /// <b>Example:</b>
                /// <para>E</para>
                /// </summary>
                [NameInMap("child_cabin")]
                [Validation(Required=false)]
                public string ChildCabin { get; set; }

                /// <summary>
                /// <para>Flight departure airport three-letter code (uppercase)</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// <para>Flight departure city three-letter code (uppercase)</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

                /// <summary>
                /// <para>String, flight departure date (yyyy-MM-dd), either departure_date or departure_time, with departure_time preferred for greater accuracy</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-10</para>
                /// </summary>
                [NameInMap("departure_date")]
                [Validation(Required=false)]
                public string DepartureDate { get; set; }

                /// <summary>
                /// <para>String, flight departure date and time (yyyy-MM-dd HH:mm:ss)</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-10 07:55:00</para>
                /// </summary>
                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public string DepartureTime { get; set; }

                /// <summary>
                /// <para>Marketing flight number (e.g., KA5809)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("marketing_flight_no")]
                [Validation(Required=false)]
                public string MarketingFlightNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The <c>solution_id</c> returned by the Search interface</para>
        /// 
        /// <b>Example:</b>
        /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
