// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetBasicInfoQAResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7***726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetBasicInfoQAResponseBodyResult Result { get; set; }
        public class GetBasicInfoQAResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11:11</para>
            /// </summary>
            [NameInMap("CheckInTime")]
            [Validation(Required=false)]
            public string CheckInTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11:11</para>
            /// </summary>
            [NameInMap("CheckOutTime")]
            [Validation(Required=false)]
            public string CheckOutTime { get; set; }

            [NameInMap("HotelAddress")]
            [Validation(Required=false)]
            public string HotelAddress { get; set; }

            [NameInMap("HotelIntroduction")]
            [Validation(Required=false)]
            public string HotelIntroduction { get; set; }

            [NameInMap("HotelMember")]
            [Validation(Required=false)]
            public string HotelMember { get; set; }

            [NameInMap("HotelService")]
            [Validation(Required=false)]
            public string HotelService { get; set; }

            [NameInMap("ParkingExpenses")]
            [Validation(Required=false)]
            public string ParkingExpenses { get; set; }

            [NameInMap("ParkingPosition")]
            [Validation(Required=false)]
            public string ParkingPosition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("WifiName")]
            [Validation(Required=false)]
            public string WifiName { get; set; }

            [NameInMap("WifiPassword")]
            [Validation(Required=false)]
            public string WifiPassword { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
