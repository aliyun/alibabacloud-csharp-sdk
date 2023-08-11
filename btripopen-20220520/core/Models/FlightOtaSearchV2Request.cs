// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaSearchV2Request : TeaModel {
        [NameInMap("cabin_type_list")]
        [Validation(Required=false)]
        public List<int?> CabinTypeList { get; set; }

        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<FlightOtaSearchV2RequestSearchJourneys> SearchJourneys { get; set; }
        public class FlightOtaSearchV2RequestSearchJourneys : TeaModel {
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<FlightOtaSearchV2RequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class FlightOtaSearchV2RequestSearchJourneysSelectedFlights : TeaModel {
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("flight_time")]
                [Validation(Required=false)]
                public string FlightTime { get; set; }

                [NameInMap("market_flight_no")]
                [Validation(Required=false)]
                public string MarketFlightNo { get; set; }

                [NameInMap("operate_flight_no")]
                [Validation(Required=false)]
                public string OperateFlightNo { get; set; }

            }

        }

        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
