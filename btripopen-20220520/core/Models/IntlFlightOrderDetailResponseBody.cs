// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOrderDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOrderDetailResponseBodyModule : TeaModel {
            [NameInMap("booker_user_id")]
            [Validation(Required=false)]
            public string BookerUserId { get; set; }

            [NameInMap("booker_user_name")]
            [Validation(Required=false)]
            public string BookerUserName { get; set; }

            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709708165000</para>
            /// </summary>
            [NameInMap("close_time")]
            [Validation(Required=false)]
            public string CloseTime { get; set; }

            [NameInMap("contact_info")]
            [Validation(Required=false)]
            public IntlFlightOrderDetailResponseBodyModuleContactInfo ContactInfo { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleContactInfo : TeaModel {
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

            }

            [NameInMap("journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleJourneyList> JourneyList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleJourneyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
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
                public List<IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfos : TeaModel {
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                    public List<IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
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

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1012000000000000</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("order_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleOrderItemList> OrderItemList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleOrderItemList : TeaModel {
                [NameInMap("baggage_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule BaggageRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule : TeaModel {
                    [NameInMap("baggage_digest")]
                    [Validation(Required=false)]
                    public string BaggageDigest { get; set; }

                    [NameInMap("offer_baggage_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListBaggageRuleOfferBaggageInfoMapValue>> OfferBaggageInfoMap { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("structured_baggage")]
                    [Validation(Required=false)]
                    public bool? StructuredBaggage { get; set; }

                }

                [NameInMap("passenger_price_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList> PassengerPriceList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>21300</para>
                    /// </summary>
                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public int? SellPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>19300</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public int? Tax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                }

                [NameInMap("refund_change_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule RefundChangeRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cancel_fee_ind")]
                    [Validation(Required=false)]
                    public bool? CancelFeeInd { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("change_fee_ind")]
                    [Validation(Required=false)]
                    public bool? ChangeFeeInd { get; set; }

                    [NameInMap("change_rule_desc")]
                    [Validation(Required=false)]
                    public string ChangeRuleDesc { get; set; }

                    [NameInMap("offer_penalty_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                    [NameInMap("refund_change_digest")]
                    [Validation(Required=false)]
                    public string RefundChangeDigest { get; set; }

                    [NameInMap("refund_rule_desc")]
                    [Validation(Required=false)]
                    public string RefundRuleDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("structured_refund")]
                    [Validation(Required=false)]
                    public bool? StructuredRefund { get; set; }

                }

                [NameInMap("segment_key_list")]
                [Validation(Required=false)]
                public List<string> SegmentKeyList { get; set; }

            }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F11374007131319304192</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001101</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12292812036903456</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("passenger_ticket_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketList> PassengerTicketList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerTicketList : TeaModel {
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketList> TicketList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketList : TeaModel {
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    [NameInMap("price_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListPriceInfo PriceInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListPriceInfo : TeaModel {
                        [NameInMap("sell_price")]
                        [Validation(Required=false)]
                        public int? SellPrice { get; set; }

                        [NameInMap("tax")]
                        [Validation(Required=false)]
                        public int? Tax { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public int? TicketPrice { get; set; }

                    }

                    [NameInMap("segment_key_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeyList { get; set; }

                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    [NameInMap("ticket_segment_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList : TeaModel {
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

                    }

                }

            }

            [NameInMap("pay_latest_time")]
            [Validation(Required=false)]
            public string PayLatestTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 15:00:35</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            [NameInMap("success_time")]
            [Validation(Required=false)]
            public string SuccessTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21300</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            [NameInMap("total_tax_price")]
            [Validation(Required=false)]
            public long? TotalTaxPrice { get; set; }

            [NameInMap("total_ticket_price")]
            [Validation(Required=false)]
            public long? TotalTicketPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
