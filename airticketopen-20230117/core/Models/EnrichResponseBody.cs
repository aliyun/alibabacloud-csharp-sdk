// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichResponseBody : TeaModel {
        /// <summary>
        /// <para>request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>correctly processed return data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EnrichResponseBodyData Data { get; set; }
        public class EnrichResponseBodyData : TeaModel {
            /// <summary>
            /// <para>search quotation results</para>
            /// </summary>
            [NameInMap("solution_list")]
            [Validation(Required=false)]
            public List<EnrichResponseBodyDataSolutionList> SolutionList { get; set; }
            public class EnrichResponseBodyDataSolutionList : TeaModel {
                /// <summary>
                /// <para>adult unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>adult tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>child unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>child tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>infant unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>infant tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                /// <summary>
                /// <para>journey</para>
                /// </summary>
                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<EnrichResponseBodyDataSolutionListJourneyList> JourneyList { get; set; }
                public class EnrichResponseBodyDataSolutionListJourneyList : TeaModel {
                    /// <summary>
                    /// <para>segment information</para>
                    /// </summary>
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<EnrichResponseBodyDataSolutionListJourneyListSegmentList> SegmentList { get; set; }
                    public class EnrichResponseBodyDataSolutionListJourneyListSegmentList : TeaModel {
                        /// <summary>
                        /// <para>Three-letter code of the arrival airport (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_airport")]
                        [Validation(Required=false)]
                        public string ArrivalAirport { get; set; }

                        /// <summary>
                        /// <para>Three-letter code of the arrival city (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_city")]
                        [Validation(Required=false)]
                        public string ArrivalCity { get; set; }

                        /// <summary>
                        /// <para>Arrival terminal of the flight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("arrival_terminal")]
                        [Validation(Required=false)]
                        public string ArrivalTerminal { get; set; }

                        /// <summary>
                        /// <para>Arrival date and time in string format (yyyy-MM-dd HH:mm:ss)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 10:40:00</para>
                        /// </summary>
                        [NameInMap("arrival_time")]
                        [Validation(Required=false)]
                        public string ArrivalTime { get; set; }

                        /// <summary>
                        /// <para>Number of remaining seats. The value range is 1,2,3,4,5,6,7,8,9,A; A indicates more than 9 seats available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// <para>Cabin class</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>Cabin grade</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Whether it is a code-share flight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <para>Three-letter code of the departure airport (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("departure_airport")]
                        [Validation(Required=false)]
                        public string DepartureAirport { get; set; }

                        /// <summary>
                        /// <para>Three-letter code of the departure city (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("departure_city")]
                        [Validation(Required=false)]
                        public string DepartureCity { get; set; }

                        /// <summary>
                        /// <para>Departure terminal of the flight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("departure_terminal")]
                        [Validation(Required=false)]
                        public string DepartureTerminal { get; set; }

                        /// <summary>
                        /// <para>Departure date and time in string format (yyyy-MM-dd HH:mm:ss)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 07:55:00</para>
                        /// </summary>
                        [NameInMap("departure_time")]
                        [Validation(Required=false)]
                        public string DepartureTime { get; set; }

                        /// <summary>
                        /// <para>Aircraft type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32Q</para>
                        /// </summary>
                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        /// <summary>
                        /// <para>Flight duration in minutes</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        /// <summary>
                        /// <para>Marketing airline (e.g., KA)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("marketing_airline")]
                        [Validation(Required=false)]
                        public string MarketingAirline { get; set; }

                        /// <summary>
                        /// <para>Marketing flight number (e.g., KA5809)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no")]
                        [Validation(Required=false)]
                        public string MarketingFlightNo { get; set; }

                        /// <summary>
                        /// <para>Marketing flight number in digits (e.g., 5809)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no_int")]
                        [Validation(Required=false)]
                        public int? MarketingFlightNoInt { get; set; }

                        /// <summary>
                        /// <para>Operating airline (e.g., CX)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("operating_airline")]
                        [Validation(Required=false)]
                        public string OperatingAirline { get; set; }

                        /// <summary>
                        /// <para>Operating flight number (e.g., CX601)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <para>segment ID format: flight number + departure airport + arrival airport + departure date (MMdd)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295-PVG-MFM-20230310</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>List of stopover cities, with values when stopQuantity &gt; 0, separated by commas</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;&quot;</para>
                        /// </summary>
                        [NameInMap("stop_city_list")]
                        [Validation(Required=false)]
                        public string StopCityList { get; set; }

                        /// <summary>
                        /// <para>Number of stopover cities</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                    /// <summary>
                    /// <para>number of transfers</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_count")]
                    [Validation(Required=false)]
                    public int? TransferCount { get; set; }

                }

                /// <summary>
                /// <para>Baggage check-in rules</para>
                /// </summary>
                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<EnrichResponseBodyDataSolutionListSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class EnrichResponseBodyDataSolutionListSegmentBaggageCheckInInfoList : TeaModel {
                    /// <summary>
                    /// <para>Baggage check-in rule type 1: Direct baggage between segments; 2: Re-check baggage between segments; 3: Direct baggage at stopover cities; 4: Re-check baggage at stopover cities</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    /// <summary>
                    /// <para>List of segment IDs that use the same baggage check-in rule</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>Free baggage rules</para>
                /// </summary>
                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<EnrichResponseBodyDataSolutionListSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class EnrichResponseBodyDataSolutionListSegmentBaggageMappingList : TeaModel {
                    /// <summary>
                    /// <para>Mapping of passenger type to free baggage allowance</para>
                    /// </summary>
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionListSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    /// <summary>
                    /// <para>List of segment IDs that use the same free baggage allowance rule</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>Refund and change rules</para>
                /// </summary>
                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<EnrichResponseBodyDataSolutionListSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class EnrichResponseBodyDataSolutionListSegmentRefundChangeRuleMappingList : TeaModel {
                    /// <summary>
                    /// <para>Passenger type - refund and change rule mapping</para>
                    /// </summary>
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    /// <summary>
                    /// <para>Segment ID list. These segment IDs use the same refund and change rules.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>Quotation attributes</para>
                /// </summary>
                [NameInMap("solution_attribute")]
                [Validation(Required=false)]
                public EnrichResponseBodyDataSolutionListSolutionAttribute SolutionAttribute { get; set; }
                public class EnrichResponseBodyDataSolutionListSolutionAttribute : TeaModel {
                    /// <summary>
                    /// <para>Issue ticket time related</para>
                    /// </summary>
                    [NameInMap("issue_time_info")]
                    [Validation(Required=false)]
                    public EnrichResponseBodyDataSolutionListSolutionAttributeIssueTimeInfo IssueTimeInfo { get; set; }
                    public class EnrichResponseBodyDataSolutionListSolutionAttributeIssueTimeInfo : TeaModel {
                        /// <summary>
                        /// <para>Issue ticket type:  1: after payment; 2: before departure; -1: unknown</para>
                        /// </summary>
                        [NameInMap("issue_ticket_type")]
                        [Validation(Required=false)]
                        public int? IssueTicketType { get; set; }

                        /// <summary>
                        /// <para>Estimated issue ticket time, unit: minutes</para>
                        /// </summary>
                        [NameInMap("issue_time_limit")]
                        [Validation(Required=false)]
                        public int? IssueTimeLimit { get; set; }

                    }

                    /// <summary>
                    /// <para>Supply source type 1: Self-operated; 2: Agent; 3: Flagship store</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
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
        /// <para>business error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Data carried in error handling</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http request successful, status value is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
