// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelOrderRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public ListHotelOrderRequestPayload Payload { get; set; }
        public class ListHotelOrderRequestPayload : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelOrderRequestPayloadPage Page { get; set; }
            public class ListHotelOrderRequestPayloadPage : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

            }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListHotelOrderRequestUserInfo UserInfo { get; set; }
        public class ListHotelOrderRequestUserInfo : TeaModel {
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

}
