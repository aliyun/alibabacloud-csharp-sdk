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

        [NameInMap("source-bucket")]
        [Validation(Required=false)]
        public string SourceBucket { get; set; }

        [NameInMap("source-key")]
        [Validation(Required=false)]
        public string SourceKey { get; set; }

        [NameInMap("x-oss-copy-source-if-match")]
        [Validation(Required=false)]
        public string XOssCopySourceIfMatch { get; set; }

        [NameInMap("x-oss-copy-source-if-modified-since")]
        [Validation(Required=false)]
        public string XOssCopySourceIfModifiedSince { get; set; }

        [NameInMap("x-oss-copy-source-if-none-match")]
        [Validation(Required=false)]
        public string XOssCopySourceIfNoneMatch { get; set; }

        [NameInMap("x-oss-copy-source-if-unmodified-since")]
        [Validation(Required=false)]
        public string XOssCopySourceIfUnmodifiedSince { get; set; }

        [NameInMap("x-oss-copy-source-range")]
        [Validation(Required=false)]
        public string XOssCopySourceRange { get; set; }

    }

}
