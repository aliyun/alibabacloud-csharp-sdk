// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListMultipartUploadsResponseBody : TeaModel {
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("KeyMarker")]
        [Validation(Required=false)]
        public string KeyMarker { get; set; }

        [NameInMap("MaxUploads")]
        [Validation(Required=false)]
        public long? MaxUploads { get; set; }

        [NameInMap("NextKeyMarker")]
        [Validation(Required=false)]
        public string NextKeyMarker { get; set; }

        [NameInMap("NextUploadMarker")]
        [Validation(Required=false)]
        public string NextUploadMarker { get; set; }

        [NameInMap("Upload")]
        [Validation(Required=false)]
        public List<Upload> Upload { get; set; }

        [NameInMap("UploadIdMarker")]
        [Validation(Required=false)]
        public string UploadIdMarker { get; set; }

    }

}
