// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderDetailResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOrderDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOrderDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>122928120369012</para>
            /// </summary>
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZHANG/SAN</para>
            /// </summary>
            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709708165000</para>
            /// </summary>
            [NameInMap("close_time")]
            [Validation(Required=false)]
            public long? CloseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 14:56:05</para>
            /// </summary>
            [NameInMap("close_time_str")]
            [Validation(Required=false)]
            public string CloseTimeStr { get; set; }

            [NameInMap("contact_info")]
            [Validation(Required=false)]
            public IntlFlightOrderDetailResponseBodyModuleContactInfo ContactInfo { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleContactInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:test@cainiao.com">test@cainiao.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>185006022345</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709708165000</para>
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 14:56:05</para>
            /// </summary>
            [NameInMap("create_time_str")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            [NameInMap("ext_info_map")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfoMap { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-06</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentList> SegmentList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_airport_code")]
                    [Validation(Required=false)]
                    public string ArrAirportCode { get; set; }

                    [NameInMap("arr_airport_name")]
                    [Validation(Required=false)]
                    public string ArrAirportName { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-07-06 14:05:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("dep_airport_code")]
                    [Validation(Required=false)]
                    public string DepAirportCode { get; set; }

                    [NameInMap("dep_airport_name")]
                    [Validation(Required=false)]
                    public string DepAirportName { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-07-06 11:10:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_other_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListFlightOtherInfo FlightOtherInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListFlightOtherInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("aircraft_age")]
                        [Validation(Required=false)]
                        public string AircraftAge { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("avg_delay_time")]
                        [Validation(Required=false)]
                        public string AvgDelayTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>32Q</para>
                        /// </summary>
                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("flight_cancel_rate")]
                        [Validation(Required=false)]
                        public string FlightCancelRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>195</para>
                        /// </summary>
                        [NameInMap("flight_distance")]
                        [Validation(Required=false)]
                        public int? FlightDistance { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        [NameInMap("flight_size")]
                        [Validation(Required=false)]
                        public string FlightSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>70</para>
                        /// </summary>
                        [NameInMap("jet_bridge_rate")]
                        [Validation(Required=false)]
                        public string JetBridgeRate { get; set; }

                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("meal")]
                        [Validation(Required=false)]
                        public int? Meal { get; set; }

                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("wifi")]
                        [Validation(Required=false)]
                        public bool? Wifi { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    [NameInMap("marketing_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListMarketingAirlineInfo MarketingAirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListMarketingAirlineInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("alliance_name")]
                        [Validation(Required=false)]
                        public string AllianceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png">https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png">https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("logo_url")]
                        [Validation(Required=false)]
                        public string LogoUrl { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU507</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListOperatingAirlineInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("alliance_name")]
                        [Validation(Required=false)]
                        public string AllianceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png">https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png">https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("logo_url")]
                        [Validation(Required=false)]
                        public string LogoUrl { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU507</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU507PVGHKG0706</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListSegmentVisaRemark : TeaModel {
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
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

                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListStopCityList> StopCityList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListStopCityList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_arr_terminal")]
                        [Validation(Required=false)]
                        public string StopArrTerminal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-07-06 11:10:00</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_dep_terminal")]
                        [Validation(Required=false)]
                        public string StopDepTerminal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-07-06 11:10:00</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

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
            public long? OrderId { get; set; }

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

                    [NameInMap("baggage_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListBaggageRuleBaggageInfoMapValue>> BaggageInfoMap { get; set; }

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
                    /// <para>3.5</para>
                    /// </summary>
                    [NameInMap("discount")]
                    [Validation(Required=false)]
                    public double? Discount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3.5折</para>
                    /// </summary>
                    [NameInMap("discount_info")]
                    [Validation(Required=false)]
                    public string DiscountInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("modify_fee")]
                    [Validation(Required=false)]
                    public long? ModifyFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("modify_tax_spread")]
                    [Validation(Required=false)]
                    public long? ModifyTaxSpread { get; set; }

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
                    public long? SellPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>19300</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public long? Tax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public long? UpgradeFee { get; set; }

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

                    [NameInMap("offer_penalty_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                    [NameInMap("refund_change_digest")]
                    [Validation(Required=false)]
                    public string RefundChangeDigest { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>F11374007131319304192</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_item_detail_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailList> PassengerItemDetailList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketList> TicketList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-03-05 00:00:00</para>
                    /// </summary>
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    [NameInMap("price_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListPriceInfo PriceInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListPriceInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("modify_fee")]
                        [Validation(Required=false)]
                        public long? ModifyFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("modify_tax_spread")]
                        [Validation(Required=false)]
                        public long? ModifyTaxSpread { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>26900</para>
                        /// </summary>
                        [NameInMap("sell_price")]
                        [Validation(Required=false)]
                        public long? SellPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>24900</para>
                        /// </summary>
                        [NameInMap("tax")]
                        [Validation(Required=false)]
                        public long? Tax { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2000</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("upgrade_fee")]
                        [Validation(Required=false)]
                        public long? UpgradeFee { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>000-1709625883</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    [NameInMap("ticket_segment_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListTicketSegmentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>K</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>OPEN FOR USE</para>
                        /// </summary>
                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU507PVGHKG0706</para>
                        /// </summary>
                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

                    }

                }

            }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1996-09-13</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("cascade_dept_mask")]
                [Validation(Required=false)]
                public string CascadeDeptMask { get; set; }

                [NameInMap("cascade_dept_name")]
                [Validation(Required=false)]
                public string CascadeDeptName { get; set; }

                [NameInMap("cert_info")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModulePassengerListCertInfo CertInfo { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerListCertInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("cert_nation")]
                    [Validation(Required=false)]
                    public string CertNation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>H123456</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-09-09</para>
                    /// </summary>
                    [NameInMap("cert_valid_date")]
                    [Validation(Required=false)]
                    public string CertValidDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZHANG/SAN</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1009909</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("dept_id")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                [NameInMap("dept_name")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001101</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

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
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>185006021321</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testcode</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("subsidiary_cert_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerListSubsidiaryCertInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("cert_nation")]
                    [Validation(Required=false)]
                    public string CertNation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>H123456</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-09-09</para>
                    /// </summary>
                    [NameInMap("cert_valid_date")]
                    [Validation(Required=false)]
                    public string CertValidDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZHANG/SAN</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709711779000</para>
            /// </summary>
            [NameInMap("pay_expire_time")]
            [Validation(Required=false)]
            public long? PayExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 15:56:19</para>
            /// </summary>
            [NameInMap("pay_expire_time_str")]
            [Validation(Required=false)]
            public string PayExpireTimeStr { get; set; }

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
            public long? PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709708435000</para>
            /// </summary>
            [NameInMap("pay_time_str")]
            [Validation(Required=false)]
            public string PayTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1709711779000</para>
            /// </summary>
            [NameInMap("succeed_time")]
            [Validation(Required=false)]
            public long? SucceedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 15:56:19</para>
            /// </summary>
            [NameInMap("succeed_time_str")]
            [Validation(Required=false)]
            public string SucceedTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21300</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A3F8DCAB-8301-5770-BD9F-71B0BF9E1A6E</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("trace_id")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
