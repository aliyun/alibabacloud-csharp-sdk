// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        [NameInMap("VersionNumber")]
        [Validation(Required=false)]
        public string VersionNumber { get; set; }

    }

}
