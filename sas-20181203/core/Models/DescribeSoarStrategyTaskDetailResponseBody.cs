// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public DescribeSoarStrategyTaskDetailResponseBodyTaskDetail TaskDetail { get; set; }
        public class DescribeSoarStrategyTaskDetailResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// The operational log information of the task.
            /// </summary>
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public string LogInfo { get; set; }

            /// <summary>
            /// The parameters of the task.
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// The process information of the task.
            /// </summary>
            [NameInMap("ProcessInfo")]
            [Validation(Required=false)]
            public string ProcessInfo { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

    }

}
