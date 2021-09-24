// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDISyncTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TaskDetail")]
        [Validation(Required=true)]
        public ExportDISyncTasksResponseTaskDetail TaskDetail { get; set; }
        public class ExportDISyncTasksResponseTaskDetail : TeaModel {
            [NameInMap("RealTimeSolution")]
            [Validation(Required=true)]
            public string RealTimeSolution { get; set; }
        };

    }

}
