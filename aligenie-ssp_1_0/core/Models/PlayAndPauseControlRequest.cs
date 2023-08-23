// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PlayAndPauseControlRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PlayAndPauseControlRequestDeviceInfo DeviceInfo { get; set; }
        public class PlayAndPauseControlRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenPlayAndPauseControlParam")]
        [Validation(Required=false)]
        public PlayAndPauseControlRequestOpenPlayAndPauseControlParam OpenPlayAndPauseControlParam { get; set; }
        public class PlayAndPauseControlRequestOpenPlayAndPauseControlParam : TeaModel {
            [NameInMap("OpenPlayAndPauseCommand")]
            [Validation(Required=false)]
            public string OpenPlayAndPauseCommand { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public PlayAndPauseControlRequestUserInfo UserInfo { get; set; }
        public class PlayAndPauseControlRequestUserInfo : TeaModel {
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
