// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaItemDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOtaItemDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOtaItemDetailResponseBodyModule : TeaModel {
            [NameInMap("flight_journey_infos")]
            [Validation(Required=false)]
            public List<IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfos> FlightJourneyInfos { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfos : TeaModel {
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

                [NameInMap("extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfos : TeaModel {
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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

                    [NameInMap("baggage_desc")]
                    [Validation(Required=false)]
                    public string BaggageDesc { get; set; }

                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            [NameInMap("airline_chinese_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseName { get; set; }

                            [NameInMap("airline_chinese_short_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseShortName { get; set; }

                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            [NameInMap("airline_icon")]
                            [Validation(Required=false)]
                            public string AirlineIcon { get; set; }

                            [NameInMap("cheap_flight")]
                            [Validation(Required=false)]
                            public bool? CheapFlight { get; set; }

                        }

                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    [NameInMap("flight_stop_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfo : TeaModel {
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

                        [NameInMap("stop_city_names")]
                        [Validation(Required=false)]
                        public List<string> StopCityNames { get; set; }

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

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    [NameInMap("on_time_rate")]
                    [Validation(Required=false)]
                    public string OnTimeRate { get; set; }

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

                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

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

                    [NameInMap("transfer_time")]
                    [Validation(Required=false)]
                    public string TransferTime { get; set; }

                    [NameInMap("transfer_time_number")]
                    [Validation(Required=false)]
                    public int? TransferTimeNumber { get; set; }

                }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            [NameInMap("group_item")]
            [Validation(Required=false)]
            public IntlFlightOtaItemDetailResponseBodyModuleGroupItem GroupItem { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleGroupItem : TeaModel {
                [NameInMap("agreement_price_codes")]
                [Validation(Required=false)]
                public List<string> AgreementPriceCodes { get; set; }

                [NameInMap("flight_rule_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoList> FlightRuleInfoList { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoList : TeaModel {
                    [NameInMap("flight_rule_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListFlightRuleInfo FlightRuleInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListFlightRuleInfo : TeaModel {
                        [NameInMap("baggage_desc")]
                        [Validation(Required=false)]
                        public string BaggageDesc { get; set; }

                        [NameInMap("refund_change_rule_desc")]
                        [Validation(Required=false)]
                        public string RefundChangeRuleDesc { get; set; }

                    }

                    [NameInMap("segment_position")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListSegmentPosition SegmentPosition { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListSegmentPosition : TeaModel {
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                }

                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("shopping_item_map")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleGroupItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                [NameInMap("sub_item_position_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleGroupItemSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                [NameInMap("sub_items")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItems> SubItems { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItems : TeaModel {
                    [NameInMap("baggage_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsBaggageRule BaggageRule { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsBaggageRule : TeaModel {
                        [NameInMap("baggage_digest")]
                        [Validation(Required=false)]
                        public string BaggageDigest { get; set; }

                        [NameInMap("baggage_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleGroupItemSubItemsBaggageRuleBaggageInfoMapValue>> BaggageInfoMap { get; set; }

                        [NameInMap("structured_baggage")]
                        [Validation(Required=false)]
                        public bool? StructuredBaggage { get; set; }

                    }

                    [NameInMap("refund_change_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsRefundChangeRule RefundChangeRule { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsRefundChangeRule : TeaModel {
                        [NameInMap("cancel_fee_ind")]
                        [Validation(Required=false)]
                        public bool? CancelFeeInd { get; set; }

                        [NameInMap("change_fee_ind")]
                        [Validation(Required=false)]
                        public bool? ChangeFeeInd { get; set; }

                        [NameInMap("offer_penalty_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleGroupItemSubItemsRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                        [NameInMap("refund_change_digest")]
                        [Validation(Required=false)]
                        public string RefundChangeDigest { get; set; }

                        [NameInMap("structured_refund")]
                        [Validation(Required=false)]
                        public bool? StructuredRefund { get; set; }

                    }

                    [NameInMap("segment_keys")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeys { get; set; }

                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleGroupItemSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                    [NameInMap("uniq_key")]
                    [Validation(Required=false)]
                    public string UniqKey { get; set; }

                }

            }

            [NameInMap("shutter_docs")]
            [Validation(Required=false)]
            public List<IntlFlightOtaItemDetailResponseBodyModuleShutterDocs> ShutterDocs { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleShutterDocs : TeaModel {
                [NameInMap("contents")]
                [Validation(Required=false)]
                public List<string> Contents { get; set; }

                [NameInMap("main_title")]
                [Validation(Required=false)]
                public string MainTitle { get; set; }

            }

            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

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
