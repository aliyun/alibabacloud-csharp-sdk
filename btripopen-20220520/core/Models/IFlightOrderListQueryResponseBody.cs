// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderListQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<IFlightOrderListQueryResponseBodyModule> Module { get; set; }
        public class IFlightOrderListQueryResponseBodyModule : TeaModel {
            [NameInMap("flight_modify_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderList> FlightModifyOrderList { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderList : TeaModel {
                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public int? CorpPayPrice { get; set; }

                [NameInMap("flight_modify_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList> FlightModifySegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-25 12:25:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU7384</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                [NameInMap("flight_order_modify_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList> FlightOrderModifyTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList : TeaModel {
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU5236</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU5236</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>781-6605714721</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1005200138736000</para>
                /// </summary>
                [NameInMap("modify_apply_id")]
                [Validation(Required=false)]
                public long? ModifyApplyId { get; set; }

                [NameInMap("passenger_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListPassengerFee> PassengerFee { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListPassengerFee : TeaModel {
                    [NameInMap("modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? ModifyHandFee { get; set; }

                    [NameInMap("modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? ModifyUpgradeFee { get; set; }

                    [NameInMap("tax_gap")]
                    [Validation(Required=false)]
                    public long? TaxGap { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<string> PassengerList { get; set; }

                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public int? PersonPayPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1005200138736028</para>
                /// </summary>
                [NameInMap("relate_modify_apply_id")]
                [Validation(Required=false)]
                public long? RelateModifyApplyId { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                [NameInMap("total_fee")]
                [Validation(Required=false)]
                public long? TotalFee { get; set; }

            }

            [NameInMap("flight_refund_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderList> FlightRefundOrderList { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderList : TeaModel {
                [NameInMap("corp_refund_Amount")]
                [Validation(Required=false)]
                public int? CorpRefundAmount { get; set; }

                [NameInMap("flight_order_refund_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList> FlightOrderRefundTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList : TeaModel {
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BK3162</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BK3162</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>999-6605133193</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("flight_refund_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList> FlightRefundSegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-25 11:24:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU5334</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                [NameInMap("passenger_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListPassengerFee> PassengerFee { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListPassengerFee : TeaModel {
                    [NameInMap("no_refund_modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyHandFee { get; set; }

                    [NameInMap("no_refund_modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyUpgradeFee { get; set; }

                    [NameInMap("refund_amount")]
                    [Validation(Required=false)]
                    public long? RefundAmount { get; set; }

                    [NameInMap("refund_hand_fee")]
                    [Validation(Required=false)]
                    public long? RefundHandFee { get; set; }

                    [NameInMap("refund_modify_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyAmount { get; set; }

                    [NameInMap("refund_modify_hand_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyHandAmount { get; set; }

                    [NameInMap("refund_modify_upgrade_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyUpgradeAmount { get; set; }

                    [NameInMap("refund_tax_hand_fee")]
                    [Validation(Required=false)]
                    public long? RefundTaxHandFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("passenger_info")]
                [Validation(Required=false)]
                public List<string> PassengerInfo { get; set; }

                [NameInMap("person_refund_Amount")]
                [Validation(Required=false)]
                public int? PersonRefundAmount { get; set; }

                [NameInMap("refund_Amount")]
                [Validation(Required=false)]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1006200138737069</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public long? RefundApplyId { get; set; }

                [NameInMap("refund_hand_fee")]
                [Validation(Required=false)]
                public int? RefundHandFee { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

            }

            [NameInMap("flight_sale_order")]
            [Validation(Required=false)]
            public IFlightOrderListQueryResponseBodyModuleFlightSaleOrder FlightSaleOrder { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrder : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>82587500</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public long? ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("book_type")]
                [Validation(Required=false)]
                public int? BookType { get; set; }

                [NameInMap("booker_info")]
                [Validation(Required=false)]
                public IFlightOrderListQueryResponseBodyModuleFlightSaleOrderBookerInfo BookerInfo { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderBookerInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("user_name")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public long? CorpPayPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                [NameInMap("flight_order_insure_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList> FlightOrderInsureList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17060573244016310</para>
                    /// </summary>
                    [NameInMap("ins_order_id")]
                    [Validation(Required=false)]
                    public string InsOrderId { get; set; }

                    [NameInMap("ins_pay_type")]
                    [Validation(Required=false)]
                    public string InsPayType { get; set; }

                    [NameInMap("ins_total_price")]
                    [Validation(Required=false)]
                    public int? InsTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("trade_action")]
                    [Validation(Required=false)]
                    public string TradeAction { get; set; }

                }

                [NameInMap("flight_order_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList> FlightOrderTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList : TeaModel {
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MF8765</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public int? Tax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>018-6605785754</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("flight_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightSegmentList> FlightSegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightSegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-25 15:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-24 15:26:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU5925</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                [NameInMap("mix_pay")]
                [Validation(Required=false)]
                public bool? MixPay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("order_create_time")]
                [Validation(Required=false)]
                public string OrderCreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1003038200110661039</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("order_pay_time")]
                [Validation(Required=false)]
                public string OrderPayTime { get; set; }

                [NameInMap("order_reserve_price")]
                [Validation(Required=false)]
                public long? OrderReservePrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order_type")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderPassengerList> PassengerList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderPassengerList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0111</para>
                    /// </summary>
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1002</para>
                    /// </summary>
                    [NameInMap("department_id")]
                    [Validation(Required=false)]
                    public string DepartmentId { get; set; }

                    [NameInMap("department_name")]
                    [Validation(Required=false)]
                    public string DepartmentName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01112</para>
                    /// </summary>
                    [NameInMap("invoice_id")]
                    [Validation(Required=false)]
                    public string InvoiceId { get; set; }

                    [NameInMap("invoice_title")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100757</para>
                    /// </summary>
                    [NameInMap("job_no")]
                    [Validation(Required=false)]
                    public string JobNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1111</para>
                    /// </summary>
                    [NameInMap("project_code")]
                    [Validation(Required=false)]
                    public string ProjectCode { get; set; }

                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("user_name")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public long? PersonPayPrice { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>business_trip_api_000001</para>
                /// </summary>
                [NameInMap("third_part_apply_id")]
                [Validation(Required=false)]
                public string ThirdPartApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

        }

        [NameInMap("pageInfo")]
        [Validation(Required=false)]
        public IFlightOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class IFlightOrderListQueryResponseBodyPageInfo : TeaModel {
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4ZGViODFlYmM3MYzM4</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
