// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmResponseBody : TeaModel {
        [NameInMap("Extentions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extentions { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43***86881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<CreateHotelAlarmResponseBodyResult> Result { get; set; }
        public class CreateHotelAlarmResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>94</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pvk***TA==</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mg***Qd</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

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
