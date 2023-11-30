// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AsyncTask : TeaModel {
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("consumed_process")]
        [Validation(Required=false)]
        public long? ConsumedProcess { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("finished_at")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        [NameInMap("started_at")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("task_type")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("total_process")]
        [Validation(Required=false)]
        public long? TotalProcess { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
