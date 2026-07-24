// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class StandardSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Data returned on successful processing</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public StandardSearchResponseBodyData Data { get; set; }
        public class StandardSearchResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Search and quote results</para>
            /// </summary>
            [NameInMap("solution_list")]
            [Validation(Required=false)]
            public List<StandardSearchResponseBodyDataSolutionList> SolutionList { get; set; }
            public class StandardSearchResponseBodyDataSolutionList : TeaModel {
                /// <summary>
                /// <para>Adult unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>Adult tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>Child unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>Child tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>Infant unit price</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>Infant tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                /// <summary>
                /// <para>Journey</para>
                /// </summary>
                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<StandardSearchResponseBodyDataSolutionListJourneyList> JourneyList { get; set; }
                public class StandardSearchResponseBodyDataSolutionListJourneyList : TeaModel {
                    /// <summary>
                    /// <para>Segment information</para>
                    /// </summary>
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<StandardSearchResponseBodyDataSolutionListJourneyListSegmentList> SegmentList { get; set; }
                    public class StandardSearchResponseBodyDataSolutionListJourneyListSegmentList : TeaModel {
                        /// <summary>
                        /// <para>Flight arrival airport three-letter code (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_airport")]
                        [Validation(Required=false)]
                        public string ArrivalAirport { get; set; }

                        /// <summary>
                        /// <para>Flight arrival city three-letter code (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_city")]
                        [Validation(Required=false)]
                        public string ArrivalCity { get; set; }

                        /// <summary>
                        /// <para>Flight arrival terminal</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("arrival_terminal")]
                        [Validation(Required=false)]
                        public string ArrivalTerminal { get; set; }

                        /// <summary>
                        /// <para>Flight arrival date and time, string format (yyyy-MM-dd HH:mm:ss)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 10:40:00</para>
                        /// </summary>
                        [NameInMap("arrival_time")]
                        [Validation(Required=false)]
                        public string ArrivalTime { get; set; }

                        /// <summary>
                        /// <para>Remaining seat count. Value range: 1,2,3,4,5,6,7,8,9,A; A indicates more than 9 seats available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// <para>Cabin</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>Cabin class</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Whether it is a codeshare flight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <para>Flight departure airport three-letter code (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("departure_airport")]
                        [Validation(Required=false)]
                        public string DepartureAirport { get; set; }

                        /// <summary>
                        /// <para>Flight departure city three-letter code (uppercase)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("departure_city")]
                        [Validation(Required=false)]
                        public string DepartureCity { get; set; }

                        /// <summary>
                        /// <para>Flight departure terminal</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("departure_terminal")]
                        [Validation(Required=false)]
                        public string DepartureTerminal { get; set; }

                        /// <summary>
                        /// <para>Flight departure date and time, string format (yyyy-MM-dd HH:mm:ss)</para>
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
                        /// <para>Flight duration, unit: minutes</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        /// <summary>
                        /// <para>Marketing airline (e.g.: HO)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("marketing_airline")]
                        [Validation(Required=false)]
                        public string MarketingAirline { get; set; }

                        /// <summary>
                        /// <para>Marketing flight number (e.g.: HO1295)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no")]
                        [Validation(Required=false)]
                        public string MarketingFlightNo { get; set; }

                        /// <summary>
                        /// <para>Marketing flight number in integer format (e.g.: 1295)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no_int")]
                        [Validation(Required=false)]
                        public int? MarketingFlightNoInt { get; set; }

                        /// <summary>
                        /// <para>Operating airline (e.g.: CX)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("operating_airline")]
                        [Validation(Required=false)]
                        public string OperatingAirline { get; set; }

                        /// <summary>
                        /// <para>Operating flight number (e.g.: CX601)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <para>Segment ID, format: flight number + departure airport + arrival airport + departure date (MMdd)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295-PVG-MFM-20230310</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>Stopover city list, has values when stopQuantity &gt; 0, multiple values separated by commas</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SEL,HKG</para>
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
                    /// <para>Number of transfers</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_count")]
                    [Validation(Required=false)]
                    public int? TransferCount { get; set; }

                }

                /// <summary>
                /// <para>Baggage through-check rules</para>
                /// </summary>
                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<StandardSearchResponseBodyDataSolutionListSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class StandardSearchResponseBodyDataSolutionListSegmentBaggageCheckInInfoList : TeaModel {
                    /// <summary>
                    /// <para>Baggage through-check rule type. 1: Baggage direct transfer between segments; 2: Baggage re-check between segments; 3: Baggage direct transfer at stopover city; 4: Baggage re-check at stopover city</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    /// <summary>
                    /// <para>Segment ID list. These segment IDs share the same baggage through-check rule</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>Free baggage allowance rules</para>
                /// </summary>
                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<StandardSearchResponseBodyDataSolutionListSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class StandardSearchResponseBodyDataSolutionListSegmentBaggageMappingList : TeaModel {
                    /// <summary>
                    /// <para>Passenger type to free baggage allowance mapping. Key values: ADT: Adult; CHD: Child; INF: Infant</para>
                    /// </summary>
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionListSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    /// <summary>
                    /// <para>Segment ID list. These segment IDs share the same free baggage allowance rule</para>
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
                public List<StandardSearchResponseBodyDataSolutionListSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class StandardSearchResponseBodyDataSolutionListSegmentRefundChangeRuleMappingList : TeaModel {
                    /// <summary>
                    /// <para>Passenger type to refund and change rule mapping. Key values: ADT: Adult; CHD: Child; INF: Infant</para>
                    /// </summary>
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    /// <summary>
                    /// <para>Segment ID list. These segment IDs share the same refund and change rule</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>Quote attributes</para>
                /// </summary>
                [NameInMap("solution_attribute")]
                [Validation(Required=false)]
                public StandardSearchResponseBodyDataSolutionListSolutionAttribute SolutionAttribute { get; set; }
                public class StandardSearchResponseBodyDataSolutionListSolutionAttribute : TeaModel {
                    /// <summary>
                    /// <para>Ticketing time information</para>
                    /// </summary>
                    [NameInMap("issue_time_info")]
                    [Validation(Required=false)]
                    public StandardSearchResponseBodyDataSolutionListSolutionAttributeIssueTimeInfo IssueTimeInfo { get; set; }
                    public class StandardSearchResponseBodyDataSolutionListSolutionAttributeIssueTimeInfo : TeaModel {
                        /// <summary>
                        /// <para>Ticketing type. 1: After payment; 2: Before departure; -1: Unknown</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("issue_ticket_type")]
                        [Validation(Required=false)]
                        public int? IssueTicketType { get; set; }

                        /// <summary>
                        /// <para>Estimated ticketing duration, unit: minutes</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("issue_time_limit")]
                        [Validation(Required=false)]
                        public int? IssueTimeLimit { get; set; }

                    }

                    /// <summary>
                    /// <para>Supply source type. 1: Self-operated; 2: Agent; 3: Flagship store</para>
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
                /// <para>eJwz8DeySEo0NjQ01TU3TUxxx</para>
                /// </summary>
                [NameInMap("solution_id")]
                [Validation(Required=false)]
                public string SolutionId { get; set; }

            }

        }

        /// <summary>
        /// <para>Business error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Data carried with error handling</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>When HTTP request is successful, status value is always 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Whether the request is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
