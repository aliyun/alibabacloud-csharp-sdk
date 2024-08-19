// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanNumResponseBody : TeaModel {
        [NameInMap("LimitNumber")]
        [Validation(Required=false)]
        public long? LimitNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanNumber")]
        [Validation(Required=false)]
        public long? ScanNumber { get; set; }

        [NameInMap("SumNumber")]
        [Validation(Required=false)]
        public long? SumNumber { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public bool? Tag { get; set; }

    }

}
