// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartSqlExecutionResult : TeaModel {
        [NameInMap("newlyCreated")]
        [Validation(Required=false)]
        public bool? NewlyCreated { get; set; }

        [NameInMap("sqlExecutionId")]
        [Validation(Required=false)]
        public string SqlExecutionId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
