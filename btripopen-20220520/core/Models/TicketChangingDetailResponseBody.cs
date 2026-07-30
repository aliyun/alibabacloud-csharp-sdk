// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误提示</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingDetailResponseBodyModule Module { get; set; }
        public class TicketChangingDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The payment transaction number (not available).</para>
            /// 
            /// <b>Example:</b>
            /// <para>暂无</para>
            /// </summary>
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <para>The business travel sub-order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37772</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <para>The distribution external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <para>The distribution external sub-order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chang123</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <para>The extra information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The flight information.</para>
            /// </summary>
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingDetailResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class TicketChangingDetailResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <para>The two-letter IATA code of the airline.</para>
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
                /// <para>东航</para>
                /// </summary>
                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <para>The airline short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>国航</para>
                /// </summary>
                [NameInMap("airline_simple_name")]
                [Validation(Required=false)]
                public string AirlineSimpleName { get; set; }

                /// <summary>
                /// <para>The arrival airport (not available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>****机场</para>
                /// </summary>
                [NameInMap("arr_airport_code_name")]
                [Validation(Required=false)]
                public string ArrAirportCodeName { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival terminal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T3</para>
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
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The baggage allowance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“描述”</para>
                /// </summary>
                [NameInMap("baggage")]
                [Validation(Required=false)]
                public string Baggage { get; set; }

                /// <summary>
                /// <para>The airport construction fee, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public long? BuildPrice { get; set; }

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
                /// <para>The cabin class description (not available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The operating flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU3849</para>
                /// </summary>
                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                /// <summary>
                /// <para>The departure airport (not available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***机场。</para>
                /// </summary>
                [NameInMap("dep_airport_code_name")]
                [Validation(Required=false)]
                public string DepAirportCodeName { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure terminal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T4</para>
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
                /// <para>2000-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU3849</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The cabin before the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("last_cabin")]
                [Validation(Required=false)]
                public string LastCabin { get; set; }

                /// <summary>
                /// <para>The flight number before the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1982</para>
                /// </summary>
                [NameInMap("last_flight_no")]
                [Validation(Required=false)]
                public string LastFlightNo { get; set; }

                /// <summary>
                /// <para>The meal type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("meal")]
                [Validation(Required=false)]
                public string Meal { get; set; }

                /// <summary>
                /// <para>The fuel surcharge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public long? OilPrice { get; set; }

                /// <summary>
                /// <para>The segment type (not available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public int? SegmentType { get; set; }

                /// <summary>
                /// <para>The stopover arrival time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// <item><description>Returns empty if there is no stopover city.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The stopover departure time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// <item><description>Returns empty if there is no stopover city.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                /// <summary>
                /// <para>The ticket price, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public long? TicketPrice { get; set; }

                /// <summary>
                /// <para>The refund/change policy text after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;退改文案&quot;</para>
                /// </summary>
                [NameInMap("tuigaiqian_info")]
                [Validation(Required=false)]
                public string TuigaiqianInfo { get; set; }

            }

            /// <summary>
            /// <para>The latest payment time (yyyy-MM-dd HH:mm:ss).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-30 11:30:00</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <para>The payment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Initial state.</description></item>
            /// <item><description>1: Pending payment.</description></item>
            /// <item><description>2: Payment succeeded.</description></item>
            /// <item><description>3: Transaction succeeded (payment transferred to seller).</description></item>
            /// <item><description>4: Paid order closed successfully.</description></item>
            /// <item><description>5: Unpaid order closed successfully.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The actual payment time.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
            /// <item><description>This field has a value only after payment succeeds.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-30 11:30:00</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The settlement amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("settle_price")]
            [Validation(Required=false)]
            public long? SettlePrice { get; set; }

            /// <summary>
            /// <para>The settlement type (not available).</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            /// <summary>
            /// <para>The change order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Initial state.</description></item>
            /// <item><description>2: Change succeeded.</description></item>
            /// <item><description>3: Change closed.</description></item>
            /// <item><description>4: Pending payment.</description></item>
            /// <item><description>5: Payment succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The change service fee, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_change_price")]
            [Validation(Required=false)]
            public long? TotalChangePrice { get; set; }

            /// <summary>
            /// <para>The total cost, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <para>The cabin upgrade price difference, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_upgrade_price")]
            [Validation(Required=false)]
            public long? TotalUpgradePrice { get; set; }

            /// <summary>
            /// <para>The passenger information.</para>
            /// </summary>
            [NameInMap("traveler_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingDetailResponseBodyModuleTravelerInfoList> TravelerInfoList { get; set; }
            public class TicketChangingDetailResponseBodyModuleTravelerInfoList : TeaModel {
                /// <summary>
                /// <para>The date of birth.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2000-01-01</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110101********1234</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The certificate type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ID card.</description></item>
                /// <item><description>1: Passport.</description></item>
                /// <item><description>3: Military ID.</description></item>
                /// <item><description>4: Home Return Permit.</description></item>
                /// <item><description>5: Taiwan Compatriot Permit.</description></item>
                /// <item><description>8: Foreigner Permanent Residence Permit.</description></item>
                /// <item><description>10: Police ID.</description></item>
                /// <item><description>11: Soldier ID.</description></item>
                /// <item><description>14: Household register.</description></item>
                /// <item><description>15: Birth certificate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The ticket status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Available.</description></item>
                /// <item><description>1: Used.</description></item>
                /// <item><description>2: Refunded.</description></item>
                /// <item><description>3: Voided.</description></item>
                /// <item><description>5: Checked in.</description></item>
                /// <item><description>6: Changed.</description></item>
                /// <item><description>7: Suspended.</description></item>
                /// <item><description>8: Boarded.</description></item>
                /// <item><description>10: Unavailable.</description></item>
                /// <item><description>11: Boarding pass printed.</description></item>
                /// <item><description>12: Airport control.</description></item>
                /// <item><description>14: No ticket control authority.</description></item>
                /// <item><description>-1: Unknown.</description></item>
                /// <item><description>-2: Does not exist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public int? OpenTicketStatus { get; set; }

                /// <summary>
                /// <para>The passenger name (the username passed when placing the order).</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The passenger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Adult.</description></item>
                /// <item><description>1: Child.</description></item>
                /// <item><description>2: Student.</description></item>
                /// <item><description>3: Laborer.</description></item>
                /// <item><description>4: New immigrant.</description></item>
                /// <item><description>5: Seaman.</description></item>
                /// <item><description>6: Senior.</description></item>
                /// <item><description>7: Youth.</description></item>
                /// <item><description>8: Infant.</description></item>
                /// <item><description>99: Special identity.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public string PassengerType { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****8888</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>444-000000000</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The employee ID (the userId from the external distributor\&quot;s user information. Business travel only stores and associates this value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>012992</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
