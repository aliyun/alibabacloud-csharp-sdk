// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteTableResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=true)]
        public DeleteTableResponseTaskInfo TaskInfo { get; set; }
        public class DeleteTableResponseTaskInfo : TeaModel {
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
