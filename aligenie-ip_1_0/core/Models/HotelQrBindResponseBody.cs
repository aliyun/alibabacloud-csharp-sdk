// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class HotelQrBindResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73*<em><b>9-175A-1324-8202-9FAAB</b></em>**A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public HotelQrBindResponseBodyResult Result { get; set; }
        public class HotelQrBindResponseBodyResult : TeaModel {
            [NameInMap("OpenDeviceInfo")]
            [Validation(Required=false)]
            public HotelQrBindResponseBodyResultOpenDeviceInfo OpenDeviceInfo { get; set; }
            public class HotelQrBindResponseBodyResultOpenDeviceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("EncodeKey")]
                [Validation(Required=false)]
                public string EncodeKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HOTEL</para>
                /// </summary>
                [NameInMap("EncodeType")]
                [Validation(Required=false)]
                public string EncodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPEN_ID</para>
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaaaaaaa</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

            [NameInMap("OpenUserInfo")]
            [Validation(Required=false)]
            public HotelQrBindResponseBodyResultOpenUserInfo OpenUserInfo { get; set; }
            public class HotelQrBindResponseBodyResultOpenUserInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("EncodeKey")]
                [Validation(Required=false)]
                public string EncodeKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HOTEL</para>
                /// </summary>
                [NameInMap("EncodeType")]
                [Validation(Required=false)]
                public string EncodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPEN_ID</para>
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaaaaaaa</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

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
