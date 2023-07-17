// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class SubmitHotelOrderRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public SubmitHotelOrderRequestPayload Payload { get; set; }
        public class SubmitHotelOrderRequestPayload : TeaModel {
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<SubmitHotelOrderRequestPayloadItemList> ItemList { get; set; }
            public class SubmitHotelOrderRequestPayloadItemList : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SubmitHotelOrderRequestUserInfo UserInfo { get; set; }
        public class SubmitHotelOrderRequestUserInfo : TeaModel {
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
