// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundDetailResponseBodyData Data { get; set; }
        public class RefundDetailResponseBodyData : TeaModel {
            [NameInMap("contain_multi_refund")]
            [Validation(Required=false)]
            public bool? ContainMultiRefund { get; set; }

            [NameInMap("multi_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataMultiRefundDetails> MultiRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataMultiRefundDetails : TeaModel {
                [NameInMap("multi_refund_order_num")]
                [Validation(Required=false)]
                public long? MultiRefundOrderNum { get; set; }

                [NameInMap("multi_refund_transaction_no")]
                [Validation(Required=false)]
                public string MultiRefundTransactionNo { get; set; }

                [NameInMap("passenger_multi_refund_details")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails> PassengerMultiRefundDetails { get; set; }
                public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails : TeaModel {
                    [NameInMap("change_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? ChangeOrderRefundFee { get; set; }

                    [NameInMap("original_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? OriginalOrderRefundFee { get; set; }

                    [NameInMap("passenger")]
                    [Validation(Required=false)]
                    public RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger Passenger { get; set; }
                    public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger : TeaModel {
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

            }

            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            [NameInMap("passenger_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataPassengerRefundDetails> PassengerRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataPassengerRefundDetails : TeaModel {
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsPassenger Passenger { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsPassenger : TeaModel {
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

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee RefundFee { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee : TeaModel {
                    [NameInMap("already_used_total_fee")]
                    [Validation(Required=false)]
                    public double? AlreadyUsedTotalFee { get; set; }

                    [NameInMap("modify_refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? ModifyRefundToBuyerMoney { get; set; }

                    [NameInMap("non_refundable_change_service_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeServiceFee { get; set; }

                    [NameInMap("non_refundable_change_upgrade_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeUpgradeFee { get; set; }

                    [NameInMap("non_refundable_tax_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTaxFee { get; set; }

                    [NameInMap("non_refundable_ticket_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTicketFee { get; set; }

                    [NameInMap("refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? RefundToBuyerMoney { get; set; }

                }

            }

            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            [NameInMap("refund_attachment_urls")]
            [Validation(Required=false)]
            public List<string> RefundAttachmentUrls { get; set; }

            [NameInMap("refund_journeys")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataRefundJourneys> RefundJourneys { get; set; }
            public class RefundDetailResponseBodyDataRefundJourneys : TeaModel {
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataRefundJourneysSegmentList> SegmentList { get; set; }
                public class RefundDetailResponseBodyDataRefundJourneysSegmentList : TeaModel {
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

            [NameInMap("refund_order_num")]
            [Validation(Required=false)]
            public long? RefundOrderNum { get; set; }

            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            [NameInMap("refund_type")]
            [Validation(Required=false)]
            public int? RefundType { get; set; }

            [NameInMap("refuse_reason")]
            [Validation(Required=false)]
            public string RefuseReason { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

            [NameInMap("utc_create_time")]
            [Validation(Required=false)]
            public long? UtcCreateTime { get; set; }

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
