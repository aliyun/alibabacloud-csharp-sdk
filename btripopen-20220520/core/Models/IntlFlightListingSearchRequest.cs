// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchRequest : TeaModel {
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_wheel_search")]
        [Validation(Required=false)]
        public bool? OutWheelSearch { get; set; }

        [NameInMap("query_record_id")]
        [Validation(Required=false)]
        public string QueryRecordId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<IntlFlightListingSearchRequestSearchJourneys> SearchJourneys { get; set; }
        public class IntlFlightListingSearchRequestSearchJourneys : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<IntlFlightListingSearchRequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class IntlFlightListingSearchRequestSearchJourneysSelectedFlights : TeaModel {
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("cabin_type")]
                [Validation(Required=false)]
                public int? CabinType { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("flight_time")]
                [Validation(Required=false)]
                public string FlightTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("market_flight_no")]
                [Validation(Required=false)]
                public string MarketFlightNo { get; set; }

                [NameInMap("operate_flight_no")]
                [Validation(Required=false)]
                public string OperateFlightNo { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightListingSearchRequestSearchPassengerList> SearchPassengerList { get; set; }
        public class IntlFlightListingSearchRequestSearchPassengerList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
