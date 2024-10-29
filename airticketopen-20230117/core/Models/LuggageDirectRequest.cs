// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class LuggageDirectRequest : TeaModel {
        [NameInMap("flight_segment_param_list")]
        [Validation(Required=false)]
        public List<LuggageDirectRequestFlightSegmentParamList> FlightSegmentParamList { get; set; }
        public class LuggageDirectRequestFlightSegmentParamList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIN</para>
            /// </summary>
            [NameInMap("arrival_airport")]
            [Validation(Required=false)]
            public string ArrivalAirport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>T1</para>
            /// </summary>
            [NameInMap("arrival_terminal")]
            [Validation(Required=false)]
            public string ArrivalTerminal { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1705285430445</para>
            /// </summary>
            [NameInMap("arrival_time")]
            [Validation(Required=false)]
            public long? ArrivalTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("code_share")]
            [Validation(Required=false)]
            public bool? CodeShare { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("departure_airport")]
            [Validation(Required=false)]
            public string DepartureAirport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>T1</para>
            /// </summary>
            [NameInMap("departure_terminal")]
            [Validation(Required=false)]
            public string DepartureTerminal { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1705285430445</para>
            /// </summary>
            [NameInMap("departure_time")]
            [Validation(Required=false)]
            public long? DepartureTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CZ</para>
            /// </summary>
            [NameInMap("marketing_airline")]
            [Validation(Required=false)]
            public string MarketingAirline { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CZ616</para>
            /// </summary>
            [NameInMap("marketing_flight_no")]
            [Validation(Required=false)]
            public string MarketingFlightNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CZ</para>
            /// </summary>
            [NameInMap("operating_airline")]
            [Validation(Required=false)]
            public string OperatingAirline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SEL,HKG</para>
            /// </summary>
            [NameInMap("stop_city_list")]
            [Validation(Required=false)]
            public string StopCityList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CZ</para>
            /// </summary>
            [NameInMap("ticketing_airline")]
            [Validation(Required=false)]
            public string TicketingAirline { get; set; }

        }

    }

}
