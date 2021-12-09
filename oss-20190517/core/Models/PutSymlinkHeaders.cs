// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class PutSymlinkHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-oss-forbid-overwrite")]
        [Validation(Required=false)]
        public string XOssForbidOverwrite { get; set; }

        [NameInMap("x-oss-object-acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        [NameInMap("x-oss-storage-class")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("x-oss-symlink-target")]
        [Validation(Required=false)]
        public string SymlinkTargetKey { get; set; }

    }

}
