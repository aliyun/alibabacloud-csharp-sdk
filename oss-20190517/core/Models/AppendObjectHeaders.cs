// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class AppendObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("Cache-Control")]
        [Validation(Required=false)]
        public string CacheControl { get; set; }

        [NameInMap("Content-Disposition")]
        [Validation(Required=false)]
        public string ContentDisposition { get; set; }

        [NameInMap("Content-Encoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        [NameInMap("Content-MD5")]
        [Validation(Required=false)]
        public string ContentMD5 { get; set; }

        [NameInMap("Expires")]
        [Validation(Required=false)]
        public string Expires { get; set; }

        [NameInMap("x-oss-meta-*")]
        [Validation(Required=false)]
        public Dictionary<string, string> MetaData { get; set; }

        [NameInMap("x-oss-object-acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("x-oss-storage-class")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
