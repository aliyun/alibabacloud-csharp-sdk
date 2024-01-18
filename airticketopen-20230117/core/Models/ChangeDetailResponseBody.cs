// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeDetailResponseBodyData Data { get; set; }
        public class ChangeDetailResponseBodyData : TeaModel {
            [NameInMap("change_fee_details")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangeFeeDetails> ChangeFeeDetails { get; set; }
            public class ChangeDetailResponseBodyDataChangeFeeDetails : TeaModel {
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee ChangeFee { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsChangeFee : TeaModel {
                    [NameInMap("service_fee")]
                    [Validation(Required=false)]
                    public double? ServiceFee { get; set; }

                    [NameInMap("tax_fee")]
                    [Validation(Required=false)]
                    public double? TaxFee { get; set; }

                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public double? UpgradeFee { get; set; }

                }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public ChangeDetailResponseBodyDataChangeFeeDetailsPassenger Passenger { get; set; }
                public class ChangeDetailResponseBodyDataChangeFeeDetailsPassenger : TeaModel {
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

            }

            [NameInMap("change_order_num")]
            [Validation(Required=false)]
            public long? ChangeOrderNum { get; set; }

            [NameInMap("change_passengers")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangePassengers> ChangePassengers { get; set; }
            public class ChangeDetailResponseBodyDataChangePassengers : TeaModel {
                [NameInMap("document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

            }

            [NameInMap("change_reason_type")]
            [Validation(Required=false)]
            public int? ChangeReasonType { get; set; }

            [NameInMap("changed_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataChangedJourneys> ChangedJourneys { get; set; }
            public class ChangeDetailResponseBodyDataChangedJourneys : TeaModel {
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataChangedJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataChangedJourneysSegmentList : TeaModel {
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    [NameInMap("arrival_city")]
                    [Validation(Required=false)]
                    public string ArrivalCity { get; set; }

                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    [NameInMap("departure_city")]
                    [Validation(Required=false)]
                    public string DepartureCity { get; set; }

                    [NameInMap("departure_terminal")]
                    [Validation(Required=false)]
                    public string DepartureTerminal { get; set; }

                    [NameInMap("departure_time")]
                    [Validation(Required=false)]
                    public string DepartureTime { get; set; }

                    [NameInMap("equip_type")]
                    [Validation(Required=false)]
                    public string EquipType { get; set; }

                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

            }

            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            [NameInMap("close_utc_time")]
            [Validation(Required=false)]
            public long? CloseUtcTime { get; set; }

            [NameInMap("contact")]
            [Validation(Required=false)]
            public ChangeDetailResponseBodyDataContact Contact { get; set; }
            public class ChangeDetailResponseBodyDataContact : TeaModel {
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                [NameInMap("mobile_phone_num")]
                [Validation(Required=false)]
                public string MobilePhoneNum { get; set; }

            }

            [NameInMap("create_utc_time")]
            [Validation(Required=false)]
            public long? CreateUtcTime { get; set; }

            [NameInMap("last_confirm_utc_time")]
            [Validation(Required=false)]
            public long? LastConfirmUtcTime { get; set; }

            [NameInMap("last_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataLastJourneys> LastJourneys { get; set; }
            public class ChangeDetailResponseBodyDataLastJourneys : TeaModel {
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataLastJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataLastJourneysSegmentList : TeaModel {
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    [NameInMap("arrival_city")]
                    [Validation(Required=false)]
                    public string ArrivalCity { get; set; }

                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    [NameInMap("departure_city")]
                    [Validation(Required=false)]
                    public string DepartureCity { get; set; }

                    [NameInMap("departure_terminal")]
                    [Validation(Required=false)]
                    public string DepartureTerminal { get; set; }

                    [NameInMap("departure_time")]
                    [Validation(Required=false)]
                    public string DepartureTime { get; set; }

                    [NameInMap("equip_type")]
                    [Validation(Required=false)]
                    public string EquipType { get; set; }

                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

            }

            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("original_journeys")]
            [Validation(Required=false)]
            public List<ChangeDetailResponseBodyDataOriginalJourneys> OriginalJourneys { get; set; }
            public class ChangeDetailResponseBodyDataOriginalJourneys : TeaModel {
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<ChangeDetailResponseBodyDataOriginalJourneysSegmentList> SegmentList { get; set; }
                public class ChangeDetailResponseBodyDataOriginalJourneysSegmentList : TeaModel {
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    [NameInMap("arrival_city")]
                    [Validation(Required=false)]
                    public string ArrivalCity { get; set; }

                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    [NameInMap("availability")]
                    [Validation(Required=false)]
                    public string Availability { get; set; }

                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    [NameInMap("departure_city")]
                    [Validation(Required=false)]
                    public string DepartureCity { get; set; }

                    [NameInMap("departure_terminal")]
                    [Validation(Required=false)]
                    public string DepartureTerminal { get; set; }

                    [NameInMap("departure_time")]
                    [Validation(Required=false)]
                    public string DepartureTime { get; set; }

                    [NameInMap("equip_type")]
                    [Validation(Required=false)]
                    public string EquipType { get; set; }

                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

            }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public double? TotalAmount { get; set; }

            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
