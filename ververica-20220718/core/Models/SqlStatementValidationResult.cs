// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementValidationResult : TeaModel {
        [NameInMap("errorDetails")]
        [Validation(Required=false)]
        public ErrorDetails ErrorDetails { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("validationResult")]
        [Validation(Required=false)]
        public string ValidationResult { get; set; }

    }

}
