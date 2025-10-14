// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchRequest : TeaModel {
        /// <summary>
        /// <para>adult passenger amount 1-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>itinerary list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public List<SearchRequestAirLegs> AirLegs { get; set; }
        public class SearchRequestAirLegs : TeaModel {
            /// <summary>
            /// <para>arrival airport [IATA airport code] list</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_airport_list")]
            [Validation(Required=false)]
            public List<string> ArrivalAirportList { get; set; }

            /// <summary>
            /// <para>arrival city code</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <para>departure airport [IATA airport code] list</para>
            /// 
            /// <b>Example:</b>
            /// <para>PVG</para>
            /// </summary>
            [NameInMap("departure_airport_list")]
            [Validation(Required=false)]
            public List<string> DepartureAirportList { get; set; }

            /// <summary>
            /// <para>departure city code</para>
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

        }

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
        /// <para>search controls</para>
        /// </summary>
        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public SearchRequestSearchControlOptions SearchControlOptions { get; set; }
        public class SearchRequestSearchControlOptions : TeaModel {
            /// <summary>
            /// <para>excluded airlines list</para>
            /// </summary>
            [NameInMap("airline_excluded_list")]
            [Validation(Required=false)]
            public List<string> AirlineExcludedList { get; set; }

            /// <summary>
            /// <para>preferred airlines list</para>
            /// </summary>
            [NameInMap("airline_prefer_list")]
            [Validation(Required=false)]
            public List<string> AirlinePreferList { get; set; }

            /// <summary>
            /// <para>service quality</para>
            /// 
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("service_quality")]
            [Validation(Required=false)]
            public string ServiceQuality { get; set; }

        }

    }

}
