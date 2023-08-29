// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOrderDetailV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyOrderDetailV2ResponseBodyModule Module { get; set; }
        public class FlightModifyOrderDetailV2ResponseBodyModule : TeaModel {
            [NameInMap("apply_time")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            [NameInMap("book_user_email")]
            [Validation(Required=false)]
            public string BookUserEmail { get; set; }

            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            [NameInMap("bookuser_phone")]
            [Validation(Required=false)]
            public string BookuserPhone { get; set; }

            [NameInMap("change_fail_reason")]
            [Validation(Required=false)]
            public string ChangeFailReason { get; set; }

            [NameInMap("contact_info_d_t_o")]
            [Validation(Required=false)]
            public FlightModifyOrderDetailV2ResponseBodyModuleContactInfoDTO ContactInfoDTO { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleContactInfoDTO : TeaModel {
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            [NameInMap("dest_flight_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS> DestFlightInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS : TeaModel {
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_icon_url")]
                [Validation(Required=false)]
                public string AirlineIconUrl { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                [NameInMap("cabin_discount")]
                [Validation(Required=false)]
                public long? CabinDiscount { get; set; }

                [NameInMap("carrier_airline_code")]
                [Validation(Required=false)]
                public string CarrierAirlineCode { get; set; }

                [NameInMap("carrier_airline_icon_url")]
                [Validation(Required=false)]
                public string CarrierAirlineIconUrl { get; set; }

                [NameInMap("carrier_airline_name")]
                [Validation(Required=false)]
                public string CarrierAirlineName { get; set; }

                [NameInMap("carrier_flight_no")]
                [Validation(Required=false)]
                public string CarrierFlightNo { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("segmentI_id")]
                [Validation(Required=false)]
                public string SegmentIId { get; set; }

                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition SegmentPosition { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition : TeaModel {
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                }

                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

            }

            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("out_sub_order_id")]
            [Validation(Required=false)]
            public string OutSubOrderId { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("sub_order_id")]
            [Validation(Required=false)]
            public long? SubOrderId { get; set; }

            [NameInMap("ticket_time")]
            [Validation(Required=false)]
            public string TicketTime { get; set; }

            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            [NameInMap("total_service_fee_price")]
            [Validation(Required=false)]
            public long? TotalServiceFeePrice { get; set; }

            [NameInMap("traveler_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS> TravelerInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS : TeaModel {
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOSChangeFee ChangeFee { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOSChangeFee : TeaModel {
                    [NameInMap("change_fee")]
                    [Validation(Required=false)]
                    public long? ChangeFee { get; set; }

                    [NameInMap("service_fee")]
                    [Validation(Required=false)]
                    public long? ServiceFee { get; set; }

                    [NameInMap("upgrade_price")]
                    [Validation(Required=false)]
                    public long? UpgradePrice { get; set; }

                }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("origin_ticket_nos")]
                [Validation(Required=false)]
                public List<string> OriginTicketNos { get; set; }

                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("pid")]
                [Validation(Required=false)]
                public long? Pid { get; set; }

                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
