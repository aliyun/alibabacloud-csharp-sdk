// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("CustomSessionId")]
        [Validation(Required=false)]
        public string CustomSessionId { get; set; }

        [NameInMap("PlatformSessionId")]
        [Validation(Required=false)]
        public string PlatformSessionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
