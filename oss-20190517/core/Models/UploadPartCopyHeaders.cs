// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class UploadPartCopyHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-oss-copy-source")]
        [Validation(Required=false)]
        public string CopySource { get; set; }

        [NameInMap("x-oss-copy-source-if-match")]
        [Validation(Required=false)]
        public string CopySourceIfMatch { get; set; }

        [NameInMap("x-oss-copy-source-if-modified-since")]
        [Validation(Required=false)]
        public string CopySourceIfModifiedSince { get; set; }

        [NameInMap("x-oss-copy-source-if-none-match")]
        [Validation(Required=false)]
        public string CopySourceIfNoneMatch { get; set; }

        [NameInMap("x-oss-copy-source-if-unmodified-since")]
        [Validation(Required=false)]
        public string CopySourceIfUnmodifiedSince { get; set; }

        [NameInMap("x-oss-copy-source-range")]
        [Validation(Required=false)]
        public string CopySourceRange { get; set; }

    }

}
