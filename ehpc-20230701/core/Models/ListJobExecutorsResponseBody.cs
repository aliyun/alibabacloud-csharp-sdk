// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20230701.Models
{
    public class ListJobExecutorsResponseBody : TeaModel {
        [NameInMap("ExecutorStatus")]
        [Validation(Required=false)]
        public ListJobExecutorsResponseBodyExecutorStatus ExecutorStatus { get; set; }
        public class ListJobExecutorsResponseBodyExecutorStatus : TeaModel {
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            [NameInMap("Exception")]
            [Validation(Required=false)]
            public int? Exception { get; set; }

            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            [NameInMap("Initing")]
            [Validation(Required=false)]
            public int? Initing { get; set; }

            [NameInMap("Pending")]
            [Validation(Required=false)]
            public int? Pending { get; set; }

            [NameInMap("Running")]
            [Validation(Required=false)]
            public int? Running { get; set; }

            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

        }

        [NameInMap("Executors")]
        [Validation(Required=false)]
        public List<ListJobExecutorsResponseBodyExecutors> Executors { get; set; }
        public class ListJobExecutorsResponseBodyExecutors : TeaModel {
            [NameInMap("ArrayIndex")]
            [Validation(Required=false)]
            public int? ArrayIndex { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public List<string> HostName { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
