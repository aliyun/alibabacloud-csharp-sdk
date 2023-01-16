// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderDetailInfoResponseBody : TeaModel {
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
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleFlightInfoList : TeaModel {
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

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_code_name")]
                [Validation(Required=false)]
                public string ArrAirportCodeName { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("baggage")]
                [Validation(Required=false)]
                public string Baggage { get; set; }

                [NameInMap("build_price")]
                [Validation(Required=false)]
                public long? BuildPrice { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_code_name")]
                [Validation(Required=false)]
                public string DepAirportCodeName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("last_cabin")]
                [Validation(Required=false)]
                public string LastCabin { get; set; }

                [NameInMap("last_flight_no")]
                [Validation(Required=false)]
                public string LastFlightNo { get; set; }

                [NameInMap("meal")]
                [Validation(Required=false)]
                public string Meal { get; set; }

                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public long? OilPrice { get; set; }

                [NameInMap("segment_type")]
                [Validation(Required=false)]
                public int? SegmentType { get; set; }

                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public long? TicketPrice { get; set; }

                [NameInMap("tuigaiqian_info")]
                [Validation(Required=false)]
                public string TuigaiqianInfo { get; set; }

            }

            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public long? PromotionPrice { get; set; }

            [NameInMap("settle_amount")]
            [Validation(Required=false)]
            public long? SettleAmount { get; set; }

            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTicketInfoList> TicketInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTicketInfoList : TeaModel {
                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public string OpenTicketStatus { get; set; }

                [NameInMap("pnr_code")]
                [Validation(Required=false)]
                public string PnrCode { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

            }

            [NameInMap("total_build_price")]
            [Validation(Required=false)]
            public long? TotalBuildPrice { get; set; }

            [NameInMap("total_oil_price")]
            [Validation(Required=false)]
            public long? TotalOilPrice { get; set; }

            [NameInMap("total_order_price")]
            [Validation(Required=false)]
            public long? TotalOrderPrice { get; set; }

            [NameInMap("traveler_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailInfoResponseBodyModuleTravelerInfoList> TravelerInfoList { get; set; }
            public class FlightOrderDetailInfoResponseBodyModuleTravelerInfoList : TeaModel {
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("open_ticket_status")]
                [Validation(Required=false)]
                public int? OpenTicketStatus { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public string PassengerType { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
