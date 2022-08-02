// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectsResponseBody : TeaModel {
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<ObjectSummary> Contents { get; set; }

        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public int? MaxKeys { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
