// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOrderDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyOrderDetailV2ResponseBodyModule Module { get; set; }
        public class FlightModifyOrderDetailV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-14 11:28:01</para>
            /// </summary>
            [NameInMap("apply_time")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            [NameInMap("attributes")]
            [Validation(Required=false)]
            public FlightModifyOrderDetailV2ResponseBodyModuleAttributes Attributes { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleAttributes : TeaModel {
                [NameInMap("baggage_rule")]
                [Validation(Required=false)]
                public string BaggageRule { get; set; }

                [NameInMap("change_rule")]
                [Validation(Required=false)]
                public string ChangeRule { get; set; }

                [NameInMap("latest_pay_time")]
                [Validation(Required=false)]
                public object LatestPayTime { get; set; }

                [NameInMap("latest_pay_time_str")]
                [Validation(Required=false)]
                public string LatestPayTimeStr { get; set; }

                [NameInMap("refund_rule")]
                [Validation(Required=false)]
                public string RefundRule { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:17635462345@163.com">17635462345@163.com</a></para>
            /// </summary>
            [NameInMap("book_user_email")]
            [Validation(Required=false)]
            public string BookUserEmail { get; set; }

            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17635462345</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:17816963077@163.com">17816963077@163.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17816963077</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            [NameInMap("dest_flight_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS> DestFlightInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_icon_url")]
                [Validation(Required=false)]
                public string AirlineIconUrl { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-03 09:30:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
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

                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-03 07:30:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_change")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSFlightChange FlightChange { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSFlightChange : TeaModel {
                    [NameInMap("change_desc")]
                    [Validation(Required=false)]
                    public string ChangeDesc { get; set; }

                    [NameInMap("change_status")]
                    [Validation(Required=false)]
                    public string ChangeStatus { get; set; }

                    [NameInMap("change_status_code")]
                    [Validation(Required=false)]
                    public string ChangeStatusCode { get; set; }

                    [NameInMap("new_segment")]
                    [Validation(Required=false)]
                    public object NewSegment { get; set; }

                    [NameInMap("passenger_names")]
                    [Validation(Required=false)]
                    public List<string> PassengerNames { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU5193</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1194012</para>
                /// </summary>
                [NameInMap("segmentI_id")]
                [Validation(Required=false)]
                public string SegmentIId { get; set; }

                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition SegmentPosition { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-14 11:48:01</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1019195836916029</para>
            /// </summary>
            [NameInMap("out_sub_order_id")]
            [Validation(Required=false)]
            public string OutSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-14 11:38:01</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1019195836916029</para>
            /// </summary>
            [NameInMap("sub_order_id")]
            [Validation(Required=false)]
            public long? SubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-19 15:24:08</para>
            /// </summary>
            [NameInMap("ticket_time")]
            [Validation(Required=false)]
            public string TicketTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("total_service_fee_price")]
            [Validation(Required=false)]
            public long? TotalServiceFeePrice { get; set; }

            [NameInMap("traveler_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS> TravelerInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2000-08-19</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>430131413423435353</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("origin_ticket_nos")]
                [Validation(Required=false)]
                public List<string> OriginTicketNos { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12172819047252004460056</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17635462345</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("pid")]
                [Validation(Required=false)]
                public long? Pid { get; set; }

                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc2dc16839612026565712dcbe6</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
