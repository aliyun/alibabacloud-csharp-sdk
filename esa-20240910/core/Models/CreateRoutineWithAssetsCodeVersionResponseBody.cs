// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineWithAssetsCodeVersionResponseBody : TeaModel {
        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        [NameInMap("OssPostConfig")]
        [Validation(Required=false)]
        public CreateRoutineWithAssetsCodeVersionResponseBodyOssPostConfig OssPostConfig { get; set; }
        public class CreateRoutineWithAssetsCodeVersionResponseBodyOssPostConfig : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OSSAccessKeyId")]
            [Validation(Required=false)]
            public string OSSAccessKeyId { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("XOssSecurityToken")]
            [Validation(Required=false)]
            public string XOssSecurityToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
