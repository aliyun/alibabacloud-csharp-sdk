// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListBucketsResponseBody : TeaModel {
        [NameInMap("buckets")]
        [Validation(Required=false)]
        public List<Bucket> Buckets { get; set; }

        [NameInMap("isTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("maxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        [NameInMap("nextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
