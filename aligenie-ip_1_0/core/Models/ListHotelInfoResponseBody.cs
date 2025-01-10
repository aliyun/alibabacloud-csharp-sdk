// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelInfoResponseBody : TeaModel {
        [NameInMap("Extentions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extentions { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListHotelInfoResponseBodyResult> Result { get; set; }
        public class ListHotelInfoResponseBodyResult : TeaModel {
            [NameInMap("AuthAccount")]
            [Validation(Required=false)]
            public List<ListHotelInfoResponseBodyResultAuthAccount> AuthAccount { get; set; }
            public class ListHotelInfoResponseBodyResultAuthAccount : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>leetest</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("HotelAddress")]
            [Validation(Required=false)]
            public string HotelAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cf2446fc9d144c85aaee4f9ae20a96e7</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("HotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

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
