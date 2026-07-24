// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchRequest : TeaModel {
        /// <summary>
        /// <para>The number of adult passengers. Valid values: 1 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>The journey array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public List<SearchRequestAirLegs> AirLegs { get; set; }
        public class SearchRequestAirLegs : TeaModel {
            /// <summary>
            /// <para>The list of three-letter codes of arrival airports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_airport_list")]
            [Validation(Required=false)]
            public List<string> ArrivalAirportList { get; set; }

            /// <summary>
            /// <para>The three-letter code of the arrival city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <para>The list of three-letter codes of departure airports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PVG</para>
            /// </summary>
            [NameInMap("departure_airport_list")]
            [Validation(Required=false)]
            public List<string> DepartureAirportList { get; set; }

            /// <summary>
            /// <para>The three-letter code of the departure city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// <para>The departure date (for example, yyyyMMdd).</para>
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
        /// <para>The cabin class. Valid values: ALL_CABIN: all cabin classes. Y: economy class. FC: first class and business class. S: premium economy class. YS: economy class and premium economy class. YSC: economy class, premium economy class, and business class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_CABIN</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>The number of child passengers. Valid values: 0 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>The number of infant passengers. Valid values: 0 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        /// <summary>
        /// <para>The search control options. This parameter is optional.</para>
        /// </summary>
        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public SearchRequestSearchControlOptions SearchControlOptions { get; set; }
        public class SearchRequestSearchControlOptions : TeaModel {
            /// <summary>
            /// <para>The list of excluded airlines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7C</para>
            /// </summary>
            [NameInMap("airline_excluded_list")]
            [Validation(Required=false)]
            public List<string> AirlineExcludedList { get; set; }

            /// <summary>
            /// <para>The list of preferred airlines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FD</para>
            /// </summary>
            [NameInMap("airline_prefer_list")]
            [Validation(Required=false)]
            public List<string> AirlinePreferList { get; set; }

            /// <summary>
            /// <para>The service quality identifier.</para>
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
