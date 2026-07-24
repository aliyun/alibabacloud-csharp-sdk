// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class PricingResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public PricingResponseBodyData Data { get; set; }
        public class PricingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The price information after the price change.</para>
            /// </summary>
            [NameInMap("changed_price_info")]
            [Validation(Required=false)]
            public PricingResponseBodyDataChangedPriceInfo ChangedPriceInfo { get; set; }
            public class PricingResponseBodyDataChangedPriceInfo : TeaModel {
                /// <summary>
                /// <para>The unit price per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>The tax per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>The unit price per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>The tax per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>The unit price per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>The tax per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the price has changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_changed")]
            [Validation(Required=false)]
            public bool? IsChanged { get; set; }

            /// <summary>
            /// <para>The price information before the price change. This field has a value only when isChanged is true.</para>
            /// </summary>
            [NameInMap("original_price_info")]
            [Validation(Required=false)]
            public PricingResponseBodyDataOriginalPriceInfo OriginalPriceInfo { get; set; }
            public class PricingResponseBodyDataOriginalPriceInfo : TeaModel {
                /// <summary>
                /// <para>The unit price per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>The tax per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>The unit price per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>The tax per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>The unit price per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>The tax per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

            }

            /// <summary>
            /// <para>The number of remaining seats. A indicates more than 9. Values 0 through 9 represent the exact number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("remain_seats")]
            [Validation(Required=false)]
            public string RemainSeats { get; set; }

            /// <summary>
            /// <para>solution</para>
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public PricingResponseBodyDataSolution Solution { get; set; }
            public class PricingResponseBodyDataSolution : TeaModel {
                /// <summary>
                /// <para>The unit price per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>The tax per adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>The unit price per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>The tax per child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>The unit price per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>The tax per infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                /// <summary>
                /// <para>The journey list.</para>
                /// </summary>
                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionJourneyList> JourneyList { get; set; }
                public class PricingResponseBodyDataSolutionJourneyList : TeaModel {
                    /// <summary>
                    /// <para>The segment information.</para>
                    /// </summary>
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<PricingResponseBodyDataSolutionJourneyListSegmentList> SegmentList { get; set; }
                    public class PricingResponseBodyDataSolutionJourneyListSegmentList : TeaModel {
                        /// <summary>
                        /// <para>The three-letter IATA code of the arrival airport (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_airport")]
                        [Validation(Required=false)]
                        public string ArrivalAirport { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the arrival city (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_city")]
                        [Validation(Required=false)]
                        public string ArrivalCity { get; set; }

                        /// <summary>
                        /// <para>The arrival terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("arrival_terminal")]
                        [Validation(Required=false)]
                        public string ArrivalTerminal { get; set; }

                        /// <summary>
                        /// <para>The arrival date and time in string format (yyyy-MM-dd HH:mm:ss).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 10:40:00</para>
                        /// </summary>
                        [NameInMap("arrival_time")]
                        [Validation(Required=false)]
                        public string ArrivalTime { get; set; }

                        /// <summary>
                        /// <para>The number of remaining seats.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

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
                        /// <para>ALL_CABIN</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the flight is a codeshare flight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the departure airport (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("departure_airport")]
                        [Validation(Required=false)]
                        public string DepartureAirport { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the departure city (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("departure_city")]
                        [Validation(Required=false)]
                        public string DepartureCity { get; set; }

                        /// <summary>
                        /// <para>The departure terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("departure_terminal")]
                        [Validation(Required=false)]
                        public string DepartureTerminal { get; set; }

                        /// <summary>
                        /// <para>The departure date and time in string format (yyyy-MM-dd HH:mm:ss).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 07:55:00</para>
                        /// </summary>
                        [NameInMap("departure_time")]
                        [Validation(Required=false)]
                        public string DepartureTime { get; set; }

                        /// <summary>
                        /// <para>The aircraft type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32Q</para>
                        /// </summary>
                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        /// <summary>
                        /// <para>The flight duration in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        /// <summary>
                        /// <para>The marketing airline code (for example, KA).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("marketing_airline")]
                        [Validation(Required=false)]
                        public string MarketingAirline { get; set; }

                        /// <summary>
                        /// <para>The marketing flight number (for example, KA5809).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no")]
                        [Validation(Required=false)]
                        public string MarketingFlightNo { get; set; }

                        /// <summary>
                        /// <para>The numeric marketing flight number (for example, 5809).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no_int")]
                        [Validation(Required=false)]
                        public int? MarketingFlightNoInt { get; set; }

                        /// <summary>
                        /// <para>The operating airline code (for example, CX).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("operating_airline")]
                        [Validation(Required=false)]
                        public string OperatingAirline { get; set; }

                        /// <summary>
                        /// <para>The operating flight number (for example, CX601).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <para>The segment ID in the format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295-PVG-MFM-20230310</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>The list of stopover cities. This field has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;&quot;</para>
                        /// </summary>
                        [NameInMap("stop_city_list")]
                        [Validation(Required=false)]
                        public string StopCityList { get; set; }

                        /// <summary>
                        /// <para>The number of stopover cities.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of transfers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_count")]
                    [Validation(Required=false)]
                    public int? TransferCount { get; set; }

                }

                /// <summary>
                /// <para>The baggage through-check rules.</para>
                /// </summary>
                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentBaggageCheckInInfoList : TeaModel {
                    /// <summary>
                    /// <para>The baggage through-check rule type. Valid values: 1: baggage is checked through between segments. 2: baggage must be rechecked between segments. 3: baggage is checked through at stopover cities. 4: baggage must be rechecked at stopover cities.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs that share the same baggage through-check rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>The free baggage allowance rules.</para>
                /// </summary>
                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentBaggageMappingList : TeaModel {
                    /// <summary>
                    /// <para>The mapping between passenger types and free baggage allowances.</para>
                    /// </summary>
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs that share the same free baggage allowance rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>The refund and change rules.</para>
                /// </summary>
                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentRefundChangeRuleMappingList : TeaModel {
                    /// <summary>
                    /// <para>The mapping between passenger types and refund and change rules.</para>
                    /// </summary>
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs that share the same refund and change rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("solution_attribute")]
                [Validation(Required=false)]
                public PricingResponseBodyDataSolutionSolutionAttribute SolutionAttribute { get; set; }
                public class PricingResponseBodyDataSolutionSolutionAttribute : TeaModel {
                    [NameInMap("issue_time_info")]
                    [Validation(Required=false)]
                    public PricingResponseBodyDataSolutionSolutionAttributeIssueTimeInfo IssueTimeInfo { get; set; }
                    public class PricingResponseBodyDataSolutionSolutionAttributeIssueTimeInfo : TeaModel {
                        [NameInMap("issue_ticket_type")]
                        [Validation(Required=false)]
                        public int? IssueTicketType { get; set; }

                        [NameInMap("issue_time_limit")]
                        [Validation(Required=false)]
                        public int? IssueTimeLimit { get; set; }

                    }

                    [NameInMap("supply_source_type")]
                    [Validation(Required=false)]
                    public string SupplySourceType { get; set; }

                }

                /// <summary>
                /// <para>solution_id</para>
                /// 
                /// <b>Example:</b>
                /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
                /// </summary>
                [NameInMap("solution_id")]
                [Validation(Required=false)]
                public string SolutionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful HTTP requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
