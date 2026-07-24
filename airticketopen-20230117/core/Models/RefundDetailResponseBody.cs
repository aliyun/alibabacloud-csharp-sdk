// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailResponseBody : TeaModel {
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
        public RefundDetailResponseBodyData Data { get; set; }
        public class RefundDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the refund contains a supplementary refund.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("contain_multi_refund")]
            [Validation(Required=false)]
            public bool? ContainMultiRefund { get; set; }

            /// <summary>
            /// <para>The list of supplementary refund details associated with the initial refund.</para>
            /// </summary>
            [NameInMap("multi_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataMultiRefundDetails> MultiRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataMultiRefundDetails : TeaModel {
                /// <summary>
                /// <para>The refund order number of the supplementary refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_order_num")]
                [Validation(Required=false)]
                public long? MultiRefundOrderNum { get; set; }

                /// <summary>
                /// <para>The transaction serial number of the supplementary refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_transaction_no")]
                [Validation(Required=false)]
                public string MultiRefundTransactionNo { get; set; }

                /// <summary>
                /// <para>The passenger-level supplementary refund details.</para>
                /// </summary>
                [NameInMap("passenger_multi_refund_details")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails> PassengerMultiRefundDetails { get; set; }
                public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails : TeaModel {
                    /// <summary>
                    /// <para>The supplementary refund amount from the rebooking order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("change_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? ChangeOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>The supplementary refund amount from the original order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("original_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? OriginalOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>The passenger for the refund.</para>
                    /// </summary>
                    [NameInMap("passenger")]
                    [Validation(Required=false)]
                    public RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger Passenger { get; set; }
                    public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger : TeaModel {
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

            }

            /// <summary>
            /// <para>The order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>The list of passenger-level refund details.</para>
            /// </summary>
            [NameInMap("passenger_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataPassengerRefundDetails> PassengerRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataPassengerRefundDetails : TeaModel {
                /// <summary>
                /// <para>The passenger information for the refund.</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsPassenger Passenger { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsPassenger : TeaModel {
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
                /// <para>The refund fee breakdown.</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee RefundFee { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee : TeaModel {
                    /// <summary>
                    /// <para>The total price of already used tickets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("already_used_total_fee")]
                    [Validation(Required=false)]
                    public double? AlreadyUsedTotalFee { get; set; }

                    [NameInMap("ancillary_refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? AncillaryRefundToBuyerMoney { get; set; }

                    /// <summary>
                    /// <para>The refundable amount to the buyer from rebooking.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("modify_refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? ModifyRefundToBuyerMoney { get; set; }

                    /// <summary>
                    /// <para>The non-refundable rebooking service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_service_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeServiceFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable cabin upgrade service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_upgrade_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable tax amount, which is the tax refund service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_tax_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTaxFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable ticket amount, which is the ticket refund service fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_ticket_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTicketFee { get; set; }

                    /// <summary>
                    /// <para>The refundable amount to the buyer from the original ticket (ticket price + taxes - ticket refund service fee - tax refund service fee - total price of already used tickets).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? RefundToBuyerMoney { get; set; }

                    [NameInMap("suez_service_fee")]
                    [Validation(Required=false)]
                    public double? SuezServiceFee { get; set; }

                }

            }

            /// <summary>
            /// <para>The actual refund time, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            /// <summary>
            /// <para>The list of attachment URLs for medical refund requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[zzz,yyy]</para>
            /// </summary>
            [NameInMap("refund_attachment_urls")]
            [Validation(Required=false)]
            public List<string> RefundAttachmentUrls { get; set; }

            /// <summary>
            /// <para>The journeys included in the refund.</para>
            /// </summary>
            [NameInMap("refund_journeys")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataRefundJourneys> RefundJourneys { get; set; }
            public class RefundDetailResponseBodyDataRefundJourneys : TeaModel {
                /// <summary>
                /// <para>The segment information.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataRefundJourneysSegmentList> SegmentList { get; set; }
                public class RefundDetailResponseBodyDataRefundJourneysSegmentList : TeaModel {
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
                    /// <para>The list of stopover cities. This field has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
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
            /// <para>The refund order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617654</para>
            /// </summary>
            [NameInMap("refund_order_num")]
            [Validation(Required=false)]
            public long? RefundOrderNum { get; set; }

            /// <summary>
            /// <para>The reason for the refund request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc reason</para>
            /// </summary>
            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            /// <summary>
            /// <para>The refund request type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: voluntary request.</description></item>
            /// <item><description>5: airline-initiated reasons such as flight delay, cancellation, or schedule change.</description></item>
            /// <item><description>6: medical reasons with a certificate from a Grade II Class A hospital or above.</description></item>
            /// <item><description>7: involuntary definitive emergency guidance.</description></item>
            /// <item><description>100: involuntary non-definitive emergency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("refund_type")]
            [Validation(Required=false)]
            public int? RefundType { get; set; }

            /// <summary>
            /// <para>The reason for rejecting the refund request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>refuse reason</para>
            /// </summary>
            [NameInMap("refuse_reason")]
            [Validation(Required=false)]
            public string RefuseReason { get; set; }

            /// <summary>
            /// <para>The refund order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: refund requested.</description></item>
            /// <item><description>1: refund being processed.</description></item>
            /// <item><description>2: refund failed.</description></item>
            /// <item><description>3: refund succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The transaction serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

            /// <summary>
            /// <para>The creation time of the refund order, in UTC timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229002000</para>
            /// </summary>
            [NameInMap("utc_create_time")]
            [Validation(Required=false)]
            public long? UtcCreateTime { get; set; }

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
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
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
