// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TransitVisaRequest : TeaModel {
        [NameInMap("flight_segment_param_list")]
        [Validation(Required=false)]
        public List<TransitVisaRequestFlightSegmentParamList> FlightSegmentParamList { get; set; }
        public class TransitVisaRequestFlightSegmentParamList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrival_airport")]
            [Validation(Required=false)]
            public string ArrivalAirport { get; set; }

            [NameInMap("arrival_terminal")]
            [Validation(Required=false)]
            public string ArrivalTerminal { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrival_time")]
            [Validation(Required=false)]
            public long? ArrivalTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code_share")]
            [Validation(Required=false)]
            public bool? CodeShare { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departure_airport")]
            [Validation(Required=false)]
            public string DepartureAirport { get; set; }

            [NameInMap("departure_terminal")]
            [Validation(Required=false)]
            public string DepartureTerminal { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departure_time")]
            [Validation(Required=false)]
            public long? DepartureTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("marketing_airline")]
            [Validation(Required=false)]
            public string MarketingAirline { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("marketing_flight_no")]
            [Validation(Required=false)]
            public string MarketingFlightNo { get; set; }

            [NameInMap("operating_airline")]
            [Validation(Required=false)]
            public string OperatingAirline { get; set; }

            [NameInMap("stop_city_list")]
            [Validation(Required=false)]
            public string StopCityList { get; set; }

            [NameInMap("ticketing_airline")]
            [Validation(Required=false)]
            public string TicketingAirline { get; set; }

        }

    }

}
