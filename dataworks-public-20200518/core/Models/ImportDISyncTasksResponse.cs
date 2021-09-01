// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDISyncTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=true)]
        public ImportDISyncTasksResponseTaskInfo TaskInfo { get; set; }
        public class ImportDISyncTasksResponseTaskInfo : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public long? TaskId { get; set; }
        };

    }

}
