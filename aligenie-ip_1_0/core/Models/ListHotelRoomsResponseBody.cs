// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelRoomsResponseBody : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListHotelRoomsResponseBodyResult> Result { get; set; }
        public class ListHotelRoomsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>e6dd44fd16084db8a60d69fd625d9f0f</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>102</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

        }

    }

}
