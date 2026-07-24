// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailResponseBody : TeaModel {
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
        public ChangeDetailResponseBodyData Data { get; set; }
        public class ChangeDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The change fee details at the passenger level.</para>
            /// </summary>
            [NameInMap("change_fee_details")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangeFeeDetails> ChangeFeeDetails { get; set; }
            public class ChangeDetailResponseBodyDataChangeFeeDetails : TeaModel {
                /// <summary>
                /// <para>The change fee details for the passenger.</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee ChangeFee { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee : TeaModel {
                    /// <summary>
                    /// <para>The service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("service_fee")]
                    [Validation(Required=false)]
                    public double? ServiceFee { get; set; }

                    [NameInMap("suez_service_fee")]
                    [Validation(Required=false)]
                    public double? SuezServiceFee { get; set; }

                    /// <summary>
                    /// <para>The change tax fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("tax_fee")]
                    [Validation(Required=false)]
                    public double? TaxFee { get; set; }

                    /// <summary>
                    /// <para>The upgrade fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public double? UpgradeFee { get; set; }

                }

                /// <summary>
                /// <para>The passenger information for the change.</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsPassenger Passenger { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsPassenger : TeaModel {
                    /// <summary>
                    /// <para>The document number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>411***********4411</para>
                    /// </summary>
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    /// <summary>
                    /// <para>The first name of the passenger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>The last name of the passenger.</para>
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
            /// <para>The change order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4988430***950</para>
            /// </summary>
            [NameInMap("change_order_num")]
            [Validation(Required=false)]
            public long? ChangeOrderNum { get; set; }

            /// <summary>
            /// <para>The list of passengers for the flight change.</para>
            /// </summary>
            [NameInMap("change_passengers")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangePassengers> ChangePassengers { get; set; }
            public class ChangeDetailResponseBodyDataChangePassengers : TeaModel {
                /// <summary>
                /// <para>The document number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>411***********4411</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                /// <summary>
                /// <para>The first name of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAN</para>
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                /// <summary>
                /// <para>The last name of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

            }

            /// <summary>
            /// <para>The type of the change reason. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: voluntary date change</description></item>
            /// <item><description>1: flight schedule change or flight cancellation</description></item>
            /// <item><description>2: change due to pandemic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("change_reason_type")]
            [Validation(Required=false)]
            public int? ChangeReasonType { get; set; }

            /// <summary>
            /// <para>The journeys after the change.</para>
            /// </summary>
            [NameInMap("changed_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangedJourneys> ChangedJourneys { get; set; }
            public class ChangeDetailResponseBodyDataChangedJourneys : TeaModel {
                /// <summary>
                /// <para>The segment information.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataChangedJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataChangedJourneysSegmentList : TeaModel {
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
                    /// <para>Y</para>
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
                    /// <para>The flight duration, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165</para>
                    /// </summary>
                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    /// <summary>
                    /// <para>The marketing airline code (such as HO).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>The marketing flight number (such as HO1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The numeric marketing flight number (such as 1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    /// <summary>
                    /// <para>The operating airline code (such as CX).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    /// <summary>
                    /// <para>The operating flight number (such as CX601).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The segment ID. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>The list of stopover cities. This parameter has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
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
            /// <para>The reason for closing the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reason desc</para>
            /// </summary>
            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <para>The time when the order was closed, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415244000</para>
            /// </summary>
            [NameInMap("close_utc_time")]
            [Validation(Required=false)]
            public long? CloseUtcTime { get; set; }

            /// <summary>
            /// <para>The contact information for the change order.</para>
            /// </summary>
            [NameInMap("contact")]
            [Validation(Required=false)]
            public ChangeDetailResponseBodyDataContact Contact { get; set; }
            public class ChangeDetailResponseBodyDataContact : TeaModel {
                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gao******@gmail.com</para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The country calling code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>The mobile phone number of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>183*****92</para>
                /// </summary>
                [NameInMap("mobile_phone_num")]
                [Validation(Required=false)]
                public string MobilePhoneNum { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the change order, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415276000</para>
            /// </summary>
            [NameInMap("create_utc_time")]
            [Validation(Required=false)]
            public long? CreateUtcTime { get; set; }

            /// <summary>
            /// <para>The latest payment deadline for the buyer, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415278000</para>
            /// </summary>
            [NameInMap("last_confirm_utc_time")]
            [Validation(Required=false)]
            public long? LastConfirmUtcTime { get; set; }

            /// <summary>
            /// <para>The journeys from the previous change.</para>
            /// </summary>
            [NameInMap("last_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataLastJourneys> LastJourneys { get; set; }
            public class ChangeDetailResponseBodyDataLastJourneys : TeaModel {
                /// <summary>
                /// <para>The segment information.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataLastJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataLastJourneysSegmentList : TeaModel {
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
                    /// <para>Y</para>
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
                    /// <para>The flight duration, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165</para>
                    /// </summary>
                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    /// <summary>
                    /// <para>The marketing airline code (such as HO).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>The marketing flight number (such as HO1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The numeric marketing flight number (such as 1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    /// <summary>
                    /// <para>The operating airline code (such as CX).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    /// <summary>
                    /// <para>The operating flight number (such as CX601).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The segment ID. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>The list of stopover cities. This parameter has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
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
            /// <para>The order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5988430***541</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>The status of the change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: initial state</description></item>
            /// <item><description>1: pending payment</description></item>
            /// <item><description>2: payment successful</description></item>
            /// <item><description>3: change successful</description></item>
            /// <item><description>4: change closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The original journeys.</para>
            /// </summary>
            [NameInMap("original_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataOriginalJourneys> OriginalJourneys { get; set; }
            public class ChangeDetailResponseBodyDataOriginalJourneys : TeaModel {
                /// <summary>
                /// <para>The segment information.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataOriginalJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataOriginalJourneysSegmentList : TeaModel {
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
                    /// <para>Y</para>
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
                    /// <para>The flight duration, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165</para>
                    /// </summary>
                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    /// <summary>
                    /// <para>The marketing airline code (such as HO).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>The marketing flight number (such as HO1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The numeric marketing flight number (such as 1295).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    /// <summary>
                    /// <para>The operating airline code (such as CX).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    /// <summary>
                    /// <para>The operating flight number (such as CX601).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The segment ID. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>The list of stopover cities. This parameter has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
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
            /// <para>The payment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: initial state</description></item>
            /// <item><description>1: pending payment</description></item>
            /// <item><description>2: payment successful</description></item>
            /// <item><description>4: paid order closed successfully</description></item>
            /// <item><description>5: unpaid order closed successfully.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The time when the buyer completed the payment, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677415255000</para>
            /// </summary>
            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            /// <summary>
            /// <para>The total payment amount of the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public double? TotalAmount { get; set; }

            /// <summary>
            /// <para>The transaction number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

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
