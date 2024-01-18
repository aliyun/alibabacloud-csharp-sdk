// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class FlightChangeOfOrderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<FlightChangeOfOrderResponseBodyData> Data { get; set; }
        public class FlightChangeOfOrderResponseBodyData : TeaModel {
            [NameInMap("flight_change_detail")]
            [Validation(Required=false)]
            public FlightChangeOfOrderResponseBodyDataFlightChangeDetail FlightChangeDetail { get; set; }
            public class FlightChangeOfOrderResponseBodyDataFlightChangeDetail : TeaModel {
                [NameInMap("change_reason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                [NameInMap("change_time")]
                [Validation(Required=false)]
                public string ChangeTime { get; set; }

                [NameInMap("change_type")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                [NameInMap("new_arrival_airport")]
                [Validation(Required=false)]
                public string NewArrivalAirport { get; set; }

                [NameInMap("new_arrival_time")]
                [Validation(Required=false)]
                public string NewArrivalTime { get; set; }

                [NameInMap("new_departure_airport")]
                [Validation(Required=false)]
                public string NewDepartureAirport { get; set; }

                [NameInMap("new_departure_time")]
                [Validation(Required=false)]
                public string NewDepartureTime { get; set; }

                [NameInMap("new_flight_no")]
                [Validation(Required=false)]
                public string NewFlightNo { get; set; }

                [NameInMap("old_arrival_airport")]
                [Validation(Required=false)]
                public string OldArrivalAirport { get; set; }

                [NameInMap("old_arrival_time")]
                [Validation(Required=false)]
                public string OldArrivalTime { get; set; }

                [NameInMap("old_departure_airport")]
                [Validation(Required=false)]
                public string OldDepartureAirport { get; set; }

                [NameInMap("old_departure_time")]
                [Validation(Required=false)]
                public string OldDepartureTime { get; set; }

                [NameInMap("old_flight_no")]
                [Validation(Required=false)]
                public string OldFlightNo { get; set; }

            }

            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
