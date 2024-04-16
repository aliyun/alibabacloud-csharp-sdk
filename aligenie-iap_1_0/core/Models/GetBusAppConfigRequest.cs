// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetBusAppConfigRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public GetBusAppConfigRequestDeviceInfo DeviceInfo { get; set; }
        public class GetBusAppConfigRequestDeviceInfo : TeaModel {
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
        public GetBusAppConfigRequestPayload Payload { get; set; }
        public class GetBusAppConfigRequestPayload : TeaModel {
            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetBusAppConfigRequestUserInfo UserInfo { get; set; }
        public class GetBusAppConfigRequestUserInfo : TeaModel {
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
