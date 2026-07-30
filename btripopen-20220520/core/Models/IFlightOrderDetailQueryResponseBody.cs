// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IFlightOrderDetailQueryResponseBodyModule Module { get; set; }
        public class IFlightOrderDetailQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The change order information.<notice>Returned only when change orders exist. Returns [] by default. Check for empty values.</notice></para>
            /// </summary>
            [NameInMap("flight_modify_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderList> FlightModifyOrderList { get; set; }
            public class IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderList : TeaModel {
                /// <summary>
                /// <para>The corporate payment amount for the change fee. <notice>Returned after payment. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>3000，单位:分</para>
                /// </summary>
                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public int? CorpPayPrice { get; set; }

                /// <summary>
                /// <para>The change flight information. <notice>Returned after the change is confirmed. The default value is []. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_modify_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList> FlightModifySegmentList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国东方航空</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The arrival airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The operating airline code.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating airline name.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-25 12:25:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU7384</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the flight is a code-share flight.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The change ticket information. <notice>Returned after the change ticket is successfully issued. The default value is []. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_order_modify_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList> FlightOrderModifyTicketList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class information list.</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass : TeaModel {
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
                        /// <para>The cabin class. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MU5236</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5236</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The ticket number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>781-6605285563</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0132</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1005200138736000</para>
                /// </summary>
                [NameInMap("modify_apply_id")]
                [Validation(Required=false)]
                public long? ModifyApplyId { get; set; }

                /// <summary>
                /// <para>The change fee at the passenger level. <notice>Returned after the change ticket is successfully issued. The default value is []. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("modify_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListModifyFee> ModifyFee { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightModifyOrderListModifyFee : TeaModel {
                    /// <summary>
                    /// <para>The rebooking fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? ModifyHandFee { get; set; }

                    /// <summary>
                    /// <para>The cabin upgrade fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? ModifyUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The tax difference (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("tax_gap")]
                    [Validation(Required=false)]
                    public long? TaxGap { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0132</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The change order status. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("modify_order_status")]
                [Validation(Required=false)]
                public int? ModifyOrderStatus { get; set; }

                /// <summary>
                /// <para>The total change fee (unit: cents). <notice>This field has a value only after the seller confirms the change. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>5000，单位:分</para>
                /// </summary>
                [NameInMap("modify_total_fee")]
                [Validation(Required=false)]
                public int? ModifyTotalFee { get; set; }

                /// <summary>
                /// <para>The passenger information. <notice>Returned after the change is confirmed. The default value is []. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<string> PassengerList { get; set; }

                /// <summary>
                /// <para>The personal payment amount for the change fee. <notice>Returned after payment. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>1000，单位:分</para>
                /// </summary>
                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public int? PersonPayPrice { get; set; }

                /// <summary>
                /// <para>The related change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1005200138736028</para>
                /// </summary>
                [NameInMap("relate_modify_apply_id")]
                [Validation(Required=false)]
                public long? RelateModifyApplyId { get; set; }

                /// <summary>
                /// <para>The service fee charged by the business travel platform (unit: cents). <notice>The change service fee is calculated and deducted after the change is successful.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>1000，单位:分</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                /// <summary>
                /// <para>The change submission time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-26 11:25:00</para>
                /// </summary>
                [NameInMap("submit_modify_time")]
                [Validation(Required=false)]
                public string SubmitModifyTime { get; set; }

                /// <summary>
                /// <para>The change type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true 自愿改签 false 非自愿改签</para>
                /// </summary>
                [NameInMap("voluntary")]
                [Validation(Required=false)]
                public bool? Voluntary { get; set; }

            }

            /// <summary>
            /// <para>The refund order information. <notice>This field has a value only when a refund application exists. The default value is []. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("flight_refund_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderList> FlightRefundOrderList { get; set; }
            public class IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderList : TeaModel {
                /// <summary>
                /// <para>The amount refunded to the corporation (unit: cents). <notice>This field has a value only after a successful refund. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("corp_refund_Amount")]
                [Validation(Required=false)]
                public int? CorpRefundAmount { get; set; }

                /// <summary>
                /// <para>The refund ticket information.</para>
                /// </summary>
                [NameInMap("flight_order_refund_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList> FlightOrderRefundTicketList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class information.</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass : TeaModel {
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
                        /// <para>The cabin class. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MU5236</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5236</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The ticket number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>018-6605785754</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0132</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund fee at the passenger level. <notice>This field has a value only after a successful refund. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_passenger_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightPassengerFee> FlightPassengerFee { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightPassengerFee : TeaModel {
                    /// <summary>
                    /// <para>The non-refundable rebooking fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("no_refund_modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyHandFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable change upgrade fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("no_refund_modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The refund amount (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_amount")]
                    [Validation(Required=false)]
                    public long? RefundAmount { get; set; }

                    /// <summary>
                    /// <para>The refund handling fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_hand_fee")]
                    [Validation(Required=false)]
                    public long? RefundHandFee { get; set; }

                    /// <summary>
                    /// <para>The change refund amount (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyAmount { get; set; }

                    /// <summary>
                    /// <para>The rebooking fee refund amount (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_hand_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyHandAmount { get; set; }

                    /// <summary>
                    /// <para>The change upgrade fee refund amount (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_upgrade_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyUpgradeAmount { get; set; }

                    /// <summary>
                    /// <para>The tax refund handling fee (unit: cents).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_tax_hand_fee")]
                    [Validation(Required=false)]
                    public long? RefundTaxHandFee { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0132</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund flight information.</para>
                /// </summary>
                [NameInMap("flight_refund_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList> FlightRefundSegmentList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国东方航空</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The arrival airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal. This value may not always be available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The operating airline code.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating airline name.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal. This value may not always be available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-25 11:24:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5334</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the flight is a code-share flight.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The passenger information.</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<string> PassengerList { get; set; }

                /// <summary>
                /// <para>The amount refunded to the individual (unit: cents). <notice>This field has a value only after a successful refund. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("person_refund_Amount")]
                [Validation(Required=false)]
                public int? PersonRefundAmount { get; set; }

                /// <summary>
                /// <para>The refund application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1006200138737069</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public long? RefundApplyId { get; set; }

                /// <summary>
                /// <para>The refund handling fee (unit: cents).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_hand_fee")]
                [Validation(Required=false)]
                public int? RefundHandFee { get; set; }

                /// <summary>
                /// <para>The refund order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("refund_order_status")]
                [Validation(Required=false)]
                public int? RefundOrderStatus { get; set; }

                /// <summary>
                /// <para>The refund service fee (unit: cents).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_service_fee")]
                [Validation(Required=false)]
                public long? RefundServiceFee { get; set; }

                /// <summary>
                /// <para>The total refund amount (unit: cents). <notice>This field has a value only after a successful refund. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_total_Amount")]
                [Validation(Required=false)]
                public int? RefundTotalAmount { get; set; }

                /// <summary>
                /// <para>The list of associated change order IDs. <notice>This field has a value only for refund orders after a change. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("relate_modify_apply_id")]
                [Validation(Required=false)]
                public List<long?> RelateModifyApplyId { get; set; }

                /// <summary>
                /// <para>The associated refund order ID for the supplementary refund. <warning>This field is not yet populated. Do not use it directly.</warning></para>
                /// 
                /// <b>Example:</b>
                /// <para>10062001387370</para>
                /// </summary>
                [NameInMap("relate_refund_apply_id")]
                [Validation(Required=false)]
                public long? RelateRefundApplyId { get; set; }

                /// <summary>
                /// <para>The supplementary refund indicator. Only when the value is true does it indicate a supplementary refund order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("repeat_refund")]
                [Validation(Required=false)]
                public bool? RepeatRefund { get; set; }

                /// <summary>
                /// <para>The refund submission time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-26 11:25:00</para>
                /// </summary>
                [NameInMap("submit_refund_time")]
                [Validation(Required=false)]
                public string SubmitRefundTime { get; set; }

                /// <summary>
                /// <para>The refund type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("voluntary")]
                [Validation(Required=false)]
                public bool? Voluntary { get; set; }

            }

            /// <summary>
            /// <para>The international flight sale order information.</para>
            /// </summary>
            [NameInMap("flight_sale_order")]
            [Validation(Required=false)]
            public IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrder FlightSaleOrder { get; set; }
            public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrder : TeaModel {
                /// <summary>
                /// <para>The business travel application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82587500</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public long? ApplyId { get; set; }

                /// <summary>
                /// <para>The order booking type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("book_type")]
                [Validation(Required=false)]
                public int? BookType { get; set; }

                /// <summary>
                /// <para>The booker information.</para>
                /// </summary>
                [NameInMap("booker_info")]
                [Validation(Required=false)]
                public IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderBookerInfo BookerInfo { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderBookerInfo : TeaModel {
                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("user_name")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The enterprise payment amount for the booking order, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000，单位:分</para>
                /// </summary>
                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public long? CorpPayPrice { get; set; }

                /// <summary>
                /// <para>The excess approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>The insurance information.<warning>Not yet populated. Do not use directly.</warning></para>
                /// </summary>
                [NameInMap("flight_order_insure_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList> FlightOrderInsureList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList : TeaModel {
                    /// <summary>
                    /// <para>The insurance order ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17060573244016310</para>
                    /// </summary>
                    [NameInMap("ins_order_id")]
                    [Validation(Required=false)]
                    public string InsOrderId { get; set; }

                    /// <summary>
                    /// <para>The insurance payment method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ins_pay_type")]
                    [Validation(Required=false)]
                    public string InsPayType { get; set; }

                    /// <summary>
                    /// <para>The insurance total price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000， 单位:分</para>
                    /// </summary>
                    [NameInMap("ins_total_price")]
                    [Validation(Required=false)]
                    public int? InsTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The expense direction. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("trade_action")]
                    [Validation(Required=false)]
                    public string TradeAction { get; set; }

                }

                /// <summary>
                /// <para>The international flight ticket information.<notice>Returned only after ticketing succeeds. Returns [] by default. Check for empty values.</notice></para>
                /// </summary>
                [NameInMap("flight_order_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList> FlightOrderTicketList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class list.</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass : TeaModel {
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
                        /// <para>The cabin class. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MF8765</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The tax amount, in cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public int? Tax { get; set; }

                    /// <summary>
                    /// <para>The ticket number.<notice>The ticket number format is not fixed and depends on the airline. Generally, only low-cost carriers differ from other regular airlines.</notice></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>018-6605785754</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The ticket price, in cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightSegmentList> FlightSegmentList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderFlightSegmentList : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国东方航空</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The arrival airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal. This value may not always be available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-25 15:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The operating airline code.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating airline name.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal. This value may not always be available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-24 15:26:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5925</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the flight is a code-share flight.<warning>Not yet populated. Do not use directly.</warning></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.<notice>Returned only when stopover information exists.</notice></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db22bf8a51ea47f28d6a94c12bf2a8ea</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>Indicates whether the order uses mixed payment. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true:企业和个人混合支付</para>
                /// </summary>
                [NameInMap("mix_pay")]
                [Validation(Required=false)]
                public bool? MixPay { get; set; }

                /// <summary>
                /// <para>The order creation time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-11 19:13:20</para>
                /// </summary>
                [NameInMap("order_create_time")]
                [Validation(Required=false)]
                public string OrderCreateTime { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1003038200110661039</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order payment time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-11 19:13:24</para>
                /// </summary>
                [NameInMap("order_pay_time")]
                [Validation(Required=false)]
                public string OrderPayTime { get; set; }

                /// <summary>
                /// <para>The total booking amount of the order, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000，单位:分</para>
                /// </summary>
                [NameInMap("order_reserve_price")]
                [Validation(Required=false)]
                public long? OrderReservePrice { get; set; }

                /// <summary>
                /// <para>The order status. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <para>The order status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出票成功</para>
                /// </summary>
                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <para>The order type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order_type")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                /// <summary>
                /// <para>The passenger information.</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderPassengerList> PassengerList { get; set; }
                public class IFlightOrderDetailQueryResponseBodyModuleFlightSaleOrderPassengerList : TeaModel {
                    /// <summary>
                    /// <para>The cost center ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0111</para>
                    /// </summary>
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    /// <summary>
                    /// <para>The cost center name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试成本中心</para>
                    /// </summary>
                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    /// <summary>
                    /// <para>The department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1002</para>
                    /// </summary>
                    [NameInMap("department_id")]
                    [Validation(Required=false)]
                    public string DepartmentId { get; set; }

                    /// <summary>
                    /// <para>The department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试部门</para>
                    /// </summary>
                    [NameInMap("department_name")]
                    [Validation(Required=false)]
                    public string DepartmentName { get; set; }

                    /// <summary>
                    /// <para>The invoice ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01112</para>
                    /// </summary>
                    [NameInMap("invoice_id")]
                    [Validation(Required=false)]
                    public string InvoiceId { get; set; }

                    /// <summary>
                    /// <para>The invoice title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试发票</para>
                    /// </summary>
                    [NameInMap("invoice_title")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// <para>The employee ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100757</para>
                    /// </summary>
                    [NameInMap("job_no")]
                    [Validation(Required=false)]
                    public string JobNo { get; set; }

                    /// <summary>
                    /// <para>The passenger type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    /// <summary>
                    /// <para>The project code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1111</para>
                    /// </summary>
                    [NameInMap("project_code")]
                    [Validation(Required=false)]
                    public string ProjectCode { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试项目</para>
                    /// </summary>
                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01323</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("user_name")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The payment method. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The personal payment amount for the booking order, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000，单位:分</para>
                /// </summary>
                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public long? PersonPayPrice { get; set; }

                /// <summary>
                /// <para>The service fee for the booking order, in cents. This value is calculated and charged after ticketing succeeds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000, 单位:分</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                /// <summary>
                /// <para>The third-party travel application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_trip_api_000001</para>
                /// </summary>
                [NameInMap("third_part_apply_id")]
                [Validation(Required=false)]
                public string ThirdPartApplyId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TableField_14P1V6GJ7HMO0_W42ZWKTC074</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The trip type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
