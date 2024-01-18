// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderDetailResponseBodyData Data { get; set; }
        public class OrderDetailResponseBodyData : TeaModel {
            [NameInMap("ancillary_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataAncillaryItemDetailList> AncillaryItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataAncillaryItemDetailList : TeaModel {
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListAncillary Ancillary { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillary : TeaModel {
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary : TeaModel {
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public double? Price { get; set; }

                    }

                }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListPassenger : TeaModel {
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential : TeaModel {
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            [NameInMap("baggage_allowance_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataBaggageAllowanceMapValue> BaggageAllowanceMap { get; set; }

            [NameInMap("book_time")]
            [Validation(Required=false)]
            public long? BookTime { get; set; }

            [NameInMap("flight_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataFlightItemDetailList> FlightItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataFlightItemDetailList : TeaModel {
                [NameInMap("b_pnr_list")]
                [Validation(Required=false)]
                public List<string> BPnrList { get; set; }

                [NameInMap("c_pnr_list")]
                [Validation(Required=false)]
                public List<string> CPnrList { get; set; }

                [NameInMap("flight_price")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListFlightPrice FlightPrice { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightPrice : TeaModel {
                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public double? SellPrice { get; set; }

                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public double? Tax { get; set; }

                }

                [NameInMap("flight_segment_cabin_relation")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation> FlightSegmentCabinRelation { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation : TeaModel {
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    [NameInMap("cabin_quantity")]
                    [Validation(Required=false)]
                    public string CabinQuantity { get; set; }

                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListPassenger : TeaModel {
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential : TeaModel {
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("ticket_air_line")]
                [Validation(Required=false)]
                public string TicketAirLine { get; set; }

                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("out_order_num")]
            [Validation(Required=false)]
            public string OutOrderNum { get; set; }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataPassengerList> PassengerList { get; set; }
            public class OrderDetailResponseBodyDataPassengerList : TeaModel {
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("credential")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataPassengerListCredential Credential { get; set; }
                public class OrderDetailResponseBodyDataPassengerListCredential : TeaModel {
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    [NameInMap("credential_type")]
                    [Validation(Required=false)]
                    public int? CredentialType { get; set; }

                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public double? PromotionPrice { get; set; }

            [NameInMap("real_pay_price")]
            [Validation(Required=false)]
            public double? RealPayPrice { get; set; }

            [NameInMap("refund_change_rule_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

            [NameInMap("session_nick")]
            [Validation(Required=false)]
            public string SessionNick { get; set; }

            [NameInMap("solution")]
            [Validation(Required=false)]
            public OrderDetailResponseBodyDataSolution Solution { get; set; }
            public class OrderDetailResponseBodyDataSolution : TeaModel {
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionJourneyList> JourneyList { get; set; }
                public class OrderDetailResponseBodyDataSolutionJourneyList : TeaModel {
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<OrderDetailResponseBodyDataSolutionJourneyListSegmentList> SegmentList { get; set; }
                    public class OrderDetailResponseBodyDataSolutionJourneyListSegmentList : TeaModel {
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

                [NameInMap("product_type_description")]
                [Validation(Required=false)]
                public string ProductTypeDescription { get; set; }

                [NameInMap("refund_ticket_coupon_description")]
                [Validation(Required=false)]
                public string RefundTicketCouponDescription { get; set; }

                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList : TeaModel {
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList : TeaModel {
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList : TeaModel {
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// solution_id
                /// </summary>
                [NameInMap("solution_id")]
                [Validation(Required=false)]
                public string SolutionId { get; set; }

            }

            [NameInMap("succeed_time")]
            [Validation(Required=false)]
            public long? SucceedTime { get; set; }

            [NameInMap("total_price")]
            [Validation(Required=false)]
            public double? TotalPrice { get; set; }

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
