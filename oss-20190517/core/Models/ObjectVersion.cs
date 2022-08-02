// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ObjectVersion : TeaModel {
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public bool? IsLatest { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
