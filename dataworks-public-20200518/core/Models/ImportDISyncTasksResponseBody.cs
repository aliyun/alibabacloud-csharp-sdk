// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDISyncTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public ImportDISyncTasksResponseBodyTaskInfo TaskInfo { get; set; }
        public class ImportDISyncTasksResponseBodyTaskInfo : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
        };

    }

}
