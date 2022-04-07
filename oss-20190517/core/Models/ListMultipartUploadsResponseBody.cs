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

        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

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

        [NameInMap("NextUploadIdMarker")]
        [Validation(Required=false)]
        public string NextUploadIdMarker { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("Upload")]
        [Validation(Required=false)]
        public List<Upload> Uploads { get; set; }

        [NameInMap("UploadIdMarker")]
        [Validation(Required=false)]
        public string UploadIdMarker { get; set; }

    }

}
