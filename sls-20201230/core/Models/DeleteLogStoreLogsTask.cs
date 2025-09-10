// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DeleteLogStoreLogsTask : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
