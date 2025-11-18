// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Correctly processed return data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeDetailResponseBodyData Data { get; set; }
        public class ChangeDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Change fee details, per passenger</para>
            /// </summary>
            [NameInMap("change_fee_details")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangeFeeDetails> ChangeFeeDetails { get; set; }
            public class ChangeDetailResponseBodyDataChangeFeeDetails : TeaModel {
                /// <summary>
                /// <para>Change fee details for the passenger</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee ChangeFee { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee : TeaModel {
                    /// <summary>
                    /// <para>fare penalty</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("service_fee")]
                    [Validation(Required=false)]
                    public double? ServiceFee { get; set; }

                    /// <summary>
                    /// <para>tax penalty</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("tax_fee")]
                    [Validation(Required=false)]
                    public double? TaxFee { get; set; }

                    /// <summary>
                    /// <para>price difference</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public double? UpgradeFee { get; set; }

                }

                /// <summary>
                /// <para>Information of the passenger for the change</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsPassenger Passenger { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsPassenger : TeaModel {
                    /// <summary>
                    /// <para>Document number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>411***********4411</para>
                    /// </summary>
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    /// <summary>
                    /// <para>Passenger\&quot;s first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>Passenger\&quot;s last name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

            }

            /// <summary>
            /// <para>Change order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>4988430***950</para>
            /// </summary>
            [NameInMap("change_order_num")]
            [Validation(Required=false)]
            public long? ChangeOrderNum { get; set; }

            /// <summary>
            /// <para>List of passengers for the change</para>
            /// </summary>
            [NameInMap("change_passengers")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangePassengers> ChangePassengers { get; set; }
            public class ChangeDetailResponseBodyDataChangePassengers : TeaModel {
                /// <summary>
                /// <para>Document number</para>
                /// 
                /// <b>Example:</b>
                /// <para>411***********4411</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                /// <summary>
                /// <para>Passenger first name</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAN</para>
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                /// <summary>
                /// <para>Passenger last name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

            }

            /// <summary>
            /// <para>Change reason type. 
            /// 0: Voluntary change; 
            /// 1: Involuntary change, due to flight delay or cancellation, schedule changes, or other airline reasons; 
            /// 2: Involuntary change, due to health reasons with a medical report</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("change_reason_type")]
            [Validation(Required=false)]
            public int? ChangeReasonType { get; set; }

            /// <summary>
            /// <para>New journeys</para>
            /// </summary>
            [NameInMap("changed_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangedJourneys> ChangedJourneys { get; set; }
            public class ChangeDetailResponseBodyDataChangedJourneys : TeaModel {
                /// <summary>
                /// <para>Segment information</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataChangedJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataChangedJourneysSegmentList : TeaModel {
                    /// <summary>
                    /// <para>Arrival airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    /// <summary>
                    /// <para>Arrival city three-letter code (uppercase)</para>
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
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    /// <summary>
                    /// <para>Flight arrival date and time, in the format (yyyy-MM-dd HH:mm:ss)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-10 10:40:00</para>
                    /// </summary>
                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    /// <summary>
                    /// <para>Number of available seats</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    /// <summary>
                    /// <para>RBD</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>service class ( compartment )</para>
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
                    /// <para>Departure airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    /// <summary>
                    /// <para>Departure city three-letter code (uppercase)</para>
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
                    /// <para>Flight departure date and time, in the format (yyyy-MM-dd HH:mm:ss)</para>
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
                    /// <para>Market airline (e.g., HO)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>Marketing flight number (e.g., HO1295)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>Marketing flight number (e.g., 1295)</para>
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
                    /// <para>Segment ID format: flight number + departure airport + arrival airport + departure date (MMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>List of stop cities, with values when stopQuantity &gt; 0, separated by commas</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
                    /// </summary>
                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    /// <summary>
                    /// <para>Number of stop cities</para>
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
            /// <para>Reason for closing the change order</para>
            /// 
            /// <b>Example:</b>
            /// <para>reason desc</para>
            /// </summary>
            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <para>The time when the order was closed, in UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415244000</para>
            /// </summary>
            [NameInMap("close_utc_time")]
            [Validation(Required=false)]
            public long? CloseUtcTime { get; set; }

            /// <summary>
            /// <para>Contact information for the change request</para>
            /// </summary>
            [NameInMap("contact")]
            [Validation(Required=false)]
            public ChangeDetailResponseBodyDataContact Contact { get; set; }
            public class ChangeDetailResponseBodyDataContact : TeaModel {
                /// <summary>
                /// <para>Email address</para>
                /// 
                /// <b>Example:</b>
                /// <para>gao******@gmail.com</para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>Country code</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>Contact\&quot;s mobile phone number</para>
                /// 
                /// <b>Example:</b>
                /// <para>183*****92</para>
                /// </summary>
                [NameInMap("mobile_phone_num")]
                [Validation(Required=false)]
                public string MobilePhoneNum { get; set; }

            }

            /// <summary>
            /// <para>Creation time of the change order, UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415276000</para>
            /// </summary>
            [NameInMap("create_utc_time")]
            [Validation(Required=false)]
            public long? CreateUtcTime { get; set; }

            /// <summary>
            /// <para>Latest payment time for the buyer, UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415278000</para>
            /// </summary>
            [NameInMap("last_confirm_utc_time")]
            [Validation(Required=false)]
            public long? LastConfirmUtcTime { get; set; }

            /// <summary>
            /// <para>The itinerary of the last change</para>
            /// </summary>
            [NameInMap("last_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataLastJourneys> LastJourneys { get; set; }
            public class ChangeDetailResponseBodyDataLastJourneys : TeaModel {
                /// <summary>
                /// <para>Segment information</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataLastJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataLastJourneysSegmentList : TeaModel {
                    /// <summary>
                    /// <para>Arrival airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    /// <summary>
                    /// <para>Arrival city three-letter code (uppercase)</para>
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
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    /// <summary>
                    /// <para>Flight arrival date and time, in the format (yyyy-MM-dd HH:mm:ss)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-10 10:40:00</para>
                    /// </summary>
                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    /// <summary>
                    /// <para>Number of available seats</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    /// <summary>
                    /// <para>RBD</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>service class ( compartment )</para>
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
                    /// <para>Departure airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    /// <summary>
                    /// <para>Departure city three-letter code (uppercase)</para>
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
                    /// <para>Flight departure date and time, in the format (yyyy-MM-dd HH:mm:ss)</para>
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
                    /// <para>Marketing airline (e.g., HO)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>Marketing flight number (e.g., HO1295)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>Marketing flight number (e.g., 1295)</para>
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
                    /// <para>Segment ID format: flight number + departure airport + arrival airport + departure date (MMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>List of stop cities, with values when stopQuantity &gt; 0, separated by commas</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
                    /// </summary>
                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    /// <summary>
                    /// <para>Number of stop cities</para>
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
            /// <para>Ticketing Order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>5988430***541</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>Change order status 0: Initial state; 1: Pending payment; 2: Payment successful; 3: Change successful; 4: Change closed</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>Original journeys</para>
            /// </summary>
            [NameInMap("original_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataOriginalJourneys> OriginalJourneys { get; set; }
            public class ChangeDetailResponseBodyDataOriginalJourneys : TeaModel {
                /// <summary>
                /// <para>Segment information</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataOriginalJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataOriginalJourneysSegmentList : TeaModel {
                    /// <summary>
                    /// <para>Arrival airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    /// <summary>
                    /// <para>Arrival city three-letter code (uppercase)</para>
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
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    /// <summary>
                    /// <para>Flight arrival date and time in string format (yyyy-MM-dd HH:mm:ss)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-10 10:40:00</para>
                    /// </summary>
                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    /// <summary>
                    /// <para>Number of available seats</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    /// <summary>
                    /// <para>RBD</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>service class ( compartment )</para>
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
                    /// <para>Departure airport three-letter code (uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    /// <summary>
                    /// <para>Departure city three-letter code (uppercase)</para>
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
                    /// <para>Flight departure date and time in string format (yyyy-MM-dd HH:mm:ss)</para>
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
                    /// <para>Marketing airline (e.g., HO)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>Marketing flight number (e.g., HO1295)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>Marketing airline\&quot;s numeric flight number (e.g., 1295)</para>
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
                    /// <para>Operating airline\&quot;s flight number (e.g., CX601)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>Segment ID format: flight number + departure airport + arrival airport + departure date (yyyyMMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>List of stop cities, with values when stopQuantity &gt; 0, separated by commas</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
                    /// </summary>
                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    /// <summary>
                    /// <para>Number of stop cities</para>
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
            /// <para>Payment status 0: initial state; 1: pending payment; 2: payment successful; 4: successfully closed paid order; 5: successfully closed unpaid order</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The time when the buyer successfully paid, in UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415255000</para>
            /// </summary>
            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            /// <summary>
            /// <para>Total payment amount for the change order</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public double? TotalAmount { get; set; }

            /// <summary>
            /// <para>Transaction serial number</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        /// <summary>
        /// <para>error code</para>
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
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>HTTP request successful, status value is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Whether it is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
