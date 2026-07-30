// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingFlightListResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
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
        public TicketChangingFlightListResponseBodyModule Module { get; set; }
        public class TicketChangingFlightListResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of available flights for rebooking.</para>
            /// </summary>
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingFlightListResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class TicketChangingFlightListResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <para>The marketing airline information. Required.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListAirlineInfo AirlineInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name (not available).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The airline short name (not available).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                /// <summary>
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListArrAirportInfo ArrAirportInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListArrAirportInfo : TeaModel {
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
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T4</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The cabin list (not available).</para>
                /// </summary>
                [NameInMap("cabin_list")]
                [Validation(Required=false)]
                public List<TicketChangingFlightListResponseBodyModuleFlightInfoListCabinList> CabinList { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListCabinList : TeaModel {
                    /// <summary>
                    /// <para>The cabin code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>G</para>
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
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The cabin description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>超级经济舱</para>
                    /// </summary>
                    [NameInMap("cabin_desc")]
                    [Validation(Required=false)]
                    public string CabinDesc { get; set; }

                    /// <summary>
                    /// <para>The cabin discount. A value of 80 represents a 20% discount. A null value indicates no restriction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("cabin_discount")]
                    [Validation(Required=false)]
                    public int? CabinDiscount { get; set; }

                    /// <summary>
                    /// <para>The child cabin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>G</para>
                    /// </summary>
                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    /// <summary>
                    /// <para>The number of remaining seats.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("left_num")]
                    [Validation(Required=false)]
                    public string LeftNum { get; set; }

                    /// <summary>
                    /// <para>The rebooking fee information.</para>
                    /// </summary>
                    [NameInMap("modify_price_list")]
                    [Validation(Required=false)]
                    public List<TicketChangingFlightListResponseBodyModuleFlightInfoListCabinListModifyPriceList> ModifyPriceList { get; set; }
                    public class TicketChangingFlightListResponseBodyModuleFlightInfoListCabinListModifyPriceList : TeaModel {
                        /// <summary>
                        /// <para>The passenger type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("passenger_type")]
                        [Validation(Required=false)]
                        public int? PassengerType { get; set; }

                        /// <summary>
                        /// <para>The ticket price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public int? TicketPrice { get; set; }

                        /// <summary>
                        /// <para>The rebooking service fee.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("upgrade_fee")]
                        [Validation(Required=false)]
                        public int? UpgradeFee { get; set; }

                        /// <summary>
                        /// <para>The cabin upgrade fare difference.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("upgrade_price")]
                        [Validation(Required=false)]
                        public int? UpgradePrice { get; set; }

                    }

                    /// <summary>
                    /// <para>The product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;360379a11ee84e9aa011baa41b758fe6&quot;</para>
                    /// </summary>
                    [NameInMap("ota_itemid")]
                    [Validation(Required=false)]
                    public string OtaItemid { get; set; }

                }

                /// <summary>
                /// <para>The operating flight information. This field has a value only for code-share flights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1704</para>
                /// </summary>
                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                /// <summary>
                /// <para>The operating flight information. This field has a value only for code-share flights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1704</para>
                /// </summary>
                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListDepAirportInfo DepAirportInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The marketing flight number. Required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1704</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The aircraft size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大型机</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <para>The aircraft type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>空客320</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>Indicates whether the price is a contract price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight is a code-share flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_stop")]
                [Validation(Required=false)]
                public bool? IsStop { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("lowest_cabin")]
                [Validation(Required=false)]
                public string LowestCabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("lowest_cabin_class")]
                [Validation(Required=false)]
                public string LowestCabinClass { get; set; }

                /// <summary>
                /// <para>The cabin description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("lowest_cabin_desc")]
                [Validation(Required=false)]
                public string LowestCabinDesc { get; set; }

                /// <summary>
                /// <para>The cabin availability (not available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("lowest_cabin_num")]
                [Validation(Required=false)]
                public string LowestCabinNum { get; set; }

                /// <summary>
                /// <para>The cabin rebooking price.</para>
                /// </summary>
                [NameInMap("lowest_cabin_price")]
                [Validation(Required=false)]
                public List<TicketChangingFlightListResponseBodyModuleFlightInfoListLowestCabinPrice> LowestCabinPrice { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListLowestCabinPrice : TeaModel {
                    /// <summary>
                    /// <para>The passenger type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    /// <summary>
                    /// <para>The ticket price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    /// <summary>
                    /// <para>The rebooking service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public int? UpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The cabin upgrade fare difference.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("upgrade_price")]
                    [Validation(Required=false)]
                    public int? UpgradePrice { get; set; }

                }

                /// <summary>
                /// <para>The meal service description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无餐食</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The arrival time of the rebooking flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("modify_flight_arr_time")]
                [Validation(Required=false)]
                public string ModifyFlightArrTime { get; set; }

                /// <summary>
                /// <para>The departure date of the rebooking flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("modify_flight_dep_date")]
                [Validation(Required=false)]
                public string ModifyFlightDepDate { get; set; }

                /// <summary>
                /// <para>The departure time of the rebooking flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("modify_flight_dep_time")]
                [Validation(Required=false)]
                public string ModifyFlightDepTime { get; set; }

                /// <summary>
                /// <para>The session ID used for the rebooking request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d1fb9e0a794f45e1b762d36ff1d17zz</para>
                /// </summary>
                [NameInMap("session_id")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The arrival time at the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The departure time from the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
