// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RetryReportTaskResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("outRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("retryAvailable")]
        [Validation(Required=false)]
        public bool? RetryAvailable { get; set; }

        [NameInMap("retryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
