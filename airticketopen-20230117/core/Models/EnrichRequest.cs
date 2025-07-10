// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichRequest : TeaModel {
        /// <summary>
        /// <para>adult passenger amount 1-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>cabin class</para>
        /// <ol>
        /// <item><description><b>ALL_CABIN</b> : all cabin class</description></item>
        /// <item><description><b>Y</b> : economy class</description></item>
        /// <item><description><b>FC</b> : first class and business class</description></item>
        /// <item><description><b>S</b> : premium economy class</description></item>
        /// <item><description><b>YS</b> : economy class and premium economy class</description></item>
        /// <item><description><b>YSC</b> : economy class, premium economy class and business class</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>child passenger amount 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>infant passenger amount 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>journey list</para>
        /// </summary>
        [NameInMap("journey_param_list")]
        [Validation(Required=false)]
        public List<EnrichRequestJourneyParamList> JourneyParamList { get; set; }
        public class EnrichRequestJourneyParamList : TeaModel {
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
            /// <para>departure city code (capitalized)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// <para>departure date (eg: yyyyMMdd)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230310</para>
            /// </summary>
            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

            /// <summary>
            /// <para>segement param list</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("segment_param_list")]
            [Validation(Required=false)]
            public List<EnrichRequestJourneyParamListSegmentParamList> SegmentParamList { get; set; }
            public class EnrichRequestJourneyParamListSegmentParamList : TeaModel {
                /// <summary>
                /// <para>arrival airport code (capitalized)</para>
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
                /// <para>RBD</para>
                /// 
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>child RBD</para>
                /// 
                /// <b>Example:</b>
                /// <para>E</para>
                /// </summary>
                [NameInMap("child_cabin")]
                [Validation(Required=false)]
                public string ChildCabin { get; set; }

                /// <summary>
                /// <para>departure airport code (capitalized)</para>
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

                /// <summary>
                /// <para>departure time in string format (yyyy-MM-dd HH:mm:ss)</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-10 07:55:00</para>
                /// </summary>
                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public string DepartureTime { get; set; }

                /// <summary>
                /// <para>marketing flight no. (eg: KA5809)</para>
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
        /// <para>solution_id returned by Search</para>
        /// 
        /// <b>Example:</b>
        /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
