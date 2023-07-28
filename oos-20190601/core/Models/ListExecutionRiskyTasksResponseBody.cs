// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionRiskyTasksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about high-risk tasks.
        /// </summary>
        [NameInMap("RiskyTasks")]
        [Validation(Required=false)]
        public List<ListExecutionRiskyTasksResponseBodyRiskyTasks> RiskyTasks { get; set; }
        public class ListExecutionRiskyTasksResponseBodyRiskyTasks : TeaModel {
            /// <summary>
            /// The name of the operation that the high-risk task calls.
            /// </summary>
            [NameInMap("API")]
            [Validation(Required=false)]
            public string API { get; set; }

            /// <summary>
            /// The cloud service in which the high-risk task runs.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// The details of the high-risk task.
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<string> Task { get; set; }

            /// <summary>
            /// The details of templates to which the high-risk task belongs.
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<string> Template { get; set; }

        }

    }

}
