// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetAsyncTaskResponseBody : TeaModel {
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        [NameInMap("consumed_process")]
        [Validation(Required=false)]
        public long? ConsumedProcess { get; set; }

        [NameInMap("err_code")]
        [Validation(Required=false)]
        public long? ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("total_process")]
        [Validation(Required=false)]
        public long? TotalProcess { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
