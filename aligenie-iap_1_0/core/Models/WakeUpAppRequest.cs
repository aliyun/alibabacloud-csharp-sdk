// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class WakeUpAppRequest : TeaModel {
        [NameInMap("IsDebug")]
        [Validation(Required=false)]
        public bool? IsDebug { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public WakeUpAppRequestTargetInfo TargetInfo { get; set; }
        public class WakeUpAppRequestTargetInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("TargetIdentity")]
            [Validation(Required=false)]
            public string TargetIdentity { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
