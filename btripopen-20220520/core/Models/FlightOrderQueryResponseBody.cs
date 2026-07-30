// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOrderQueryResponseBodyModule Module { get; set; }
        public class FlightOrderQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of rebooking tickets.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the order has no rebookings, an empty array is returned.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_change_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList> FlightChangeTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The rebooking approval ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If rebooking approval is not enabled, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>165485404</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The arrival airport after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大兴国际机场</para>
                /// </summary>
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <para>The arrival airport code after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city code after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival time of the rebooked ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin class after rebooking, such as V.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("change_cabin")]
                [Validation(Required=false)]
                public string ChangeCabin { get; set; }

                /// <summary>
                /// <para>The cabin level after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("change_cabin_level")]
                [Validation(Required=false)]
                public string ChangeCabinLevel { get; set; }

                /// <summary>
                /// <para>The rebooking fee. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，改签费仅在第一个航段上体现，第二个航段改签费=0</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// <para>The flight number after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU7767</para>
                /// </summary>
                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                /// <summary>
                /// <para>The rebooking order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33576</para>
                /// </summary>
                [NameInMap("change_order_id")]
                [Validation(Required=false)]
                public long? ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The rebooking reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人原因</para>
                /// </summary>
                [NameInMap("change_reason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                /// <summary>
                /// <para>The rebooking type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("change_type")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                /// <summary>
                /// <para>The departure airport after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                /// <summary>
                /// <para>The departure airport code after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure city after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The departure city code after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time of the rebooked ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The discount of the new flight after rebooking.</para>
                /// <remarks>
                /// <para>Warning: Deprecated. Do not use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The journey index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The original ticket number before rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00-123123</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                /// <summary>
                /// <para>The third-party rebooking approval ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If rebooking approval is not enabled, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>a165485404</para>
                /// </summary>
                [NameInMap("out_apply_id")]
                [Validation(Required=false)]
                public string OutApplyId { get; set; }

                /// <summary>
                /// <para>The segment index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The stopover city after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西安</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The rebooking ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000-123123</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

                /// <summary>
                /// <para>The ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ticket_status_code")]
                [Validation(Required=false)]
                public int? TicketStatusCode { get; set; }

                /// <summary>
                /// <para>The cabin upgrade fee. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，升舱费仅在第一个航段上体现，第二个航段升舱费=0</para>
                /// </summary>
                [NameInMap("upgrade_fee")]
                [Validation(Required=false)]
                public double? UpgradeFee { get; set; }

            }

            /// <summary>
            /// <para>The flight information list.</para>
            /// </summary>
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <para>The airline code, such as CA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                /// <summary>
                /// <para>The airline name, such as Air China.</para>
                /// 
                /// <b>Example:</b>
                /// <para>东航</para>
                /// </summary>
                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <para>The detailed information of the city where the arrival airport is located.</para>
                /// </summary>
                [NameInMap("arr_airport_city_county")]
                [Validation(Required=false)]
                public FlightOrderQueryResponseBodyModuleFlightInfoListArrAirportCityCounty ArrAirportCityCounty { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListArrAirportCityCounty : TeaModel {
                    /// <summary>
                    /// <para>The administrative division code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("adcode")]
                    [Validation(Required=false)]
                    public string Adcode { get; set; }

                    /// <summary>
                    /// <para>The airport city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("airport_city_code")]
                    [Validation(Required=false)]
                    public string AirportCityCode { get; set; }

                    /// <summary>
                    /// <para>The airport city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("airport_city_name")]
                    [Validation(Required=false)]
                    public string AirportCityName { get; set; }

                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The parent city name of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("airport_parent_city_name")]
                    [Validation(Required=false)]
                    public string AirportParentCityName { get; set; }

                    /// <summary>
                    /// <para>The administrative division code of the county-level city where the airport is located.</para>
                    /// <remarks>
                    /// <para>Notice: Null if the airport is not a county-level airport.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("county_city_adcode")]
                    [Validation(Required=false)]
                    public string CountyCityAdcode { get; set; }

                    /// <summary>
                    /// <para>The name of the county-level city where the airport is located.</para>
                    /// <remarks>
                    /// <para>Notice: Null if the airport is not a county-level airport.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("county_city_name")]
                    [Validation(Required=false)]
                    public string CountyCityName { get; set; }

                    /// <summary>
                    /// <para>The administrative division code of the prefecture-level city where the airport is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330100</para>
                    /// </summary>
                    [NameInMap("prefecture_city_adcode")]
                    [Validation(Required=false)]
                    public string PrefectureCityAdcode { get; set; }

                    /// <summary>
                    /// <para>The name of the prefecture-level city where the airport is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("prefecture_city_name")]
                    [Validation(Required=false)]
                    public string PrefectureCityName { get; set; }

                }

                /// <summary>
                /// <para>The three-letter arrival airport code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>兰州中川机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The arrival city six-letter code.</para>
                /// <remarks>
                /// <para>Notice: Deprecated. Use the three-letter city code instead.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("arr_city_ad_code")]
                [Validation(Required=false)]
                public string ArrCityAdCode { get; set; }

                /// <summary>
                /// <para>The three-letter arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>兰州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival terminal.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Empty if the airport has no terminal information.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>T3</para>
                /// </summary>
                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_level")]
                [Validation(Required=false)]
                public string CabinLevel { get; set; }

                /// <summary>
                /// <para>The detailed information of the city where the departure airport is located.</para>
                /// </summary>
                [NameInMap("dep_airport_city_county")]
                [Validation(Required=false)]
                public FlightOrderQueryResponseBodyModuleFlightInfoListDepAirportCityCounty DepAirportCityCounty { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListDepAirportCityCounty : TeaModel {
                    /// <summary>
                    /// <para>The administrative division code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>110100</para>
                    /// </summary>
                    [NameInMap("adcode")]
                    [Validation(Required=false)]
                    public string Adcode { get; set; }

                    /// <summary>
                    /// <para>The airport city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("airport_city_code")]
                    [Validation(Required=false)]
                    public string AirportCityCode { get; set; }

                    /// <summary>
                    /// <para>The airport city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("airport_city_name")]
                    [Validation(Required=false)]
                    public string AirportCityName { get; set; }

                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PKX</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京大兴国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The parent city name of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("airport_parent_city_name")]
                    [Validation(Required=false)]
                    public string AirportParentCityName { get; set; }

                    /// <summary>
                    /// <para>The administrative division code of the county-level city where the airport is located.</para>
                    /// <remarks>
                    /// <para>Notice: Null if the airport is not a county-level airport.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("county_city_adcode")]
                    [Validation(Required=false)]
                    public string CountyCityAdcode { get; set; }

                    /// <summary>
                    /// <para>The name of the county-level city where the airport is located.</para>
                    /// <remarks>
                    /// <para>Notice: Null if the airport is not a county-level airport.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("county_city_name")]
                    [Validation(Required=false)]
                    public string CountyCityName { get; set; }

                    /// <summary>
                    /// <para>The administrative division code of the prefecture-level city where the airport is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>110100</para>
                    /// </summary>
                    [NameInMap("prefecture_city_adcode")]
                    [Validation(Required=false)]
                    public string PrefectureCityAdcode { get; set; }

                    /// <summary>
                    /// <para>The name of the prefecture-level city where the airport is located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("prefecture_city_name")]
                    [Validation(Required=false)]
                    public string PrefectureCityName { get; set; }

                }

                /// <summary>
                /// <para>The three-letter departure airport code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>栎社国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The departure city six-letter code.</para>
                /// <remarks>
                /// <para>Notice: Deprecated. Use the three-letter city code instead.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("dep_city_ad_code")]
                [Validation(Required=false)]
                public string DepCityAdCode { get; set; }

                /// <summary>
                /// <para>The three-letter departure city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city name, such as Beijing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>宁波</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure terminal.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Empty if the airport has no terminal information.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>T4</para>
                /// </summary>
                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The flight mileage.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Empty if the flight has no mileage information at the time of order creation.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU3849</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The journey index.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For round-trip or multi-leg trips, the journey index of the second leg is 1.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment index.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For transfer flights, the segment index of the second segment is 1.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The list of stopover cities.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Empty for segments without stopover cities.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public List<string> StopCity { get; set; }

                /// <summary>
                /// <para>The stopover city information.</para>
                /// </summary>
                [NameInMap("stop_city_info_list")]
                [Validation(Required=false)]
                public List<FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoList> StopCityInfoList { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoList : TeaModel {
                    /// <summary>
                    /// <para>The detailed information of the city where the stopover airport is located.</para>
                    /// </summary>
                    [NameInMap("stop_airport_city_county")]
                    [Validation(Required=false)]
                    public FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoListStopAirportCityCounty StopAirportCityCounty { get; set; }
                    public class FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoListStopAirportCityCounty : TeaModel {
                        /// <summary>
                        /// <para>The administrative division code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>330100</para>
                        /// </summary>
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        /// <summary>
                        /// <para>The airport city code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("airport_city_code")]
                        [Validation(Required=false)]
                        public string AirportCityCode { get; set; }

                        /// <summary>
                        /// <para>The airport city name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>杭州</para>
                        /// </summary>
                        [NameInMap("airport_city_name")]
                        [Validation(Required=false)]
                        public string AirportCityName { get; set; }

                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萧山国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The parent city name of the airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("airport_parent_city_name")]
                        [Validation(Required=false)]
                        public string AirportParentCityName { get; set; }

                        /// <summary>
                        /// <para>The administrative division code of the county-level city where the airport is located.</para>
                        /// <remarks>
                        /// <para>Notice: Null if the airport is not a county-level airport.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("county_city_adcode")]
                        [Validation(Required=false)]
                        public string CountyCityAdcode { get; set; }

                        /// <summary>
                        /// <para>The name of the county-level city where the airport is located.</para>
                        /// <remarks>
                        /// <para>Notice: Null if the airport is not a county-level airport.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("county_city_name")]
                        [Validation(Required=false)]
                        public string CountyCityName { get; set; }

                        /// <summary>
                        /// <para>The administrative division code of the prefecture-level city where the airport is located.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>330100</para>
                        /// </summary>
                        [NameInMap("prefecture_city_adcode")]
                        [Validation(Required=false)]
                        public string PrefectureCityAdcode { get; set; }

                        /// <summary>
                        /// <para>The name of the prefecture-level city where the airport is located.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>杭州</para>
                        /// </summary>
                        [NameInMap("prefecture_city_name")]
                        [Validation(Required=false)]
                        public string PrefectureCityName { get; set; }

                    }

                    /// <summary>
                    /// <para>The stopover airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("stop_airport_code")]
                    [Validation(Required=false)]
                    public string StopAirportCode { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of refund tickets.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the order has no refunds, an empty array is returned.</description></item>
            /// <item><description>Only successfully refunded data is displayed.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList> FlightRefundTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The refund approval ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If refund approval is not enabled, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>131241241</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The arrival airport of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大兴国际机场</para>
                /// </summary>
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <para>The arrival airport code of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city code of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The corporate refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("company_refund_ticket_fee")]
                [Validation(Required=false)]
                public double? CompanyRefundTicketFee { get; set; }

                /// <summary>
                /// <para>The departure airport of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                /// <summary>
                /// <para>The departure airport code of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure city of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The departure city code of the refunded flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The refund flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU9688</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The journey index.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>A round-trip or multi-leg itinerary contains multiple journeys.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The third-party refund approval ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If third-party refund approval is not enabled, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>a131241241</para>
                /// </summary>
                [NameInMap("out_apply_id")]
                [Validation(Required=false)]
                public string OutApplyId { get; set; }

                /// <summary>
                /// <para>The personal refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("personal_refund_ticket_fee")]
                [Validation(Required=false)]
                public double? PersonalRefundTicketFee { get; set; }

                /// <summary>
                /// <para>The refund order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43667</para>
                /// </summary>
                [NameInMap("refund_order_id")]
                [Validation(Required=false)]
                public long? RefundOrderId { get; set; }

                /// <summary>
                /// <para>The refund reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>临时不出差</para>
                /// </summary>
                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                /// <summary>
                /// <para>The refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，退票金额仅在第一个航段上体现，第二个航段退票金额=0</para>
                /// </summary>
                [NameInMap("refund_ticket_fee")]
                [Validation(Required=false)]
                public double? RefundTicketFee { get; set; }

                /// <summary>
                /// <para>The refund type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("refund_type")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

                /// <summary>
                /// <para>The segment index.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>A connecting itinerary contains multiple segments.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The refund ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000-13232</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            /// <summary>
            /// <para>The list of forward tickets.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the order has not been ticketed, an empty array is returned.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightTicketInfoList> FlightTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大兴国际机场</para>
                /// </summary>
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <para>The arrival airport code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The three-letter arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The airport construction fee. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，机建费用仅在第一个航段上体现，第二个航段机建费用=0</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public double? BuildPrice { get; set; }

                /// <summary>
                /// <para>Indicates whether the ticket has been rebooked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                /// <summary>
                /// <para>The departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                /// <summary>
                /// <para>The departure airport code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The three-letter departure city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10 中转航班为两段平均折扣，值一样</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1739</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The journey index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The fuel surcharge. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，燃油费用仅在第一个航段上体现，第二个航段燃油费=0</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public double? OilPrice { get; set; }

                /// <summary>
                /// <para>The payment method for the forward ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The personal payment amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 票价个人支付部分，如果是真中转/往返，体现在第一个航段上，第二个航段为0</para>
                /// </summary>
                [NameInMap("personal_price")]
                [Validation(Required=false)]
                public double? PersonalPrice { get; set; }

                /// <summary>
                /// <para>The segment index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The settlement amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班，结算金额仅在第一个航段上体现，第二个航段结算=0</para>
                /// </summary>
                [NameInMap("settle_price")]
                [Validation(Required=false)]
                public double? SettlePrice { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000-123</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The ticket price. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100 如果为真中转航班（两个航班一个票号），票价仅在第一个航段上体现，第二个航段票价=0</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <para>The ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

                /// <summary>
                /// <para>The ticket status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ticket_status_code")]
                [Validation(Required=false)]
                public int? TicketStatusCode { get; set; }

                /// <summary>
                /// <para>The user ID of the passenger associated with the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机票对应乘客用户id</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The insurance list.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns an empty array if no insurance information exists.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("insurance_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleInsuranceInfoList> InsuranceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleInsuranceInfoList : TeaModel {
                /// <summary>
                /// <para>The insurance amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <para>The insurance order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>345-987-098</para>
                /// </summary>
                [NameInMap("insurance_no")]
                [Validation(Required=false)]
                public string InsuranceNo { get; set; }

                /// <summary>
                /// <para>The name of the insured person.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The insurance status.
                /// [_single</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The insurance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>航空意外险</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <para>The invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43316</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The basic information of the order.</para>
            /// </summary>
            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <para>The approval form ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If no approval form is required for the trip, the approval form ID is 0.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>175634</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The travel reason on the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出差</para>
                /// </summary>
                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <para>The contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The business travel enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅企业id</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The enterprise name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// <para>The ID of the department to which the user belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>部门id</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <para>The name of the department to which the user belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试部门</para>
                /// </summary>
                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <para>The excess approval form IDs, separated by commas.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This field has a value only when an excess approval is initiated during order creation. Otherwise, it is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12345,34556</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>The third-party excess approval form IDs, separated by commas.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This field has a value only when a third-party excess approval is initiated during order creation. Otherwise, it is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>a12345,a34556</para>
                /// </summary>
                [NameInMap("exceed_third_part_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdPartApplyId { get; set; }

                /// <summary>
                /// <para>The order creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The order update time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13628</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>146178</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <para>The service provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里商旅</para>
                /// </summary>
                [NameInMap("supplier")]
                [Validation(Required=false)]
                public string Supplier { get; set; }

                /// <summary>
                /// <para>The third-party approval form ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The external approval form ID displayed to users.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The third-party approval form ID. We recommend that you use this value.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>00021230711000001Test-2</para>
                /// </summary>
                [NameInMap("thirdpart_business_id")]
                [Validation(Required=false)]
                public string ThirdpartBusinessId { get; set; }

                /// <summary>
                /// <para>The third-party enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>三方企业id</para>
                /// </summary>
                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Empty if no third-party itinerary information exists.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户id</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The passenger list.</para>
            /// </summary>
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePassengerInfoList : TeaModel {
                /// <summary>
                /// <para>The cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13446</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The cost center code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-3345</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-PROJECT</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>133576</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-THIRDPROJECT</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                /// <summary>
                /// <para>The passenger user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出行人用户id</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The passenger type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The price details list.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns an empty array if no transaction records exist.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <para>The transaction category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The transaction creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The passenger names, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三,李四</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The order transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS73290</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <para>The fund flow direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
