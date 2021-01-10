// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasTaskLogRequest : TeaModel {
        [NameInMap("ExecutionTimes")]
        [Validation(Required=false)]
        public long? ExecutionTimes { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
