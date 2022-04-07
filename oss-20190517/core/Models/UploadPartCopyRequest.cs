// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class UploadPartCopyRequest : TeaModel {
        [NameInMap("partNumber")]
        [Validation(Required=false)]
        public long? PartNumber { get; set; }

        [NameInMap("uploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
