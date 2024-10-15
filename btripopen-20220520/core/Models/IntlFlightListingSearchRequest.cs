// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZHANGSAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("out_wheel_search")]
        [Validation(Required=false)]
        public bool? OutWheelSearch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60b412-cc05-4d10-b570-</para>
        /// </summary>
        [NameInMap("query_record_id")]
        [Validation(Required=false)]
        public string QueryRecordId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<IntlFlightListingSearchRequestSearchJourneys> SearchJourneys { get; set; }
        public class IntlFlightListingSearchRequestSearchJourneys : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEL</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HKG</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-28</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<IntlFlightListingSearchRequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class IntlFlightListingSearchRequestSearchJourneysSelectedFlights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HNY</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MEL</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cabin_type")]
                [Validation(Required=false)]
                public int? CabinType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SZX</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-28 12:00:00</para>
                /// </summary>
                [NameInMap("flight_time")]
                [Validation(Required=false)]
                public string FlightTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KA5809</para>
                /// </summary>
                [NameInMap("market_flight_no")]
                [Validation(Required=false)]
                public string MarketFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CX601</para>
                /// </summary>
                [NameInMap("operate_flight_no")]
                [Validation(Required=false)]
                public string OperateFlightNo { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightListingSearchRequestSearchPassengerList> SearchPassengerList { get; set; }
        public class IntlFlightListingSearchRequestSearchPassengerList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10012301201</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANGSAN</para>
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JIANHANG</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9960b412-cc05-4d10-b570-93372d816807</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
