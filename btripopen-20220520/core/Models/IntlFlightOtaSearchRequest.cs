// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaSearchRequest : TeaModel {
        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10023</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The cabin class type for the search. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: all cabin classes</description></item>
        /// <item><description>1: economy class</description></item>
        /// <item><description>2: first class and business class</description></item>
        /// <item><description>3: premium economy class</description></item>
        /// <item><description>4: first class</description></item>
        /// <item><description>5: business class</description></item>
        /// <item><description>6: economy class and premium economy class</description></item>
        /// <item><description>7: economy class, premium economy class, and business class</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open12igetbis4o07v10B1TlOWcM00</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The search journeys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<IntlFlightOtaSearchRequestSearchJourneys> SearchJourneys { get; set; }
        public class IntlFlightOtaSearchRequestSearchJourneys : TeaModel {
            /// <summary>
            /// <para>The three-letter code of the arrival city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZQZ</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The three-letter code of the departure city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure date in the format yyyy-MM-dd.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-15</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>The list of selected flights for the current origin-destination (OD) pair.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<IntlFlightOtaSearchRequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class IntlFlightOtaSearchRequestSearchJourneysSelectedFlights : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NNG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KOW</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CTU</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm</description></item>
                /// </list>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-15 12:00</para>
                /// </summary>
                [NameInMap("flight_time")]
                [Validation(Required=false)]
                public string FlightTime { get; set; }

                /// <summary>
                /// <para>The marketing carrier flight number (e.g., KA5809).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KA5809</para>
                /// </summary>
                [NameInMap("market_flight_no")]
                [Validation(Required=false)]
                public string MarketFlightNo { get; set; }

                /// <summary>
                /// <para>The operating carrier flight number (e.g., CX601, available for codeshare flights).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CX601</para>
                /// </summary>
                [NameInMap("operate_flight_no")]
                [Validation(Required=false)]
                public string OperateFlightNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The passenger information. Required if the passenger has a managed agreement price.</para>
        /// </summary>
        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightOtaSearchRequestSearchPassengerList> SearchPassengerList { get; set; }
        public class IntlFlightOtaSearchRequestSearchPassengerList : TeaModel {
            /// <summary>
            /// <para>The document number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13412341234</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>The document type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// <para>The full name of the passenger.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANGSAN</para>
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>The passenger type.</para>
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
        /// <para>The trip type. Default value: 1 (one-way).</para>
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
