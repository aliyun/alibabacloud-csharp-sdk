// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingFlightListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingFlightListResponseBodyModule Module { get; set; }
        public class TicketChangingFlightListResponseBodyModule : TeaModel {
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingFlightListResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class TicketChangingFlightListResponseBodyModuleFlightInfoList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListAirlineInfo AirlineInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListAirlineInfo : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListArrAirportInfo ArrAirportInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListArrAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("cabin_list")]
                [Validation(Required=false)]
                public List<TicketChangingFlightListResponseBodyModuleFlightInfoListCabinList> CabinList { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListCabinList : TeaModel {
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_desc")]
                    [Validation(Required=false)]
                    public string CabinDesc { get; set; }

                    [NameInMap("cabin_discount")]
                    [Validation(Required=false)]
                    public int? CabinDiscount { get; set; }

                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    [NameInMap("left_num")]
                    [Validation(Required=false)]
                    public string LeftNum { get; set; }

                    [NameInMap("modify_price_list")]
                    [Validation(Required=false)]
                    public List<TicketChangingFlightListResponseBodyModuleFlightInfoListCabinListModifyPriceList> ModifyPriceList { get; set; }
                    public class TicketChangingFlightListResponseBodyModuleFlightInfoListCabinListModifyPriceList : TeaModel {
                        [NameInMap("passenger_type")]
                        [Validation(Required=false)]
                        public int? PassengerType { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public int? TicketPrice { get; set; }

                        [NameInMap("upgrade_fee")]
                        [Validation(Required=false)]
                        public int? UpgradeFee { get; set; }

                        [NameInMap("upgrade_price")]
                        [Validation(Required=false)]
                        public int? UpgradePrice { get; set; }

                    }

                    [NameInMap("ota_itemid")]
                    [Validation(Required=false)]
                    public string OtaItemid { get; set; }

                }

                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public TicketChangingFlightListResponseBodyModuleFlightInfoListDepAirportInfo DepAirportInfo { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListDepAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                [NameInMap("is_stop")]
                [Validation(Required=false)]
                public bool? IsStop { get; set; }

                [NameInMap("lowest_cabin")]
                [Validation(Required=false)]
                public string LowestCabin { get; set; }

                [NameInMap("lowest_cabin_class")]
                [Validation(Required=false)]
                public string LowestCabinClass { get; set; }

                [NameInMap("lowest_cabin_desc")]
                [Validation(Required=false)]
                public string LowestCabinDesc { get; set; }

                [NameInMap("lowest_cabin_num")]
                [Validation(Required=false)]
                public string LowestCabinNum { get; set; }

                [NameInMap("lowest_cabin_price")]
                [Validation(Required=false)]
                public List<TicketChangingFlightListResponseBodyModuleFlightInfoListLowestCabinPrice> LowestCabinPrice { get; set; }
                public class TicketChangingFlightListResponseBodyModuleFlightInfoListLowestCabinPrice : TeaModel {
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public int? UpgradeFee { get; set; }

                    [NameInMap("upgrade_price")]
                    [Validation(Required=false)]
                    public int? UpgradePrice { get; set; }

                }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("modify_flight_arr_time")]
                [Validation(Required=false)]
                public string ModifyFlightArrTime { get; set; }

                [NameInMap("modify_flight_dep_date")]
                [Validation(Required=false)]
                public string ModifyFlightDepDate { get; set; }

                [NameInMap("modify_flight_dep_time")]
                [Validation(Required=false)]
                public string ModifyFlightDepTime { get; set; }

                [NameInMap("session_id")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
