// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDISyncTasksResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public ExportDISyncTasksResponseBodyTaskDetail TaskDetail { get; set; }
        public class ExportDISyncTasksResponseBodyTaskDetail : TeaModel {
            [NameInMap("RealTimeSolution")]
            [Validation(Required=false)]
            public string RealTimeSolution { get; set; }
        };

    }

}
