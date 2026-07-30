// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderDetailInfoResponseBody : TeaModel {
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
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOrderDetailInfoResponseBodyModule Module { get; set; }
        public class FlightOrderDetailInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The payment transaction number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2389927372772</para>
            /// </summary>
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <para>The booker ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1223</para>
            /// </summary>
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            /// <summary>
            /// <para>The Business Travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The contact phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678909</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>The external order ID of the distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

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
            /// <para>The flight information list.</para>
            /// </summary>
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <para>The two-letter IATA code of the airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                /// <summary>
                /// <para>The airline name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <para>The airline short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("airline_simple_name")]
                [Validation(Required=false)]
                public string AirlineSimpleName { get; set; }

                /// <summary>
                /// <para>The arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>白云国际机场</para>
                /// </summary>
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京首都国际机场</para>
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
                /// <para>The arrival terminal (may not have a value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
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
                /// <para>“”</para>
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
                /// <para>Y无枚举值</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>全价经济舱</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The operating flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;CA1351_PEK_CAN_2000-00-00 08:00</para>
                /// </summary>
                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                /// <summary>
                /// <para>The departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京首都国际机</para>
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
                /// <para>The airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>白云国际机场</para>
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
                /// <para>The departure terminal (may not have a value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
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
                /// <para>CA1351</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The cabin before rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("last_cabin")]
                [Validation(Required=false)]
                public string LastCabin { get; set; }

                /// <summary>
                /// <para>The flight number before rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1351</para>
                /// </summary>
                [NameInMap("last_flight_no")]
                [Validation(Required=false)]
                public string LastFlightNo { get; set; }

                /// <summary>
                /// <para>The meal type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>早餐</para>
                /// </summary>
                [NameInMap("meal")]
                [Validation(Required=false)]
                public string Meal { get; set; }

                /// <summary>
                /// <para>The fuel surcharge, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public long? OilPrice { get; set; }

                /// <summary>
                /// <para>The segment type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public int? SegmentType { get; set; }

                /// <summary>
                /// <para>The stopover arrival time.</para>
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
                /// <para>CAN</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The stopover departure time.</para>
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
                /// <para>The change and refund policy text after rebooking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("tuigaiqian_info")]
                [Validation(Required=false)]
                public string TuigaiqianInfo { get; set; }

            }

            /// <summary>
            /// <para>The latest payment time.&gt; </para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <para>The payment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The actual payment time.&gt; </para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public long? PromotionPrice { get; set; }

            /// <summary>
            /// <para>The settlement amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("settle_amount")]
            [Validation(Required=false)]
            public long? SettleAmount { get; set; }

            /// <summary>
            /// <para>The settlement type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ticket information list.<notice>Returned after successful ticketing. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTicketInfoList : TeaModel {
                /// <summary>
                /// <para>The open ticket status.<notice>This value may not be available.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public string OpenTicketStatus { get; set; }

                /// <summary>
                /// <para>The PNR code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KF0528</para>
                /// </summary>
                [NameInMap("pnr_code")]
                [Validation(Required=false)]
                public string PnrCode { get; set; }

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
                /// <para>The ticket status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

            }

            /// <summary>
            /// <para>The total airport construction fee, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_build_price")]
            [Validation(Required=false)]
            public long? TotalBuildPrice { get; set; }

            /// <summary>
            /// <para>The total fuel surcharge, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_oil_price")]
            [Validation(Required=false)]
            public long? TotalOilPrice { get; set; }

            /// <summary>
            /// <para>The total order price, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_order_price")]
            [Validation(Required=false)]
            public long? TotalOrderPrice { get; set; }

            /// <summary>
            /// <para>The passenger information.</para>
            /// </summary>
            [NameInMap("traveler_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTravelerInfoList> TravelerInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTravelerInfoList : TeaModel {
                /// <summary>
                /// <para>The date of birth.</para>
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
                /// <para>1234</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The ticket status.<notice>This value may not be available.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public int? OpenTicketStatus { get; set; }

                /// <summary>
                /// <para>The passenger name (the single user name passed during order placement).</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The passenger type.</para>
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
                /// <para>The employee ID (the userId from the external distributor\&quot;s own user information. Business Travel only stores the association).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
