// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class UploadPartRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        [NameInMap("partNumber")]
        [Validation(Required=false)]
        public string PartNumber { get; set; }

        [NameInMap("uploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
