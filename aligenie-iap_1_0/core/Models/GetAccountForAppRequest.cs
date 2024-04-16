// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetAccountForAppRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public GetAccountForAppRequestDeviceInfo DeviceInfo { get; set; }
        public class GetAccountForAppRequestDeviceInfo : TeaModel {
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

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public GetAccountForAppRequestPayload Payload { get; set; }
        public class GetAccountForAppRequestPayload : TeaModel {
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetAccountForAppRequestUserInfo UserInfo { get; set; }
        public class GetAccountForAppRequestUserInfo : TeaModel {
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
