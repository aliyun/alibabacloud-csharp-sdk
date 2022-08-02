// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectsV2ResponseBody : TeaModel {
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<ObjectSummary> Contents { get; set; }

        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("KeyCount")]
        [Validation(Required=false)]
        public int? KeyCount { get; set; }

        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public int? MaxKeys { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("StartAfter")]
        [Validation(Required=false)]
        public string StartAfter { get; set; }

    }

}
