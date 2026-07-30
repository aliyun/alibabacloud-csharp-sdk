// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchV2Request : TeaModel {
        /// <summary>
        /// <para>The two-letter IATA airline code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA</para>
        /// </summary>
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        /// <summary>
        /// <para>The cabin class type for search. Default value: 0 (ALL_CABIN, all cabins).</para>
        /// <remarks>
        /// <para>Notice: Although the parameter structure is a list, only a single cabin class is currently supported. Multiple cabin classes are not supported.</notice></para>
        /// </remarks>
        /// </summary>
        [NameInMap("cabin_type_list")]
        [Validation(Required=false)]
        public List<int?> CabinTypeList { get; set; }

        /// <summary>
        /// <para>Specifies whether to show only direct flights. Default value: TRUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query multi-cabin prices (aggregated OTA search). Default value: FALSE.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_multi_class_price")]
        [Validation(Required=false)]
        public bool? NeedMultiClassPrice { get; set; }

        /// <summary>
        /// <para>Specifies whether to query service fees. Default value: TRUE.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("need_query_service_fee")]
        [Validation(Required=false)]
        public bool? NeedQueryServiceFee { get; set; }

        /// <summary>
        /// <para>Specifies whether to include codeshare flights. Default value: TRUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        /// <summary>
        /// <para>Specifies whether to separately query the lowest prices for Y (economy) and C (business) cabins. Default value: FALSE.</para>
        /// <remarks>
        /// <para>Specifies whether to separately query the lowest prices for Y (economy) and C (business) cabins. Default value: FALSE.</para>
        /// <list type="bullet">
        /// <item><description>Normal case: Set to FALSE. The &quot;item_list&quot; returns only one item, which is the same as &quot;best_price_item&quot;. You can use either one.</description></item>
        /// <item><description>Special case: When set to TRUE, multiple prices are returned in the flight list. The &quot;item_list&quot; may return two items, and &quot;best_price_item&quot; is the lowest-priced item in &quot;item_list&quot; (not recommended).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_y_c_best_price")]
        [Validation(Required=false)]
        public bool? NeedYCBestPrice { get; set; }

        /// <summary>
        /// <para>The search journeys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public List<FlightListingSearchV2RequestSearchJourneys> SearchJourneys { get; set; }
        public class FlightListingSearchV2RequestSearchJourneys : TeaModel {
            /// <summary>
            /// <para>The three-letter code of the arrival city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The three-letter code of the departure city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure date in yyyy-MM-dd format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-01</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>The list of selected flights for the current origin-destination (OD).</para>
            /// <remarks>
            /// <para>The list of selected flights for the current OD.</para>
            /// <list type="bullet">
            /// <item><description>Only when searching for the return leg of a round-trip, pass the selected outbound flight in selected_flights. In all other cases, this parameter is not required.</description></item>
            /// <item><description>For the return leg of a round-trip search, selected_flights must be taken from the results of the previous outbound search using &quot;Flight List Search V2&quot;.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<FlightListingSearchV2RequestSearchJourneysSelectedFlights> SelectedFlights { get; set; }
            public class FlightListingSearchV2RequestSearchJourneysSelectedFlights : TeaModel {
                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time in yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-01 07:10:00</para>
                /// </summary>
                [NameInMap("flight_time")]
                [Validation(Required=false)]
                public string FlightTime { get; set; }

                /// <summary>
                /// <para>The marketing flight number (e.g., KA5809).</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO3925</para>
                /// </summary>
                [NameInMap("market_flight_no")]
                [Validation(Required=false)]
                public string MarketFlightNo { get; set; }

                /// <summary>
                /// <para>The operating flight number (e.g., CX601, populated for codeshare flights).</para>
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
        /// <para>The search mode.</para>
        /// <remarks>
        /// <para>Search mode:</para>
        /// <list type="bullet">
        /// <item><description>For one-way search: pass 0 (outbound).</description></item>
        /// <item><description>For round-trip outbound search: pass 0 (outbound).</description></item>
        /// <item><description>For round-trip return search: pass 1 (return).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        /// <summary>
        /// <para>The trip type.</para>
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
