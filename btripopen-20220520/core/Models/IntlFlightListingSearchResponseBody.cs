// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightListingSearchResponseBodyModule Module { get; set; }
        public class IntlFlightListingSearchResponseBodyModule : TeaModel {
            [NameInMap("flight_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightListingSearchResponseBodyModuleFlightItemList> FlightItemList { get; set; }
            public class IntlFlightListingSearchResponseBodyModuleFlightItemList : TeaModel {
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem BestPriceItem { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem : TeaModel {
                    [NameInMap("agreement_price_codes")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes> AgreementPriceCodes { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes : TeaModel {
                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("item_type")]
                    [Validation(Required=false)]
                    public string ItemType { get; set; }

                    [NameInMap("label_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemLabelList> LabelList { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemLabelList : TeaModel {
                        [NameInMap("labelCode")]
                        [Validation(Required=false)]
                        public int? LabelCode { get; set; }

                        [NameInMap("labelName")]
                        [Validation(Required=false)]
                        public string LabelName { get; set; }

                    }

                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                }

                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos : TeaModel {
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("flight_segment_infos")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        [NameInMap("arr_airport_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
                            [NameInMap("airport_code")]
                            [Validation(Required=false)]
                            public string AirportCode { get; set; }

                            [NameInMap("airport_name")]
                            [Validation(Required=false)]
                            public string AirportName { get; set; }

                            [NameInMap("airport_short_name")]
                            [Validation(Required=false)]
                            public string AirportShortName { get; set; }

                            [NameInMap("terminal")]
                            [Validation(Required=false)]
                            public string Terminal { get; set; }

                        }

                        [NameInMap("arr_city_code")]
                        [Validation(Required=false)]
                        public string ArrCityCode { get; set; }

                        [NameInMap("arr_city_name")]
                        [Validation(Required=false)]
                        public string ArrCityName { get; set; }

                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("dep_airport_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
                            [NameInMap("airport_code")]
                            [Validation(Required=false)]
                            public string AirportCode { get; set; }

                            [NameInMap("airport_name")]
                            [Validation(Required=false)]
                            public string AirportName { get; set; }

                            [NameInMap("airport_short_name")]
                            [Validation(Required=false)]
                            public string AirportShortName { get; set; }

                            [NameInMap("terminal")]
                            [Validation(Required=false)]
                            public string Terminal { get; set; }

                        }

                        [NameInMap("dep_city_code")]
                        [Validation(Required=false)]
                        public string DepCityCode { get; set; }

                        [NameInMap("dep_city_name")]
                        [Validation(Required=false)]
                        public string DepCityName { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        [NameInMap("flight_share_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                                [NameInMap("airline_code")]
                                [Validation(Required=false)]
                                public string AirlineCode { get; set; }

                                [NameInMap("airline_name")]
                                [Validation(Required=false)]
                                public string AirlineName { get; set; }

                                [NameInMap("short_name")]
                                [Validation(Required=false)]
                                public string ShortName { get; set; }

                            }

                            [NameInMap("operating_flight_no")]
                            [Validation(Required=false)]
                            public string OperatingFlightNo { get; set; }

                        }

                        [NameInMap("flight_size")]
                        [Validation(Required=false)]
                        public string FlightSize { get; set; }

                        [NameInMap("flight_stop_info_list")]
                        [Validation(Required=false)]
                        public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
                            [NameInMap("stop_airport")]
                            [Validation(Required=false)]
                            public string StopAirport { get; set; }

                            [NameInMap("stop_airport_name")]
                            [Validation(Required=false)]
                            public string StopAirportName { get; set; }

                            [NameInMap("stop_arr_term")]
                            [Validation(Required=false)]
                            public string StopArrTerm { get; set; }

                            [NameInMap("stop_arr_time")]
                            [Validation(Required=false)]
                            public string StopArrTime { get; set; }

                            [NameInMap("stop_city_code")]
                            [Validation(Required=false)]
                            public string StopCityCode { get; set; }

                            [NameInMap("stop_city_name")]
                            [Validation(Required=false)]
                            public string StopCityName { get; set; }

                            [NameInMap("stop_dep_term")]
                            [Validation(Required=false)]
                            public string StopDepTerm { get; set; }

                            [NameInMap("stop_dep_time")]
                            [Validation(Required=false)]
                            public string StopDepTime { get; set; }

                            [NameInMap("stop_time")]
                            [Validation(Required=false)]
                            public string StopTime { get; set; }

                        }

                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        [NameInMap("one_more")]
                        [Validation(Required=false)]
                        public int? OneMore { get; set; }

                        [NameInMap("one_more_show")]
                        [Validation(Required=false)]
                        public string OneMoreShow { get; set; }

                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

                        [NameInMap("share")]
                        [Validation(Required=false)]
                        public bool? Share { get; set; }

                        [NameInMap("short_flight_size")]
                        [Validation(Required=false)]
                        public string ShortFlightSize { get; set; }

                        [NameInMap("stop")]
                        [Validation(Required=false)]
                        public bool? Stop { get; set; }

                        [NameInMap("total_time")]
                        [Validation(Required=false)]
                        public string TotalTime { get; set; }

                    }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("transfer_time")]
                    [Validation(Required=false)]
                    public int? TransferTime { get; set; }

                }

            }

            [NameInMap("need_continue")]
            [Validation(Required=false)]
            public bool? NeedContinue { get; set; }

            [NameInMap("query_record_id")]
            [Validation(Required=false)]
            public string QueryRecordId { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

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
