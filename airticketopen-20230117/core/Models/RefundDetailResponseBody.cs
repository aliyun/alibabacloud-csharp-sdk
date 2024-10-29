// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundDetailResponseBodyData Data { get; set; }
        public class RefundDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>whether it is a supplementary refund order (if the refund amount is not enough, you can use RefundApply to create a supplementary refund order)</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("contain_multi_refund")]
            [Validation(Required=false)]
            public bool? ContainMultiRefund { get; set; }

            /// <summary>
            /// <para>supplementary refund orders</para>
            /// </summary>
            [NameInMap("multi_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataMultiRefundDetails> MultiRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataMultiRefundDetails : TeaModel {
                /// <summary>
                /// <para>supplementary refund order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_order_num")]
                [Validation(Required=false)]
                public long? MultiRefundOrderNum { get; set; }

                /// <summary>
                /// <para>transaction number of the supplementary refund order</para>
                /// 
                /// <b>Example:</b>
                /// <para>498843***6950</para>
                /// </summary>
                [NameInMap("multi_refund_transaction_no")]
                [Validation(Required=false)]
                public string MultiRefundTransactionNo { get; set; }

                /// <summary>
                /// <para>supplementary refund details in passenger dimension</para>
                /// </summary>
                [NameInMap("passenger_multi_refund_details")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails> PassengerMultiRefundDetails { get; set; }
                public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetails : TeaModel {
                    /// <summary>
                    /// <para>amount of the supplementary refund for the change order</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("change_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? ChangeOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>amount of the supplementary refund for the original order</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("original_order_refund_fee")]
                    [Validation(Required=false)]
                    public double? OriginalOrderRefundFee { get; set; }

                    /// <summary>
                    /// <para>passenger for the refund</para>
                    /// </summary>
                    [NameInMap("passenger")]
                    [Validation(Required=false)]
                    public RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger Passenger { get; set; }
                    public class RefundDetailResponseBodyDataMultiRefundDetailsPassengerMultiRefundDetailsPassenger : TeaModel {
                        /// <summary>
                        /// <para>credential number</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>411***********4411</para>
                        /// </summary>
                        [NameInMap("document")]
                        [Validation(Required=false)]
                        public string Document { get; set; }

                        /// <summary>
                        /// <para>first name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SAN</para>
                        /// </summary>
                        [NameInMap("first_name")]
                        [Validation(Required=false)]
                        public string FirstName { get; set; }

                        /// <summary>
                        /// <para>last name</para>
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
            /// <para>order number that returned by Book</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>refund details by passenger dimension</para>
            /// </summary>
            [NameInMap("passenger_refund_details")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataPassengerRefundDetails> PassengerRefundDetails { get; set; }
            public class RefundDetailResponseBodyDataPassengerRefundDetails : TeaModel {
                /// <summary>
                /// <para>information of the passenger applying for a refund</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsPassenger Passenger { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsPassenger : TeaModel {
                    /// <summary>
                    /// <para>credential number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>411***********4411</para>
                    /// </summary>
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    /// <summary>
                    /// <para>first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

                /// <summary>
                /// <para>details of the refund fee</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee RefundFee { get; set; }
                public class RefundDetailResponseBodyDataPassengerRefundDetailsRefundFee : TeaModel {
                    /// <summary>
                    /// <para>total price of the used flight tickets</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("already_used_total_fee")]
                    [Validation(Required=false)]
                    public double? AlreadyUsedTotalFee { get; set; }

                    /// <summary>
                    /// <para>amount refunded to the user after change (only available when has change order)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("modify_refund_to_buyer_money")]
                    [Validation(Required=false)]
                    public double? ModifyRefundToBuyerMoney { get; set; }

                    /// <summary>
                    /// <para>non-refundable change service fee</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_service_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeServiceFee { get; set; }

                    /// <summary>
                    /// <para>non-refundable upgrade fee</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_change_upgrade_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableChangeUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>non-refundable tax amount, i.e., tax refund fee</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_tax_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTaxFee { get; set; }

                    /// <summary>
                    /// <para>non-refundable ticket amount, i.e., ticket refund fee</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("non_refundable_ticket_fee")]
                    [Validation(Required=false)]
                    public double? NonRefundableTicketFee { get; set; }

                    /// <summary>
                    /// <para>amount refundable to the user from the original ticket (fare + tax - non_refundable_ticket_fee - non_refundable_tax_fee - already_used_total_fee - discount)</para>
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
            /// <para>refund completed time(timestamp)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("pay_success_utc_time")]
            [Validation(Required=false)]
            public long? PaySuccessUtcTime { get; set; }

            /// <summary>
            /// <para>URLs for refund attachments</para>
            /// 
            /// <b>Example:</b>
            /// <para>[zzz,yyy]</para>
            /// </summary>
            [NameInMap("refund_attachment_urls")]
            [Validation(Required=false)]
            public List<string> RefundAttachmentUrls { get; set; }

            /// <summary>
            /// <para>refunded journey</para>
            /// </summary>
            [NameInMap("refund_journeys")]
            [Validation(Required=false)]
            public List<RefundDetailResponseBodyDataRefundJourneys> RefundJourneys { get; set; }
            public class RefundDetailResponseBodyDataRefundJourneys : TeaModel {
                /// <summary>
                /// <para>segment list</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<RefundDetailResponseBodyDataRefundJourneysSegmentList> SegmentList { get; set; }
                public class RefundDetailResponseBodyDataRefundJourneysSegmentList : TeaModel {
                    /// <summary>
                    /// <para>arrival airport code (capitalized)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_airport")]
                    [Validation(Required=false)]
                    public string ArrivalAirport { get; set; }

                    /// <summary>
                    /// <para>arrival city code (capitalized)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MFM</para>
                    /// </summary>
                    [NameInMap("arrival_city")]
                    [Validation(Required=false)]
                    public string ArrivalCity { get; set; }

                    /// <summary>
                    /// <para>arrival terminal</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arrival_terminal")]
                    [Validation(Required=false)]
                    public string ArrivalTerminal { get; set; }

                    /// <summary>
                    /// <para>arrival time in string format (yyyy-MM-dd HH:mm:ss)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-10 10:40:00</para>
                    /// </summary>
                    [NameInMap("arrival_time")]
                    [Validation(Required=false)]
                    public string ArrivalTime { get; set; }

                    /// <summary>
                    /// <para>field deprecated</para>
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
                    /// <para>cabin class</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>code share or not</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

                    /// <summary>
                    /// <para>departure airport code (capitalized)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PVG</para>
                    /// </summary>
                    [NameInMap("departure_airport")]
                    [Validation(Required=false)]
                    public string DepartureAirport { get; set; }

                    /// <summary>
                    /// <para>departure city code (capitalized)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SHA</para>
                    /// </summary>
                    [NameInMap("departure_city")]
                    [Validation(Required=false)]
                    public string DepartureCity { get; set; }

                    /// <summary>
                    /// <para>departure terminal</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("departure_terminal")]
                    [Validation(Required=false)]
                    public string DepartureTerminal { get; set; }

                    /// <summary>
                    /// <para>departure time in string format (yyyy-MM-dd HH:mm:ss)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-10 07:55:00</para>
                    /// </summary>
                    [NameInMap("departure_time")]
                    [Validation(Required=false)]
                    public string DepartureTime { get; set; }

                    /// <summary>
                    /// <para>equipment type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32Q</para>
                    /// </summary>
                    [NameInMap("equip_type")]
                    [Validation(Required=false)]
                    public string EquipType { get; set; }

                    /// <summary>
                    /// <para>flight time, unit: minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165</para>
                    /// </summary>
                    [NameInMap("flight_duration")]
                    [Validation(Required=false)]
                    public int? FlightDuration { get; set; }

                    /// <summary>
                    /// <para>marketing airline code (eg: KA)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    /// <summary>
                    /// <para>marketing flight no. (eg: KA5809)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    /// <summary>
                    /// <para>marketing flight no. (eg: 5809)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1295</para>
                    /// </summary>
                    [NameInMap("marketing_flight_no_int")]
                    [Validation(Required=false)]
                    public int? MarketingFlightNoInt { get; set; }

                    /// <summary>
                    /// <para>operating airline code (eg: CX)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO</para>
                    /// </summary>
                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    /// <summary>
                    /// <para>operating flight no. (eg: CX601)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>segment ID format: flight no.+departure airport[IATA airport code]+arrival airport[IATA airport code]+departure time(MMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                    /// <summary>
                    /// <para>stopover city list when stop_quantity &gt; 0 , use “,” for seperation use</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEL,HKG</para>
                    /// </summary>
                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public string StopCityList { get; set; }

                    /// <summary>
                    /// <para>number of stopover</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                /// <summary>
                /// <para>number of transfer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

            }

            /// <summary>
            /// <para>refund order number that returned by RefundApply</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617654</para>
            /// </summary>
            [NameInMap("refund_order_num")]
            [Validation(Required=false)]
            public long? RefundOrderNum { get; set; }

            /// <summary>
            /// <para>reason for refund</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc reason</para>
            /// </summary>
            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            /// <summary>
            /// <para>refund type </para>
            /// <para>2: voluntary application</para>
            /// <para>5: flight delay or cancellation, flight schedule change, etc., due to airline reasons</para>
            /// <para>6: health reasons with a certificate from a secondary class A hospital or above</para>
            /// <para>7: non-voluntary confirmed guidance</para>
            /// <para>100: non-voluntary non-confirmed guidance</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("refund_type")]
            [Validation(Required=false)]
            public int? RefundType { get; set; }

            /// <summary>
            /// <para>reason for refund rejection</para>
            /// 
            /// <b>Example:</b>
            /// <para>refuse reason</para>
            /// </summary>
            [NameInMap("refuse_reason")]
            [Validation(Required=false)]
            public string RefuseReason { get; set; }

            /// <summary>
            /// <para>refund order status</para>
            /// <para>0: refund application</para>
            /// <para>1: refund in progress</para>
            /// <para>2: refund failed</para>
            /// <para>3: refund succeeded</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>transaction number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677229005000</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

            /// <summary>
            /// <para>refund order created time(timestamp)</para>
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
        /// <para>error data</para>
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
        /// <para>http reqeust has been processed successfully，status code is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
