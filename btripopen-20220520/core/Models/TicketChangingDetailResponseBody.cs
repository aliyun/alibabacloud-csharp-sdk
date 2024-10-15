// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingDetailResponseBodyModule Module { get; set; }
        public class TicketChangingDetailResponseBodyModule : TeaModel {
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37772</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chang123</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingDetailResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class TicketChangingDetailResponseBodyModuleFlightInfoList : TeaModel {
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

                [NameInMap("airline_simple_name")]
                [Validation(Required=false)]
                public string AirlineSimpleName { get; set; }

                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>T3</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU3849</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>T4</para>
                /// </summary>
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
                /// <para>MU3849</para>
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
                /// <para>CA1982</para>
                /// </summary>
                [NameInMap("last_flight_no")]
                [Validation(Required=false)]
                public string LastFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
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
                /// <para>NGB</para>
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

                [NameInMap("tuigaiqian_info")]
                [Validation(Required=false)]
                public string TuigaiqianInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-30 11:30:00</para>
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
            /// <para>2022-12-30 11:30:00</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("settle_price")]
            [Validation(Required=false)]
            public long? SettlePrice { get; set; }

            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_change_price")]
            [Validation(Required=false)]
            public long? TotalChangePrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_upgrade_price")]
            [Validation(Required=false)]
            public long? TotalUpgradePrice { get; set; }

            [NameInMap("traveler_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingDetailResponseBodyModuleTravelerInfoList> TravelerInfoList { get; set; }
            public class TicketChangingDetailResponseBodyModuleTravelerInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-01-01</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
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
                /// <para>012992</para>
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
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
