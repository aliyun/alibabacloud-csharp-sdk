// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("task_result")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyTaskResult> TaskResult { get; set; }
        public class DescribeTaskInfoResponseBodyTaskResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("task_type")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

    }

}
