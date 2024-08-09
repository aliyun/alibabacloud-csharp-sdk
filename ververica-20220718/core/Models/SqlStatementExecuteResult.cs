// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementExecuteResult : TeaModel {
        [NameInMap("errorDetails")]
        [Validation(Required=false)]
        public ErrorDetails ErrorDetails { get; set; }

        [NameInMap("executeSuccess")]
        [Validation(Required=false)]
        public bool? ExecuteSuccess { get; set; }

        [NameInMap("statement")]
        [Validation(Required=false)]
        public string Statement { get; set; }

    }

}
