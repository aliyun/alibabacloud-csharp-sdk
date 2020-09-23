// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=true)]
        public CreateTableResponseTaskInfo TaskInfo { get; set; }
        public class CreateTableResponseTaskInfo : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public string TaskId { get; set; }
            [NameInMap("Content")]
            [Validation(Required=true)]
            public string Content { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("NextTaskId")]
            [Validation(Required=true)]
            public string NextTaskId { get; set; }
        };

    }

}
