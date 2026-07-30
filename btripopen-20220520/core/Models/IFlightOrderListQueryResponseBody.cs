// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderListQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        public List<IFlightOrderListQueryResponseBodyModule> Module { get; set; }
        public class IFlightOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The international flight change order information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns empty if the order has not been changed.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_modify_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderList> FlightModifyOrderList { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderList : TeaModel {
                /// <summary>
                /// <para>The corporate payment portion for the change. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public int? CorpPayPrice { get; set; }

                /// <summary>
                /// <para>The change flight segment information.</para>
                /// </summary>
                [NameInMap("flight_modify_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList> FlightModifySegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightModifySegmentList : TeaModel {
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
                    /// <para>The arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The arrival airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The arrival city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no terminal information is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The code of the actual operating airline.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating carrier airline name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The departure airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no terminal information is available.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
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
                    /// <para>Indicates whether the flight is a codeshare flight.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover airport.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The change ticket information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns an empty array if the change has not been completed.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("flight_order_modify_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList> FlightOrderModifyTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class information.</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListFlightOrderModifyTicketListCabinClass : TeaModel {
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
                    /// <para>781-6605714721</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01332</para>
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
                /// <para>The change fees at the passenger level.</para>
                /// </summary>
                [NameInMap("passenger_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListPassengerFee> PassengerFee { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightModifyOrderListPassengerFee : TeaModel {
                    /// <summary>
                    /// <para>The rebooking fee. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? ModifyHandFee { get; set; }

                    /// <summary>
                    /// <para>The cabin upgrade fee. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? ModifyUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The tax difference. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("tax_gap")]
                    [Validation(Required=false)]
                    public long? TaxGap { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The passenger information for the change.</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<string> PassengerList { get; set; }

                /// <summary>
                /// <para>The personal payment portion for the change. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public int? PersonPayPrice { get; set; }

                /// <summary>
                /// <para>The related change order ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns empty if no value exists.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1005200138736028</para>
                /// </summary>
                [NameInMap("relate_modify_apply_id")]
                [Validation(Required=false)]
                public long? RelateModifyApplyId { get; set; }

                /// <summary>
                /// <para>The service fee. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                /// <summary>
                /// <para>The total change fee. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("total_fee")]
                [Validation(Required=false)]
                public long? TotalFee { get; set; }

            }

            /// <summary>
            /// <para>The international flight refund order information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns empty if no refund records exist.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_refund_order_list")]
            [Validation(Required=false)]
            public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderList> FlightRefundOrderList { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderList : TeaModel {
                /// <summary>
                /// <para>The corporate refund amount. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("corp_refund_Amount")]
                [Validation(Required=false)]
                public int? CorpRefundAmount { get; set; }

                /// <summary>
                /// <para>The refund ticket information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns an empty array if no value exists.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("flight_order_refund_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList> FlightOrderRefundTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class information.</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightOrderRefundTicketListCabinClass : TeaModel {
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
                        /// <para>BK3162</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BK3162</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The ticket number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>999-6605133193</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund flight segment information.</para>
                /// </summary>
                [NameInMap("flight_refund_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList> FlightRefundSegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListFlightRefundSegmentList : TeaModel {
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
                    /// <para>The arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The arrival airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city.</para>
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
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no terminal information is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-28 14:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The operating carrier airline code.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating carrier airline name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The departure airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city.</para>
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
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no terminal information is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
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
                    /// <para>Indicates whether the flight is a codeshare flight.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover airport.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty for flights without a stopover city.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-27 11:26:00</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                /// <summary>
                /// <para>The refund fees at the passenger level.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns empty if no value exists.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("passenger_fee")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListPassengerFee> PassengerFee { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightRefundOrderListPassengerFee : TeaModel {
                    /// <summary>
                    /// <para>The non-refundable rebooking fee. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("no_refund_modify_hand_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyHandFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable change upgrade fee. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("no_refund_modify_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? NoRefundModifyUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The refund amount. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_amount")]
                    [Validation(Required=false)]
                    public long? RefundAmount { get; set; }

                    /// <summary>
                    /// <para>The refund handling fee. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_hand_fee")]
                    [Validation(Required=false)]
                    public long? RefundHandFee { get; set; }

                    /// <summary>
                    /// <para>The change refund amount. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyAmount { get; set; }

                    /// <summary>
                    /// <para>The rebooking fee refund amount. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_hand_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyHandAmount { get; set; }

                    /// <summary>
                    /// <para>The change upgrade fee refund amount. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("refund_modify_upgrade_amount")]
                    [Validation(Required=false)]
                    public long? RefundModifyUpgradeAmount { get; set; }

                    /// <summary>
                    /// <para>The tax refund handling fee. Unit: cents.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty if no value exists.</description></item>
                    /// </list>
                    /// </remarks>
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
                    /// <para>01332</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund passenger information.</para>
                /// </summary>
                [NameInMap("passenger_info")]
                [Validation(Required=false)]
                public List<string> PassengerInfo { get; set; }

                /// <summary>
                /// <para>The personal refund amount. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("person_refund_Amount")]
                [Validation(Required=false)]
                public int? PersonRefundAmount { get; set; }

                /// <summary>
                /// <para>The refund amount. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_Amount")]
                [Validation(Required=false)]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// <para>The refund order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1006200138737069</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public long? RefundApplyId { get; set; }

                /// <summary>
                /// <para>The refund handling fee. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_hand_fee")]
                [Validation(Required=false)]
                public int? RefundHandFee { get; set; }

                /// <summary>
                /// <para>The refund service fee. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

            }

            /// <summary>
            /// <para>The international flight sales order information.</para>
            /// </summary>
            [NameInMap("flight_sale_order")]
            [Validation(Required=false)]
            public IFlightOrderListQueryResponseBodyModuleFlightSaleOrder FlightSaleOrder { get; set; }
            public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrder : TeaModel {
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
                /// <para>The order booking type.</para>
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
                public IFlightOrderListQueryResponseBodyModuleFlightSaleOrderBookerInfo BookerInfo { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderBookerInfo : TeaModel {
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
                /// <para>The enterprise payment amount for the booking order. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("corp_pay_price")]
                [Validation(Required=false)]
                public long? CorpPayPrice { get; set; }

                /// <summary>
                /// <para>The excess approval ID.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If no excess approval was initiated when the order was created, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                /// <summary>
                /// <para>The insurance information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If no insurance information exists, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("flight_order_insure_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList> FlightOrderInsureList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderInsureList : TeaModel {
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
                    /// <para>The insurance total price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
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
                /// <para>The international flight forward ticket information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If the order has not been ticketed, an empty array is returned.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("flight_order_ticket_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList> FlightOrderTicketList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketList : TeaModel {
                    /// <summary>
                    /// <para>The cabin class list.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the cabin class list is empty, an empty array is returned.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass> CabinClass { get; set; }
                    public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightOrderTicketListCabinClass : TeaModel {
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
                        /// <para>The segment number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MF8765</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000，单位:分</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public int? Tax { get; set; }

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
                    /// <para>The ticket price.</para>
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
                /// <para>The flight information.</para>
                /// </summary>
                [NameInMap("flight_segment_list")]
                [Validation(Required=false)]
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightSegmentList> FlightSegmentList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderFlightSegmentList : TeaModel {
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
                    /// <para>The arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The arrival airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The arrival city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no terminal information is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-25 15:26:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The operating carrier airline code.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("carrier_airline_code")]
                    [Validation(Required=false)]
                    public string CarrierAirlineCode { get; set; }

                    /// <summary>
                    /// <para>The operating carrier airline name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("carrier_airline_name")]
                    [Validation(Required=false)]
                    public string CarrierAirlineName { get; set; }

                    /// <summary>
                    /// <para>The departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The departure airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The departure city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no terminal information is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
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
                    /// <para>Indicates whether the flight is a codeshare flight.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If no value is available, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The stopover airport code.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the flight has no stopover city, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KIX</para>
                    /// </summary>
                    [NameInMap("stop_apt_code")]
                    [Validation(Required=false)]
                    public string StopAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the flight has no stopover city, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-26 11:25:00</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the flight has no stopover city, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大阪</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public string StopCity { get; set; }

                    /// <summary>
                    /// <para>The stopover city code.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the flight has no stopover city, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSA</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the flight has no stopover city, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
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
                /// <para>Indicates whether mixed payment is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true:企业和个人混合支付</para>
                /// </summary>
                [NameInMap("mix_pay")]
                [Validation(Required=false)]
                public bool? MixPay { get; set; }

                /// <summary>
                /// <para>The order creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
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
                /// <item><description>If the order is unpaid, this field is empty.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("order_pay_time")]
                [Validation(Required=false)]
                public string OrderPayTime { get; set; }

                /// <summary>
                /// <para>The forward booking amount of the order. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
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
                public List<IFlightOrderListQueryResponseBodyModuleFlightSaleOrderPassengerList> PassengerList { get; set; }
                public class IFlightOrderListQueryResponseBodyModuleFlightSaleOrderPassengerList : TeaModel {
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
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>If the traveler information does not contain an employee ID, this field is empty.</description></item>
                    /// </list>
                    /// </remarks>
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
                /// <para>The personal payment amount for the booking order. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("person_pay_price")]
                [Validation(Required=false)]
                public long? PersonPayPrice { get; set; }

                /// <summary>
                /// <para>The forward order service fee.</para>
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
                /// <para>The third-party itinerary ID.
                /// [_</para>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("pageInfo")]
        [Validation(Required=false)]
        public IFlightOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class IFlightOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of records returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10，最多100</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The scroll ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4ZGViODFlYmM3MYzM4</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
