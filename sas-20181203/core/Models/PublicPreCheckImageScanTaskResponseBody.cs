// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicPreCheckImageScanTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicPreCheckImageScanTaskResponseBodyData Data { get; set; }
        public class PublicPreCheckImageScanTaskResponseBodyData : TeaModel {
            [NameInMap("NeedAuthCount")]
            [Validation(Required=false)]
            public int? NeedAuthCount { get; set; }
            [NameInMap("ScanImageCount")]
            [Validation(Required=false)]
            public int? ScanImageCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
