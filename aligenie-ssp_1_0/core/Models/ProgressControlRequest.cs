// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ProgressControlRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public ProgressControlRequestDeviceInfo DeviceInfo { get; set; }
        public class ProgressControlRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenProgressControlRequest")]
        [Validation(Required=false)]
        public ProgressControlRequestOpenProgressControlRequest OpenProgressControlRequest { get; set; }
        public class ProgressControlRequestOpenProgressControlRequest : TeaModel {
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ProgressControlRequestUserInfo UserInfo { get; set; }
        public class ProgressControlRequestUserInfo : TeaModel {
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
