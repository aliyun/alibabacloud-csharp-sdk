// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelRoomDeviceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vrehvuifdsgrts</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetHotelRoomDeviceResponseBodyResult> Result { get; set; }
        public class GetHotelRoomDeviceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0-release</para>
            /// </summary>
            [NameInMap("FirmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>af7***536</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aa:aa:aa:aa:aa:aa</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public int? OnlineStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1211</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsfdsfrgreg</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
