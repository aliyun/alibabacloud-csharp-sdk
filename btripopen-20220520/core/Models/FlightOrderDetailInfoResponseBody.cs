// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderDetailInfoResponseBody : TeaModel {
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
        public FlightOrderDetailInfoResponseBodyModule Module { get; set; }
        public class FlightOrderDetailInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2389927372772</para>
            /// </summary>
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1223</para>
            /// </summary>
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678909</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CA</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("airline_simple_name")]
                [Validation(Required=false)]
                public string AirlineSimpleName { get; set; }

                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_code_name")]
                [Validation(Required=false)]
                public string ArrAirportCodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("baggage")]
                [Validation(Required=false)]
                public string Baggage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public long? BuildPrice { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;CA1351_PEK_CAN_2000-00-00 08:00</para>
                /// </summary>
                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_code_name")]
                [Validation(Required=false)]
                public string DepAirportCodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CA1351</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("last_cabin")]
                [Validation(Required=false)]
                public string LastCabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CA1351</para>
                /// </summary>
                [NameInMap("last_flight_no")]
                [Validation(Required=false)]
                public string LastFlightNo { get; set; }

                [NameInMap("meal")]
                [Validation(Required=false)]
                public string Meal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public long? OilPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public int? SegmentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAN</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-00-00 00:00:00</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public long? TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("tuigaiqian_info")]
                [Validation(Required=false)]
                public string TuigaiqianInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public long? PromotionPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("settle_amount")]
            [Validation(Required=false)]
            public long? SettleAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTicketInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public string OpenTicketStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KF0528</para>
                /// </summary>
                [NameInMap("pnr_code")]
                [Validation(Required=false)]
                public string PnrCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>444-000000000</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_build_price")]
            [Validation(Required=false)]
            public long? TotalBuildPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_oil_price")]
            [Validation(Required=false)]
            public long? TotalOilPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_order_price")]
            [Validation(Required=false)]
            public long? TotalOrderPrice { get; set; }

            [NameInMap("traveler_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTravelerInfoList> TravelerInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTravelerInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-01-01</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public int? OpenTicketStatus { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public string PassengerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345678909</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>444-000000000</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
