// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RestoreObjectRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public RestoreRequest Body { get; set; }

        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
