// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlExecutionFetchResult : TeaModel {
        [NameInMap("dqlResult")]
        [Validation(Required=false)]
        public DqlResult DqlResult { get; set; }

        [NameInMap("sqlExecution")]
        [Validation(Required=false)]
        public SqlExecution SqlExecution { get; set; }

    }

}
