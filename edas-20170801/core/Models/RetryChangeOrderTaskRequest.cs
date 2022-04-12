// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RetryChangeOrderTaskRequest : TeaModel {
        [NameInMap("RetryStatus")]
        [Validation(Required=false)]
        public bool? RetryStatus { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
