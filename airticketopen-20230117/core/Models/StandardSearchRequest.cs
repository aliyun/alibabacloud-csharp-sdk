// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class StandardSearchRequest : TeaModel {
        /// <summary>
        /// <para>Number of adult passengers, range 1-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>Journey array. At least one of departure_city and departure_airport_list must be non-empty; when departure_airport_list has values, they must belong to the same city. At least one of arrival_city and arrival_airport_list must be non-empty; when arrival_airport_list has values, they must belong to the same city.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public List<StandardSearchRequestAirLegs> AirLegs { get; set; }
        public class StandardSearchRequestAirLegs : TeaModel {
            /// <summary>
            /// <para>Arrival airport three-letter code</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_airport_list")]
            [Validation(Required=false)]
            public List<string> ArrivalAirportList { get; set; }

            /// <summary>
            /// <para>Arrival city three-letter code</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <para>Departure airport three-letter code</para>
            /// 
            /// <b>Example:</b>
            /// <para>PVG</para>
            /// </summary>
            [NameInMap("departure_airport_list")]
            [Validation(Required=false)]
            public List<string> DepartureAirportList { get; set; }

            /// <summary>
            /// <para>Departure city three-letter code</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// <para>Departure date (e.g.: yyyyMMdd)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230320</para>
            /// </summary>
            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

        }

        /// <summary>
        /// <para>Defaults to ALL_CABIN if not specified. Cabin class ALL_CABIN: All cabin classes; Y: Economy class; FC: First class and Business class; S: Premium Economy class; YS: Economy class and Premium Economy class; YSC: Economy class, Premium Economy class, and Business class;</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>Number of child passengers, range 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>Number of infant passengers, range 0-9</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>Search control options, optional</para>
        /// </summary>
        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public StandardSearchRequestSearchControlOptions SearchControlOptions { get; set; }
        public class StandardSearchRequestSearchControlOptions : TeaModel {
            /// <summary>
            /// <para>Excluded airlines list</para>
            /// 
            /// <b>Example:</b>
            /// <para>7C</para>
            /// </summary>
            [NameInMap("airline_excluded_list")]
            [Validation(Required=false)]
            public List<string> AirlineExcludedList { get; set; }

            /// <summary>
            /// <para>Preferred airlines list</para>
            /// 
            /// <b>Example:</b>
            /// <para>FD</para>
            /// </summary>
            [NameInMap("airline_prefer_list")]
            [Validation(Required=false)]
            public List<string> AirlinePreferList { get; set; }

            /// <summary>
            /// <para>Ticketing service quality</para>
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
