// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryDeviceStatusRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public QueryDeviceStatusRequestPayload Payload { get; set; }
        public class QueryDeviceStatusRequestPayload : TeaModel {
            [NameInMap("LocationDevices")]
            [Validation(Required=false)]
            public List<QueryDeviceStatusRequestPayloadLocationDevices> LocationDevices { get; set; }
            public class QueryDeviceStatusRequestPayloadLocationDevices : TeaModel {
                [NameInMap("DeviceNumber")]
                [Validation(Required=false)]
                public string DeviceNumber { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

            }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, string> Properties { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public QueryDeviceStatusRequestUserInfo UserInfo { get; set; }
        public class QueryDeviceStatusRequestUserInfo : TeaModel {
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
