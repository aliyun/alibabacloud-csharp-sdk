// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundDetailV2ResponseBody : TeaModel {
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundDetailV2ResponseBodyModule Module { get; set; }
        public class FlightRefundDetailV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The application time.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-19 17:18:19</para>
            /// </summary>
            [NameInMap("apply_time")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// </summary>
            [NameInMap("contact_info_d_t_o")]
            [Validation(Required=false)]
            public FlightRefundDetailV2ResponseBodyModuleContactInfoDTO ContactInfoDTO { get; set; }
            public class FlightRefundDetailV2ResponseBodyModuleContactInfoDTO : TeaModel {
                /// <summary>
                /// <para>The contact email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j*********@example.com</para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <para>The contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张四</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The contact phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****8888</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <para>Indicates whether to send an SMS message to the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            /// <summary>
            /// <para>The refund flight information.</para>
            /// </summary>
            [NameInMap("flight_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundDetailV2ResponseBodyModuleFlightInfoDTOS> FlightInfoDTOS { get; set; }
            public class FlightRefundDetailV2ResponseBodyModuleFlightInfoDTOS : TeaModel {
                /// <summary>
                /// <para>The airline two-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                /// <summary>
                /// <para>The airline icon URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>航司 icon</para>
                /// </summary>
                [NameInMap("airline_icon_url")]
                [Validation(Required=false)]
                public string AirlineIconUrl { get; set; }

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
                /// <para>The arrival airport three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival airport three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The arrival city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival terminal (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>到达航站楼</para>
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
                /// <para>2023-10-03 09:30:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>舱等名称</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The discount (may not have a value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("cabin_discount")]
                [Validation(Required=false)]
                public long? CabinDiscount { get; set; }

                /// <summary>
                /// <para>The operating airline two-letter code (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司二字码</para>
                /// </summary>
                [NameInMap("carrier_airline_code")]
                [Validation(Required=false)]
                public string CarrierAirlineCode { get; set; }

                /// <summary>
                /// <para>The operating airline icon URL (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司 icon</para>
                /// </summary>
                [NameInMap("carrier_airline_icon_url")]
                [Validation(Required=false)]
                public string CarrierAirlineIconUrl { get; set; }

                /// <summary>
                /// <para>The operating airline name (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司名称</para>
                /// </summary>
                [NameInMap("carrier_airline_name")]
                [Validation(Required=false)]
                public string CarrierAirlineName { get; set; }

                /// <summary>
                /// <para>The operating flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运航班号</para>
                /// </summary>
                [NameInMap("carrier_flight_no")]
                [Validation(Required=false)]
                public string CarrierFlightNo { get; set; }

                /// <summary>
                /// <para>The departure airport three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大兴国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The departure city three-letter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure terminal (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>出发航站楼</para>
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
                /// <para>2023-10-03 07:30:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU5193</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The aircraft type, such as &quot;738&quot; (may be empty).</para>
                /// 
                /// <b>Example:</b>
                /// <para>机型，例&quot;738&quot;</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The meal description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>餐食描述</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The segment ID. Multiple values are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1194012</para>
                /// </summary>
                [NameInMap("segment_id")]
                [Validation(Required=false)]
                public string SegmentId { get; set; }

                /// <summary>
                /// <para>The segment position information, indicating the journey and segment index within the overall itinerary.</para>
                /// </summary>
                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public FlightRefundDetailV2ResponseBodyModuleFlightInfoDTOSSegmentPosition SegmentPosition { get; set; }
                public class FlightRefundDetailV2ResponseBodyModuleFlightInfoDTOSSegmentPosition : TeaModel {
                    /// <summary>
                    /// <para>The journey index (starting from 0).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index (starting from 0 within the same journey).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                }

                /// <summary>
                /// <para>The stopover arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停到达时间</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停城市</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The stopover departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停出发时间</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

            }

            /// <summary>
            /// <para>The non-refundable change service fee (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("non_refundable_change_service_price")]
            [Validation(Required=false)]
            public long? NonRefundableChangeServicePrice { get; set; }

            /// <summary>
            /// <para>The non-refundable change upgrade fee (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("non_refundable_change_upgrade_price")]
            [Validation(Required=false)]
            public long? NonRefundableChangeUpgradePrice { get; set; }

            /// <summary>
            /// <para>The order ID (business travel order ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002039195025156700</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The distribution external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002039195025156700</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The distribution external sub-order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1019195836916039</para>
            /// </summary>
            [NameInMap("out_sub_order_id")]
            [Validation(Required=false)]
            public string OutSubOrderId { get; set; }

            /// <summary>
            /// <para>The refund reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我要改变行程计划、我不想飞</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The refund reason code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("reason_code")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The refund failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>退票失败原因</para>
            /// </summary>
            [NameInMap("refund_fail_reason")]
            [Validation(Required=false)]
            public string RefundFailReason { get; set; }

            /// <summary>
            /// <para>The refund service fee (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_handling_fee")]
            [Validation(Required=false)]
            public long? RefundHandlingFee { get; set; }

            /// <summary>
            /// <para>The refund amount (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("refund_money")]
            [Validation(Required=false)]
            public long? RefundMoney { get; set; }

            /// <summary>
            /// <para>The refund order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The sub-order ID (business travel sub-order ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000297003</para>
            /// </summary>
            [NameInMap("sub_order_id")]
            [Validation(Required=false)]
            public long? SubOrderId { get; set; }

            /// <summary>
            /// <para>The passenger information.</para>
            /// </summary>
            [NameInMap("traveler_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundDetailV2ResponseBodyModuleTravelerInfoDTOS> TravelerInfoDTOS { get; set; }
            public class FlightRefundDetailV2ResponseBodyModuleTravelerInfoDTOS : TeaModel {
                /// <summary>
                /// <para>The date of birth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-08-19</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>430131413423435353</para>
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
                public int? CertType { get; set; }

                /// <summary>
                /// <para>The gender.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The original ticket numbers.</para>
                /// </summary>
                [NameInMap("origin_ticket_nos")]
                [Validation(Required=false)]
                public List<string> OriginTicketNos { get; set; }

                /// <summary>
                /// <para>The passenger ID, corresponding to btripUserId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12172819047252004460056</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
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
                public int? PassengerType { get; set; }

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
                /// <para>The passenger primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("pid")]
                [Validation(Required=false)]
                public long? Pid { get; set; }

                /// <summary>
                /// <para>The ticket numbers.</para>
                /// </summary>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
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
        /// <para>210e845f16785007404904300ddc92</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
