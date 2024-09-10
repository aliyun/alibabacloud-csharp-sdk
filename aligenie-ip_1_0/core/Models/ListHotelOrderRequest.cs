// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelOrderRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public ListHotelOrderRequestPayload Payload { get; set; }
        public class ListHotelOrderRequestPayload : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelOrderRequestPayloadPage Page { get; set; }
            public class ListHotelOrderRequestPayloadPage : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListHotelOrderRequestUserInfo UserInfo { get; set; }
        public class ListHotelOrderRequestUserInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
