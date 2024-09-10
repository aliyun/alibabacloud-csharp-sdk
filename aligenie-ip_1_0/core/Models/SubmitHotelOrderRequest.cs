// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class SubmitHotelOrderRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public SubmitHotelOrderRequestPayload Payload { get; set; }
        public class SubmitHotelOrderRequestPayload : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<SubmitHotelOrderRequestPayloadItemList> ItemList { get; set; }
            public class SubmitHotelOrderRequestPayloadItemList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SubmitHotelOrderRequestUserInfo UserInfo { get; set; }
        public class SubmitHotelOrderRequestUserInfo : TeaModel {
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
