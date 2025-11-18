// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailResponseBody : TeaModel {
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
        public RefundDetailResponseBodyData Data { get; set; }
        public class RefundDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether it contains additional refunds</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("contain_multi_refund")]
            [Validation(Required=false)]
            public bool? ContainMultiRefund { get; set; }

            /// <summary>
            /// <para>List of additional refund details associated with the initial refund</para>
            /// </summary>
            [NameInMap("multi_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataMultiRefundDetails> MultiRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataMultiRefundDetails : TeaModel {
                /// <summary>
                /// <para>Additional refund order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_order_num")]
                [Validation(Required=false)]
                public long? MultiRefundOrderNum { get; set; }

                /// <summary>
                /// <para>Transaction number of the Additional Refund order</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_transaction_no")]
                [Validation(Required=false)]
                public string MultiRefundTransactionNo { get; set; }

                /// <summary>
                /// <para>Additional refund details from the passenger\&quot;s</para>
                /// </summary>
                [NameInMap("passenger_multi_refund_details")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails> PassengerMultiRefundDetails { get; set; }
                public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails : TeaModel {
                    /// <summary>
                    /// <para>Amount refunded from the Change order</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("change_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? ChangeOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>Amount refunded from the Ticketing order</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("original_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? OriginalOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>Passenger for the refund</para>
                    /// </summary>
                    [NameInMap("passenger")]
                    [Validation(Required=false)]
                    public RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger Passenger { get; set; }
                    public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger : TeaModel {
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

            }

            /// <summary>
            /// <para>Order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>List of passenger refund details, refund information by passenger</para>
            /// </summary>
            [NameInMap("passenger_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataPassengerRefundDetails> PassengerRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataPassengerRefundDetails : TeaModel {
                /// <summary>
                /// <para>Information of the passenger applying for a refund</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsPassenger Passenger { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsPassenger : TeaModel {
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

                /// <summary>
                /// <para>Refund fee details</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee RefundFee { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee : TeaModel {
                    /// <summary>
                    /// <para>Total price of the used segments</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("already_used_total_fee")]
                    [Validation(Required=false)]
                    public double? AlreadyUsedTotalFee { get; set; }

                    /// <summary>
                    /// <para>Amount refunded to the user after a change</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("modify_refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? ModifyRefundToBuyerMoney { get; set; }

                    /// <summary>
                    /// <para>Non-refundable change penalty</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_service_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeServiceFee { get; set; }

                    /// <summary>
                    /// <para>Non-refundable fare difference</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_upgrade_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>tax penalty</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_tax_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTaxFee { get; set; }

                    /// <summary>
                    /// <para>fare penalty</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_ticket_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTicketFee { get; set; }

                    /// <summary>
                    /// <para>Amount refundable to the user (ticket price + taxes - fare penalty - tax penalty - total price of used segments)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? RefundToBuyerMoney { get; set; }

                }

            }

            /// <summary>
            /// <para>Actual refund time, UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            /// <summary>
            /// <para>List of URLs for medical refund attachments</para>
            /// 
            /// <b>Example:</b>
            /// <para>[zzz,yyy]</para>
            /// </summary>
            [NameInMap("refund_attachment_urls")]
            [Validation(Required=false)]
            public List<string> RefundAttachmentUrls { get; set; }

            /// <summary>
            /// <para>Refund journey</para>
            /// </summary>
            [NameInMap("refund_journeys")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataRefundJourneys> RefundJourneys { get; set; }
            public class RefundDetailResponseBodyDataRefundJourneys : TeaModel {
                /// <summary>
                /// <para>Segment information</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataRefundJourneysSegmentList> SegmentList { get; set; }
                public class RefundDetailResponseBodyDataRefundJourneysSegmentList : TeaModel {
                    /// <summary>
                    /// <para>Three-letter code of the arrival airport (in uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    /// <summary>
                    /// <para>Three-letter code of the arrival city (in uppercase)</para>
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
                    /// <para>Arrival date and time in string format (yyyy-mm-dd hh:mm:ss)</para>
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
                    /// <para>Indicates whether it is a codeshare flight</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    /// <summary>
                    /// <para>Three-letter code of the departure airport (in uppercase)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    /// <summary>
                    /// <para>Three-letter code of the departure city (in uppercase)</para>
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
                    /// <para>Departure date and time in string format (yyyy-mm-dd hh:mm:ss)</para>
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
                    /// <para>Marketing flight number (numeric part, e.g., 1295)</para>
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
                    /// <para>List of stop cities, present when stopQuantity &gt; 0, multiple values separated by commas</para>
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
            /// <para>Refund order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617654</para>
            /// </summary>
            [NameInMap("refund_order_num")]
            [Validation(Required=false)]
            public long? RefundOrderNum { get; set; }

            /// <summary>
            /// <para>Reason for refund</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc reason</para>
            /// </summary>
            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            /// <summary>
            /// <para>2: Voluntary application; 5: Flight delay or cancellation, flight schedule change, etc., due to airline reasons; 6: Health reasons with a report from a hospital of at least secondary level A; 7: Involuntary emergency guidance; 100: Involuntary non-emergency</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("refund_type")]
            [Validation(Required=false)]
            public int? RefundType { get; set; }

            /// <summary>
            /// <para>Reason for refund rejection</para>
            /// 
            /// <b>Example:</b>
            /// <para>refuse reason</para>
            /// </summary>
            [NameInMap("refuse_reason")]
            [Validation(Required=false)]
            public string RefuseReason { get; set; }

            /// <summary>
            /// <para>Refund order status 0: Refund application; 1: Refund in progress; 2: Refund failed; 3: Refund successful</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Transaction serial number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

            /// <summary>
            /// <para>Refund order creation time, UTC timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229002000</para>
            /// </summary>
            [NameInMap("utc_create_time")]
            [Validation(Required=false)]
            public long? UtcCreateTime { get; set; }

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
        /// <para>Error handling carries data</para>
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
        /// <para>Whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
