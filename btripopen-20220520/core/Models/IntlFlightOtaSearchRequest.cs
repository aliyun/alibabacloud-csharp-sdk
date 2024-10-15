// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaSearchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10023</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

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
        /// <b>Example:</b>
        /// <para>open12igetbis4o07v10B1TlOWcM00</para>
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
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<IntlFlightOtaSearchRequestSearchJourneys> SearchJourneys { get; set; }
        public class IntlFlightOtaSearchRequestSearchJourneys : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZQZ</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-15</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<IntlFlightOtaSearchRequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class IntlFlightOtaSearchRequestSearchJourneysSelectedFlights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NNG</para>
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
                /// <para>KOW</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CTU</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-15 12:00:00</para>
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

        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightOtaSearchRequestSearchPassengerList> SearchPassengerList { get; set; }
        public class IntlFlightOtaSearchRequestSearchPassengerList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13412341234</para>
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
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

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
