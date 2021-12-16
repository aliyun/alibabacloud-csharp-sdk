// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListPartsResponseBody : TeaModel {
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("MaxParts")]
        [Validation(Required=false)]
        public long? MaxParts { get; set; }

        [NameInMap("NextPartNumberMarker")]
        [Validation(Required=false)]
        public long? NextPartNumberMarker { get; set; }

        [NameInMap("Part")]
        [Validation(Required=false)]
        public List<Part> Part { get; set; }

        [NameInMap("PartNumberMarker")]
        [Validation(Required=false)]
        public long? PartNumberMarker { get; set; }

        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
