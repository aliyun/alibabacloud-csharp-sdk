// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PlayModeControlRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PlayModeControlRequestDeviceInfo DeviceInfo { get; set; }
        public class PlayModeControlRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenPlayModeControlRequest")]
        [Validation(Required=false)]
        public PlayModeControlRequestOpenPlayModeControlRequest OpenPlayModeControlRequest { get; set; }
        public class PlayModeControlRequestOpenPlayModeControlRequest : TeaModel {
            [NameInMap("OpenPlayMode")]
            [Validation(Required=false)]
            public string OpenPlayMode { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public PlayModeControlRequestUserInfo UserInfo { get; set; }
        public class PlayModeControlRequestUserInfo : TeaModel {
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
