// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class FlightChangeOfOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<FlightChangeOfOrderResponseBodyData> Data { get; set; }
        public class FlightChangeOfOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The flight change information.</para>
            /// </summary>
            [NameInMap("flight_change_detail")]
            [Validation(Required=false)]
            public FlightChangeOfOrderResponseBodyDataFlightChangeDetail FlightChangeDetail { get; set; }
            public class FlightChangeOfOrderResponseBodyDataFlightChangeDetail : TeaModel {
                /// <summary>
                /// <para>The reason for the flight change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>天气</para>
                /// </summary>
                [NameInMap("change_reason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                /// <summary>
                /// <para>The time of the flight change in string format (yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-01 10:01:00</para>
                /// </summary>
                [NameInMap("change_time")]
                [Validation(Required=false)]
                public string ChangeTime { get; set; }

                /// <summary>
                /// <para>The type of the flight change. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: cancellation</description></item>
                /// <item><description>2: schedule change.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("change_type")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the new arrival airport (uppercase).</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("new_arrival_airport")]
                [Validation(Required=false)]
                public string NewArrivalAirport { get; set; }

                /// <summary>
                /// <para>The arrival date and time of the new flight in string format (yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-01 15:01:00</para>
                /// </summary>
                [NameInMap("new_arrival_time")]
                [Validation(Required=false)]
                public string NewArrivalTime { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the new departure airport (uppercase).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("new_departure_airport")]
                [Validation(Required=false)]
                public string NewDepartureAirport { get; set; }

                /// <summary>
                /// <para>The departure date and time of the new flight in string format (yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-01 13:01:00</para>
                /// </summary>
                [NameInMap("new_departure_time")]
                [Validation(Required=false)]
                public string NewDepartureTime { get; set; }

                /// <summary>
                /// <para>The new flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("new_flight_no")]
                [Validation(Required=false)]
                public string NewFlightNo { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the original arrival airport (uppercase).</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("old_arrival_airport")]
                [Validation(Required=false)]
                public string OldArrivalAirport { get; set; }

                /// <summary>
                /// <para>The arrival date and time of the original flight in string format (yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>023-02-01 14:01:00</para>
                /// </summary>
                [NameInMap("old_arrival_time")]
                [Validation(Required=false)]
                public string OldArrivalTime { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the original departure airport (uppercase).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("old_departure_airport")]
                [Validation(Required=false)]
                public string OldDepartureAirport { get; set; }

                /// <summary>
                /// <para>The departure date and time of the original flight in string format (yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-01 12:01:00</para>
                /// </summary>
                [NameInMap("old_departure_time")]
                [Validation(Required=false)]
                public string OldDepartureTime { get; set; }

                /// <summary>
                /// <para>The original flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("old_flight_no")]
                [Validation(Required=false)]
                public string OldFlightNo { get; set; }

            }

            /// <summary>
            /// <para>The order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
