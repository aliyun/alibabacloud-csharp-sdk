// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class DeviceControlRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public DeviceControlRequestPayload Payload { get; set; }
        public class DeviceControlRequestPayload : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DeviceNumber")]
            [Validation(Required=false)]
            public string DeviceNumber { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, string> Properties { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DeviceControlRequestUserInfo UserInfo { get; set; }
        public class DeviceControlRequestUserInfo : TeaModel {
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
