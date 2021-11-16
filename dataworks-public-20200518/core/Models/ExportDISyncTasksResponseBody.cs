// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDISyncTasksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExportDISyncTasksResponseBodyData Data { get; set; }
        public class ExportDISyncTasksResponseBodyData : TeaModel {
            [NameInMap("realTimeSolution")]
            [Validation(Required=false)]
            public string RealTimeSolution { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
