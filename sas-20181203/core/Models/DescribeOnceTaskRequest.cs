// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EndTimeQuery")]
        [Validation(Required=false)]
        public long? EndTimeQuery { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        [NameInMap("StartTimeQuery")]
        [Validation(Required=false)]
        public long? StartTimeQuery { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
