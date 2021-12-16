// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CompleteMultipartUploadHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-oss-complete-all")]
        [Validation(Required=false)]
        public string CompleteAll { get; set; }

        [NameInMap("x-oss-forbid-overwrite")]
        [Validation(Required=false)]
        public string ForbidOverwrite { get; set; }

    }

}
