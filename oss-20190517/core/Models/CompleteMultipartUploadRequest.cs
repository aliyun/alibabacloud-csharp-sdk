// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CompleteMultipartUploadRequest : TeaModel {
        [NameInMap("CompleteMultipartUpload")]
        [Validation(Required=false)]
        public CompleteMultipartUpload Body { get; set; }

        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("uploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
