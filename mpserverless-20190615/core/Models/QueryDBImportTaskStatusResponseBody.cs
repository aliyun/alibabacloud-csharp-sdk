// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QueryDBImportTaskStatusResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public string FailedCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DetailMessage")]
        [Validation(Required=false)]
        public string DetailMessage { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
