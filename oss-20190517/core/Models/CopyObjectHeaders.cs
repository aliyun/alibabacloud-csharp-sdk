// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CopyObjectHeaders : TeaModel {
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

        [NameInMap("x-oss-forbid-overwrite")]
        [Validation(Required=false)]
        public string ForbidOverwrite { get; set; }

        [NameInMap("x-oss-meta-*")]
        [Validation(Required=false)]
        public Dictionary<string, string> MetaData { get; set; }

        [NameInMap("x-oss-metadata-directive")]
        [Validation(Required=false)]
        public string MetadataDirective { get; set; }

        [NameInMap("x-oss-object-acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("x-oss-server-side-encryption-key-id")]
        [Validation(Required=false)]
        public string SseKeyId { get; set; }

        [NameInMap("x-oss-storage-class")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("x-oss-tagging")]
        [Validation(Required=false)]
        public string Tagging { get; set; }

        [NameInMap("x-oss-tagging-directive")]
        [Validation(Required=false)]
        public string TaggingDirective { get; set; }

    }

}
