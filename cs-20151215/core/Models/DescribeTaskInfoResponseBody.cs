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

        [NameInMap("current_stage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        [NameInMap("error")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyError Error { get; set; }
        public class DescribeTaskInfoResponseBodyError : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }
        };

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyEvents> Events { get; set; }
        public class DescribeTaskInfoResponseBodyEvents : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("stages")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyStages> Stages { get; set; }
        public class DescribeTaskInfoResponseBodyStages : TeaModel {
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Outputs { get; set; }

            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyTarget Target { get; set; }
        public class DescribeTaskInfoResponseBodyTarget : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

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
