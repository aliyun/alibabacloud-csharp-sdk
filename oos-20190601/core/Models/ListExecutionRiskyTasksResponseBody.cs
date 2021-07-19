// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionRiskyTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskyTasks")]
        [Validation(Required=false)]
        public List<ListExecutionRiskyTasksResponseBodyRiskyTasks> RiskyTasks { get; set; }
        public class ListExecutionRiskyTasksResponseBodyRiskyTasks : TeaModel {
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("API")]
            [Validation(Required=false)]
            public string API { get; set; }

            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<string> Task { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<string> Template { get; set; }

        }

    }

}
