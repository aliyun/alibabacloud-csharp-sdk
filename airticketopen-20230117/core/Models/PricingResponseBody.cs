// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class PricingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public PricingResponseBodyData Data { get; set; }
        public class PricingResponseBodyData : TeaModel {
            [NameInMap("changed_price_info")]
            [Validation(Required=false)]
            public PricingResponseBodyDataChangedPriceInfo ChangedPriceInfo { get; set; }
            public class PricingResponseBodyDataChangedPriceInfo : TeaModel {
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

            }

            [NameInMap("is_changed")]
            [Validation(Required=false)]
            public bool? IsChanged { get; set; }

            /// <summary>
            /// 变价之前价格信息 isChanged = true 时，才有值
            /// </summary>
            [NameInMap("original_price_info")]
            [Validation(Required=false)]
            public PricingResponseBodyDataOriginalPriceInfo OriginalPriceInfo { get; set; }
            public class PricingResponseBodyDataOriginalPriceInfo : TeaModel {
                /// <summary>
                /// 成人单价
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// 成人税
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// 儿童单价
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// 儿童税
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// 婴儿单价
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// 婴儿税
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

            }

            [NameInMap("remain_seats")]
            [Validation(Required=false)]
            public string RemainSeats { get; set; }

            /// <summary>
            /// solution
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public PricingResponseBodyDataSolution Solution { get; set; }
            public class PricingResponseBodyDataSolution : TeaModel {
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
                public List<PricingResponseBodyDataSolutionJourneyList> JourneyList { get; set; }
                public class PricingResponseBodyDataSolutionJourneyList : TeaModel {
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<PricingResponseBodyDataSolutionJourneyListSegmentList> SegmentList { get; set; }
                    public class PricingResponseBodyDataSolutionJourneyListSegmentList : TeaModel {
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
                public List<PricingResponseBodyDataSolutionSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentBaggageCheckInInfoList : TeaModel {
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentBaggageMappingList : TeaModel {
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<PricingResponseBodyDataSolutionSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class PricingResponseBodyDataSolutionSegmentRefundChangeRuleMappingList : TeaModel {
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
