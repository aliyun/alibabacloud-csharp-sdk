// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class StandardSearchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public List<StandardSearchRequestAirLegs> AirLegs { get; set; }
        public class StandardSearchRequestAirLegs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_airport_list")]
            [Validation(Required=false)]
            public List<string> ArrivalAirportList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PVG</para>
            /// </summary>
            [NameInMap("departure_airport_list")]
            [Validation(Required=false)]
            public List<string> DepartureAirportList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public StandardSearchRequestSearchControlOptions SearchControlOptions { get; set; }
        public class StandardSearchRequestSearchControlOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7C</para>
            /// </summary>
            [NameInMap("airline_excluded_list")]
            [Validation(Required=false)]
            public List<string> AirlineExcludedList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FD</para>
            /// </summary>
            [NameInMap("airline_prefer_list")]
            [Validation(Required=false)]
            public List<string> AirlinePreferList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("service_quality")]
            [Validation(Required=false)]
            public string ServiceQuality { get; set; }

        }

    }

}
