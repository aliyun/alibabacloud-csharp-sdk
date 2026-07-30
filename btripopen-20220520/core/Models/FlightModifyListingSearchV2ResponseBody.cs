// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyListingSearchV2ResponseBodyModule Module { get; set; }
        public class FlightModifyListingSearchV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of direct flights.</para>
            /// </summary>
            [NameInMap("direct_flight_list")]
            [Validation(Required=false)]
            public List<FlightModifyListingSearchV2ResponseBodyModuleDirectFlightList> DirectFlightList { get; set; }
            public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightList : TeaModel {
                /// <summary>
                /// <para>The marketing airline information.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline Chinese name, such as 中国国航.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    /// <summary>
                    /// <para>The airline Chinese short name, such as 国航.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    /// <summary>
                    /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>//gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png_80x80.jpg</para>
                    /// </summary>
                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    /// <summary>
                    /// <para>The low-cost carrier indicator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                /// <summary>
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XIL</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>锡林浩特机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>锡林浩特</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

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
                /// <para>The arrival city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-18 10:25:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabinClassName")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListDepAirportInfo : TeaModel {
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
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The departure city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XIL</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time, such as 2021-11-15 21:55.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-18 09:10:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total flight duration, from departure time to arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight number. For multi-segment transfers, this is the first segment flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1110</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The code-share flight information.</para>
                /// </summary>
                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfo FlightShareInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfo : TeaModel {
                    /// <summary>
                    /// <para>The operating airline information.</para>
                    /// </summary>
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfoOperatingAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline Chinese name, such as 中国国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文名, 如：中国国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The airline Chinese short name, such as 国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文简称, 如：国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    /// <summary>
                    /// <para>The operating flight number. This field has a value only for code-share flights.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>承运方航班号（共享航班时有值）</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                /// <summary>
                /// <para>The aircraft size name in Chinese, such as &quot;中型机&quot; (medium aircraft).</para>
                /// 
                /// <b>Example:</b>
                /// <para>小型机</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <para>The stopover information.</para>
                /// </summary>
                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightStopInfo : TeaModel {
                    /// <summary>
                    /// <para>The stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停机场</para>
                    /// </summary>
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    /// <summary>
                    /// <para>The stopover terminal for arrival.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 降落</para>
                    /// </summary>
                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停站到达时间</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市三字码</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The stopover city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市名称</para>
                    /// </summary>
                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    /// <summary>
                    /// <para>The stopover terminal for departure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 起飞</para>
                    /// </summary>
                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停站出发时间</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The transfer information.</para>
                /// </summary>
                [NameInMap("flight_transfer_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfo FlightTransferInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline information for the second leg of the transfer flight.</para>
                    /// </summary>
                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfoTransferAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline Chinese name, such as 中国国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文名, 如：中国国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The airline Chinese short name, such as 国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文简称, 如：国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    /// <summary>
                    /// <para>The transfer city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转城市三字码</para>
                    /// </summary>
                    [NameInMap("transfer_city_code")]
                    [Validation(Required=false)]
                    public string TransferCityCode { get; set; }

                    /// <summary>
                    /// <para>The transfer city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转城市名称</para>
                    /// </summary>
                    [NameInMap("transfer_city_name")]
                    [Validation(Required=false)]
                    public string TransferCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time of the transfer flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转出发时间</para>
                    /// </summary>
                    [NameInMap("transfer_dep_time")]
                    [Validation(Required=false)]
                    public string TransferDepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number for the second leg of the transfer flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转第二段航班号</para>
                    /// </summary>
                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    /// <summary>
                    /// <para>The aircraft size Chinese name for the second leg of the transfer flight, such as &quot;中型机&quot; (medium aircraft).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转第二段航班机型中文名，如&quot;中型机&quot;</para>
                    /// </summary>
                    [NameInMap("transfer_flight_size")]
                    [Validation(Required=false)]
                    public string TransferFlightSize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the transfer flight is a codeshare flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("transfer_share")]
                    [Validation(Required=false)]
                    public bool? TransferShare { get; set; }

                    /// <summary>
                    /// <para>The stopover time at the transfer city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("transfer_stop_time")]
                    [Validation(Required=false)]
                    public int? TransferStopTime { get; set; }

                }

                /// <summary>
                /// <para>The aircraft type code, such as 738.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ARJ</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The journey sequence number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                /// <summary>
                /// <para>The number of remaining seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("left_num")]
                [Validation(Required=false)]
                public string LeftNum { get; set; }

                /// <summary>
                /// <para>The manufacturer, such as &quot;Boeing&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>波音</para>
                /// </summary>
                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                /// <summary>
                /// <para>The meal description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>餐食描述</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The price information.</para>
                /// </summary>
                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <para>The adult (student) discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <para>The adult (student) tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <para>The adult (student) total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>137000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before price control, excluding tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <para>The child discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <para>The child tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <para>The child total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>66000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The infant discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <para>The infant tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <para>The infant total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The original adult price before discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1300</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <para>The original adult total price before discount, including tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12300</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The reshop price information (fees required for the flight change).</para>
                    /// </summary>
                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <para>The reshop change fee per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <para>The reshop change fee per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <para>The reshop change fee per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <para>The segment sequence number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight is a code-share flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                /// <summary>
                /// <para>The aircraft size abbreviation in Chinese, such as &quot;中&quot; (medium).</para>
                /// 
                /// <b>Example:</b>
                /// <para>小</para>
                /// </summary>
                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                /// <summary>
                /// <para>The cross-day display text, such as &quot;+1 day&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>跨天展示文案，如&quot;+1天&quot;</para>
                /// </summary>
                [NameInMap("span_day")]
                [Validation(Required=false)]
                public string SpanDay { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight involves a transfer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("transfer")]
                [Validation(Required=false)]
                public bool? Transfer { get; set; }

            }

            /// <summary>
            /// <para>The next retry time interval in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("next_req_wait_time")]
            [Validation(Required=false)]
            public long? NextReqWaitTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a retry is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// <para>The search retry token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2c230080358295f99e03aa4e3ccf1bd</para>
            /// </summary>
            [NameInMap("search_retry_token")]
            [Validation(Required=false)]
            public string SearchRetryToken { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
            /// </summary>
            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The list of transfer flights.</para>
            /// </summary>
            [NameInMap("transfer_flight_list")]
            [Validation(Required=false)]
            public List<FlightModifyListingSearchV2ResponseBodyModuleTransferFlightList> TransferFlightList { get; set; }
            public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightList : TeaModel {
                /// <summary>
                /// <para>The marketing airline information.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline Chinese name, such as 中国国航.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航空公司中文名, 如：中国国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    /// <summary>
                    /// <para>The airline Chinese short name, such as 国航.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航空公司中文简称, 如：国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    /// <summary>
                    /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                    /// </summary>
                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    /// <summary>
                    /// <para>The low-cost carrier indicator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>廉航标识</para>
                    /// </summary>
                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                /// <summary>
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场代码</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场名称</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场简称</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航站楼</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The arrival city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>到达城市三字码</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>到达时间</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabinClassName")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场代码</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场名称</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>机场简称</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>航站楼</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The departure city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出发城市三字码</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time, such as 2021-11-15 21:55.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出发时间</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total flight duration, from departure time to arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight number. For multi-segment transfers, this is the first segment flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>航班号，中转多航段为第一程航班号</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The code-share flight information.</para>
                /// </summary>
                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfo FlightShareInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfo : TeaModel {
                    /// <summary>
                    /// <para>The operating airline information.</para>
                    /// </summary>
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfoOperatingAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline Chinese name, such as 中国国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文名, 如：中国国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The airline Chinese short name, such as 国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文简称, 如：国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    /// <summary>
                    /// <para>The operating flight number. This field has a value only for code-share flights.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>承运方航班号（共享航班时有值）</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                /// <summary>
                /// <para>The aircraft size name in Chinese, such as &quot;中型机&quot; (medium aircraft).</para>
                /// 
                /// <b>Example:</b>
                /// <para>机型中文名，如&quot;中型机&quot;</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <para>The stopover information.</para>
                /// </summary>
                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightStopInfo : TeaModel {
                    /// <summary>
                    /// <para>The stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停机场</para>
                    /// </summary>
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    /// <summary>
                    /// <para>The stopover terminal for arrival.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 降落</para>
                    /// </summary>
                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市名称</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市三字码</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The stopover city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市名称</para>
                    /// </summary>
                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    /// <summary>
                    /// <para>The stopover terminal for departure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 起飞</para>
                    /// </summary>
                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停站出发时间</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The transfer information.</para>
                /// </summary>
                [NameInMap("flight_transfer_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfo FlightTransferInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline information for the second leg of the transfer flight.</para>
                    /// </summary>
                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfoTransferAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline Chinese name, such as 中国国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文名, 如：中国国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The airline Chinese short name, such as 国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文简称, 如：国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    /// <summary>
                    /// <para>The transfer city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转城市三字码</para>
                    /// </summary>
                    [NameInMap("transfer_city_code")]
                    [Validation(Required=false)]
                    public string TransferCityCode { get; set; }

                    /// <summary>
                    /// <para>The transfer city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转城市名称</para>
                    /// </summary>
                    [NameInMap("transfer_city_name")]
                    [Validation(Required=false)]
                    public string TransferCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time of the transfer flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转出发时间</para>
                    /// </summary>
                    [NameInMap("transfer_dep_time")]
                    [Validation(Required=false)]
                    public string TransferDepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number for the second leg of the transfer flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转第二段航班号</para>
                    /// </summary>
                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    /// <summary>
                    /// <para>The aircraft size Chinese name for the second leg of the transfer flight, such as &quot;中型机&quot; (medium aircraft).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中转第二段航班机型中文名，如&quot;中型机&quot;</para>
                    /// </summary>
                    [NameInMap("transfer_flight_size")]
                    [Validation(Required=false)]
                    public string TransferFlightSize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the transfer flight is a codeshare flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("transfer_share")]
                    [Validation(Required=false)]
                    public bool? TransferShare { get; set; }

                    /// <summary>
                    /// <para>The stopover time at the transfer city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("transfer_stop_time")]
                    [Validation(Required=false)]
                    public int? TransferStopTime { get; set; }

                }

                /// <summary>
                /// <para>The aircraft type code, such as 738.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机型代码，如738</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The journey sequence number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                /// <summary>
                /// <para>The number of remaining seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("left_num")]
                [Validation(Required=false)]
                public string LeftNum { get; set; }

                /// <summary>
                /// <para>The manufacturer, such as &quot;Boeing&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>制造商，如&quot;波音&quot;</para>
                /// </summary>
                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                /// <summary>
                /// <para>The meal description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>餐食描述</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The price information.</para>
                /// </summary>
                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <para>The adult (student) discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <para>The adult (student) tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <para>The adult (student) total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before price control, excluding tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <para>The child discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <para>The child tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <para>The child total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The infant discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <para>The infant tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <para>The infant total price including tax and fees. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The original adult price before discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <para>The original adult total price before discount, including tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The reshop price information (fees required for the flight change).</para>
                    /// </summary>
                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <para>The reshop change fee per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <para>The reshop change fee per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <para>The reshop change fee per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total reshop cost per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <para>The reshop price difference per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <para>The segment sequence number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight is a code-share flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                /// <summary>
                /// <para>The aircraft size abbreviation in Chinese, such as &quot;中&quot; (medium).</para>
                /// 
                /// <b>Example:</b>
                /// <para>机型简称，如&quot;中&quot;</para>
                /// </summary>
                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                /// <summary>
                /// <para>The cross-day display text, such as &quot;+1 day&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>跨天展示文案，如&quot;+1天&quot;</para>
                /// </summary>
                [NameInMap("span_day")]
                [Validation(Required=false)]
                public string SpanDay { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight involves a transfer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("transfer")]
                [Validation(Required=false)]
                public bool? Transfer { get; set; }

            }

            /// <summary>
            /// <para>The transfer flight recommendation title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>为您推荐中转航班!</para>
            /// </summary>
            [NameInMap("transfer_title")]
            [Validation(Required=false)]
            public string TransferTitle { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2136019116915615924561621e06ee</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
