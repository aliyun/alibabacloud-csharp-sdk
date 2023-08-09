// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class HotelQrBindResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
                [NameInMap("EncodeKey")]
                [Validation(Required=false)]
                public string EncodeKey { get; set; }

                [NameInMap("EncodeType")]
                [Validation(Required=false)]
                public string EncodeType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

            [NameInMap("OpenUserInfo")]
            [Validation(Required=false)]
            public HotelQrBindResponseBodyResultOpenUserInfo OpenUserInfo { get; set; }
            public class HotelQrBindResponseBodyResultOpenUserInfo : TeaModel {
                [NameInMap("EncodeKey")]
                [Validation(Required=false)]
                public string EncodeKey { get; set; }

                [NameInMap("EncodeType")]
                [Validation(Required=false)]
                public string EncodeType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
